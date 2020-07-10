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
	internal class XPathSingletonIterator : ResetableIterator // TypeDefIndex: 1891
	{
		// Fields
		private XPathNavigator nav; // 0x18
		private int position; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x000000018038B150-0x000000018038B160 
		public override int CurrentPosition { get; } // 0x00000001803C2700-0x00000001803C2710 
		public override int Count { get; } // 0x000000018042E670-0x000000018042E680 
	
		// Constructors
		public XPathSingletonIterator(XPathNavigator nav); // 0x00000001809A7720-0x00000001809A7750
		public XPathSingletonIterator(XPathNavigator nav, bool moved); // 0x00000001809A7680-0x00000001809A76C0
		public XPathSingletonIterator(XPathSingletonIterator it); // 0x00000001809A76C0-0x00000001809A7720
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001809A75C0-0x00000001809A7650
		public override bool MoveNext(); // 0x00000001809A7650-0x00000001809A7670
		public override void Reset(); // 0x00000001809A7670-0x00000001809A7680
	}
}
