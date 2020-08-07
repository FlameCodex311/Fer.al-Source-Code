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
	internal sealed class PrecedingQuery : BaseAxisQuery // TypeDefIndex: 1969
	{
		// Fields
		private XPathNodeIterator workIterator; // 0x58
		private ClonableStack<XPathNavigator> ancestorStk; // 0x60
	
		// Properties
		public override QueryProps Properties { get; } // 0x000000018144E8F0-0x000000018144E900 
	
		// Constructors
		public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x00000001819C7810-0x00000001819C7910
		private PrecedingQuery(PrecedingQuery other); // 0x00000001819C7780-0x00000001819C7810
	
		// Methods
		public override void Reset(); // 0x00000001819C7700-0x00000001819C7780
		public override XPathNavigator Advance(); // 0x00000001819C7360-0x00000001819C7640
		public override XPathNodeIterator Clone(); // 0x00000001819C7640-0x00000001819C7700
	}
}
