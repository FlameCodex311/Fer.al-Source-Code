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
	internal sealed class LogicalExpr : ValueQuery // TypeDefIndex: 1851
	{
		// Fields
		private Operator.Op op; // 0x18
		private Query opnd1; // 0x20
		private Query opnd2; // 0x28
		private static readonly cmpXslt[][] CompXsltE; // 0x00
		private static readonly cmpXslt[][] CompXsltO; // 0x08
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Nested types
		private delegate bool cmpXslt(Operator.Op op, object val1, object val2); // TypeDefIndex: 1852; 0x0000000180C9FA50-0x0000000180C9FD90
	
		private struct NodeSet // TypeDefIndex: 1853
		{
			// Fields
			private Query opnd; // 0x00
			private XPathNavigator current; // 0x08
	
			// Properties
			public string Value { get; } // 0x00000001800212C0-0x0000000180021310 
	
			// Constructors
			public NodeSet(object opnd); // 0x0000000180021220-0x00000001800212C0
	
			// Methods
			public bool MoveNext(); // 0x00000001800211B0-0x00000001800211F0
			public void Reset(); // 0x00000001800211F0-0x0000000180021220
		}
	
		// Constructors
		public LogicalExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x0000000180C8B230-0x0000000180C8B280
		private LogicalExpr(LogicalExpr other); // 0x0000000180C8B0B0-0x0000000180C8B230
		static LogicalExpr(); // 0x0000000180C89E70-0x0000000180C8B0B0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C89E10-0x0000000180C89E70
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C89A20-0x0000000180C89D30
		private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2); // 0x0000000180C8BFE0-0x0000000180C8C1F0
		private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2); // 0x0000000180C8C1F0-0x0000000180C8C550
		private static bool cmpQueryNumber(Operator.Op op, object val1, object val2); // 0x0000000180C8BE10-0x0000000180C8BFE0
		private static bool cmpQueryStringE(Operator.Op op, object val1, object val2); // 0x0000000180C8C550-0x0000000180C8C6C0
		private static bool cmpQueryStringO(Operator.Op op, object val1, object val2); // 0x0000000180C8C6C0-0x0000000180C8C900
		private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2); // 0x0000000180C8CC20-0x0000000180C8CD90
		private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2); // 0x0000000180C8CD90-0x0000000180C8CFB0
		private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2); // 0x0000000180C8BB30-0x0000000180C8BC80
		private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2); // 0x0000000180C8BC80-0x0000000180C8BE10
		private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2); // 0x0000000180C8B280-0x0000000180C8B2A0
		private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2); // 0x0000000180C8B2A0-0x0000000180C8B390
		private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2); // 0x0000000180C8B390-0x0000000180C8B4D0
		private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2); // 0x0000000180C8B4D0-0x0000000180C8B5C0
		private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2); // 0x0000000180C8B5C0-0x0000000180C8B700
		private static bool cmpBoolStringE(Operator.Op op, object val1, object val2); // 0x0000000180C8B700-0x0000000180C8B7F0
		private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2); // 0x0000000180C8C900-0x0000000180C8C9D0
		private static bool cmpBoolStringO(Operator.Op op, object val1, object val2); // 0x0000000180C8B7F0-0x0000000180C8B960
		private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2); // 0x0000000180C8C9D0-0x0000000180C8CB10
		private static bool cmpNumberNumber(Operator.Op op, double n1, double n2); // 0x0000000180C8BAA0-0x0000000180C8BB30
		private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2); // 0x0000000180C8B960-0x0000000180C8B9A0
		private static bool cmpNumberNumber(Operator.Op op, object val1, object val2); // 0x0000000180C8B9A0-0x0000000180C8BAA0
		private static bool cmpStringNumber(Operator.Op op, object val1, object val2); // 0x0000000180C8D3B0-0x0000000180C8D4E0
		private static bool cmpRtfNumber(Operator.Op op, object val1, object val2); // 0x0000000180C8CB10-0x0000000180C8CC20
		private static bool cmpStringStringE(Operator.Op op, string n1, string n2); // 0x0000000180C8D4E0-0x0000000180C8D520
		private static bool cmpStringStringE(Operator.Op op, object val1, object val2); // 0x0000000180C8D520-0x0000000180C8D600
		private static bool cmpRtfStringE(Operator.Op op, object val1, object val2); // 0x0000000180C8D1A0-0x0000000180C8D250
		private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2); // 0x0000000180C8CFB0-0x0000000180C8D050
		private static bool cmpStringStringO(Operator.Op op, object val1, object val2); // 0x0000000180C8D600-0x0000000180C8D7A0
		private static bool cmpRtfStringO(Operator.Op op, object val1, object val2); // 0x0000000180C8D250-0x0000000180C8D3B0
		private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2); // 0x0000000180C8D050-0x0000000180C8D1A0
		public override XPathNodeIterator Clone(); // 0x0000000180C899C0-0x0000000180C89A20
		private static string Rtf(object o); // 0x0000000180C89D30-0x0000000180C89E10
	}
}
