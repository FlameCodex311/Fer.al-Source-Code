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
	internal class Variable : AstNode // TypeDefIndex: 1982
	{
		// Fields
		private string localname; // 0x10
		private string prefix; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x000000018069B0C0-0x000000018069B0D0 
		public override XPathResultType ReturnType { get; } // 0x000000018040D640-0x000000018040D650 
		public string Localname { get; } // 0x0000000180372440-0x0000000180372450 
		public string Prefix { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Constructors
		public Variable(string name, string prefix); // 0x0000000180372010-0x00000001803720F0
	}
}
