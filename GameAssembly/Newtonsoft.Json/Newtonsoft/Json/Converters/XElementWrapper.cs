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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement // TypeDefIndex: 8043
	{
		// Fields
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		private XElement Element { get; } // 0x000000018069A360-0x000000018069A3F0 
		public override List<IXmlNode> Attributes { get; } // 0x0000000180699DE0-0x000000018069A360 
		public override string Value { get; } // 0x000000018069A4A0-0x000000018069A4D0 
		public override string LocalName { get; } // 0x000000018069A420-0x000000018069A460 
		public override string NamespaceUri { get; } // 0x000000018069A460-0x000000018069A4A0 
		public bool IsEmpty { get; } // 0x000000018069A3F0-0x000000018069A420 
	
		// Constructors
		public XElementWrapper(XElement element); // 0x0000000180698B70-0x0000000180698BE0
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute); // 0x0000000180699D10-0x0000000180699DE0
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180699C20-0x0000000180699CC0
		public string GetPrefixOfNamespace(string namespaceUri); // 0x0000000180699CC0-0x0000000180699D10
	}
}
