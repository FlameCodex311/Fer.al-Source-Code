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
	internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 8206
	{
		// Fields
		private List<IXmlNode> _childNodes; // 0x18
	
		// Properties
		private XContainer Container { get; } // 0x0000000180C78410-0x0000000180C784A0 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180C78200-0x0000000180C78410 
		public override IXmlNode ParentNode { get; } // 0x0000000180C784A0-0x0000000180C78500 
	
		// Constructors
		public XContainerWrapper(XContainer container); // 0x0000000180C78190-0x0000000180C78200
	
		// Methods
		internal static IXmlNode WrapNode(XObject node); // 0x0000000180C77AF0-0x0000000180C78190
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180C77A60-0x0000000180C77AF0
	}
}
