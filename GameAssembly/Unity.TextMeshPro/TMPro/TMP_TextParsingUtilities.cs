/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class TMP_TextParsingUtilities // TypeDefIndex: 8870
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x00743793
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x00743817
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x00000001818819F0-0x0000000181881A50 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x0000000181881990-0x00000001818819F0
		public TMP_TextParsingUtilities(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static uint GetHashCode(string s); // 0x0000000181881720-0x00000001818817D0
		public static int GetHashCodeCaseSensitive(string s); // 0x00000001818816C0-0x0000000181881720
		public static char ToLowerASCIIFast(char c); // 0x0000000181881870-0x00000001818818D0
		public static char ToUpperASCIIFast(char c); // 0x00000001818818D0-0x0000000181881930
		public static uint ToUpperASCIIFast(uint c); // 0x0000000181881930-0x0000000181881990
		public static uint ToLowerASCIIFast(uint c); // 0x0000000181881810-0x0000000181881870
		public static bool IsHighSurrogate(uint c); // 0x00000001818817D0-0x00000001818817F0
		public static bool IsLowSurrogate(uint c); // 0x00000001818817F0-0x0000000181881810
	}
}
