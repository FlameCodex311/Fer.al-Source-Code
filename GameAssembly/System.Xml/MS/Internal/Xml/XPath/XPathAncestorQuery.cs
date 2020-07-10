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
	internal sealed class XPathAncestorQuery : CacheAxisQuery // TypeDefIndex: 1879
	{
		// Fields
		private bool matchSelf; // 0x60
	
		// Properties
		public override int CurrentPosition { get; } // 0x0000000180C95410-0x0000000180C95460 
		public override QueryProps Properties { get; } // 0x00000001809EE650-0x00000001809EE660 
	
		// Constructors
		public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf); // 0x0000000180C95340-0x0000000180C95370
		private XPathAncestorQuery(XPathAncestorQuery other); // 0x0000000180C95370-0x0000000180C95410
	
		// Methods
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C95200-0x0000000180C95340
		public override XPathNodeIterator Clone(); // 0x0000000180C95130-0x0000000180C95200
	}
}
