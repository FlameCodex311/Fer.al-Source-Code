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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	internal class XObjectWrapper : IXmlNode // TypeDefIndex: 8207
	{
		// Fields
		private static readonly List<IXmlNode> EmptyChildNodes; // 0x00
		private readonly XObject _xmlObject; // 0x10
	
		// Properties
		public object WrappedNode { get; } // 0x0000000180372440-0x0000000180372450 
		public virtual XmlNodeType NodeType { get; } // 0x00000001808F62E0-0x00000001808F6310 
		public virtual string LocalName { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public virtual List<IXmlNode> ChildNodes { get; } // 0x0000000180C79B80-0x0000000180C79BE0 
		public virtual List<IXmlNode> Attributes { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public virtual IXmlNode ParentNode { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public virtual string Value { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public virtual string NamespaceUri { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public XObjectWrapper(XObject xmlObject); // 0x0000000180400150-0x0000000180400180
		static XObjectWrapper(); // 0x0000000180C79B20-0x0000000180C79B80
	
		// Methods
		public virtual IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180C79AD0-0x0000000180C79B20
	}
}
