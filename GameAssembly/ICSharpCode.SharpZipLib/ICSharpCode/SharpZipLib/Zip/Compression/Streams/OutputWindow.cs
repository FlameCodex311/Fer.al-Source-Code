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
	public class OutputWindow // TypeDefIndex: 7711
	{
		// Fields
		private byte[] window; // 0x10
		private int windowEnd; // 0x18
		private int windowFilled; // 0x1C
	
		// Constructors
		public OutputWindow(); // 0x0000000181EA3DF0-0x0000000181EA3E40
	
		// Methods
		public void Write(int value); // 0x0000000181EA3D30-0x0000000181EA3DF0
		private void SlowRepeat(int repStart, int length, int distance); // 0x0000000181EA3CA0-0x0000000181EA3D30
		public void Repeat(int length, int distance); // 0x0000000181EA3A80-0x0000000181EA3C90
		public int CopyStored(StreamManipulator input, int length); // 0x0000000181EA3950-0x0000000181EA3A70
		public int GetFreeSpace(); // 0x0000000181EA3A70-0x0000000181EA3A80
		public int GetAvailable(); // 0x00000001803FB770-0x00000001803FB780
		public int CopyOutput(byte[] output, int offset, int len); // 0x0000000181EA3840-0x0000000181EA3950
		public void Reset(); // 0x0000000181EA3C90-0x0000000181EA3CA0
	}
}
