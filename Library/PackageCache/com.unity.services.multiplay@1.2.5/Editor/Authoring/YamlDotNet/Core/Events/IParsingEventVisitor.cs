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

namespace Unity.Services.Multiplay.Authoring.YamlDotNet.Core.Events
{
    /// <summary>
    /// Callback interface for external event Visitor.
    /// </summary>
    interface IParsingEventVisitor
    {
        void Visit(AnchorAlias e);
        void Visit(StreamStart e);
        void Visit(StreamEnd e);
        void Visit(DocumentStart e);
        void Visit(DocumentEnd e);
        void Visit(Scalar e);
        void Visit(SequenceStart e);
        void Visit(SequenceEnd e);
        void Visit(MappingStart e);
        void Visit(MappingEnd e);
        void Visit(Comment e);
    }
}

#nullable disable
