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
	internal sealed class EmptyQuery : Query // TypeDefIndex: 1942
	{
		// Properties
		public override int CurrentPosition { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int Count { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override QueryProps Properties { get; } // 0x0000000181451370-0x0000000181451380 
		public override XPathResultType StaticType { get; } // 0x000000018043E010-0x000000018043E020 
		public override XPathNavigator Current { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public EmptyQuery(); // 0x00000001819BE2D0-0x00000001819BE2F0
	
		// Methods
		public override XPathNavigator Advance(); // 0x000000018037DDC0-0x000000018037DDD0
		public override XPathNodeIterator Clone(); // 0x0000000180411160-0x0000000180411170
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180411160-0x0000000180411170
		public override void Reset(); // 0x00000001803774A0-0x00000001803774B0
	}
}
