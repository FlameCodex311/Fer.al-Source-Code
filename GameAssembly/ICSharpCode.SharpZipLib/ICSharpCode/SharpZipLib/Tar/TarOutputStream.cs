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
	public class TarOutputStream : Stream // TypeDefIndex: 7709
	{
		// Fields
		private long currBytes; // 0x28
		private int assemblyBufferLength; // 0x30
		protected long currSize; // 0x38
		protected byte[] blockBuffer; // 0x40
		protected byte[] assemblyBuffer; // 0x48
		protected TarBuffer buffer; // 0x50
		protected Stream outputStream; // 0x58
	
		// Properties
		public override bool CanRead { get; } // 0x0000000181EAAA40-0x0000000181EAAA70 
		public override bool CanSeek { get; } // 0x0000000181EAAA70-0x0000000181EAAAA0 
		public override bool CanWrite { get; } // 0x0000000181EAAAA0-0x0000000181EAAAD0 
		public override long Length { get; } // 0x0000000181EAAAD0-0x0000000181EAAB00 
		public override long Position { get; set; } // 0x0000000181EAAB00-0x0000000181EAAB30 0x0000000181EAAB30-0x0000000181EAAB60
	
		// Methods
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000181EAA550-0x0000000181EAA580
		public override void SetLength(long value); // 0x0000000181EAA580-0x0000000181EAA5B0
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EAA520-0x0000000181EAA550
		public override void Flush(); // 0x0000000181EAA4F0-0x0000000181EAA520
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EAA5B0-0x0000000181EAAA40
	}
}
