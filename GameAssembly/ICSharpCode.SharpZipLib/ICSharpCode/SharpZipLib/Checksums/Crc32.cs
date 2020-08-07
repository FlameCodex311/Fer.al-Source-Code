/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Checksums
{
	public sealed class Crc32 // TypeDefIndex: 7687
	{
		// Fields
		private static readonly uint[] CrcTable; // 0x00
		private uint crc; // 0x10
	
		// Properties
		public long Value { get; } // 0x0000000180387590-0x0000000180387930 
	
		// Constructors
		public Crc32(); // 0x0000000180373240-0x0000000180373250
		static Crc32(); // 0x0000000181E9EDE0-0x0000000181E9EE40
	
		// Methods
		internal static uint ComputeCrc32(uint oldCrc, byte value); // 0x0000000181E9EAB0-0x0000000181E9EB50
		public void Update(int value); // 0x0000000181E9ED10-0x0000000181E9EDE0
		public void Update(byte[] buffer, int offset, int count); // 0x0000000181E9EB50-0x0000000181E9ED10
	}
}
