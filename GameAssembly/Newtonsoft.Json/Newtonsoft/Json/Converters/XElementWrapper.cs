/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement // TypeDefIndex: 8209
	{
		// Fields
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		private XElement Element { get; } // 0x0000000180C79980-0x0000000180C79A10 
		public override List<IXmlNode> Attributes { get; } // 0x0000000180C79420-0x0000000180C79980 
		public override string Value { get; } // 0x0000000180C79AA0-0x0000000180C79AD0 
		public override string LocalName { get; } // 0x0000000180C79A40-0x0000000180C79A70 
		public override string NamespaceUri { get; } // 0x0000000180C79A70-0x0000000180C79AA0 
		public bool IsEmpty { get; } // 0x0000000180C79A10-0x0000000180C79A40 
	
		// Constructors
		public XElementWrapper(XElement element); // 0x0000000180C78190-0x0000000180C78200
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute); // 0x0000000180C79350-0x0000000180C79420
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180C79260-0x0000000180C79300
		public string GetPrefixOfNamespace(string namespaceUri); // 0x0000000180C79300-0x0000000180C79350
	}
}
