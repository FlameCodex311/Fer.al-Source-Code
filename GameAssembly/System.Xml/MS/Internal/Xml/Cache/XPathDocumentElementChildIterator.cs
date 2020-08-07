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
	internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 1998
	{
		// Fields
		private string localName; // 0x28
		private string namespaceUri; // 0x30
	
		// Constructors
		public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI); // 0x00000001819CE0B0-0x00000001819CE200
		public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter); // 0x00000001819CE200-0x00000001819CE240
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819CDFC0-0x00000001819CE030
		public override bool MoveNext(); // 0x00000001819CE030-0x00000001819CE0B0
	}
}
