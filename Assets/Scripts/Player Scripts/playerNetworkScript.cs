using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class playerNetworkScript : NetworkBehaviour
{


    [SerializeField] private Transform SpawnedObjectPrefab;
    private Transform SpawnedObjectTransform;


    private NetworkVariable<customNetworkVarData> networkVarTst = new NetworkVariable<customNetworkVarData>(new customNetworkVarData
    {
        intTst = 1
    }, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    public override void OnNetworkSpawn()
    {
        networkVarTst.OnValueChanged += (customNetworkVarData previousValue, customNetworkVarData newValue) =>
        {
            Debug.Log("ClientID " + OwnerClientId + " Num: " + newValue.intTst);
        };
    }

    public struct customNetworkVarData : INetworkSerializable
    {
        public int intTst;

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
        {
            serializer.SerializeValue(ref intTst);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (!IsOwner)
        {
            return;
        }
        Vector3 moveDir = new Vector3(0, 0, 0);


        
        if (Input.GetKey(KeyCode.W))
        {
            moveDir.z = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir.z = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDir.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = +1f;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            networkVarTst.Value = new customNetworkVarData
            {
                intTst = Random.Range(0, 100)
            };
            SpawnedObjectTransform = Instantiate(SpawnedObjectPrefab);
            SpawnedObjectTransform.GetComponent<NetworkObject>().Spawn(true);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Destroy(SpawnedObjectTransform.gameObject);
        }

        float moveSpeed = 3f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    [ClientRpc]
    private void TestClientRpc()
    {

    }
}
