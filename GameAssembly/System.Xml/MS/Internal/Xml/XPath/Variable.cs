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
	internal class Variable : AstNode // TypeDefIndex: 1877
	{
		// Fields
		private string localname; // 0x10
		private string prefix; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x00000001806A5520-0x00000001806A5530 
		public override XPathResultType ReturnType { get; } // 0x000000018035E180-0x000000018035E190 
		public string Localname { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string Prefix { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		public Variable(string name, string prefix); // 0x00000001803DA900-0x00000001803DA940
	}
}
