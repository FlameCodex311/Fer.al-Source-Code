/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Zip.Compression;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputBuffer // TypeDefIndex: 7544
	{
		// Fields
		private int rawLength; // 0x10
		private byte[] rawData; // 0x18
		private int clearTextLength; // 0x20
		private byte[] clearText; // 0x28
		private int available; // 0x30
		private ICryptoTransform cryptoTransform; // 0x38
		private Stream inputStream; // 0x40
	
		// Properties
		public int RawLength { get; } // 0x000000018036CFF0-0x000000018036D000 
		public int Available { get; set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
	
		// Constructors
		public InflaterInputBuffer(Stream stream, int bufferSize); // 0x0000000180D59D70-0x0000000180D59DF0
	
		// Methods
		public void SetInflaterInput(Inflater inflater); // 0x0000000180D59D00-0x0000000180D59D70
		public void Fill(); // 0x0000000180D59A30-0x0000000180D59B20
		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length); // 0x0000000180D59B20-0x0000000180D59C40
		public int ReadLeByte(); // 0x0000000180D59C40-0x0000000180D59D00
	}
}
