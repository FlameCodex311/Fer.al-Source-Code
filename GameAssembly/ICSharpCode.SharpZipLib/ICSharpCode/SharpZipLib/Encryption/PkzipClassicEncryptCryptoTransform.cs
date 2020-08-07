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
	internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform // TypeDefIndex: 7692
	{
		// Properties
		public bool CanReuseTransform { get; } // 0x0000000180380B60-0x0000000180380B70 
		public int InputBlockSize { get; } // 0x000000018058C710-0x000000018058C720 
		public int OutputBlockSize { get; } // 0x000000018058C710-0x000000018058C720 
		public bool CanTransformMultipleBlocks { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock); // 0x0000000181EA4C10-0x0000000181EA4C40
	
		// Methods
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount); // 0x0000000181EA4D70-0x0000000181EA4EC0
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset); // 0x0000000181EA4C40-0x0000000181EA4D70
		public void Dispose(); // 0x0000000181EA49B0-0x0000000181EA49C0
	}
}
