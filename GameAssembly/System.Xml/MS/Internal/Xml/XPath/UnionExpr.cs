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
using System.Xml.Xsl;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class UnionExpr : Query // TypeDefIndex: 1875
	{
		// Fields
		internal Query qy1; // 0x18
		internal Query qy2; // 0x20
		private bool advance1; // 0x28
		private bool advance2; // 0x29
		private XPathNavigator currentNode; // 0x30
		private XPathNavigator nextNode; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override XPathNavigator Current { get; } // 0x0000000180397720-0x0000000180397730 
		public override int CurrentPosition { get; } // 0x0000000180C94CD0-0x0000000180C94D20 
	
		// Constructors
		public UnionExpr(Query query1, Query query2); // 0x0000000180C94AA0-0x0000000180C94AF0
		private UnionExpr(UnionExpr other); // 0x0000000180C94AF0-0x0000000180C94CD0
	
		// Methods
		public override void Reset(); // 0x0000000180C94A40-0x0000000180C94AA0
		public override void SetXsltContext(XsltContext xsltContext); // 0x0000000180C83A60-0x0000000180C83AC0
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C94970-0x0000000180C949F0
		private XPathNavigator ProcessSamePosition(XPathNavigator result); // 0x0000000180C94A30-0x0000000180C94A40
		private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2); // 0x0000000180C94A10-0x0000000180C94A30
		private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2); // 0x0000000180C949F0-0x0000000180C94A10
		public override XPathNavigator Advance(); // 0x0000000180C947C0-0x0000000180C94910
		public override XPathNodeIterator Clone(); // 0x0000000180C94910-0x0000000180C94970
	}
}
