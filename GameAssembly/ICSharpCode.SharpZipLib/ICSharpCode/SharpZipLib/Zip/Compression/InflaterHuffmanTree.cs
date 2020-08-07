/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class InflaterHuffmanTree // TypeDefIndex: 7716
	{
		// Fields
		private short[] tree; // 0x10
		public static InflaterHuffmanTree defLitLenTree; // 0x00
		public static InflaterHuffmanTree defDistTree; // 0x08
	
		// Constructors
		static InflaterHuffmanTree(); // 0x0000000181EA11C0-0x0000000181EA1410
		public InflaterHuffmanTree(byte[] codeLengths); // 0x0000000181EA1410-0x0000000181EA1440
	
		// Methods
		private void BuildTree(byte[] codeLengths); // 0x0000000181EA0AE0-0x0000000181EA0FB0
		public int GetSymbol(StreamManipulator input); // 0x0000000181EA0FB0-0x0000000181EA11C0
	}
}
