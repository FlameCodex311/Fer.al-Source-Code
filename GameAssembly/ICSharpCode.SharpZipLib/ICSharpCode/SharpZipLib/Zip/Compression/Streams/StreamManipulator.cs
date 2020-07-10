/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class StreamManipulator // TypeDefIndex: 7546
	{
		// Fields
		private byte[] window_; // 0x10
		private int windowStart_; // 0x18
		private int windowEnd_; // 0x1C
		private uint buffer_; // 0x20
		private int bitsInBuffer_; // 0x24
	
		// Properties
		public int AvailableBits { get; } // 0x00000001803C26F0-0x00000001803C2700 
		public int AvailableBytes { get; } // 0x0000000180D5E670-0x0000000180D5E680 
		public bool IsNeedingInput { get; } // 0x000000018098B880-0x000000018098B890 
	
		// Constructors
		public StreamManipulator(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public int PeekBits(int bitCount); // 0x0000000180D5E390-0x0000000180D5E460
		public void DropBits(int bitCount); // 0x0000000180D5E370-0x0000000180D5E390
		public void SkipToByteBoundary(); // 0x0000000180D5E650-0x0000000180D5E670
		public int CopyBytes(byte[] output, int offset, int length); // 0x0000000180D5E1B0-0x0000000180D5E370
		public void Reset(); // 0x0000000180D5E460-0x0000000180D5E470
		public void SetInput(byte[] buffer, int offset, int count); // 0x0000000180D5E470-0x0000000180D5E650
	}
}
