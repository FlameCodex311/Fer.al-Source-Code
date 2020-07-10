/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class Inflater // TypeDefIndex: 7548
	{
		// Fields
		private static readonly int[] CPLENS; // 0x00
		private static readonly int[] CPLEXT; // 0x08
		private static readonly int[] CPDIST; // 0x10
		private static readonly int[] CPDEXT; // 0x18
		private int mode; // 0x10
		private int readAdler; // 0x14
		private int neededBits; // 0x18
		private int repLength; // 0x1C
		private int repDist; // 0x20
		private int uncomprLen; // 0x24
		private bool isLastBlock; // 0x28
		private long totalOut; // 0x30
		private long totalIn; // 0x38
		private bool noHeader; // 0x40
		private StreamManipulator input; // 0x48
		private OutputWindow outputWindow; // 0x50
		private InflaterDynHeader dynHeader; // 0x58
		private InflaterHuffmanTree litlenTree; // 0x60
		private InflaterHuffmanTree distTree; // 0x68
		private Adler32 adler; // 0x70
	
		// Properties
		public bool IsNeedingInput { get; } // 0x0000000180D5BE10-0x0000000180D5BE40 
		public bool IsNeedingDictionary { get; } // 0x0000000180D5BDF0-0x0000000180D5BE10 
		public bool IsFinished { get; } // 0x0000000180D5BDC0-0x0000000180D5BDF0 
		public long TotalOut { get; } // 0x0000000180397720-0x0000000180397730 
		public int RemainingInput { get; } // 0x0000000180D5BE40-0x0000000180D5BE70 
	
		// Constructors
		public Inflater(bool noHeader); // 0x0000000180D5BCD0-0x0000000180D5BDC0
		static Inflater(); // 0x0000000180D5BBC0-0x0000000180D5BCD0
	
		// Methods
		public void Reset(); // 0x0000000180D5BB00-0x0000000180D5BB80
		private bool DecodeHeader(); // 0x0000000180D5AA50-0x0000000180D5AB90
		private bool DecodeDict(); // 0x0000000180D5A9E0-0x0000000180D5AA50
		private bool DecodeHuffman(); // 0x0000000180D5AB90-0x0000000180D5AFE0
		private bool DecodeChksum(); // 0x0000000180D5A7E0-0x0000000180D5A9E0
		private bool Decode(); // 0x0000000180D5AFE0-0x0000000180D5B7B0
		public void SetInput(byte[] buffer, int index, int count); // 0x0000000180D5BB80-0x0000000180D5BBC0
		public int Inflate(byte[] buffer, int offset, int count); // 0x0000000180D5B7B0-0x0000000180D5BB00
	}
}
