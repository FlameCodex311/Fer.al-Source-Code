/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal class XPathParser // TypeDefIndex: 1990
	{
		// Fields
		private XPathScanner scanner; // 0x10
		private int parseDepth; // 0x18
		private static readonly XPathResultType[] temparray1; // 0x00
		private static readonly XPathResultType[] temparray2; // 0x08
		private static readonly XPathResultType[] temparray3; // 0x10
		private static readonly XPathResultType[] temparray4; // 0x18
		private static readonly XPathResultType[] temparray5; // 0x20
		private static readonly XPathResultType[] temparray6; // 0x28
		private static readonly XPathResultType[] temparray7; // 0x30
		private static readonly XPathResultType[] temparray8; // 0x38
		private static readonly XPathResultType[] temparray9; // 0x40
		private static Hashtable functionTable; // 0x48
		private static Hashtable AxesTable; // 0x50
	
		// Nested types
		private class ParamInfo // TypeDefIndex: 1991
		{
			// Fields
			private Function.FunctionType ftype; // 0x10
			private int minargs; // 0x14
			private int maxargs; // 0x18
			private XPathResultType[] argTypes; // 0x20
	
			// Properties
			public Function.FunctionType FType { get; } // 0x0000000180387590-0x0000000180387930 
			public int Minargs { get; } // 0x00000001803FD2F0-0x00000001803FD300 
			public int Maxargs { get; } // 0x00000001803F46B0-0x00000001803F46C0 
			public XPathResultType[] ArgTypes { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Constructors
			internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes); // 0x00000001813BA1C0-0x00000001813BA210
		}
	
		// Constructors
		private XPathParser(XPathScanner scanner); // 0x0000000180400150-0x0000000180400180
		static XPathParser(); // 0x00000001819D6CF0-0x00000001819D6FF0
	
		// Methods
		public static AstNode ParseXPathExpresion(string xpathExpresion); // 0x00000001819D6B90-0x00000001819D6C50
		private AstNode ParseExpresion(AstNode qyInput); // 0x00000001819D46D0-0x00000001819D4880
		private AstNode ParseOrExpr(AstNode qyInput); // 0x00000001819D5A10-0x00000001819D5B70
		private AstNode ParseAndExpr(AstNode qyInput); // 0x00000001819D4470-0x00000001819D45D0
		private AstNode ParseEqualityExpr(AstNode qyInput); // 0x00000001819D45D0-0x00000001819D46D0
		private AstNode ParseRelationalExpr(AstNode qyInput); // 0x00000001819D6180-0x00000001819D62C0
		private AstNode ParseAdditiveExpr(AstNode qyInput); // 0x00000001819D4370-0x00000001819D4470
		private AstNode ParseMultiplicativeExpr(AstNode qyInput); // 0x00000001819D54C0-0x00000001819D56C0
		private AstNode ParseUnaryExpr(AstNode qyInput); // 0x00000001819D6840-0x00000001819D6980
		private AstNode ParseUnionExpr(AstNode qyInput); // 0x00000001819D6980-0x00000001819D6B90
		private static bool IsNodeType(XPathScanner scaner); // 0x00000001819D41C0-0x00000001819D4280
		private AstNode ParsePathExpr(AstNode qyInput); // 0x00000001819D5B70-0x00000001819D5E40
		private AstNode ParseFilterExpr(AstNode qyInput); // 0x00000001819D4880-0x00000001819D4AE0
		private AstNode ParsePredicate(AstNode qyInput); // 0x00000001819D5E40-0x00000001819D5EF0
		private AstNode ParseLocationPath(AstNode qyInput); // 0x00000001819D4AE0-0x00000001819D4C50
		private AstNode ParseRelativeLocationPath(AstNode qyInput); // 0x00000001819D62C0-0x00000001819D63B0
		private static bool IsStep(XPathScanner.LexKind lexKind); // 0x00000001819D4320-0x00000001819D4350
		private AstNode ParseStep(AstNode qyInput); // 0x00000001819D63B0-0x00000001819D6840
		private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType); // 0x00000001819D56C0-0x00000001819D5A10
		private static bool IsPrimaryExpr(XPathScanner scanner); // 0x00000001819D4280-0x00000001819D4320
		private AstNode ParsePrimaryExpr(AstNode qyInput); // 0x00000001819D5EF0-0x00000001819D6180
		private AstNode ParseMethod(AstNode qyInput); // 0x00000001819D4C50-0x00000001819D54C0
		private void CheckToken(XPathScanner.LexKind t); // 0x00000001819D32B0-0x00000001819D3340
		private void PassToken(XPathScanner.LexKind t); // 0x00000001819D6C50-0x00000001819D6C80
		private void NextLex(); // 0x00000001819D4350-0x00000001819D4370
		private bool TestOp(string op); // 0x00000001819D6C80-0x00000001819D6CF0
		private void CheckNodeSet(XPathResultType t); // 0x00000001819D3230-0x00000001819D32B0
		private static Hashtable CreateFunctionTable(); // 0x00000001819D3660-0x00000001819D40B0
		private static Hashtable CreateAxesTable(); // 0x00000001819D3340-0x00000001819D3660
		private Axis.AxisType GetAxis(XPathScanner scaner); // 0x00000001819D40B0-0x00000001819D41C0
	}
}
