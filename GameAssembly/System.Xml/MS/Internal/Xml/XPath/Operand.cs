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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal class Operand : AstNode // TypeDefIndex: 1964
	{
		// Fields
		private XPathResultType type; // 0x10
		private object val; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x000000018043E010-0x000000018043E020 
		public override XPathResultType ReturnType { get; } // 0x0000000180387590-0x0000000180387930 
		public object OperandValue { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Constructors
		public Operand(string val); // 0x00000001819C6C00-0x00000001819C6C30
		public Operand(double val); // 0x00000001819C6C30-0x00000001819C6CA0
	}
}
