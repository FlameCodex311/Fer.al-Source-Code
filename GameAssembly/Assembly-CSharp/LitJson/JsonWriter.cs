/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	public class JsonWriter // TypeDefIndex: 15428
	{
		// Fields
		private static readonly NumberFormatInfo number_format; // 0x00
		private WriterContext context; // 0x10
		private Stack<WriterContext> ctx_stack; // 0x18
		private bool has_reached_end; // 0x20
		private char[] hex_seq; // 0x28
		private int indentation; // 0x30
		private int indent_value; // 0x34
		private StringBuilder inst_string_builder; // 0x38
		private bool pretty_print; // 0x40
		private bool validate; // 0x41
		private bool lower_case_properties; // 0x42
		private TextWriter writer; // 0x48
	
		// Properties
		public int IndentValue { get; set; } // 0x000000018043E170-0x000000018043E180 0x00000001811E2150-0x00000001811E2170
		public bool PrettyPrint { get; set; } // 0x0000000180478660-0x0000000180478670 0x00000001807009C0-0x00000001807009D0
		public TextWriter TextWriter { get; } // 0x0000000180369C40-0x0000000180369C50 
		public bool Validate { get; set; } // 0x00000001804785A0-0x00000001804785B0 0x00000001805460C0-0x00000001805460D0
		public bool LowerCaseProperties { get; set; } // 0x00000001805460A0-0x00000001805460B0 0x00000001805460D0-0x00000001805460E0
	
		// Constructors
		static JsonWriter(); // 0x00000001811E1F20-0x00000001811E1F60
		public JsonWriter(); // 0x00000001811E1F60-0x00000001811E1FF0
		public JsonWriter(StringBuilder sb); // 0x00000001811E1FF0-0x00000001811E20C0
		public JsonWriter(TextWriter writer); // 0x00000001811E20C0-0x00000001811E2150
	
		// Methods
		private void DoValidation(Condition cond); // 0x00000001811E0180-0x00000001811E0480
		private void Init(); // 0x00000001811E0490-0x00000001811E0550
		private static void IntToHex(int n, char[] hex); // 0x00000001811E0550-0x00000001811E05F0
		private void Indent(); // 0x00000001811E0480-0x00000001811E0490
		private void Put(string str); // 0x00000001811E0AE0-0x00000001811E0B80
		private void PutNewline(); // 0x00000001811E05F0-0x00000001811E0600
		private void PutNewline(bool add_comma); // 0x00000001811E0600-0x00000001811E06C0
		private void PutString(string str); // 0x00000001811E06C0-0x00000001811E0AE0
		private void Unindent(); // 0x00000001811E0CA0-0x00000001811E0CB0
		public override string ToString(); // 0x00000001811E0C40-0x00000001811E0CA0
		public void Reset(); // 0x00000001811E0B80-0x00000001811E0C40
		public void Write(bool boolean); // 0x00000001811E1760-0x00000001811E18F0
		public void Write(decimal number); // 0x00000001811E1AE0-0x00000001811E1CD0
		public void Write(double number); // 0x00000001811E1CD0-0x00000001811E1F20
		public void Write(int number); // 0x00000001811E1570-0x00000001811E1760
		public void Write(long number); // 0x00000001811E1380-0x00000001811E1570
		public void Write(string str); // 0x00000001811E11F0-0x00000001811E1380
		public void Write(ulong number); // 0x00000001811E18F0-0x00000001811E1AE0
		public void WriteArrayEnd(); // 0x00000001811E0CB0-0x00000001811E0DD0
		public void WriteArrayStart(); // 0x00000001811E0DD0-0x00000001811E0E90
		public void WriteObjectEnd(); // 0x00000001811E0E90-0x00000001811E0FB0
		public void WriteObjectStart(); // 0x00000001811E0FB0-0x00000001811E1070
		public void WritePropertyName(string property_name); // 0x00000001811E1070-0x00000001811E11F0
	}
}
