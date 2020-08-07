/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class TMP_TextParsingUtilities // TypeDefIndex: 9032
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x00778459
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x007784DD
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x0000000180D39F90-0x0000000180D39FF0 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x0000000180D39F30-0x0000000180D39F90
		public TMP_TextParsingUtilities(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static uint GetHashCode(string s); // 0x0000000180D39CC0-0x0000000180D39D70
		public static int GetHashCodeCaseSensitive(string s); // 0x0000000180D39C60-0x0000000180D39CC0
		public static char ToLowerASCIIFast(char c); // 0x0000000180D39E10-0x0000000180D39E70
		public static char ToUpperASCIIFast(char c); // 0x0000000180D39E70-0x0000000180D39ED0
		public static uint ToUpperASCIIFast(uint c); // 0x0000000180D39ED0-0x0000000180D39F30
		public static uint ToLowerASCIIFast(uint c); // 0x0000000180D39DB0-0x0000000180D39E10
		public static bool IsHighSurrogate(uint c); // 0x0000000180D39D70-0x0000000180D39D90
		public static bool IsLowSurrogate(uint c); // 0x0000000180D39D90-0x0000000180D39DB0
	}
}
