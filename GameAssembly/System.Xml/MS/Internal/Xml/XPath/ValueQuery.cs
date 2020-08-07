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
	internal abstract class ValueQuery : Query // TypeDefIndex: 1981
	{
		// Properties
		public sealed override XPathNavigator Current { get; } // 0x00000001819CCAB0-0x00000001819CCAF0 
		public sealed override int CurrentPosition { get; } // 0x00000001819CCA70-0x00000001819CCAB0 
		public sealed override int Count { get; } // 0x00000001819CCA30-0x00000001819CCA70 
	
		// Constructors
		public ValueQuery(); // 0x00000001819BE2D0-0x00000001819BE2F0
		protected ValueQuery(ValueQuery other); // 0x00000001819CA000-0x00000001819CA040
	
		// Methods
		public sealed override void Reset(); // 0x00000001803774A0-0x00000001803774B0
		public sealed override XPathNavigator Advance(); // 0x00000001819CC9F0-0x00000001819CCA30
	}
}
