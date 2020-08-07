/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Zip.Compression;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputStream : Stream // TypeDefIndex: 7698
	{
		// Fields
		protected Inflater inf; // 0x28
		protected InflaterInputBuffer inputBuffer; // 0x30
		private Stream baseInputStream; // 0x38
		private bool isClosed; // 0x40
		private bool isStreamOwner; // 0x41
	
		// Properties
		public override bool CanRead { get; } // 0x0000000181EA20F0-0x0000000181EA2120 
		public override bool CanSeek { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool CanWrite { get; } // 0x0000000180380950-0x0000000180380960 
		public override long Length { get; } // 0x0000000181EA2120-0x0000000181EA2140 
		public override long Position { get; set; } // 0x0000000180F64FA0-0x0000000180F64FD0 0x0000000181EA2140-0x0000000181EA21A0
	
		// Constructors
		public InflaterInputStream(Stream baseInputStream, Inflater inf); // 0x0000000181EA1FB0-0x0000000181EA20F0
		public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize); // 0x0000000181EA1E20-0x0000000181EA1FB0
	
		// Methods
		protected void Fill(); // 0x0000000181EA1890-0x0000000181EA19B0
		public override void Flush(); // 0x0000000181EA19B0-0x0000000181EA19E0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000181EA1CA0-0x0000000181EA1D00
		public override void SetLength(long value); // 0x0000000181EA1D00-0x0000000181EA1D60
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EA1DC0-0x0000000181EA1E20
		public override void WriteByte(byte value); // 0x0000000181EA1D60-0x0000000181EA1DC0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state); // 0x0000000181EA17F0-0x0000000181EA1850
		public override void Close(); // 0x0000000181EA1850-0x0000000181EA1890
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EA19E0-0x0000000181EA1CA0
	}
}
