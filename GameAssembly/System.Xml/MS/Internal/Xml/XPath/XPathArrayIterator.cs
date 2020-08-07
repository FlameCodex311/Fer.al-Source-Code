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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	[DebuggerDisplay] // 0x0000000180280CA0-0x0000000180280CD0
	internal class XPathArrayIterator : ResetableIterator // TypeDefIndex: 1985
	{
		// Fields
		protected IList list; // 0x18
		protected int index; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001819CD490-0x00000001819CD650 
		public override int CurrentPosition { get; } // 0x00000001803FB670-0x00000001803FB680 
		public override int Count { get; } // 0x00000001819CD440-0x00000001819CD490 
	
		// Constructors
		public XPathArrayIterator(XPathArrayIterator it); // 0x00000001819CD260-0x00000001819CD2B0
		public XPathArrayIterator(XPathNodeIterator nodeIterator); // 0x00000001819CD2B0-0x00000001819CD440
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001819CD130-0x00000001819CD1A0
		public override bool MoveNext(); // 0x00000001819CD1F0-0x00000001819CD260
		public override void Reset(); // 0x000000018097E610-0x000000018097E620
		public override IEnumerator GetEnumerator(); // 0x00000001819CD1A0-0x00000001819CD1F0
	}
}
