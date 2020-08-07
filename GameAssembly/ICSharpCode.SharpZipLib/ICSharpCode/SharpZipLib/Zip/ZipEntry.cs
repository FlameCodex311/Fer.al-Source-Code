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
	public class ZipEntry : ICloneable // TypeDefIndex: 7721
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
		public bool IsCrypted { get; } // 0x0000000181EAC820-0x0000000181EAC830 
		internal byte CryptoCheckValue { get; set; } // 0x0000000180B929C0-0x0000000180B929D0 0x0000000180B92D60-0x0000000180B92D70
		public int Flags { get; set; } // 0x0000000180693DB0-0x0000000180693DC0 0x0000000180693DC0-0x0000000180693DD0
		public long ZipFileIndex { get; set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public long Offset { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		public int ExternalFileAttributes { get; set; } // 0x0000000181EAC810-0x0000000181EAC820 0x0000000181EACCF0-0x0000000181EACD00
		public int HostSystem { get; } // 0x0000000180690340-0x0000000180690350 
		public int Version { get; } // 0x0000000181EAC9C0-0x0000000181EACAD0 
		public bool LocalHeaderRequiresZip64 { get; } // 0x0000000181EAC940-0x0000000181EAC9A0 
		public bool CentralHeaderRequiresZip64 { get; } // 0x0000000181EAC770-0x0000000181EAC7D0 
		public long DosTime { set; } // 0x0000000181EACCE0-0x0000000181EACCF0
		public DateTime DateTime { set; } // 0x0000000181EACBE0-0x0000000181EACCE0
		public string Name { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public long Size { get; set; } // 0x0000000181EAC9A0-0x0000000181EAC9C0 0x0000000181EACDC0-0x0000000181EACDD0
		public long CompressedSize { get; set; } // 0x0000000181EAC7D0-0x0000000181EAC7F0 0x0000000181EACB50-0x0000000181EACB60
		public long Crc { get; set; } // 0x0000000181EAC7F0-0x0000000181EAC810 0x0000000181EACB60-0x0000000181EACBE0
		public CompressionMethod CompressionMethod { get; } // 0x00000001804ADA70-0x00000001804ADA80 
		public byte[] ExtraData { set; } // 0x0000000181EACD00-0x0000000181EACDC0
		public int AESKeySize { get; } // 0x0000000181EAC680-0x0000000181EAC750 
		internal int AESSaltLen { get; } // 0x0000000181EAC750-0x0000000181EAC770 
		public string Comment { set; } // 0x0000000181EACAD0-0x0000000181EACB50
		public bool IsDirectory { get; } // 0x0000000181EAC830-0x0000000181EAC8F0 
		public bool IsFile { get; } // 0x0000000181EAC8F0-0x0000000181EAC940 
	
		// Nested types
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		private enum Known : byte // TypeDefIndex: 7722
		{
			None = 0,
			Size = 1,
			CompressedSize = 2,
			Crc = 4,
			Time = 8,
			ExternalAttributes = 16
		}
	
		// Constructors
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method); // 0x0000000181EAC510-0x0000000181EAC680
	
		// Methods
		private bool HasDosAttributes(int attributes); // 0x0000000181EABDC0-0x0000000181EABDF0
		internal void ProcessExtraData(bool localHeader); // 0x0000000181EABF70-0x0000000181EAC510
		private void ProcessAESExtraData(ZipExtraData extraData); // 0x0000000181EABE20-0x0000000181EABF70
		public bool IsCompressionMethodSupported(); // 0x0000000181EABE00-0x0000000181EABE20
		public object Clone(); // 0x0000000181EABCD0-0x0000000181EABDC0
		public override string ToString(); // 0x0000000180374AF0-0x0000000180374B00
		public static bool IsCompressionMethodSupported(CompressionMethod method); // 0x0000000181EABDF0-0x0000000181EABE00
	}
}
