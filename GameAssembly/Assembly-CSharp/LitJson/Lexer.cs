/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	internal class Lexer // TypeDefIndex: 15430
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
		public bool AllowComments { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public bool AllowSingleQuotedStrings { get; set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
		public bool EndOfInput { get; } // 0x000000018036CB60-0x000000018036CB70 
		public int Token { get; } // 0x0000000180384C10-0x0000000180384C20 
		public string StringValue { get; } // 0x0000000180369B30-0x0000000180369B40 
	
		// Nested types
		private delegate bool StateHandler(FsmContext ctx); // TypeDefIndex: 15431; 0x00000001811F07B0-0x00000001811F0BA0
	
		// Constructors
		static Lexer(); // 0x00000001811E52A0-0x00000001811E52E0
		public Lexer(TextReader reader); // 0x00000001811E52E0-0x00000001811E53A0
	
		// Methods
		private static int HexValue(int digit); // 0x00000001811E21D0-0x00000001811E2270
		private static void PopulateFsmTables(out StateHandler[] fsm_handler_table, out int[] fsm_return_table); // 0x00000001811E2510-0x00000001811E3250
		private static char ProcessEscChar(int esc_char); // 0x00000001811E3250-0x00000001811E3320
		private static bool State1(FsmContext ctx); // 0x00000001811E3970-0x00000001811E3CE0
		private static bool State2(FsmContext ctx); // 0x00000001811E4710-0x00000001811E4850
		private static bool State3(FsmContext ctx); // 0x00000001811E4850-0x00000001811E4AA0
		private static bool State4(FsmContext ctx); // 0x00000001811E4AA0-0x00000001811E4C50
		private static bool State5(FsmContext ctx); // 0x00000001811E4C50-0x00000001811E4D40
		private static bool State6(FsmContext ctx); // 0x00000001811E4D40-0x00000001811E4F30
		private static bool State7(FsmContext ctx); // 0x00000001811E4F30-0x00000001811E5050
		private static bool State8(FsmContext ctx); // 0x00000001811E5050-0x00000001811E51F0
		private static bool State9(FsmContext ctx); // 0x00000001811E51F0-0x00000001811E5290
		private static bool State10(FsmContext ctx); // 0x00000001811E3320-0x00000001811E33C0
		private static bool State11(FsmContext ctx); // 0x00000001811E33C0-0x00000001811E3470
		private static bool State12(FsmContext ctx); // 0x00000001811E3470-0x00000001811E3510
		private static bool State13(FsmContext ctx); // 0x00000001811E3510-0x00000001811E35B0
		private static bool State14(FsmContext ctx); // 0x00000001811E35B0-0x00000001811E3650
		private static bool State15(FsmContext ctx); // 0x00000001811E33C0-0x00000001811E3470
		private static bool State16(FsmContext ctx); // 0x00000001811E3650-0x00000001811E36F0
		private static bool State17(FsmContext ctx); // 0x00000001811E36F0-0x00000001811E3790
		private static bool State18(FsmContext ctx); // 0x00000001811E3790-0x00000001811E3840
		private static bool State19(FsmContext ctx); // 0x00000001811E3840-0x00000001811E3970
		private static bool State20(FsmContext ctx); // 0x00000001811E3CE0-0x00000001811E3D90
		private static bool State21(FsmContext ctx); // 0x00000001811E3D90-0x00000001811E3FC0
		private static bool State22(FsmContext ctx); // 0x00000001811E3FC0-0x00000001811E4210
		private static bool State23(FsmContext ctx); // 0x00000001811E4210-0x00000001811E4340
		private static bool State24(FsmContext ctx); // 0x00000001811E4340-0x00000001811E4400
		private static bool State25(FsmContext ctx); // 0x00000001811E4400-0x00000001811E44C0
		private static bool State26(FsmContext ctx); // 0x00000001811E44C0-0x00000001811E4570
		private static bool State27(FsmContext ctx); // 0x00000001811E4570-0x00000001811E4620
		private static bool State28(FsmContext ctx); // 0x00000001811E4620-0x00000001811E4710
		private bool GetChar(); // 0x00000001811E2170-0x00000001811E21D0
		private int NextChar(); // 0x00000001811E2270-0x00000001811E22B0
		public bool NextToken(); // 0x00000001811E22B0-0x00000001811E2510
		private void UngetChar(); // 0x00000001811E5290-0x00000001811E52A0
	}
}
