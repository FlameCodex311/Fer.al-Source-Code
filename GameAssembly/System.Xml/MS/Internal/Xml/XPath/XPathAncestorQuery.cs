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
	internal sealed class XPathAncestorQuery : CacheAxisQuery // TypeDefIndex: 1984
	{
		// Fields
		private bool matchSelf; // 0x60
	
		// Properties
		public override int CurrentPosition { get; } // 0x00000001819CD0E0-0x00000001819CD130 
		public override QueryProps Properties { get; } // 0x0000000181451850-0x0000000181451860 
	
		// Constructors
		public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf); // 0x00000001819CD010-0x00000001819CD040
		private XPathAncestorQuery(XPathAncestorQuery other); // 0x00000001819CD040-0x00000001819CD0E0
	
		// Methods
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819CCED0-0x00000001819CD010
		public override XPathNodeIterator Clone(); // 0x00000001819CCE00-0x00000001819CCED0
	}
}
