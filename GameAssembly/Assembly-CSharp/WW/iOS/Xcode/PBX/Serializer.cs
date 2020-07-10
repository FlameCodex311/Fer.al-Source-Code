/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class Serializer // TypeDefIndex: 15832
	{
		// Fields
		private static string k_Indent; // 0x00
	
		// Constructors
		public Serializer(); // 0x000000018036B6C0-0x000000018036B6D0
		static Serializer(); // 0x000000018169D170-0x000000018169D1B0
	
		// Methods
		public static PBXElementDict ParseTreeAST(TreeAST ast, TokenList tokens, string text); // 0x000000018169BC80-0x000000018169BED0
		public static PBXElementArray ParseArrayAST(ArrayAST ast, TokenList tokens, string text); // 0x000000018169B910-0x000000018169BB30
		public static PBXElement ParseValueAST(ValueAST ast, TokenList tokens, string text); // 0x000000018169BED0-0x000000018169C160
		public static PBXElementString ParseIdentifierAST(IdentifierAST ast, TokenList tokens, string text); // 0x000000018169BB30-0x000000018169BC80
		private static string GetIndent(int indent); // 0x000000018169B890-0x000000018169B910
		private static void WriteStringImpl(StringBuilder sb, string s, bool comment, GUIDToCommentMap comments); // 0x000000018169D040-0x000000018169D170
		public static void WriteDictKeyValue(StringBuilder sb, string key, PBXElement value, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x000000018169C640-0x000000018169CC10
		public static void WriteDict(StringBuilder sb, PBXElementDict el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x000000018169CC10-0x000000018169D040
		public static void WriteArray(StringBuilder sb, PBXElementArray el, int indent, bool compact, PropertyCommentChecker checker, GUIDToCommentMap comments); // 0x000000018169C160-0x000000018169C640
	}
}
