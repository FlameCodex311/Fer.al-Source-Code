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

namespace MS.Internal.Xml.XPath
{
	internal class XPathDescendantIterator : XPathAxisIterator // TypeDefIndex: 1988
	{
		// Fields
		private int level; // 0x40
	
		// Constructors
		public XPathDescendantIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf); // 0x00000001819CD7F0-0x00000001819CD840
		public XPathDescendantIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf); // 0x00000001819CD650-0x00000001819CD730
		public XPathDescendantIterator(XPathDescendantIterator it); // 0x00000001819CDDD0-0x00000001819CDE60
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819CDC20-0x00000001819CDCE0
		public override bool MoveNext(); // 0x00000001819CDCE0-0x00000001819CDDD0
	}
}
