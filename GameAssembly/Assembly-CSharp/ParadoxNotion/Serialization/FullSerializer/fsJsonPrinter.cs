/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 15311
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018117D6E0-0x000000018117D760
		private static string EscapeString(string str); // 0x000000018117D300-0x000000018117D6E0
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018117C360-0x000000018117C8A0
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018117C8A0-0x000000018117D030
		public static string ToJson(fsData data, bool pretty); // 0x000000018117D8B0-0x000000018117D8D0
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x000000018117D8A0-0x000000018117D8B0
		public static string PrettyJson(fsData data); // 0x000000018117D760-0x000000018117D8A0
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x000000018117D030-0x000000018117D040
		public static string CompressedJson(fsData data); // 0x000000018117D040-0x000000018117D170
		private static string ConvertDoubleToString(double d); // 0x000000018117D170-0x000000018117D300
	}
}
