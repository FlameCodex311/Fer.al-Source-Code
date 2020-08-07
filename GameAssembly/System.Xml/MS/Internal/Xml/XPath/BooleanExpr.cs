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
	internal sealed class BooleanExpr : ValueQuery // TypeDefIndex: 1928
	{
		// Fields
		private Query opnd1; // 0x18
		private Query opnd2; // 0x20
		private bool isOr; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Constructors
		public BooleanExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x00000001819BB910-0x00000001819BBA40
		private BooleanExpr(BooleanExpr other); // 0x00000001819BBA40-0x00000001819BBBD0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819BB8B0-0x00000001819BB910
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819BB7D0-0x00000001819BB8B0
		public override XPathNodeIterator Clone(); // 0x00000001819BB770-0x00000001819BB7D0
	}
}
