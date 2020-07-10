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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal class Operator : AstNode // TypeDefIndex: 1861
	{
		// Fields
		private static Op[] invertOp; // 0x00
		private Op opType; // 0x10
		private AstNode opnd1; // 0x18
		private AstNode opnd2; // 0x20
	
		// Properties
		public override AstType Type { get; } // 0x000000018042E670-0x000000018042E680 
		public override XPathResultType ReturnType { get; } // 0x0000000180C8F200-0x0000000180C8F220 
		public Op OperatorType { get; } // 0x000000018036CFF0-0x000000018036D000 
		public AstNode Operand1 { get; } // 0x000000018038B150-0x000000018038B160 
		public AstNode Operand2 { get; } // 0x000000018036AC70-0x000000018036AC80 
	
		// Nested types
		public enum Op // TypeDefIndex: 1862
		{
			INVALID = 0,
			OR = 1,
			AND = 2,
			EQ = 3,
			NE = 4,
			LT = 5,
			LE = 6,
			GT = 7,
			GE = 8,
			PLUS = 9,
			MINUS = 10,
			MUL = 11,
			DIV = 12,
			MOD = 13,
			UNION = 14
		}
	
		// Constructors
		public Operator(Op op, AstNode opnd1, AstNode opnd2); // 0x0000000180C8F1B0-0x0000000180C8F200
		static Operator(); // 0x0000000180C8F150-0x0000000180C8F1B0
	
		// Methods
		public static Op InvertOperator(Op op); // 0x0000000180C8F0C0-0x0000000180C8F150
	}
}
