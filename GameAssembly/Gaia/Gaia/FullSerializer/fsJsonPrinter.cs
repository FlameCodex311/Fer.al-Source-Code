/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 9126
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x00000001818F8330-0x00000001818F83B0
		private static string EscapeString(string str); // 0x00000001818F7F50-0x00000001818F8330
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x00000001818F6F70-0x00000001818F74F0
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x00000001818F74F0-0x00000001818F7CB0
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x00000001818F83B0-0x00000001818F83C0
		public static string PrettyJson(fsData data); // 0x00000001818F83C0-0x00000001818F8500
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x00000001818F7DE0-0x00000001818F7DF0
		public static string CompressedJson(fsData data); // 0x00000001818F7CB0-0x00000001818F7DE0
		private static string ConvertDoubleToString(double d); // 0x00000001818F7DF0-0x00000001818F7F50
	}
}
