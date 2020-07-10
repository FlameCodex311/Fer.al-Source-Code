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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 8028
	{
		// Fields
		private readonly XmlNode _node; // 0x10
		private List<IXmlNode> _childNodes; // 0x18
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		public object WrappedNode { get; } // 0x000000018036AC80-0x000000018036AC90 
		public XmlNodeType NodeType { get; } // 0x000000018046FF30-0x000000018046FF60 
		public virtual string LocalName { get; } // 0x0000000180470130-0x0000000180470160 
		public List<IXmlNode> ChildNodes { get; } // 0x00000001806A1560-0x00000001806A19D0 
		public List<IXmlNode> Attributes { get; } // 0x00000001806A10B0-0x00000001806A1560 
		public IXmlNode ParentNode { get; } // 0x00000001806A19D0-0x00000001806A1B30 
		public string Value { get; set; } // 0x00000001804701C0-0x00000001804701F0 0x00000001806A1B30-0x00000001806A1B60
		public string NamespaceUri { get; } // 0x000000018047ACB0-0x000000018047ACE0 
	
		// Constructors
		public XmlNodeWrapper(XmlNode node); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		internal static IXmlNode WrapNode(XmlNode node); // 0x00000001806A0EE0-0x00000001806A10B0
		public IXmlNode AppendChild(IXmlNode newChild); // 0x00000001806A0E10-0x00000001806A0EE0
	}
}
