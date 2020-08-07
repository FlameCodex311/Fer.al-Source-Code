/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class Serializer // TypeDefIndex: 16212
	{
		// Fields
		private static string k_Indent; // 0x00
	
		// Constructors
		public Serializer(); // 0x0000000180373240-0x0000000180373250
		static Serializer(); // 0x00000001814D0E30-0x00000001814D0E70
	
		// Methods
		public static PBXElementDict ParseTreeAST(TreeAST ast, TokenList tokens, string text); // 0x00000001814CFC70-0x00000001814CFE80
		public static PBXElementArray ParseArrayAST(ArrayAST ast, TokenList tokens, string text); // 0x00000001814CF820-0x00000001814CF9F0
		public static PBXElement ParseValueAST(ValueAST ast, TokenList tokens, string text); // 0x00000001814CFE80-0x00000001814D0110
		public static PBXElementString ParseIdentifierAST(IdentifierAST ast, TokenList tokens, string text); // 0x00000001814CF9F0-0x00000001814CFC70
		private static string GetIndent(int indent); // 0x00000001814CF7A0-0x00000001814CF820
		private static void WriteStringImpl(StringBuilder sb, string s, bool comment, GUIDToCommentMap comments); // 0x00000001814D0DD0-0x00000001814D0E30
		public static void WriteDictKeyValue(StringBuilder sb, string key, PBXElement value, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x00000001814D0610-0x00000001814D09E0
		public static void WriteDict(StringBuilder sb, PBXElementDict el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x00000001814D09E0-0x00000001814D0DD0
		public static void WriteArray(StringBuilder sb, PBXElementArray el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x00000001814D0110-0x00000001814D0610
	}
}
