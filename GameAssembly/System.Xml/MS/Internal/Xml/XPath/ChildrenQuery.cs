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
	internal class ChildrenQuery : BaseAxisQuery // TypeDefIndex: 1828
	{
		// Fields
		private XPathNodeIterator iterator; // 0x58
	
		// Constructors
		public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x0000000180C85730-0x0000000180C85850
		protected ChildrenQuery(ChildrenQuery other); // 0x0000000180C85670-0x0000000180C85730
	
		// Methods
		public override void Reset(); // 0x0000000180C855E0-0x0000000180C85670
		public override XPathNavigator Advance(); // 0x0000000180C85400-0x0000000180C85580
		public override XPathNodeIterator Clone(); // 0x0000000180C85580-0x0000000180C855E0
	}
}
