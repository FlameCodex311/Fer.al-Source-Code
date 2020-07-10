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
	internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery // TypeDefIndex: 1835
	{
		// Fields
		private int level; // 0x60
	
		// Constructors
		public DescendantOverDescendantQuery(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis); // 0x0000000180C85F50-0x0000000180C86020
		private DescendantOverDescendantQuery(DescendantOverDescendantQuery other); // 0x0000000180C85F00-0x0000000180C85F50
	
		// Methods
		public override void Reset(); // 0x0000000180C85EC0-0x0000000180C85F00
		public override XPathNavigator Advance(); // 0x0000000180C85BF0-0x0000000180C85D80
		private bool MoveToFirstChild(); // 0x0000000180C85E00-0x0000000180C85E40
		private bool MoveUpUntillNext(); // 0x0000000180C85E40-0x0000000180C85EC0
		public override XPathNodeIterator Clone(); // 0x0000000180C85D80-0x0000000180C85E00
	}
}
