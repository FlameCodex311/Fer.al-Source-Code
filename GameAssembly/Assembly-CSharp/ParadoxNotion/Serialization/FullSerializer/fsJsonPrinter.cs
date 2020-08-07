/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 15916
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x00000001811B3F50-0x00000001811B3FC0
		private static string EscapeString(string str); // 0x00000001811B3B90-0x00000001811B3F50
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x00000001811B2C40-0x00000001811B3160
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x00000001811B3160-0x00000001811B38C0
		public static string ToJson(fsData data, bool pretty); // 0x00000001811B4100-0x00000001811B4120
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x00000001811B40F0-0x00000001811B4100
		public static string PrettyJson(fsData data); // 0x00000001811B3FC0-0x00000001811B40F0
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x00000001811B38C0-0x00000001811B38D0
		public static string CompressedJson(fsData data); // 0x00000001811B38D0-0x00000001811B3A00
		private static string ConvertDoubleToString(double d); // 0x00000001811B3A00-0x00000001811B3B90
	}
}
