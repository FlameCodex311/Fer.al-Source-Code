/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	public class JsonReader // TypeDefIndex: 15425
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
		public bool AllowComments { get; set; } // 0x00000001811E0100-0x00000001811E0120 0x00000001811E0140-0x00000001811E0160
		public bool AllowSingleQuotedStrings { get; set; } // 0x00000001811E0120-0x00000001811E0140 0x00000001811E0160-0x00000001811E0180
		public bool SkipNonMembers { get; set; } // 0x00000001804785A0-0x00000001804785B0 0x00000001805460C0-0x00000001805460D0
		public bool EndOfInput { get; } // 0x00000001803C19F0-0x00000001803C1A00 
		public bool EndOfJson { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public JsonToken Token { get; } // 0x0000000180369BA0-0x0000000180369BB0 
		public object Value { get; } // 0x0000000180369C40-0x0000000180369C50 
	
		// Constructors
		static JsonReader(); // 0x00000001811DFE70-0x00000001811DFEB0
		public JsonReader(string json_text); // 0x00000001811E0090-0x00000001811E0100
		public JsonReader(TextReader reader); // 0x00000001811E0080-0x00000001811E0090
		private JsonReader(TextReader reader, bool owned); // 0x00000001811DFEB0-0x00000001811E0080
	
		// Methods
		private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable(); // 0x00000001811DE890-0x00000001811DF240
		private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, params /* 0x00000001800B36B0-0x00000001800B36C0 */ int[] symbols); // 0x00000001811DFC90-0x00000001811DFD90
		private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule); // 0x00000001811DFD90-0x00000001811DFE70
		private void ProcessNumber(string number); // 0x00000001811DF240-0x00000001811DF4F0
		private void ProcessSymbol(); // 0x00000001811DF4F0-0x00000001811DF6B0
		private bool ReadToken(); // 0x00000001811DF6B0-0x00000001811DF720
		public void Close(); // 0x00000001811DE7D0-0x00000001811DE890
		public bool Read(); // 0x00000001811DF720-0x00000001811DFC90
	}
}
