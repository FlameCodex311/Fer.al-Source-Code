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
	internal abstract class ValueQuery : Query // TypeDefIndex: 1876
	{
		// Properties
		public sealed override XPathNavigator Current { get; } // 0x0000000180C94DE0-0x0000000180C94E20 
		public sealed override int CurrentPosition { get; } // 0x0000000180C94DA0-0x0000000180C94DE0 
		public sealed override int Count { get; } // 0x0000000180C94D60-0x0000000180C94DA0 
	
		// Constructors
		public ValueQuery(); // 0x0000000180C86500-0x0000000180C86520
		protected ValueQuery(ValueQuery other); // 0x0000000180C924F0-0x0000000180C92530
	
		// Methods
		public sealed override void Reset(); // 0x00000001803581E0-0x00000001803581F0
		public sealed override XPathNavigator Advance(); // 0x0000000180C94D20-0x0000000180C94D60
	}
}
