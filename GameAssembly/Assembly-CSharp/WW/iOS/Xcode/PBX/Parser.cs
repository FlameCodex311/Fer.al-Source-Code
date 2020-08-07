/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class Parser // TypeDefIndex: 16207
	{
		// Fields
		private TokenList tokens; // 0x10
		private int currPos; // 0x18
	
		// Constructors
		public Parser(TokenList tokens); // 0x00000001814CCF20-0x00000001814CCF60
	
		// Methods
		private int SkipComments(int pos); // 0x00000001814CCDA0-0x00000001814CCE60
		private int IncInternal(int pos); // 0x00000001814CBFD0-0x00000001814CC040
		private int Inc(); // 0x00000001814CC040-0x00000001814CC0B0
		private TokenType Tok(); // 0x00000001814CCE90-0x00000001814CCF20
		private void SkipIf(TokenType type); // 0x00000001814CCE60-0x00000001814CCE90
		private string GetErrorMsg(); // 0x00000001814CBF30-0x00000001814CBFD0
		public IdentifierAST ParseIdentifier(); // 0x00000001814CC0B0-0x00000001814CC170
		public TreeAST ParseTree(); // 0x00000001814CC6D0-0x00000001814CCCD0
		public ArrayAST ParseList(); // 0x00000001814CC250-0x00000001814CC6D0
		public KeyValueAST ParseKeyValue(); // 0x00000001814CC170-0x00000001814CC250
		public ValueAST ParseValue(); // 0x00000001814CCCD0-0x00000001814CCDA0
	}
}
