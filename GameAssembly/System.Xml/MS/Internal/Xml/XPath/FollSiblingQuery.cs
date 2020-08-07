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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class FollSiblingQuery : BaseAxisQuery // TypeDefIndex: 1947
	{
		// Fields
		private ClonableStack<XPathNavigator> elementStk; // 0x58
		private List<XPathNavigator> parentStk; // 0x60
		private XPathNavigator nextInput; // 0x68
	
		// Constructors
		public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type); // 0x00000001819BF9C0-0x00000001819BFAF0
		private FollSiblingQuery(FollSiblingQuery other); // 0x00000001819BF8D0-0x00000001819BF9C0
	
		// Methods
		public override void Reset(); // 0x00000001819BF700-0x00000001819BF790
		private bool Visited(XPathNavigator nav); // 0x00000001819BF790-0x00000001819BF8D0
		private XPathNavigator FetchInput(); // 0x00000001819BF5A0-0x00000001819BF700
		public override XPathNavigator Advance(); // 0x00000001819BF2D0-0x00000001819BF490
		public override XPathNodeIterator Clone(); // 0x00000001819BF490-0x00000001819BF5A0
	}
}
