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
	internal class XPathSelectionIterator : ResetableIterator // TypeDefIndex: 1994
	{
		// Fields
		private XPathNavigator nav; // 0x18
		private Query query; // 0x20
		private int position; // 0x28
	
		// Properties
		public override int Count { get; } // 0x00000001813BC050-0x00000001813BC080 
		public override XPathNavigator Current { get; } // 0x0000000180372430-0x0000000180372440 
		public override int CurrentPosition { get; } // 0x000000018043C680-0x000000018043C690 
	
		// Constructors
		internal XPathSelectionIterator(XPathNavigator nav, Query query); // 0x00000001813BBFF0-0x00000001813BC050
		protected XPathSelectionIterator(XPathSelectionIterator it); // 0x00000001813BBEF0-0x00000001813BBFF0
	
		// Methods
		public override void Reset(); // 0x00000001813BBEC0-0x00000001813BBEF0
		public override bool MoveNext(); // 0x00000001813BBE30-0x00000001813BBEC0
		public override XPathNodeIterator Clone(); // 0x00000001813BBD10-0x00000001813BBE30
	}
}
