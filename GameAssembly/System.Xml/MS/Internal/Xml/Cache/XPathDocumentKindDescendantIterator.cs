/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.Cache
{
	internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 1896
	{
		// Fields
		private XPathDocumentNavigator end; // 0x28
		private XPathNodeType typ; // 0x30
		private bool matchSelf; // 0x34
	
		// Constructors
		public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf); // 0x0000000180C96D10-0x0000000180C96E50
		public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter); // 0x0000000180C96E50-0x0000000180C96EA0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C96B70-0x0000000180C96BF0
		public override bool MoveNext(); // 0x0000000180C96BF0-0x0000000180C96D10
	}
}
