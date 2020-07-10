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
	internal class Operand : AstNode // TypeDefIndex: 1859
	{
		// Fields
		private XPathResultType type; // 0x10
		private object val; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override XPathResultType ReturnType { get; } // 0x000000018036CFF0-0x000000018036D000 
		public object OperandValue { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		public Operand(string val); // 0x0000000180C8F020-0x0000000180C8F050
		public Operand(double val); // 0x0000000180C8F050-0x0000000180C8F0C0
	}
}
