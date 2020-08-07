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
	internal sealed class NumericExpr : ValueQuery // TypeDefIndex: 1963
	{
		// Fields
		private Operator.Op op; // 0x18
		private Query opnd1; // 0x20
		private Query opnd2; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public NumericExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x00000001819C6AA0-0x00000001819C6BC0
		private NumericExpr(NumericExpr other); // 0x00000001819C2CD0-0x00000001819C2E50
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819C1B30-0x00000001819C1B90
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C6920-0x00000001819C6A60
		private static double GetValue(Operator.Op op, double n1, double n2); // 0x00000001819C6A60-0x00000001819C6AA0
		public override XPathNodeIterator Clone(); // 0x00000001819C68C0-0x00000001819C6920
	}
}
