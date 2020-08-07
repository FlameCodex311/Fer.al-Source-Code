/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal abstract class CacheAxisQuery : BaseAxisQuery // TypeDefIndex: 1930
	{
		// Fields
		protected List<XPathNavigator> outputBuffer; // 0x58
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001819BC760-0x00000001819BC7D0 
		public override int CurrentPosition { get; } // 0x0000000180387590-0x0000000180387930 
		public override int Count { get; } // 0x00000001819BC720-0x00000001819BC760 
		public override QueryProps Properties { get; } // 0x0000000181451370-0x0000000181451380 
	
		// Constructors
		public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x00000001819BC580-0x00000001819BC680
		protected CacheAxisQuery(CacheAxisQuery other); // 0x00000001819BC680-0x00000001819BC720
	
		// Methods
		public override void Reset(); // 0x00000001819BC570-0x00000001819BC580
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819BC4E0-0x00000001819BC570
		public override XPathNavigator Advance(); // 0x00000001819BC450-0x00000001819BC4E0
	}
}
