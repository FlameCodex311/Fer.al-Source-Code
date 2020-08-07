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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class UnionExpr : Query // TypeDefIndex: 1980
	{
		// Fields
		internal Query qy1; // 0x18
		internal Query qy2; // 0x20
		private bool advance1; // 0x28
		private bool advance2; // 0x29
		private XPathNavigator currentNode; // 0x30
		private XPathNavigator nextNode; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018043E010-0x000000018043E020 
		public override XPathNavigator Current { get; } // 0x00000001803745C0-0x00000001803745D0 
		public override int CurrentPosition { get; } // 0x00000001819CC9A0-0x00000001819CC9F0 
	
		// Constructors
		public UnionExpr(Query query1, Query query2); // 0x00000001819CC770-0x00000001819CC7C0
		private UnionExpr(UnionExpr other); // 0x00000001819CC7C0-0x00000001819CC9A0
	
		// Methods
		public override void Reset(); // 0x00000001819CC710-0x00000001819CC770
		public override void SetXsltContext(XsltContext xsltContext); // 0x00000001819BB8B0-0x00000001819BB910
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819CC640-0x00000001819CC6C0
		private XPathNavigator ProcessSamePosition(XPathNavigator result); // 0x00000001819CC700-0x00000001819CC710
		private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2); // 0x00000001819CC6E0-0x00000001819CC700
		private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2); // 0x00000001819CC6C0-0x00000001819CC6E0
		public override XPathNavigator Advance(); // 0x00000001819CC490-0x00000001819CC5E0
		public override XPathNodeIterator Clone(); // 0x00000001819CC5E0-0x00000001819CC640
	}
}
