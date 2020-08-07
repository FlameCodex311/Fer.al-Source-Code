/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarBuffer // TypeDefIndex: 7704
	{
		// Fields
		private Stream inputStream; // 0x10
		private Stream outputStream; // 0x18
		private byte[] recordBuffer; // 0x20
		private int currentBlockIndex; // 0x28
		private int currentRecordIndex; // 0x2C
		private int recordSize; // 0x30
		private int blockFactor; // 0x34
		private bool isStreamOwner_; // 0x38
	
		// Properties
		public int RecordSize { get; } // 0x00000001804AA650-0x00000001804AA660 
		public int BlockFactor { get; } // 0x00000001804EF8F0-0x00000001804EF900 
		public int CurrentBlock { get; } // 0x000000018043C680-0x000000018043C690 
		public int CurrentRecord { get; } // 0x000000018043C670-0x000000018043C680 
	
		// Constructors
		protected TarBuffer(); // 0x0000000181EA79F0-0x0000000181EA7A10
	
		// Methods
		public static TarBuffer CreateInputTarBuffer(Stream inputStream, int blockFactor); // 0x0000000181EA7020-0x0000000181EA7180
		private void Initialize(int archiveBlockFactor); // 0x0000000181EA7180-0x0000000181EA7200
		public static bool IsEndOfArchiveBlock(byte[] block); // 0x0000000181EA7200-0x0000000181EA72E0
		public byte[] ReadBlock(); // 0x0000000181EA72E0-0x0000000181EA7460
		private bool ReadRecord(); // 0x0000000181EA7460-0x0000000181EA7530
		public void WriteBlock(byte[] block); // 0x0000000181EA7530-0x0000000181EA76A0
		public void WriteBlock(byte[] buffer, int offset); // 0x0000000181EA76A0-0x0000000181EA7890
		private void WriteRecord(); // 0x0000000181EA7940-0x0000000181EA79F0
		private void WriteFinalRecord(); // 0x0000000181EA7890-0x0000000181EA7940
		public void Close(); // 0x0000000181EA6F10-0x0000000181EA7020
	}
}
