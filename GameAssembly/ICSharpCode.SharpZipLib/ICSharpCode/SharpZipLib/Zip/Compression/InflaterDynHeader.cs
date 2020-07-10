/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	internal class InflaterDynHeader // TypeDefIndex: 7549
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
		public InflaterDynHeader(); // 0x000000018036B6C0-0x000000018036B6D0
		static InflaterDynHeader(); // 0x0000000180D58F90-0x0000000180D59060
	
		// Methods
		public bool Decode(StreamManipulator input); // 0x0000000180D58A50-0x0000000180D58F90
		public InflaterHuffmanTree BuildLitLenTree(); // 0x0000000180D589C0-0x0000000180D58A50
		public InflaterHuffmanTree BuildDistTree(); // 0x0000000180D58920-0x0000000180D589C0
	}
}
