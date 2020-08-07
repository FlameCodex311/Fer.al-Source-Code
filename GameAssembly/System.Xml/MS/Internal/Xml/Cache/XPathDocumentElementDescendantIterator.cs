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
	internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 2000
	{
		// Fields
		private XPathDocumentNavigator end; // 0x28
		private string localName; // 0x30
		private string namespaceUri; // 0x38
		private bool matchSelf; // 0x40
	
		// Constructors
		public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf); // 0x00000001819CE420-0x00000001819CE5E0
		public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter); // 0x00000001819CE5E0-0x00000001819CE630
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819CE240-0x00000001819CE2C0
		public override bool MoveNext(); // 0x00000001819CE2C0-0x00000001819CE420
	}
}
