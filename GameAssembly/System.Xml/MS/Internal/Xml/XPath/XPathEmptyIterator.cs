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
	internal sealed class XPathEmptyIterator : ResetableIterator // TypeDefIndex: 1989
	{
		// Fields
		public static XPathEmptyIterator Instance; // 0x00
	
		// Properties
		public override XPathNavigator Current { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int CurrentPosition { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int Count { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		private XPathEmptyIterator(); // 0x00000001819BE2D0-0x00000001819BE2F0
		static XPathEmptyIterator(); // 0x00000001819D1860-0x00000001819D18C0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180411160-0x0000000180411170
		public override bool MoveNext(); // 0x0000000180380950-0x0000000180380960
		public override void Reset(); // 0x00000001803774A0-0x00000001803774B0
	}
}
