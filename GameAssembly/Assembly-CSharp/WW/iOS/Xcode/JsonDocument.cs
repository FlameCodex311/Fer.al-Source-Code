/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class JsonDocument // TypeDefIndex: 16129
	{
		// Fields
		public JsonElementDict root; // 0x10
		public string indentString; // 0x18
	
		// Constructors
		public JsonDocument(); // 0x0000000180972780-0x0000000180972830
	
		// Methods
		private void AppendIndent(StringBuilder sb, int indent); // 0x0000000180971A50-0x0000000180971AB0
		private void WriteString(StringBuilder sb, string str); // 0x0000000180972620-0x0000000180972680
		private void WriteBoolean(StringBuilder sb, bool value); // 0x0000000180971FA0-0x0000000180972000
		private void WriteInteger(StringBuilder sb, int value); // 0x00000001809725E0-0x0000000180972620
		private void WriteDictKeyValue(StringBuilder sb, string key, JsonElement value, int indent); // 0x0000000180972000-0x0000000180972320
		private void WriteDict(StringBuilder sb, JsonElementDict el, int indent); // 0x0000000180972320-0x00000001809725E0
		private void WriteArray(StringBuilder sb, JsonElementArray el, int indent); // 0x0000000180971AB0-0x0000000180971FA0
		public void WriteToFile(string path); // 0x0000000180972680-0x00000001809726B0
		public void WriteToStream(TextWriter tw); // 0x00000001809726B0-0x00000001809726F0
		public string WriteToString(); // 0x00000001809726F0-0x0000000180972780
	}
}
