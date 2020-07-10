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
	internal class Filter : AstNode // TypeDefIndex: 1839
	{
		// Fields
		private AstNode input; // 0x10
		private AstNode condition; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x0000000180362180-0x0000000180362190 
		public override XPathResultType ReturnType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public AstNode Input { get; } // 0x000000018036AC80-0x000000018036AC90 
		public AstNode Condition { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		public Filter(AstNode input, AstNode condition); // 0x00000001803DA900-0x00000001803DA940
	}
}
