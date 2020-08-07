/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class Lexer // TypeDefIndex: 16177
	{
		// Fields
		private string text; // 0x10
		private int pos; // 0x18
		private int length; // 0x1C
		private int line; // 0x20
	
		// Constructors
		public Lexer(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static TokenList Tokenize(string text); // 0x0000000180974380-0x00000001809744D0
		public void SetText(string text); // 0x0000000180974310-0x0000000180974380
		public TokenList ScanAll(); // 0x0000000180973720-0x00000001809737E0
		private void UpdateNewlineStats(char ch); // 0x00000001809744D0-0x00000001809744E0
		private void ScanOne(Token tok); // 0x0000000180973950-0x0000000180973F70
		private void ScanString(Token tok); // 0x00000001809741C0-0x0000000180974310
		private void ScanQuotedString(Token tok); // 0x00000001809740C0-0x00000001809741C0
		private void ScanMultilineComment(Token tok); // 0x0000000180973880-0x0000000180973950
		private void ScanComment(Token tok); // 0x00000001809737E0-0x0000000180973880
		private bool IsOperator(char ch); // 0x00000001809736F0-0x0000000180973720
		private void ScanOperator(Token tok); // 0x0000000180973FA0-0x00000001809740C0
		private void ScanOperatorSpecific(Token tok, TokenType type); // 0x0000000180973F70-0x0000000180973FA0
	}
}
