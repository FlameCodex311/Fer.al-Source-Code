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
	internal sealed class CacheChildrenQuery : ChildrenQuery // TypeDefIndex: 1826
	{
		// Fields
		private XPathNavigator nextInput; // 0x60
		private ClonableStack<XPathNavigator> elementStk; // 0x68
		private ClonableStack<int> positionStk; // 0x70
		private bool needInput; // 0x78
	
		// Constructors
		public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x0000000180C84ED0-0x0000000180C84F90
		private CacheChildrenQuery(CacheChildrenQuery other); // 0x0000000180C84F90-0x0000000180C85050
	
		// Methods
		public override void Reset(); // 0x0000000180C84DD0-0x0000000180C84ED0
		public override XPathNavigator Advance(); // 0x0000000180C849C0-0x0000000180C84B60
		private bool DecideNextNode(); // 0x0000000180C84C50-0x0000000180C84D70
		private XPathNavigator GetNextInput(); // 0x0000000180C84D70-0x0000000180C84DD0
		public override XPathNodeIterator Clone(); // 0x0000000180C84B60-0x0000000180C84C50
	}
}
