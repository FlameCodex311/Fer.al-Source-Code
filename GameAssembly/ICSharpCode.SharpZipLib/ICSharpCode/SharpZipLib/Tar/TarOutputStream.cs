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
	public class TarOutputStream : Stream // TypeDefIndex: 7543
	{
		// Fields
		private long currBytes; // 0x28
		private int assemblyBufferLength; // 0x30
		private bool isClosed; // 0x34
		protected long currSize; // 0x38
		protected byte[] blockBuffer; // 0x40
		protected byte[] assemblyBuffer; // 0x48
		protected TarBuffer buffer; // 0x50
		protected Stream outputStream; // 0x58
	
		// Properties
		public override bool CanRead { get; } // 0x0000000180D63750-0x0000000180D63780 
		public override bool CanSeek { get; } // 0x0000000180D63780-0x0000000180D637B0 
		public override bool CanWrite { get; } // 0x0000000180D637B0-0x0000000180D637E0 
		public override long Length { get; } // 0x0000000180D637F0-0x0000000180D63820 
		public override long Position { get; set; } // 0x0000000180D63820-0x0000000180D63850 0x0000000180D63850-0x0000000180D63880
		private bool IsEntryOpen { get; } // 0x0000000180D637E0-0x0000000180D637F0 
	
		// Methods
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000180D632C0-0x0000000180D632F0
		public override void SetLength(long value); // 0x0000000180D632F0-0x0000000180D63320
		public override int ReadByte(); // 0x0000000180D63260-0x0000000180D63290
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D63290-0x0000000180D632C0
		public override void Flush(); // 0x0000000180D63230-0x0000000180D63260
		public void Finish(); // 0x0000000180D630D0-0x0000000180D63230
		public override void Close(); // 0x0000000180D62F40-0x0000000180D630D0
		public void CloseEntry(); // 0x0000000180D62E20-0x0000000180D62F40
		public override void WriteByte(byte value); // 0x0000000180D63320-0x0000000180D633C0
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000180D63410-0x0000000180D63750
		private void WriteEofBlock(); // 0x0000000180D633C0-0x0000000180D63410
	}
}
