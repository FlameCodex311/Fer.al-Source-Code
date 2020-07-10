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
	internal sealed class FollowingQuery : BaseAxisQuery // TypeDefIndex: 1841
	{
		// Fields
		private XPathNavigator input; // 0x58
		private XPathNodeIterator iterator; // 0x60
	
		// Constructors
		public FollowingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x0000000180C832E0-0x0000000180C833A0
		private FollowingQuery(FollowingQuery other); // 0x0000000180C880C0-0x0000000180C88140
	
		// Methods
		public override void Reset(); // 0x0000000180C86250-0x0000000180C86290
		public override XPathNavigator Advance(); // 0x0000000180C87D40-0x0000000180C88010
		public override XPathNodeIterator Clone(); // 0x0000000180C88010-0x0000000180C880C0
	}
}
