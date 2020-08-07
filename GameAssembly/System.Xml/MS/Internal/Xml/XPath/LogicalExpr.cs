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
	internal sealed class LogicalExpr : ValueQuery // TypeDefIndex: 1956
	{
		// Fields
		private Operator.Op op; // 0x18
		private Query opnd1; // 0x20
		private Query opnd2; // 0x28
		private static readonly cmpXslt[][] CompXsltE; // 0x00
		private static readonly cmpXslt[][] CompXsltO; // 0x08
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Nested types
		private delegate bool cmpXslt(Operator.Op op, object val1, object val2); // TypeDefIndex: 1957; 0x00000001819D7080-0x00000001819D73B0
	
		private struct NodeSet // TypeDefIndex: 1958
		{
			// Fields
			private Query opnd; // 0x00
			private XPathNavigator current; // 0x08
	
			// Properties
			public string Value { get; } // 0x000000018010D9F0-0x000000018010DA40 
	
			// Constructors
			public NodeSet(object opnd); // 0x000000018010D950-0x000000018010D9F0
	
			// Methods
			public bool MoveNext(); // 0x000000018010D8E0-0x000000018010D920
			public void Reset(); // 0x000000018010D920-0x000000018010D950
		}
	
		// Constructors
		public LogicalExpr(Operator.Op op, Query opnd1, Query opnd2); // 0x00000001819C2E50-0x00000001819C2EA0
		private LogicalExpr(LogicalExpr other); // 0x00000001819C2CD0-0x00000001819C2E50
		static LogicalExpr(); // 0x00000001819C1B90-0x00000001819C2CD0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819C1B30-0x00000001819C1B90
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C1760-0x00000001819C1A50
		private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2); // 0x00000001819C3BE0-0x00000001819C3DF0
		private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2); // 0x00000001819C3DF0-0x00000001819C4150
		private static bool cmpQueryNumber(Operator.Op op, object val1, object val2); // 0x00000001819C3A10-0x00000001819C3BE0
		private static bool cmpQueryStringE(Operator.Op op, object val1, object val2); // 0x00000001819C4150-0x00000001819C42C0
		private static bool cmpQueryStringO(Operator.Op op, object val1, object val2); // 0x00000001819C42C0-0x00000001819C4500
		private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2); // 0x00000001819C4820-0x00000001819C4990
		private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2); // 0x00000001819C4990-0x00000001819C4BB0
		private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2); // 0x00000001819C3730-0x00000001819C3880
		private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2); // 0x00000001819C3880-0x00000001819C3A10
		private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2); // 0x00000001819C2EA0-0x00000001819C2EC0
		private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2); // 0x00000001819C2EC0-0x00000001819C2FB0
		private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2); // 0x00000001819C2FB0-0x00000001819C30F0
		private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2); // 0x00000001819C30F0-0x00000001819C31E0
		private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2); // 0x00000001819C31E0-0x00000001819C3310
		private static bool cmpBoolStringE(Operator.Op op, object val1, object val2); // 0x00000001819C3310-0x00000001819C3400
		private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2); // 0x00000001819C4500-0x00000001819C45D0
		private static bool cmpBoolStringO(Operator.Op op, object val1, object val2); // 0x00000001819C3400-0x00000001819C3570
		private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2); // 0x00000001819C45D0-0x00000001819C4710
		private static bool cmpNumberNumber(Operator.Op op, double n1, double n2); // 0x00000001819C36A0-0x00000001819C3730
		private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2); // 0x00000001819C3570-0x00000001819C35B0
		private static bool cmpNumberNumber(Operator.Op op, object val1, object val2); // 0x00000001819C35B0-0x00000001819C36A0
		private static bool cmpStringNumber(Operator.Op op, object val1, object val2); // 0x00000001819C4FB0-0x00000001819C50E0
		private static bool cmpRtfNumber(Operator.Op op, object val1, object val2); // 0x00000001819C4710-0x00000001819C4820
		private static bool cmpStringStringE(Operator.Op op, string n1, string n2); // 0x00000001819C50E0-0x00000001819C5120
		private static bool cmpStringStringE(Operator.Op op, object val1, object val2); // 0x00000001819C5120-0x00000001819C5200
		private static bool cmpRtfStringE(Operator.Op op, object val1, object val2); // 0x00000001819C4DA0-0x00000001819C4E50
		private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2); // 0x00000001819C4BB0-0x00000001819C4C50
		private static bool cmpStringStringO(Operator.Op op, object val1, object val2); // 0x00000001819C5200-0x00000001819C53A0
		private static bool cmpRtfStringO(Operator.Op op, object val1, object val2); // 0x00000001819C4E50-0x00000001819C4FB0
		private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2); // 0x00000001819C4C50-0x00000001819C4DA0
		public override XPathNodeIterator Clone(); // 0x00000001819C1700-0x00000001819C1760
		private static string Rtf(object o); // 0x00000001819C1A50-0x00000001819C1B30
	}
}
