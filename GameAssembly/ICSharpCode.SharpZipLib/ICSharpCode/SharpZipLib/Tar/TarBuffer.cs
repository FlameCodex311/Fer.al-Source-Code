/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarBuffer // TypeDefIndex: 7538
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
		public int RecordSize { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		public int BlockFactor { get; } // 0x000000018043E170-0x000000018043E180 
		public int CurrentBlock { get; } // 0x000000018038E0E0-0x000000018038E0F0 
		public int CurrentRecord { get; } // 0x000000018038E0D0-0x000000018038E0E0 
	
		// Constructors
		protected TarBuffer(); // 0x0000000180D60300-0x0000000180D60320
	
		// Methods
		public static TarBuffer CreateInputTarBuffer(Stream inputStream, int blockFactor); // 0x0000000180D5F920-0x0000000180D5FA80
		private void Initialize(int archiveBlockFactor); // 0x0000000180D5FA80-0x0000000180D5FB00
		public static bool IsEndOfArchiveBlock(byte[] block); // 0x0000000180D5FB00-0x0000000180D5FBE0
		public byte[] ReadBlock(); // 0x0000000180D5FBE0-0x0000000180D5FD60
		private bool ReadRecord(); // 0x0000000180D5FD60-0x0000000180D5FE30
		public void WriteBlock(byte[] block); // 0x0000000180D5FE30-0x0000000180D5FFB0
		public void WriteBlock(byte[] buffer, int offset); // 0x0000000180D5FFB0-0x0000000180D601A0
		private void WriteRecord(); // 0x0000000180D60250-0x0000000180D60300
		private void WriteFinalRecord(); // 0x0000000180D601A0-0x0000000180D60250
		public void Close(); // 0x0000000180D5F810-0x0000000180D5F920
	}
}
