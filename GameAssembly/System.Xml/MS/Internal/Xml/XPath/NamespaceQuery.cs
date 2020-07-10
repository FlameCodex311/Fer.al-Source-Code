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
	internal sealed class NamespaceQuery : BaseAxisQuery // TypeDefIndex: 1855
	{
		// Fields
		private bool onNamespace; // 0x58
	
		// Constructors
		public NamespaceQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type); // 0x0000000180C832E0-0x0000000180C833A0
		private NamespaceQuery(NamespaceQuery other); // 0x0000000180C833A0-0x0000000180C833E0
	
		// Methods
		public override void Reset(); // 0x0000000180C832A0-0x0000000180C832E0
		public override XPathNavigator Advance(); // 0x0000000180C8DAD0-0x0000000180C8DBB0
		public override bool matches(XPathNavigator e); // 0x0000000180C8DC20-0x0000000180C8DCC0
		public override XPathNodeIterator Clone(); // 0x0000000180C8DBB0-0x0000000180C8DC20
	}
}
