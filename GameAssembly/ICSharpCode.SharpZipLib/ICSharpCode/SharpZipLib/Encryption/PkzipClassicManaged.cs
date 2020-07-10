/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Encryption
{
	public sealed class PkzipClassicManaged : PkzipClassic // TypeDefIndex: 7528
	{
		// Fields
		private byte[] key_; // 0x48
	
		// Properties
		public override int BlockSize { get; set; } // 0x000000018045B7B0-0x000000018045B7C0 0x0000000180D5DA60-0x0000000180D5DAD0
		public override KeySizes[] LegalKeySizes { get; } // 0x0000000180D5D990-0x0000000180D5DA60 
		public override KeySizes[] LegalBlockSizes { get; } // 0x0000000180D5D8C0-0x0000000180D5D990 
		public override byte[] Key { get; set; } // 0x0000000180D5D820-0x0000000180D5D8C0 0x0000000180D5DAD0-0x0000000180D5DBC0
	
		// Constructors
		public PkzipClassicManaged(); // 0x0000000180D5D810-0x0000000180D5D820
	
		// Methods
		public override void GenerateIV(); // 0x00000001803581E0-0x00000001803581F0
		public override void GenerateKey(); // 0x0000000180D5D780-0x0000000180D5D810
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV); // 0x0000000180D5D700-0x0000000180D5D780
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV); // 0x0000000180D5D680-0x0000000180D5D700
	}
}
