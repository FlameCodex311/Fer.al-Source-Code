/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Zip.Compression;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputStream : Stream // TypeDefIndex: 7532
	{
		// Fields
		protected Inflater inf; // 0x28
		protected InflaterInputBuffer inputBuffer; // 0x30
		private Stream baseInputStream; // 0x38
		private bool isClosed; // 0x40
		private bool isStreamOwner; // 0x41
	
		// Properties
		public override bool CanRead { get; } // 0x0000000180D5A730-0x0000000180D5A760 
		public override bool CanSeek { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool CanWrite { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override long Length { get; } // 0x0000000180D5A760-0x0000000180D5A780 
		public override long Position { get; set; } // 0x00000001806F55D0-0x00000001806F5600 0x0000000180D5A780-0x0000000180D5A7E0
	
		// Constructors
		public InflaterInputStream(Stream baseInputStream, Inflater inf); // 0x0000000180D5A5F0-0x0000000180D5A730
		public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize); // 0x0000000180D5A450-0x0000000180D5A5F0
	
		// Methods
		protected void Fill(); // 0x0000000180D59E90-0x0000000180D59FC0
		public override void Flush(); // 0x0000000180D59FC0-0x0000000180D59FF0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000180D5A2D0-0x0000000180D5A330
		public override void SetLength(long value); // 0x0000000180D5A330-0x0000000180D5A390
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000180D5A3F0-0x0000000180D5A450
		public override void WriteByte(byte value); // 0x0000000180D5A390-0x0000000180D5A3F0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state); // 0x0000000180D59DF0-0x0000000180D59E50
		public override void Close(); // 0x0000000180D59E50-0x0000000180D59E90
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D59FF0-0x0000000180D5A2D0
	}
}
