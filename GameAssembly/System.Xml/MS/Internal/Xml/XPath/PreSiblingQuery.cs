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
	internal class PreSiblingQuery : CacheAxisQuery // TypeDefIndex: 1865
	{
		// Properties
		public override QueryProps Properties { get; } // 0x00000001809EE650-0x00000001809EE660 
	
		// Constructors
		public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x0000000180C8F3C0-0x0000000180C8F3D0
		protected PreSiblingQuery(PreSiblingQuery other); // 0x0000000180C84870-0x0000000180C84910
	
		// Methods
		private bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk); // 0x0000000180C8F6F0-0x0000000180C8F7F0
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C8F490-0x0000000180C8F6F0
		public override XPathNodeIterator Clone(); // 0x0000000180C8F3D0-0x0000000180C8F490
	}
}
