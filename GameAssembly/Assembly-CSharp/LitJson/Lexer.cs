/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	internal class Lexer // TypeDefIndex: 16085
	{
		// Fields
		private static readonly int[] fsm_return_table; // 0x00
		private static readonly StateHandler[] fsm_handler_table; // 0x08
		private bool allow_comments; // 0x10
		private bool allow_single_quoted_strings; // 0x11
		private bool end_of_input; // 0x12
		private FsmContext fsm_context; // 0x18
		private int input_buffer; // 0x20
		private int input_char; // 0x24
		private TextReader reader; // 0x28
		private int state; // 0x30
		private StringBuilder string_buffer; // 0x38
		private string string_value; // 0x40
		private int token; // 0x48
		private int unichar; // 0x4C
	
		// Properties
		public bool AllowComments { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		public bool AllowSingleQuotedStrings { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
		public bool EndOfInput { get; } // 0x000000018041B680-0x000000018041B690 
		public int Token { get; } // 0x0000000180379ED0-0x0000000180379EE0 
		public string StringValue { get; } // 0x00000001803C7290-0x00000001803C72A0 
	
		// Nested types
		private delegate bool StateHandler(FsmContext ctx); // TypeDefIndex: 16086; 0x0000000180C5A680-0x0000000180C5AAA0
	
		// Constructors
		static Lexer(); // 0x0000000180C56C00-0x0000000180C56C40
		public Lexer(TextReader reader); // 0x0000000180C56C40-0x0000000180C56D00
	
		// Methods
		private static int HexValue(int digit); // 0x0000000180C53CC0-0x0000000180C53D60
		private static void PopulateFsmTables(out StateHandler[] fsm_handler_table, out int[] fsm_return_table); // 0x0000000180C53FF0-0x0000000180C54C80
		private static char ProcessEscChar(int esc_char); // 0x0000000180C54C80-0x0000000180C54D50
		private static bool State1(FsmContext ctx); // 0x0000000180C55380-0x0000000180C556D0
		private static bool State2(FsmContext ctx); // 0x0000000180C560C0-0x0000000180C56200
		private static bool State3(FsmContext ctx); // 0x0000000180C56200-0x0000000180C56440
		private static bool State4(FsmContext ctx); // 0x0000000180C56440-0x0000000180C565E0
		private static bool State5(FsmContext ctx); // 0x0000000180C565E0-0x0000000180C566C0
		private static bool State6(FsmContext ctx); // 0x0000000180C566C0-0x0000000180C568A0
		private static bool State7(FsmContext ctx); // 0x0000000180C568A0-0x0000000180C569C0
		private static bool State8(FsmContext ctx); // 0x0000000180C569C0-0x0000000180C56B50
		private static bool State9(FsmContext ctx); // 0x0000000180C56B50-0x0000000180C56BF0
		private static bool State10(FsmContext ctx); // 0x0000000180C54D50-0x0000000180C54DF0
		private static bool State11(FsmContext ctx); // 0x0000000180C54DF0-0x0000000180C54E90
		private static bool State12(FsmContext ctx); // 0x0000000180C54E90-0x0000000180C54F30
		private static bool State13(FsmContext ctx); // 0x0000000180C54F30-0x0000000180C54FD0
		private static bool State14(FsmContext ctx); // 0x0000000180C54FD0-0x0000000180C55070
		private static bool State15(FsmContext ctx); // 0x0000000180C54DF0-0x0000000180C54E90
		private static bool State16(FsmContext ctx); // 0x0000000180C55070-0x0000000180C55110
		private static bool State17(FsmContext ctx); // 0x0000000180C55110-0x0000000180C551B0
		private static bool State18(FsmContext ctx); // 0x0000000180C551B0-0x0000000180C55250
		private static bool State19(FsmContext ctx); // 0x0000000180C55250-0x0000000180C55380
		private static bool State20(FsmContext ctx); // 0x0000000180C556D0-0x0000000180C55770
		private static bool State21(FsmContext ctx); // 0x0000000180C55770-0x0000000180C55990
		private static bool State22(FsmContext ctx); // 0x0000000180C55990-0x0000000180C55BD0
		private static bool State23(FsmContext ctx); // 0x0000000180C55BD0-0x0000000180C55D00
		private static bool State24(FsmContext ctx); // 0x0000000180C55D00-0x0000000180C55DC0
		private static bool State25(FsmContext ctx); // 0x0000000180C55DC0-0x0000000180C55E80
		private static bool State26(FsmContext ctx); // 0x0000000180C55E80-0x0000000180C55F30
		private static bool State27(FsmContext ctx); // 0x0000000180C55F30-0x0000000180C55FE0
		private static bool State28(FsmContext ctx); // 0x0000000180C55FE0-0x0000000180C560C0
		private bool GetChar(); // 0x0000000180C53C60-0x0000000180C53CC0
		private int NextChar(); // 0x0000000180C53D60-0x0000000180C53DA0
		public bool NextToken(); // 0x0000000180C53DA0-0x0000000180C53FF0
		private void UngetChar(); // 0x0000000180C56BF0-0x0000000180C56C00
	}
}
