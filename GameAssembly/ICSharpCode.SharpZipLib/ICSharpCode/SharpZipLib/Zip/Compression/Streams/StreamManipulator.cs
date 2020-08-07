/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class StreamManipulator // TypeDefIndex: 7712
	{
		// Fields
		private byte[] window_; // 0x10
		private int windowStart_; // 0x18
		private int windowEnd_; // 0x1C
		private uint buffer_; // 0x20
		private int bitsInBuffer_; // 0x24
	
		// Properties
		public int AvailableBits { get; } // 0x0000000180491DB0-0x0000000180491DC0 
		public int AvailableBytes { get; } // 0x0000000181EA5DE0-0x0000000181EA5DF0 
		public bool IsNeedingInput { get; } // 0x00000001813A0AC0-0x00000001813A0AD0 
	
		// Constructors
		public StreamManipulator(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public int PeekBits(int bitCount); // 0x0000000181EA5B10-0x0000000181EA5BD0
		public void DropBits(int bitCount); // 0x0000000181EA5AF0-0x0000000181EA5B10
		public void SkipToByteBoundary(); // 0x0000000181EA5DC0-0x0000000181EA5DE0
		public int CopyBytes(byte[] output, int offset, int length); // 0x0000000181EA5940-0x0000000181EA5AF0
		public void Reset(); // 0x0000000181EA5BD0-0x0000000181EA5BE0
		public void SetInput(byte[] buffer, int offset, int count); // 0x0000000181EA5BE0-0x0000000181EA5DC0
	}
}
