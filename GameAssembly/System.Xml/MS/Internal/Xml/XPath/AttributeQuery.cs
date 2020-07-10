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
	internal sealed class AttributeQuery : BaseAxisQuery // TypeDefIndex: 1819
	{
		// Fields
		private bool onAttribute; // 0x58
	
		// Constructors
		public AttributeQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type); // 0x0000000180C832E0-0x0000000180C833A0
		private AttributeQuery(AttributeQuery other); // 0x0000000180C833A0-0x0000000180C833E0
	
		// Methods
		public override void Reset(); // 0x0000000180C832A0-0x0000000180C832E0
		public override XPathNavigator Advance(); // 0x0000000180C83140-0x0000000180C83230
		public override XPathNodeIterator Clone(); // 0x0000000180C83230-0x0000000180C832A0
	}
}
