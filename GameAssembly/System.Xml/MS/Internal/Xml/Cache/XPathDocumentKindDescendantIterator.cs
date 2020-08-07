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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.Cache
{
	internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 2001
	{
		// Fields
		private XPathDocumentNavigator end; // 0x28
		private XPathNodeType typ; // 0x30
		private bool matchSelf; // 0x34
	
		// Constructors
		public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf); // 0x00000001819CE9A0-0x00000001819CEAE0
		public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter); // 0x00000001819CEAE0-0x00000001819CEB30
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819CE800-0x00000001819CE880
		public override bool MoveNext(); // 0x00000001819CE880-0x00000001819CE9A0
	}
}
