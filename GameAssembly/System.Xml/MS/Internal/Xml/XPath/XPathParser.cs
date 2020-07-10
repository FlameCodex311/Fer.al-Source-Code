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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal class XPathParser // TypeDefIndex: 1885
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
		private class ParamInfo // TypeDefIndex: 1886
		{
			// Fields
			private Function.FunctionType ftype; // 0x10
			private int minargs; // 0x14
			private int maxargs; // 0x18
			private XPathResultType[] argTypes; // 0x20
	
			// Properties
			public Function.FunctionType FType { get; } // 0x000000018036CFF0-0x000000018036D000 
			public int Minargs { get; } // 0x0000000180372360-0x0000000180372370 
			public int Maxargs { get; } // 0x0000000180367710-0x0000000180367720 
			public XPathResultType[] ArgTypes { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Constructors
			internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes); // 0x00000001809A5610-0x00000001809A5660
		}
	
		// Constructors
		private XPathParser(XPathScanner scanner); // 0x000000018037D3F0-0x000000018037D420
		static XPathParser(); // 0x0000000180C9F6A0-0x0000000180C9F9C0
	
		// Methods
		public static AstNode ParseXPathExpresion(string xpathExpresion); // 0x0000000180C9F530-0x0000000180C9F600
		private AstNode ParseExpresion(AstNode qyInput); // 0x0000000180C9D110-0x0000000180C9D2C0
		private AstNode ParseOrExpr(AstNode qyInput); // 0x0000000180C9E4B0-0x0000000180C9E610
		private AstNode ParseAndExpr(AstNode qyInput); // 0x0000000180C9CEB0-0x0000000180C9D010
		private AstNode ParseEqualityExpr(AstNode qyInput); // 0x0000000180C9D010-0x0000000180C9D110
		private AstNode ParseRelationalExpr(AstNode qyInput); // 0x0000000180C9EAF0-0x0000000180C9EC30
		private AstNode ParseAdditiveExpr(AstNode qyInput); // 0x0000000180C9CDB0-0x0000000180C9CEB0
		private AstNode ParseMultiplicativeExpr(AstNode qyInput); // 0x0000000180C9DF50-0x0000000180C9E150
		private AstNode ParseUnaryExpr(AstNode qyInput); // 0x0000000180C9F1D0-0x0000000180C9F310
		private AstNode ParseUnionExpr(AstNode qyInput); // 0x0000000180C9F310-0x0000000180C9F530
		private static bool IsNodeType(XPathScanner scaner); // 0x0000000180C9CC00-0x0000000180C9CCC0
		private AstNode ParsePathExpr(AstNode qyInput); // 0x0000000180C9E610-0x0000000180C9E7A0
		private AstNode ParseFilterExpr(AstNode qyInput); // 0x0000000180C9D2C0-0x0000000180C9D530
		private AstNode ParsePredicate(AstNode qyInput); // 0x0000000180C9E7A0-0x0000000180C9E850
		private AstNode ParseLocationPath(AstNode qyInput); // 0x0000000180C9D530-0x0000000180C9D6B0
		private AstNode ParseRelativeLocationPath(AstNode qyInput); // 0x0000000180C9EC30-0x0000000180C9ED20
		private static bool IsStep(XPathScanner.LexKind lexKind); // 0x0000000180C9CD60-0x0000000180C9CD90
		private AstNode ParseStep(AstNode qyInput); // 0x0000000180C9ED20-0x0000000180C9F1D0
		private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType); // 0x0000000180C9E150-0x0000000180C9E4B0
		private static bool IsPrimaryExpr(XPathScanner scanner); // 0x0000000180C9CCC0-0x0000000180C9CD60
		private AstNode ParsePrimaryExpr(AstNode qyInput); // 0x0000000180C9E850-0x0000000180C9EAF0
		private AstNode ParseMethod(AstNode qyInput); // 0x0000000180C9D6B0-0x0000000180C9DF50
		private void CheckToken(XPathScanner.LexKind t); // 0x0000000180C9BCF0-0x0000000180C9BD80
		private void PassToken(XPathScanner.LexKind t); // 0x0000000180C9F600-0x0000000180C9F630
		private void NextLex(); // 0x0000000180C9CD90-0x0000000180C9CDB0
		private bool TestOp(string op); // 0x0000000180C9F630-0x0000000180C9F6A0
		private void CheckNodeSet(XPathResultType t); // 0x0000000180C9BC60-0x0000000180C9BCF0
		private static Hashtable CreateFunctionTable(); // 0x0000000180C9C0A0-0x0000000180C9CAF0
		private static Hashtable CreateAxesTable(); // 0x0000000180C9BD80-0x0000000180C9C0A0
		private Axis.AxisType GetAxis(XPathScanner scaner); // 0x0000000180C9CAF0-0x0000000180C9CC00
	}
}
