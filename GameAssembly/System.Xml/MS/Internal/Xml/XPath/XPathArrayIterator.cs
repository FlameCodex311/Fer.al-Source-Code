/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	[DebuggerDisplay] // 0x0000000180144010-0x0000000180144040
	internal class XPathArrayIterator : ResetableIterator // TypeDefIndex: 1880
	{
		// Fields
		protected IList list; // 0x18
		protected int index; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180C957E0-0x0000000180C959A0 
		public override int CurrentPosition { get; } // 0x00000001803C2700-0x00000001803C2710 
		public override int Count { get; } // 0x0000000180C95790-0x0000000180C957E0 
	
		// Constructors
		public XPathArrayIterator(XPathArrayIterator it); // 0x0000000180C955A0-0x0000000180C955F0
		public XPathArrayIterator(XPathNodeIterator nodeIterator); // 0x0000000180C955F0-0x0000000180C95790
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180C95460-0x0000000180C954E0
		public override bool MoveNext(); // 0x0000000180C95530-0x0000000180C955A0
		public override void Reset(); // 0x00000001809A7670-0x00000001809A7680
		public override IEnumerator GetEnumerator(); // 0x0000000180C954E0-0x0000000180C95530
	}
}
