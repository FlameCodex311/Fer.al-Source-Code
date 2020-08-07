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
	internal class Function : AstNode // TypeDefIndex: 1949
	{
		// Fields
		private FunctionType functionType; // 0x10
		private ArrayList argumentList; // 0x18
		private string name; // 0x20
		private string prefix; // 0x28
		internal static XPathResultType[] ReturnTypes; // 0x00
	
		// Properties
		public override AstType Type { get; } // 0x00000001806C4390-0x00000001806C43A0 
		public override XPathResultType ReturnType { get; } // 0x00000001819C0DF0-0x00000001819C0E80 
		public FunctionType TypeOfFunction { get; } // 0x0000000180387590-0x0000000180387930 
		public ArrayList ArgumentList { get; } // 0x0000000180372430-0x0000000180372440 
		public string Prefix { get; } // 0x00000001803745B0-0x00000001803745C0 
		public string Name { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
		// Nested types
		public enum FunctionType // TypeDefIndex: 1950
		{
			FuncLast = 0,
			FuncPosition = 1,
			FuncCount = 2,
			FuncID = 3,
			FuncLocalName = 4,
			FuncNameSpaceUri = 5,
			FuncName = 6,
			FuncString = 7,
			FuncBoolean = 8,
			FuncNumber = 9,
			FuncTrue = 10,
			FuncFalse = 11,
			FuncNot = 12,
			FuncConcat = 13,
			FuncStartsWith = 14,
			FuncContains = 15,
			FuncSubstringBefore = 16,
			FuncSubstringAfter = 17,
			FuncSubstring = 18,
			FuncStringLength = 19,
			FuncNormalize = 20,
			FuncTranslate = 21,
			FuncLang = 22,
			FuncSum = 23,
			FuncFloor = 24,
			FuncCeiling = 25,
			FuncRound = 26,
			FuncUserDefined = 27
		}
	
		// Constructors
		public Function(FunctionType ftype, ArrayList argumentList); // 0x00000001819C0C60-0x00000001819C0CD0
		public Function(string prefix, string name, ArrayList argumentList); // 0x00000001819C0D60-0x00000001819C0DF0
		public Function(FunctionType ftype, AstNode arg); // 0x00000001819C0CD0-0x00000001819C0D60
		static Function(); // 0x00000001819C0C00-0x00000001819C0C60
	}
}
