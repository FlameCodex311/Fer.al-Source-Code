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
	internal sealed class NamespaceQuery : BaseAxisQuery // TypeDefIndex: 1960
	{
		// Fields
		private bool onNamespace; // 0x58
	
		// Constructors
		public NamespaceQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type); // 0x00000001819BB140-0x00000001819BB200
		private NamespaceQuery(NamespaceQuery other); // 0x00000001819BB200-0x00000001819BB240
	
		// Methods
		public override void Reset(); // 0x00000001819BB100-0x00000001819BB140
		public override XPathNavigator Advance(); // 0x00000001819C56D0-0x00000001819C57B0
		public override bool matches(XPathNavigator e); // 0x00000001819C5820-0x00000001819C58C0
		public override XPathNodeIterator Clone(); // 0x00000001819C57B0-0x00000001819C5820
	}
}
