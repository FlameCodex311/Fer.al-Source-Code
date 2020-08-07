/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Utils
{
	internal static class StringUtils // TypeDefIndex: 7334
	{
		// Fields
		private static readonly char[] HexArray; // 0x00
	
		// Constructors
		static StringUtils(); // 0x000000018200A0B0-0x000000018200A110
	
		// Methods
		public static byte[] CharsToBytes(char[] input); // 0x0000000182009E70-0x0000000182009EB0
		public static byte[] StringToBytes(string input); // 0x000000018200A070-0x000000018200A0B0
		public static char[] BytesToChars(byte[] input); // 0x0000000182009D90-0x0000000182009DD0
		public static string BytesToString(byte[] input); // 0x0000000182009E30-0x0000000182009E70
		public static string BytesToString(byte[] input, int index, int count); // 0x0000000182009DD0-0x0000000182009E30
		public static string HashBytesToHexString(byte[] input); // 0x0000000182009EB0-0x000000018200A070
	}
}
