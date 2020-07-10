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
	public class OutputWindow // TypeDefIndex: 7545
	{
		// Fields
		private byte[] window; // 0x10
		private int windowEnd; // 0x18
		private int windowFilled; // 0x1C
	
		// Constructors
		public OutputWindow(); // 0x0000000180D5C4C0-0x0000000180D5C510
	
		// Methods
		public void Write(int value); // 0x0000000180D5C400-0x0000000180D5C4C0
		private void SlowRepeat(int repStart, int length, int distance); // 0x0000000180D5C360-0x0000000180D5C400
		public void Repeat(int length, int distance); // 0x0000000180D5C130-0x0000000180D5C350
		public int CopyStored(StreamManipulator input, int length); // 0x0000000180D5C000-0x0000000180D5C120
		public int GetFreeSpace(); // 0x0000000180D5C120-0x0000000180D5C130
		public int GetAvailable(); // 0x000000018037E420-0x000000018037E430
		public int CopyOutput(byte[] output, int offset, int len); // 0x0000000180D5BEF0-0x0000000180D5C000
		public void Reset(); // 0x0000000180D5C350-0x0000000180D5C360
	}
}
