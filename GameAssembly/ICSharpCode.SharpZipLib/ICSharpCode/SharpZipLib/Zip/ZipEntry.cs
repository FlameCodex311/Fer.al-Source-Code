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
	public class ZipEntry : ICloneable // TypeDefIndex: 7555
	{
		// Fields
		private Known known; // 0x10
		private int externalFileAttributes; // 0x14
		private ushort versionMadeBy; // 0x18
		private string name; // 0x20
		private ulong size; // 0x28
		private ulong compressedSize; // 0x30
		private ushort versionToExtract; // 0x38
		private uint crc; // 0x3C
		private uint dosTime; // 0x40
		private CompressionMethod method; // 0x44
		private byte[] extra; // 0x48
		private string comment; // 0x50
		private int flags; // 0x58
		private long zipFileIndex; // 0x60
		private long offset; // 0x68
		private bool forceZip64_; // 0x70
		private byte cryptoCheckValue_; // 0x71
		private int _aesVer; // 0x74
		private int _aesEncryptionStrength; // 0x78
	
		// Properties
		public bool IsCrypted { get; } // 0x0000000180D655B0-0x0000000180D655C0 
		internal byte CryptoCheckValue { get; set; } // 0x00000001805459C0-0x00000001805459D0 0x0000000180545DA0-0x0000000180545DB0
		public int Flags { get; set; } // 0x000000018049CAA0-0x000000018049CAB0 0x000000018049CAB0-0x000000018049CAC0
		public long ZipFileIndex { get; set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public long Offset { get; set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
		public int ExternalFileAttributes { get; set; } // 0x0000000180D655A0-0x0000000180D655B0 0x0000000180D65AA0-0x0000000180D65AB0
		public int HostSystem { get; } // 0x000000018048F440-0x000000018048F450 
		public int Version { get; } // 0x0000000180D65750-0x0000000180D65860 
		public bool LocalHeaderRequiresZip64 { get; } // 0x0000000180D656D0-0x0000000180D65730 
		public bool CentralHeaderRequiresZip64 { get; } // 0x0000000180D65500-0x0000000180D65560 
		public long DosTime { set; } // 0x0000000180D65A90-0x0000000180D65AA0
		public DateTime DateTime { set; } // 0x0000000180D65990-0x0000000180D65A90
		public string Name { get; } // 0x000000018036AC70-0x000000018036AC80 
		public long Size { get; set; } // 0x0000000180D65730-0x0000000180D65750 0x0000000180D65B70-0x0000000180D65B80
		public long CompressedSize { get; set; } // 0x0000000180D65560-0x0000000180D65580 0x0000000180D658F0-0x0000000180D65900
		public long Crc { get; set; } // 0x0000000180D65580-0x0000000180D655A0 0x0000000180D65900-0x0000000180D65990
		public CompressionMethod CompressionMethod { get; } // 0x0000000180478650-0x0000000180478660 
		public byte[] ExtraData { set; } // 0x0000000180D65AB0-0x0000000180D65B70
		public int AESKeySize { get; } // 0x0000000180D65410-0x0000000180D654E0 
		internal int AESSaltLen { get; } // 0x0000000180D654E0-0x0000000180D65500 
		public string Comment { set; } // 0x0000000180D65860-0x0000000180D658F0
		public bool IsDirectory { get; } // 0x0000000180D655C0-0x0000000180D65680 
		public bool IsFile { get; } // 0x0000000180D65680-0x0000000180D656D0 
	
		// Nested types
		[Flags] // 0x00000001800B36B0-0x00000001800B36C0
		private enum Known : byte // TypeDefIndex: 7556
		{
			None = 0,
			Size = 1,
			CompressedSize = 2,
			Crc = 4,
			Time = 8,
			ExternalAttributes = 16
		}
	
		// Constructors
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method); // 0x0000000180D65290-0x0000000180D65410
	
		// Methods
		private bool HasDosAttributes(int attributes); // 0x0000000180D64B30-0x0000000180D64B60
		internal void ProcessExtraData(bool localHeader); // 0x0000000180D64CE0-0x0000000180D65290
		private void ProcessAESExtraData(ZipExtraData extraData); // 0x0000000180D64B90-0x0000000180D64CE0
		public bool IsCompressionMethodSupported(); // 0x0000000180D64B70-0x0000000180D64B90
		public object Clone(); // 0x0000000180D64A40-0x0000000180D64B30
		public override string ToString(); // 0x000000018036AC70-0x000000018036AC80
		public static bool IsCompressionMethodSupported(CompressionMethod method); // 0x0000000180D64B60-0x0000000180D64B70
	}
}
