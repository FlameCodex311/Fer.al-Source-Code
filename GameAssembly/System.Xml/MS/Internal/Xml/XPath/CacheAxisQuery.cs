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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal abstract class CacheAxisQuery : BaseAxisQuery // TypeDefIndex: 1825
	{
		// Fields
		protected List<XPathNavigator> outputBuffer; // 0x58
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180C84950-0x0000000180C849C0 
		public override int CurrentPosition { get; } // 0x000000018036CFF0-0x000000018036D000 
		public override int Count { get; } // 0x0000000180C84910-0x0000000180C84950 
		public override QueryProps Properties { get; } // 0x00000001809EE170-0x00000001809EE180 
	
		// Constructors
		public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x0000000180C84760-0x0000000180C84870
		protected CacheAxisQuery(CacheAxisQuery other); // 0x0000000180C84870-0x0000000180C84910
	
		// Methods
		public override void Reset(); // 0x0000000180C84750-0x0000000180C84760
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C846C0-0x0000000180C84750
		public override XPathNavigator Advance(); // 0x0000000180C84620-0x0000000180C846C0
	}
}
