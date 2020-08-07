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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public class JsonWriter // TypeDefIndex: 16083
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
		public int IndentValue { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x0000000180C536F0-0x0000000180C53710
		public bool PrettyPrint { get; set; } // 0x0000000180455BA0-0x0000000180455BB0 0x0000000180455C20-0x0000000180455C30
		public TextWriter TextWriter { get; } // 0x00000001803743E0-0x00000001803743F0 
		public bool Validate { get; set; } // 0x000000018053DFB0-0x000000018053DFC0 0x0000000180A2FC00-0x0000000180A2FC10
		public bool LowerCaseProperties { get; set; } // 0x0000000180A2FB20-0x0000000180A2FB30 0x0000000180B93050-0x0000000180B93060
	
		// Constructors
		static JsonWriter(); // 0x0000000180C534C0-0x0000000180C53500
		public JsonWriter(); // 0x0000000180C53500-0x0000000180C53590
		public JsonWriter(StringBuilder sb); // 0x0000000180C53590-0x0000000180C53660
		public JsonWriter(TextWriter writer); // 0x0000000180C53660-0x0000000180C536F0
	
		// Methods
		private void DoValidation(Condition cond); // 0x0000000180C51720-0x0000000180C51A00
		private void Init(); // 0x0000000180C51A10-0x0000000180C51AD0
		private static void IntToHex(int n, char[] hex); // 0x0000000180C51AD0-0x0000000180C51B60
		private void Indent(); // 0x0000000180C51A00-0x0000000180C51A10
		private void Put(string str); // 0x0000000180C52030-0x0000000180C520D0
		private void PutNewline(); // 0x0000000180C51B60-0x0000000180C51B70
		private void PutNewline(bool add_comma); // 0x0000000180C51B70-0x0000000180C51C20
		private void PutString(string str); // 0x0000000180C51C20-0x0000000180C52030
		private void Unindent(); // 0x0000000180C521F0-0x0000000180C52200
		public override string ToString(); // 0x0000000180C52190-0x0000000180C521F0
		public void Reset(); // 0x0000000180C520D0-0x0000000180C52190
		public void Write(bool boolean); // 0x0000000180C52D40-0x0000000180C52EC0
		public void Write(decimal number); // 0x0000000180C530A0-0x0000000180C53280
		public void Write(double number); // 0x0000000180C53280-0x0000000180C534C0
		public void Write(int number); // 0x0000000180C52B60-0x0000000180C52D40
		public void Write(long number); // 0x0000000180C52980-0x0000000180C52B60
		public void Write(string str); // 0x0000000180C52800-0x0000000180C52980
		public void Write(ulong number); // 0x0000000180C52EC0-0x0000000180C530A0
		public void WriteArrayEnd(); // 0x0000000180C52200-0x0000000180C52310
		public void WriteArrayStart(); // 0x0000000180C52310-0x0000000180C523D0
		public void WriteObjectEnd(); // 0x0000000180C523D0-0x0000000180C524E0
		public void WriteObjectStart(); // 0x0000000180C524E0-0x0000000180C525A0
		public void WritePropertyName(string property_name); // 0x0000000180C525A0-0x0000000180C52800
	}
}
