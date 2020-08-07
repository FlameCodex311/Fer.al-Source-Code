/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class ZipAESStream : CryptoStream // TypeDefIndex: 7695
	{
		// Fields
		private Stream _stream; // 0x60
		private ZipAESTransform _transform; // 0x68
		private byte[] _slideBuffer; // 0x70
		private int _slideBufStartPos; // 0x78
		private int _slideBufFreePos; // 0x7C
		private int _blockAndAuth; // 0x80
	
		// Constructors
		public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode); // 0x0000000181EAAEA0-0x0000000181EAAF70
	
		// Methods
		public override int Read(byte[] outBuffer, int offset, int count); // 0x0000000181EAAB60-0x0000000181EAAE50
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EAAE50-0x0000000181EAAEA0
	}
}
