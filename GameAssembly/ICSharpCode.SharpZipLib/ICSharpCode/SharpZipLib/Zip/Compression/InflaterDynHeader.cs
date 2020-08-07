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
	internal class InflaterDynHeader // TypeDefIndex: 7715
	{
		// Fields
		private static readonly int[] repMin; // 0x00
		private static readonly int[] repBits; // 0x08
		private static readonly int[] BL_ORDER; // 0x10
		private byte[] blLens; // 0x10
		private byte[] litdistLens; // 0x18
		private InflaterHuffmanTree blTree; // 0x20
		private int mode; // 0x28
		private int lnum; // 0x2C
		private int dnum; // 0x30
		private int blnum; // 0x34
		private int num; // 0x38
		private int repSymbol; // 0x3C
		private byte lastLen; // 0x40
		private int ptr; // 0x44
	
		// Constructors
		public InflaterDynHeader(); // 0x0000000180373240-0x0000000180373250
		static InflaterDynHeader(); // 0x0000000181EA0A10-0x0000000181EA0AE0
	
		// Methods
		public bool Decode(StreamManipulator input); // 0x0000000181EA04F0-0x0000000181EA0A10
		public InflaterHuffmanTree BuildLitLenTree(); // 0x0000000181EA0460-0x0000000181EA04F0
		public InflaterHuffmanTree BuildDistTree(); // 0x0000000181EA03C0-0x0000000181EA0460
	}
}
