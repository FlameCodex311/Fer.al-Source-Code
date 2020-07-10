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
	public class InflaterHuffmanTree // TypeDefIndex: 7550
	{
		// Fields
		private short[] tree; // 0x10
		public static InflaterHuffmanTree defLitLenTree; // 0x00
		public static InflaterHuffmanTree defDistTree; // 0x08
	
		// Constructors
		static InflaterHuffmanTree(); // 0x0000000180D59790-0x0000000180D59A00
		public InflaterHuffmanTree(byte[] codeLengths); // 0x0000000180D59A00-0x0000000180D59A30
	
		// Methods
		private void BuildTree(byte[] codeLengths); // 0x0000000180D59060-0x0000000180D59560
		public int GetSymbol(StreamManipulator input); // 0x0000000180D59560-0x0000000180D59790
	}
}
