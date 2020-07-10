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
	internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 1893
	{
		// Fields
		private string localName; // 0x28
		private string namespaceUri; // 0x30
	
		// Constructors
		public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI); // 0x0000000180C96410-0x0000000180C96560
		public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter); // 0x0000000180C96560-0x0000000180C965A0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C96320-0x0000000180C96390
		public override bool MoveNext(); // 0x0000000180C96390-0x0000000180C96410
	}
}
