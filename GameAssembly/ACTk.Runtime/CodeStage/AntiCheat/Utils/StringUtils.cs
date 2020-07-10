/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Utils
{
	internal static class StringUtils // TypeDefIndex: 7168
	{
		// Fields
		private static readonly char[] HexArray; // 0x00
	
		// Constructors
		static StringUtils(); // 0x000000018229EB40-0x000000018229EBA0
	
		// Methods
		public static byte[] CharsToBytes(char[] input); // 0x000000018229E8E0-0x000000018229E920
		public static byte[] StringToBytes(string input); // 0x000000018229EB00-0x000000018229EB40
		public static char[] BytesToChars(byte[] input); // 0x000000018229E800-0x000000018229E840
		public static string BytesToString(byte[] input); // 0x000000018229E8A0-0x000000018229E8E0
		public static string BytesToString(byte[] input, int index, int count); // 0x000000018229E840-0x000000018229E8A0
		public static string HashBytesToHexString(byte[] input); // 0x000000018229E920-0x000000018229EB00
	}
}
