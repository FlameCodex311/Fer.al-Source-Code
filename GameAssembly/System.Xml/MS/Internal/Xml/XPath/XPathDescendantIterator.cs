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

namespace MS.Internal.Xml.XPath
{
	internal class XPathDescendantIterator : XPathAxisIterator // TypeDefIndex: 1883
	{
		// Fields
		private int level; // 0x40
	
		// Constructors
		public XPathDescendantIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf); // 0x0000000180C95B50-0x0000000180C95BA0
		public XPathDescendantIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf); // 0x0000000180C959A0-0x0000000180C95A90
		public XPathDescendantIterator(XPathDescendantIterator it); // 0x0000000180C96130-0x0000000180C961C0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C95F80-0x0000000180C96040
		public override bool MoveNext(); // 0x0000000180C96040-0x0000000180C96130
	}
}
