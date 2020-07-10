/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class Parser // TypeDefIndex: 15827
	{
		// Fields
		private TokenList tokens; // 0x10
		private int currPos; // 0x18
	
		// Constructors
		public Parser(TokenList tokens); // 0x000000018169AE10-0x000000018169AE50
	
		// Methods
		private int SkipComments(int pos); // 0x000000018169AC90-0x000000018169AD50
		private int IncInternal(int pos); // 0x0000000181699E20-0x0000000181699E90
		private int Inc(); // 0x0000000181699E90-0x0000000181699F00
		private TokenType Tok(); // 0x000000018169AD80-0x000000018169AE10
		private void SkipIf(TokenType type); // 0x000000018169AD50-0x000000018169AD80
		private string GetErrorMsg(); // 0x0000000181699D80-0x0000000181699E20
		public IdentifierAST ParseIdentifier(); // 0x0000000181699F00-0x0000000181699FD0
		public TreeAST ParseTree(); // 0x000000018169A590-0x000000018169ABC0
		public ArrayAST ParseList(); // 0x000000018169A0C0-0x000000018169A590
		public KeyValueAST ParseKeyValue(); // 0x0000000181699FD0-0x000000018169A0C0
		public ValueAST ParseValue(); // 0x000000018169ABC0-0x000000018169AC90
	}
}
