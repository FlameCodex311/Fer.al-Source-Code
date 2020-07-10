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
	internal sealed class XPathEmptyIterator : ResetableIterator // TypeDefIndex: 1884
	{
		// Fields
		public static XPathEmptyIterator Instance; // 0x00
	
		// Properties
		public override XPathNavigator Current { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int CurrentPosition { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int Count { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		private XPathEmptyIterator(); // 0x0000000180C86500-0x0000000180C86520
		static XPathEmptyIterator(); // 0x0000000180C99B90-0x0000000180C99BF0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x0000000180362190-0x00000001803621A0
		public override bool MoveNext(); // 0x00000001803C28F0-0x00000001803C2900
		public override void Reset(); // 0x00000001803581E0-0x00000001803581F0
	}
}
