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
	internal sealed class BooleanExpr : ValueQuery // TypeDefIndex: 1823
	{
		// Fields
		private Query opnd1; // 0x18
		private Query opnd2; // 0x20
		private bool isOr; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Constructors
		public BooleanExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x0000000180C83AC0-0x0000000180C83BF0
		private BooleanExpr(BooleanExpr other); // 0x0000000180C83BF0-0x0000000180C83D80
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C83A60-0x0000000180C83AC0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C83980-0x0000000180C83A60
		public override XPathNodeIterator Clone(); // 0x0000000180C83920-0x0000000180C83980
	}
}
