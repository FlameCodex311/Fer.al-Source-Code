/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarEntry : ICloneable // TypeDefIndex: 7539
	{
		// Fields
		private string file; // 0x10
		private TarHeader header; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x00000001805A6D10-0x00000001805A6D30 0x0000000180D60730-0x0000000180D607B0
		public long Size { get; } // 0x0000000180699030-0x0000000180699050 
		public bool IsDirectory { get; } // 0x0000000180D606B0-0x0000000180D60730 
	
		// Constructors
		private TarEntry(); // 0x0000000180D60650-0x0000000180D606B0
		public TarEntry(byte[] headerBuffer); // 0x0000000180D605C0-0x0000000180D60650
	
		// Methods
		public object Clone(); // 0x0000000180D60320-0x0000000180D604B0
		public override bool Equals(object obj); // 0x0000000180D604B0-0x0000000180D60580
		public override int GetHashCode(); // 0x0000000180D60580-0x0000000180D605C0
	}
}
