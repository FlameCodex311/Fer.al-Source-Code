/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip
{
	internal class ZipHelperStream : Stream // TypeDefIndex: 7734
	{
		// Fields
		private bool isOwner_; // 0x28
		private Stream stream_; // 0x30
	
		// Properties
		public override bool CanRead { get; } // 0x0000000181EB0B00-0x0000000181EB0B30 
		public override bool CanSeek { get; } // 0x0000000181EB0B30-0x0000000181EB0B60 
		public override long Length { get; } // 0x0000000181EB0B90-0x0000000181EB0BC0 
		public override long Position { get; set; } // 0x0000000181EB0BC0-0x0000000181EB0BF0 0x0000000181031270-0x00000001810312A0
		public override bool CanWrite { get; } // 0x0000000181EB0B60-0x0000000181EB0B90 
	
		// Constructors
		public ZipHelperStream(Stream stream); // 0x0000000181EB0A90-0x0000000181EB0B00
	
		// Methods
		public override void Flush(); // 0x0000000181EB0780-0x0000000181EB07B0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000181EB0A00-0x0000000181EB0A30
		public override void SetLength(long value); // 0x0000000181EB0A30-0x0000000181EB0A60
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EB09D0-0x0000000181EB0A00
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EB0A60-0x0000000181EB0A90
		public override void Close(); // 0x0000000181EB0750-0x0000000181EB0780
		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData); // 0x0000000181EB07B0-0x0000000181EB08C0
		public int ReadLEShort(); // 0x0000000181EB08F0-0x0000000181EB09D0
		public int ReadLEInt(); // 0x0000000181EB08C0-0x0000000181EB08F0
	}
}
