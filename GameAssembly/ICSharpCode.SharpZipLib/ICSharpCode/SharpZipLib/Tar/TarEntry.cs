/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarEntry : ICloneable // TypeDefIndex: 7705
	{
		// Fields
		private string file; // 0x10
		private TarHeader header; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x00000001804AD7D0-0x00000001804AD7F0 0x0000000181EA7DF0-0x0000000181EA7E70
		public long Size { get; } // 0x0000000180C78660-0x0000000180C78680 
		public bool IsDirectory { get; } // 0x0000000181EA7D70-0x0000000181EA7DF0 
	
		// Constructors
		private TarEntry(); // 0x0000000181EA7D10-0x0000000181EA7D70
		public TarEntry(byte[] headerBuffer); // 0x0000000181EA7C90-0x0000000181EA7D10
	
		// Methods
		public object Clone(); // 0x0000000181EA7A10-0x0000000181EA7B90
		public override bool Equals(object obj); // 0x0000000181EA7B90-0x0000000181EA7C50
		public override int GetHashCode(); // 0x0000000181EA7C50-0x0000000181EA7C90
	}
}
