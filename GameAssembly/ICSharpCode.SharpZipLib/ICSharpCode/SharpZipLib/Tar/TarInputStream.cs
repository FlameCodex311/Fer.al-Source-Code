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
	public class TarInputStream : Stream // TypeDefIndex: 7541
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
		public override bool CanRead { get; } // 0x0000000180D62D30-0x0000000180D62D60 
		public override bool CanSeek { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool CanWrite { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override long Length { get; } // 0x0000000180D62D60-0x0000000180D62D90 
		public override long Position { get; set; } // 0x0000000180D62D90-0x0000000180D62DC0 0x0000000180D62DC0-0x0000000180D62E20
	
		// Nested types
		public interface IEntryFactory // TypeDefIndex: 7542
		{
			// Methods
			TarEntry CreateEntry(byte[] headerBuffer);
		}
	
		// Constructors
		public TarInputStream(Stream inputStream, int blockFactor); // 0x0000000180D62B90-0x0000000180D62D30
	
		// Methods
		public override void Flush(); // 0x0000000180D61E70-0x0000000180D61EA0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000180D628A0-0x0000000180D62900
		public override void SetLength(long value); // 0x0000000180D62900-0x0000000180D62960
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000180D62B30-0x0000000180D62B90
		public override void WriteByte(byte value); // 0x0000000180D62AD0-0x0000000180D62B30
		public override int ReadByte(); // 0x0000000180D62570-0x0000000180D62620
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D62620-0x0000000180D628A0
		public override void Close(); // 0x0000000180D61E50-0x0000000180D61E70
		public void Skip(long skipCount); // 0x0000000180D62A20-0x0000000180D62AD0
		public TarEntry GetNextEntry(); // 0x0000000180D61EA0-0x0000000180D62570
		private void SkipToNextEntry(); // 0x0000000180D62960-0x0000000180D62A20
	}
}
