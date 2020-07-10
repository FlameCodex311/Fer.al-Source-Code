/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class Lexer // TypeDefIndex: 15797
	{
		// Fields
		private string text; // 0x10
		private int pos; // 0x18
		private int length; // 0x1C
		private int line; // 0x20
	
		// Constructors
		public Lexer(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static TokenList Tokenize(string text); // 0x000000018167A780-0x000000018167A910
		public void SetText(string text); // 0x000000018167A710-0x000000018167A780
		public TokenList ScanAll(); // 0x0000000181679AD0-0x0000000181679BC0
		private void UpdateNewlineStats(char ch); // 0x000000018167A910-0x000000018167A920
		private void ScanOne(Token tok); // 0x0000000181679D30-0x000000018167A360
		private void ScanString(Token tok); // 0x000000018167A5C0-0x000000018167A710
		private void ScanQuotedString(Token tok); // 0x000000018167A4C0-0x000000018167A5C0
		private void ScanMultilineComment(Token tok); // 0x0000000181679C60-0x0000000181679D30
		private void ScanComment(Token tok); // 0x0000000181679BC0-0x0000000181679C60
		private bool IsOperator(char ch); // 0x0000000181679AA0-0x0000000181679AD0
		private void ScanOperator(Token tok); // 0x000000018167A390-0x000000018167A4C0
		private void ScanOperatorSpecific(Token tok, TokenType type); // 0x000000018167A360-0x000000018167A390
	}
}
