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
	internal class XPathSingletonIterator : ResetableIterator // TypeDefIndex: 1996
	{
		// Fields
		private XPathNavigator nav; // 0x18
		private int position; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000180372430-0x0000000180372440 
		public override int CurrentPosition { get; } // 0x00000001803FB670-0x00000001803FB680 
		public override int Count { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		public XPathSingletonIterator(XPathNavigator nav); // 0x00000001813BC2C0-0x00000001813BC2F0
		public XPathSingletonIterator(XPathNavigator nav, bool moved); // 0x00000001813BC220-0x00000001813BC260
		public XPathSingletonIterator(XPathSingletonIterator it); // 0x00000001813BC260-0x00000001813BC2C0
	
		// Methods
		public override XPathNodeIterator Clone(); // 0x00000001813BC170-0x00000001813BC200
		public override bool MoveNext(); // 0x00000001813BC200-0x00000001813BC220
		public override void Reset(); // 0x000000018097E610-0x000000018097E620
	}
}
