/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public static class fsJsonPrinter // TypeDefIndex: 9298
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018151D360-0x000000018151D3D0
		private static string EscapeString(string str); // 0x000000018151CFA0-0x000000018151D360
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018151C010-0x000000018151C570
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018151C570-0x000000018151CD00
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x000000018151D3D0-0x000000018151D3E0
		public static string PrettyJson(fsData data); // 0x000000018151D3E0-0x000000018151D510
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x000000018151CE30-0x000000018151CE40
		public static string CompressedJson(fsData data); // 0x000000018151CD00-0x000000018151CE30
		private static string ConvertDoubleToString(double d); // 0x000000018151CE40-0x000000018151CFA0
	}
}
