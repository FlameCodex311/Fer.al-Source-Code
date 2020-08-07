/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Encryption
{
	public sealed class PkzipClassicManaged : PkzipClassic // TypeDefIndex: 7694
	{
		// Fields
		private byte[] key_; // 0x48
	
		// Properties
		public override int BlockSize { get; set; } // 0x00000001808E2210-0x00000001808E2220 0x0000000181EA5280-0x0000000181EA52E0
		public override KeySizes[] LegalKeySizes { get; } // 0x0000000181EA51C0-0x0000000181EA5280 
		public override KeySizes[] LegalBlockSizes { get; } // 0x0000000181EA5100-0x0000000181EA51C0 
		public override byte[] Key { get; set; } // 0x0000000181EA5060-0x0000000181EA5100 0x0000000181EA52E0-0x0000000181EA53D0
	
		// Constructors
		public PkzipClassicManaged(); // 0x0000000181EA5050-0x0000000181EA5060
	
		// Methods
		public override void GenerateIV(); // 0x00000001803774A0-0x00000001803774B0
		public override void GenerateKey(); // 0x0000000181EA4FC0-0x0000000181EA5050
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV); // 0x0000000181EA4F40-0x0000000181EA4FC0
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV); // 0x0000000181EA4EC0-0x0000000181EA4F40
	}
}
