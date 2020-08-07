/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.GZip
{
	public class GZipInputStream : InflaterInputStream // TypeDefIndex: 7699
	{
		// Fields
		protected Crc32 crc; // 0x48
		private bool readGZIPHeader; // 0x50
	
		// Constructors
		public GZipInputStream(Stream baseInputStream); // 0x0000000181EA0250-0x0000000181EA03C0
		public GZipInputStream(Stream baseInputStream, int size); // 0x0000000181EA01C0-0x0000000181EA0250
	
		// Methods
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EA00E0-0x0000000181EA01C0
		private bool ReadHeader(); // 0x0000000181E9F910-0x0000000181EA00E0
		private void ReadFooter(); // 0x0000000181E9F420-0x0000000181E9F910
	}
}
