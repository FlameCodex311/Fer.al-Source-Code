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
	internal sealed class NumericExpr : ValueQuery // TypeDefIndex: 1858
	{
		// Fields
		private Operator.Op op; // 0x18
		private Query opnd1; // 0x20
		private Query opnd2; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public NumericExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x0000000180C8EEC0-0x0000000180C8EFE0
		private NumericExpr(NumericExpr other); // 0x0000000180C8B0B0-0x0000000180C8B230
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C89E10-0x0000000180C89E70
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C8ED40-0x0000000180C8EE80
		private static double GetValue(Operator.Op op, double n1, double n2); // 0x0000000180C8EE80-0x0000000180C8EEC0
		public override XPathNodeIterator Clone(); // 0x0000000180C8ECE0-0x0000000180C8ED40
	}
}
