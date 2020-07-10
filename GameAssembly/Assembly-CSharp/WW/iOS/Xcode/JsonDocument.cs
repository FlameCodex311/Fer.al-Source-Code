/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal class JsonDocument // TypeDefIndex: 15749
	{
		// Fields
		public JsonElementDict root; // 0x10
		public string indentString; // 0x18
	
		// Constructors
		public JsonDocument(); // 0x0000000181678B20-0x0000000181678BD0
	
		// Methods
		private void AppendIndent(StringBuilder sb, int indent); // 0x0000000181677DD0-0x0000000181677E30
		private void WriteString(StringBuilder sb, string str); // 0x00000001816789C0-0x0000000181678A20
		private void WriteBoolean(StringBuilder sb, bool value); // 0x0000000181678330-0x0000000181678390
		private void WriteInteger(StringBuilder sb, int value); // 0x0000000181678980-0x00000001816789C0
		private void WriteDictKeyValue(StringBuilder sb, string key, JsonElement value, int indent); // 0x0000000181678390-0x00000001816786B0
		private void WriteDict(StringBuilder sb, JsonElementDict el, int indent); // 0x00000001816786B0-0x0000000181678980
		private void WriteArray(StringBuilder sb, JsonElementArray el, int indent); // 0x0000000181677E30-0x0000000181678330
		public void WriteToFile(string path); // 0x0000000181678A20-0x0000000181678A50
		public void WriteToStream(TextWriter tw); // 0x0000000181678A50-0x0000000181678A90
		public string WriteToString(); // 0x0000000181678A90-0x0000000181678B20
	}
}
