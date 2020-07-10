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
	internal class IteratorFilter : XPathNodeIterator // TypeDefIndex: 1850
	{
		// Fields
		private XPathNodeIterator innerIterator; // 0x18
		private string name; // 0x20
		private int position; // 0x28
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180C89990-0x0000000180C899C0 
		public override int CurrentPosition { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
		// Constructors
		internal IteratorFilter(XPathNodeIterator innerIterator, string name); // 0x0000000180C89950-0x0000000180C89990
		private IteratorFilter(IteratorFilter it); // 0x0000000180C898F0-0x0000000180C89950
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C897C0-0x0000000180C89850
		public override bool MoveNext(); // 0x0000000180C89850-0x0000000180C898F0
	}
}
