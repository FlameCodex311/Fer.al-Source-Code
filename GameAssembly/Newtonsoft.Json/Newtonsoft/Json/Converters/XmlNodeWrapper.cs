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
	internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 8194
	{
		// Fields
		private readonly XmlNode _node; // 0x10
		private List<IXmlNode> _childNodes; // 0x18
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		public object WrappedNode { get; } // 0x0000000180372440-0x0000000180372450 
		public XmlNodeType NodeType { get; } // 0x00000001808F60E0-0x00000001808F6110 
		public virtual string LocalName { get; } // 0x00000001808F62B0-0x00000001808F62E0 
		public List<IXmlNode> ChildNodes { get; } // 0x0000000180C80930-0x0000000180C80D90 
		public List<IXmlNode> Attributes { get; } // 0x0000000180C80490-0x0000000180C80930 
		public IXmlNode ParentNode { get; } // 0x0000000180C80D90-0x0000000180C80EF0 
		public string Value { get; set; } // 0x00000001808F6340-0x00000001808F6370 0x0000000180C80EF0-0x0000000180C82F30
		public string NamespaceUri { get; } // 0x0000000180900950-0x0000000180900980 
	
		// Constructors
		public XmlNodeWrapper(XmlNode node); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		internal static IXmlNode WrapNode(XmlNode node); // 0x0000000180C802C0-0x0000000180C80490
		public IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180C801F0-0x0000000180C802C0
	}
}
