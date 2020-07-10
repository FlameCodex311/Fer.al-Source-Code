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
	internal sealed class PrecedingQuery : BaseAxisQuery // TypeDefIndex: 1864
	{
		// Fields
		private XPathNodeIterator workIterator; // 0x58
		private ClonableStack<XPathNavigator> ancestorStk; // 0x60
	
		// Properties
		public override QueryProps Properties { get; } // 0x00000001809EB6C0-0x00000001809EB6D0 
	
		// Constructors
		public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x0000000180C8FCB0-0x0000000180C8FDB0
		private PrecedingQuery(PrecedingQuery other); // 0x0000000180C8FC10-0x0000000180C8FCB0
	
		// Methods
		public override void Reset(); // 0x0000000180C8FB90-0x0000000180C8FC10
		public override XPathNavigator Advance(); // 0x0000000180C8F7F0-0x0000000180C8FAD0
		public override XPathNodeIterator Clone(); // 0x0000000180C8FAD0-0x0000000180C8FB90
	}
}
