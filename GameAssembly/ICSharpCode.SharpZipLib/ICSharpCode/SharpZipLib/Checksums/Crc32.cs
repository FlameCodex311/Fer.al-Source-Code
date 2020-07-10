/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Checksums
{
	public sealed class Crc32 // TypeDefIndex: 7521
	{
		// Fields
		private static readonly uint[] CrcTable; // 0x00
		private uint crc; // 0x10
	
		// Properties
		public long Value { get; } // 0x000000018036CFF0-0x000000018036D000 
	
		// Constructors
		public Crc32(); // 0x000000018036B6C0-0x000000018036B6D0
		static Crc32(); // 0x0000000180D57250-0x0000000180D572B0
	
		// Methods
		internal static uint ComputeCrc32(uint oldCrc, byte value); // 0x0000000180D56F00-0x0000000180D56FA0
		public void Update(int value); // 0x0000000180D57170-0x0000000180D57250
		public void Update(byte[] buffer, int offset, int count); // 0x0000000180D56FA0-0x0000000180D57170
	}
}
