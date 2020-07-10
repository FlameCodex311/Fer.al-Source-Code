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
	internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform // TypeDefIndex: 7526
	{
		// Properties
		public bool CanReuseTransform { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public int InputBlockSize { get; } // 0x000000018042E670-0x000000018042E680 
		public int OutputBlockSize { get; } // 0x000000018042E670-0x000000018042E680 
		public bool CanTransformMultipleBlocks { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock); // 0x0000000180D5D3A0-0x0000000180D5D3D0
	
		// Methods
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount); // 0x0000000180D5D520-0x0000000180D5D680
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset); // 0x0000000180D5D3D0-0x0000000180D5D520
		public void Dispose(); // 0x0000000180D5D120-0x0000000180D5D130
	}
}
