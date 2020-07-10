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
	internal sealed class FollSiblingQuery : BaseAxisQuery // TypeDefIndex: 1842
	{
		// Fields
		private ClonableStack<XPathNavigator> elementStk; // 0x58
		private List<XPathNavigator> parentStk; // 0x60
		private XPathNavigator nextInput; // 0x68
	
		// Constructors
		public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x0000000180C87C10-0x0000000180C87D40
		private FollSiblingQuery(FollSiblingQuery other); // 0x0000000180C87B20-0x0000000180C87C10
	
		// Methods
		public override void Reset(); // 0x0000000180C87950-0x0000000180C879E0
		private bool Visited(XPathNavigator nav); // 0x0000000180C879E0-0x0000000180C87B20
		private XPathNavigator FetchInput(); // 0x0000000180C877F0-0x0000000180C87950
		public override XPathNavigator Advance(); // 0x0000000180C87520-0x0000000180C876E0
		public override XPathNodeIterator Clone(); // 0x0000000180C876E0-0x0000000180C877F0
	}
}
