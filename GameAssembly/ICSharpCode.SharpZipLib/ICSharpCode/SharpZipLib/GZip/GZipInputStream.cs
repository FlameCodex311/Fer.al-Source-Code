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

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.GZip
{
	public class GZipInputStream : InflaterInputStream // TypeDefIndex: 7533
	{
		// Fields
		protected Crc32 crc; // 0x48
		private bool readGZIPHeader; // 0x50
	
		// Constructors
		public GZipInputStream(Stream baseInputStream); // 0x0000000180D587A0-0x0000000180D58920
		public GZipInputStream(Stream baseInputStream, int size); // 0x0000000180D58710-0x0000000180D587A0
	
		// Methods
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D58630-0x0000000180D58710
		private bool ReadHeader(); // 0x0000000180D57E30-0x0000000180D58630
		private void ReadFooter(); // 0x0000000180D57900-0x0000000180D57E30
	}
}
