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
	internal class IteratorFilter : XPathNodeIterator // TypeDefIndex: 1955
	{
		// Fields
		private XPathNodeIterator innerIterator; // 0x18
		private string name; // 0x20
		private int position; // 0x28
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001819C16D0-0x00000001819C1700 
		public override int CurrentPosition { get; } // 0x000000018043C680-0x000000018043C690 
	
		// Constructors
		internal IteratorFilter(XPathNodeIterator innerIterator, string name); // 0x00000001819C1690-0x00000001819C16D0
		private IteratorFilter(IteratorFilter it); // 0x00000001819C1630-0x00000001819C1690
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819C1500-0x00000001819C1590
		public override bool MoveNext(); // 0x00000001819C1590-0x00000001819C1630
	}
}
