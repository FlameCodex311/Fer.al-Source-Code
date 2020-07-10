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
	internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 8040
	{
		// Fields
		private List<IXmlNode> _childNodes; // 0x18
	
		// Properties
		private XContainer Container { get; } // 0x0000000180698E00-0x0000000180698E90 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180698BE0-0x0000000180698E00 
		public override IXmlNode ParentNode { get; } // 0x0000000180698E90-0x0000000180698F00 
	
		// Constructors
		public XContainerWrapper(XContainer container); // 0x0000000180698B70-0x0000000180698BE0
	
		// Methods
		internal static IXmlNode WrapNode(XObject node); // 0x00000001806984D0-0x0000000180698B70
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180698430-0x00000001806984D0
	}
}
