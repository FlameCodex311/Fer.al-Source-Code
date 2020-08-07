/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class XPathScanner // TypeDefIndex: 1992
	{
		// Fields
		private string xpathExpr; // 0x10
		private int xpathExprIndex; // 0x18
		private LexKind kind; // 0x1C
		private char currentChar; // 0x20
		private string name; // 0x28
		private string prefix; // 0x30
		private string stringValue; // 0x38
		private double numberValue; // 0x40
		private bool canBeFunction; // 0x48
		private XmlCharType xmlCharType; // 0x50
	
		// Properties
		public string SourceText { get; } // 0x0000000180372440-0x0000000180372450 
		private char CurerntChar { get; } // 0x00000001813BBCF0-0x00000001813BBD00 
		public LexKind Kind { get; } // 0x00000001803FB770-0x00000001803FB780 
		public string Name { get; } // 0x00000001803745B0-0x00000001803745C0 
		public string Prefix { get; } // 0x00000001803745C0-0x00000001803745D0 
		public string StringValue { get; } // 0x00000001803743D0-0x00000001803743E0 
		public double NumberValue { get; } // 0x00000001813BBD00-0x00000001813BBD10 
		public bool CanBeFunction { get; } // 0x00000001803C9D60-0x00000001803C9D70 
	
		// Nested types
		public enum LexKind // TypeDefIndex: 1993
		{
			Bang = 33,
			Quote = 34,
			Dollar = 36,
			Apos = 39,
			LParens = 40,
			RParens = 41,
			Star = 42,
			Plus = 43,
			Comma = 44,
			Minus = 45,
			Dot = 46,
			Slash = 47,
			Lt = 60,
			Eq = 61,
			Gt = 62,
			At = 64,
			And = 65,
			DotDot = 68,
			Eof = 69,
			Ge = 71,
			Le = 76,
			Ne = 78,
			Or = 79,
			SlashSlash = 83,
			LBracket = 91,
			RBracket = 93,
			Axe = 97,
			Number = 100,
			Name = 110,
			String = 115,
			Union = 124
		}
	
		// Constructors
		public XPathScanner(string xpathExpr); // 0x00000001813BBC20-0x00000001813BBCF0
	
		// Methods
		private bool NextChar(); // 0x00000001813BB000-0x00000001813BB060
		private void SkipSpace(); // 0x00000001813BBBB0-0x00000001813BBC20
		public bool NextLex(); // 0x00000001813BB060-0x00000001813BB6B0
		private double ScanNumber(); // 0x00000001813BB880-0x00000001813BBA40
		private double ScanFraction(); // 0x00000001813BB6B0-0x00000001813BB7B0
		private string ScanString(); // 0x00000001813BBA40-0x00000001813BBBB0
		private string ScanName(); // 0x00000001813BB7B0-0x00000001813BB880
	}
}
