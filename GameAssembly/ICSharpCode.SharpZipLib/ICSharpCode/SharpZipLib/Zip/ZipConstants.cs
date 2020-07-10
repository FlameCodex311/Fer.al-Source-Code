/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip
{
	public sealed class ZipConstants // TypeDefIndex: 7554
	{
		// Fields
		private static int defaultCodePage; // 0x00
	
		// Properties
		public static int DefaultCodePage { get; set; } // 0x0000000180D64880-0x0000000180D648E0 0x0000000180D648E0-0x0000000180D64940
	
		// Constructors
		static ZipConstants(); // 0x0000000180D647E0-0x0000000180D64880
	
		// Methods
		public static string ConvertToString(byte[] data, int count); // 0x0000000180D646D0-0x0000000180D647E0
		public static string ConvertToString(byte[] data); // 0x0000000180D64650-0x0000000180D646D0
		public static string ConvertToStringExt(int flags, byte[] data, int count); // 0x0000000180D644A0-0x0000000180D64580
		public static string ConvertToStringExt(int flags, byte[] data); // 0x0000000180D64580-0x0000000180D64650
		public static byte[] ConvertToArray(string str); // 0x0000000180D643B0-0x0000000180D644A0
	}
}
