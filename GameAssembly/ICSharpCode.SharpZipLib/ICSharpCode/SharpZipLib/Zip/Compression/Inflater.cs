/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class Inflater // TypeDefIndex: 7714
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
		public bool IsNeedingInput { get; } // 0x0000000181EA3760-0x0000000181EA3790 
		public bool IsNeedingDictionary { get; } // 0x0000000181EA3740-0x0000000181EA3760 
		public bool IsFinished { get; } // 0x0000000181EA3710-0x0000000181EA3740 
		public long TotalOut { get; } // 0x00000001803745C0-0x00000001803745D0 
		public int RemainingInput { get; } // 0x0000000181EA3790-0x0000000181EA37C0 
	
		// Constructors
		public Inflater(bool noHeader); // 0x0000000181EA3620-0x0000000181EA3710
		static Inflater(); // 0x0000000181EA3510-0x0000000181EA3620
	
		// Methods
		public void Reset(); // 0x0000000181EA3460-0x0000000181EA34D0
		private bool DecodeHeader(); // 0x0000000181EA2400-0x0000000181EA2540
		private bool DecodeDict(); // 0x0000000181EA2390-0x0000000181EA2400
		private bool DecodeHuffman(); // 0x0000000181EA2540-0x0000000181EA2970
		private bool DecodeChksum(); // 0x0000000181EA21A0-0x0000000181EA2390
		private bool Decode(); // 0x0000000181EA2970-0x0000000181EA3120
		public void SetInput(byte[] buffer, int index, int count); // 0x0000000181EA34D0-0x0000000181EA3510
		public int Inflate(byte[] buffer, int offset, int count); // 0x0000000181EA3120-0x0000000181EA3460
	}
}
