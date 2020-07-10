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
	internal class XPathSelectionIterator : ResetableIterator // TypeDefIndex: 1889
	{
		// Fields
		private XPathNavigator nav; // 0x18
		private Query query; // 0x20
		private int position; // 0x28
	
		// Properties
		public override int Count { get; } // 0x00000001809A74A0-0x00000001809A74D0 
		public override XPathNavigator Current { get; } // 0x000000018038B150-0x000000018038B160 
		public override int CurrentPosition { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
		// Constructors
		internal XPathSelectionIterator(XPathNavigator nav, Query query); // 0x00000001809A7440-0x00000001809A74A0
		protected XPathSelectionIterator(XPathSelectionIterator it); // 0x00000001809A7340-0x00000001809A7440
	
		// Methods
		public override void Reset(); // 0x00000001809A7310-0x00000001809A7340
		public override bool MoveNext(); // 0x00000001809A7280-0x00000001809A7310
		public override XPathNodeIterator Clone(); // 0x00000001809A7150-0x00000001809A7280
	}
}
