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
	internal class ZipAESTransform : ICryptoTransform // TypeDefIndex: 7530
	{
		// Fields
		private int _blockSize; // 0x10
		private ICryptoTransform _encryptor; // 0x18
		private readonly byte[] _counterNonce; // 0x20
		private byte[] _encryptBuffer; // 0x28
		private int _encrPos; // 0x30
		private byte[] _pwdVerifier; // 0x38
		private HMACSHA1 _hmacsha1; // 0x40
		private bool _finalised; // 0x48
		private bool _writeMode; // 0x49
	
		// Properties
		public byte[] PwdVerifier { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		public int InputBlockSize { get; } // 0x000000018036CFF0-0x000000018036D000 
		public int OutputBlockSize { get; } // 0x000000018036CFF0-0x000000018036D000 
		public bool CanTransformMultipleBlocks { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public bool CanReuseTransform { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode); // 0x0000000180D64050-0x0000000180D643B0
	
		// Methods
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset); // 0x0000000180D63D80-0x0000000180D63FF0
		public byte[] GetAuthCode(); // 0x0000000180D63CF0-0x0000000180D63D80
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount); // 0x0000000180D63FF0-0x0000000180D64050
		public void Dispose(); // 0x0000000180D63CA0-0x0000000180D63CF0
	}
}
