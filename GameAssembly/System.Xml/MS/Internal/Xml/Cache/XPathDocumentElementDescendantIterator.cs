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
	internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 1895
	{
		// Fields
		private XPathDocumentNavigator end; // 0x28
		private string localName; // 0x30
		private string namespaceUri; // 0x38
		private bool matchSelf; // 0x40
	
		// Constructors
		public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf); // 0x0000000180C96790-0x0000000180C96950
		public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter); // 0x0000000180C96950-0x0000000180C969A0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C965A0-0x0000000180C96620
		public override bool MoveNext(); // 0x0000000180C96620-0x0000000180C96790
	}
}
