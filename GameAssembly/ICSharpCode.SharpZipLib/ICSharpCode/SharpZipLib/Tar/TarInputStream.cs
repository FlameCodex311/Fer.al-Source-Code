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
	public class TarInputStream : Stream // TypeDefIndex: 7707
	{
		// Fields
		protected bool hasHitEOF; // 0x28
		protected long entrySize; // 0x30
		protected long entryOffset; // 0x38
		protected byte[] readBuffer; // 0x40
		protected TarBuffer tarBuffer; // 0x48
		private TarEntry currentEntry; // 0x50
		protected IEntryFactory entryFactory; // 0x58
		private readonly Stream inputStream; // 0x60
	
		// Properties
		public override bool CanRead { get; } // 0x0000000181EAA400-0x0000000181EAA430 
		public override bool CanSeek { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool CanWrite { get; } // 0x0000000180380950-0x0000000180380960 
		public override long Length { get; } // 0x0000000181EAA430-0x0000000181EAA460 
		public override long Position { get; set; } // 0x0000000181EAA460-0x0000000181EAA490 0x0000000181EAA490-0x0000000181EAA4F0
	
		// Nested types
		public interface IEntryFactory // TypeDefIndex: 7708
		{
			// Methods
			TarEntry CreateEntry(byte[] headerBuffer);
		}
	
		// Constructors
		public TarInputStream(Stream inputStream, int blockFactor); // 0x0000000181EAA260-0x0000000181EAA400
	
		// Methods
		public override void Flush(); // 0x0000000181EA9570-0x0000000181EA95A0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000181EA9F80-0x0000000181EA9FE0
		public override void SetLength(long value); // 0x0000000181EA9FE0-0x0000000181EAA040
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EAA200-0x0000000181EAA260
		public override void WriteByte(byte value); // 0x0000000181EAA1A0-0x0000000181EAA200
		public override int ReadByte(); // 0x0000000181EA9C50-0x0000000181EA9D00
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EA9D00-0x0000000181EA9F80
		public override void Close(); // 0x0000000181EA9450-0x0000000181EA9570
		public void Skip(long skipCount); // 0x0000000181EAA0F0-0x0000000181EAA1A0
		public TarEntry GetNextEntry(); // 0x0000000181EA95A0-0x0000000181EA9C50
		private void SkipToNextEntry(); // 0x0000000181EAA040-0x0000000181EAA0F0
	}
}
