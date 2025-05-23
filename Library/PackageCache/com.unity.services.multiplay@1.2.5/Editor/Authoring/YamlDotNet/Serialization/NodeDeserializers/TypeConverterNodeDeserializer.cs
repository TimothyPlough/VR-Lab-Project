// WARNING: Auto generated code. Modifications will be lost!
#nullable enable
// This file is part of YamlDotNet - A .NET library for YAML.
// Copyright (c) Antoine Aubry and contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Services.Multiplay.Authoring.YamlDotNet.Core;

namespace Unity.Services.Multiplay.Authoring.YamlDotNet.Serialization.NodeDeserializers
{
    sealed class TypeConverterNodeDeserializer : INodeDeserializer
    {
        private readonly IEnumerable<IYamlTypeConverter> converters;

        public TypeConverterNodeDeserializer(IEnumerable<IYamlTypeConverter> converters)
        {
            this.converters = converters ?? throw new ArgumentNullException(nameof(converters));
        }

        bool INodeDeserializer.Deserialize(IParser parser, Type expectedType, Func<IParser, Type, object?> nestedObjectDeserializer, out object? value)
        {
            var converter = converters.FirstOrDefault(c => c.Accepts(expectedType));
            if (converter == null)
            {
                value = null;
                return false;
            }

            value = converter.ReadYaml(parser, expectedType);
            return true;
        }
    }
}


#nullable disable
