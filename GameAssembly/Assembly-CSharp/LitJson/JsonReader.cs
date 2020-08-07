/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public class JsonReader // TypeDefIndex: 16080
	{
		// Fields
		private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table; // 0x00
		private Stack<int> automaton_stack; // 0x10
		private int current_input; // 0x18
		private int current_symbol; // 0x1C
		private bool end_of_json; // 0x20
		private bool end_of_input; // 0x21
		private Lexer lexer; // 0x28
		private bool parser_in_string; // 0x30
		private bool parser_return; // 0x31
		private bool read_started; // 0x32
		private TextReader reader; // 0x38
		private bool reader_is_owned; // 0x40
		private bool skip_non_members; // 0x41
		private object token_value; // 0x48
		private JsonToken token; // 0x50
	
		// Properties
		public bool AllowComments { get; set; } // 0x0000000180C516A0-0x0000000180C516C0 0x0000000180C516E0-0x0000000180C51700
		public bool AllowSingleQuotedStrings { get; set; } // 0x0000000180C516C0-0x0000000180C516E0 0x0000000180C51700-0x0000000180C51720
		public bool SkipNonMembers { get; set; } // 0x000000018053DFB0-0x000000018053DFC0 0x0000000180A2FC00-0x0000000180A2FC10
		public bool EndOfInput { get; } // 0x00000001804F2E80-0x00000001804F2E90 
		public bool EndOfJson { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public JsonToken Token { get; } // 0x00000001803F8270-0x00000001803F8280 
		public object Value { get; } // 0x00000001803743E0-0x00000001803743F0 
	
		// Constructors
		static JsonReader(); // 0x0000000180C51410-0x0000000180C51450
		public JsonReader(string json_text); // 0x0000000180C51630-0x0000000180C516A0
		public JsonReader(TextReader reader); // 0x0000000180C51620-0x0000000180C51630
		private JsonReader(TextReader reader, bool owned); // 0x0000000180C51450-0x0000000180C51620
	
		// Methods
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable(); // 0x0000000180C4FBB0-0x0000000180C50840
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ int[] symbols); // 0x0000000180C51280-0x0000000180C51380
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule); // 0x0000000180C51380-0x0000000180C51410
		private void ProcessNumber(string number); // 0x0000000180C50840-0x0000000180C50AF0
		private void ProcessSymbol(); // 0x0000000180C50AF0-0x0000000180C50CB0
		private bool ReadToken(); // 0x0000000180C50CB0-0x0000000180C50D20
		public void Close(); // 0x0000000180C4FAF0-0x0000000180C4FBB0
		public bool Read(); // 0x0000000180C50D20-0x0000000180C51280
	}
}
