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
	internal class Filter : AstNode // TypeDefIndex: 1944
	{
		// Fields
		private AstNode input; // 0x10
		private AstNode condition; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x0000000180411150-0x0000000180411160 
		public override XPathResultType ReturnType { get; } // 0x000000018043E010-0x000000018043E020 
		public AstNode Input { get; } // 0x0000000180372440-0x0000000180372450 
		public AstNode Condition { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Constructors
		public Filter(AstNode input, AstNode condition); // 0x0000000180372010-0x00000001803720F0
	}
}
