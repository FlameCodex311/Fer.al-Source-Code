/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip
{
	public sealed class ZipConstants // TypeDefIndex: 7720
	{
		// Fields
		private static int defaultCodePage; // 0x00
	
		// Properties
		public static int DefaultCodePage { get; set; } // 0x0000000181EABB10-0x0000000181EABB70 0x0000000181EABB70-0x0000000181EABBD0
	
		// Constructors
		static ZipConstants(); // 0x0000000181EABA80-0x0000000181EABB10
	
		// Methods
		public static string ConvertToString(byte[] data, int count); // 0x0000000181EAB970-0x0000000181EABA80
		public static string ConvertToString(byte[] data); // 0x0000000181EAB8F0-0x0000000181EAB970
		public static string ConvertToStringExt(int flags, byte[] data, int count); // 0x0000000181EAB740-0x0000000181EAB820
		public static string ConvertToStringExt(int flags, byte[] data); // 0x0000000181EAB820-0x0000000181EAB8F0
		public static byte[] ConvertToArray(string str); // 0x0000000181EAB650-0x0000000181EAB740
	}
}
