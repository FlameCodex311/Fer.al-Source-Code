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
	internal class PreSiblingQuery : CacheAxisQuery // TypeDefIndex: 1970
	{
		// Properties
		public override QueryProps Properties { get; } // 0x0000000181451850-0x0000000181451860 
	
		// Constructors
		public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x00000001819C6F30-0x00000001819C6F40
		protected PreSiblingQuery(PreSiblingQuery other); // 0x00000001819BC680-0x00000001819BC720
	
		// Methods
		private bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk); // 0x00000001819C7260-0x00000001819C7360
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819C7000-0x00000001819C7260
		public override XPathNodeIterator Clone(); // 0x00000001819C6F40-0x00000001819C7000
	}
}
