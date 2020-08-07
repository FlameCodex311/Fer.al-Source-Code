/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	internal interface IXmlNode // TypeDefIndex: 8199
	{
		// Properties
		XmlNodeType NodeType { get; }
		string LocalName { get; }
		List<IXmlNode> ChildNodes { get; }
		List<IXmlNode> Attributes { get; }
		IXmlNode ParentNode { get; }
		string Value { get; }
		string NamespaceUri { get; }
		object WrappedNode { get; }
	
		// Methods
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
