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

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputBuffer // TypeDefIndex: 7710
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
		public int RawLength { get; } // 0x0000000180387590-0x0000000180387930 
		public int Available { get; set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
	
		// Constructors
		public InflaterInputBuffer(Stream stream, int bufferSize); // 0x0000000181EA1770-0x0000000181EA17F0
	
		// Methods
		public void SetInflaterInput(Inflater inflater); // 0x0000000181EA1700-0x0000000181EA1770
		public void Fill(); // 0x0000000181EA1440-0x0000000181EA1530
		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length); // 0x0000000181EA1530-0x0000000181EA1650
		public int ReadLeByte(); // 0x0000000181EA1650-0x0000000181EA1700
	}
}
