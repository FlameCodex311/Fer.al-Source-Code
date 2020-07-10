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
using System.Xml.Linq;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	internal class XObjectWrapper : IXmlNode // TypeDefIndex: 8041
	{
		// Fields
		private static readonly List<IXmlNode> EmptyChildNodes; // 0x00
		private readonly XObject _xmlObject; // 0x10
	
		// Properties
		public object WrappedNode { get; } // 0x000000018036AC80-0x000000018036AC90 
		public virtual XmlNodeType NodeType { get; } // 0x0000000180470160-0x0000000180470190 
		public virtual string LocalName { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public virtual List<IXmlNode> ChildNodes { get; } // 0x000000018069A580-0x000000018069A5E0 
		public virtual List<IXmlNode> Attributes { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public virtual IXmlNode ParentNode { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public virtual string Value { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public virtual string NamespaceUri { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public XObjectWrapper(XObject xmlObject); // 0x000000018037D3F0-0x000000018037D420
		static XObjectWrapper(); // 0x000000018069A520-0x000000018069A580
	
		// Methods
		public virtual IXmlNode AppendChild(IXmlNode newChild); // 0x000000018069A4D0-0x000000018069A520
	}
}
