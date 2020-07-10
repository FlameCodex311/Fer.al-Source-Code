/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip
{
	internal class ZipHelperStream : Stream // TypeDefIndex: 7568
	{
		// Fields
		private bool isOwner_; // 0x28
		private Stream stream_; // 0x30
	
		// Properties
		public override bool CanRead { get; } // 0x000000018077A950-0x000000018077A980 
		public override bool CanSeek { get; } // 0x0000000180D69A00-0x0000000180D69A30 
		public override long Length { get; } // 0x0000000180D69A60-0x0000000180D69A90 
		public override long Position { get; set; } // 0x0000000180D69A90-0x0000000180D69AC0 0x0000000180D69AC0-0x0000000180D69AF0
		public override bool CanWrite { get; } // 0x0000000180D69A30-0x0000000180D69A60 
	
		// Constructors
		public ZipHelperStream(Stream stream); // 0x0000000180D69990-0x0000000180D69A00
	
		// Methods
		public override void Flush(); // 0x0000000180D69680-0x0000000180D696B0
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000180D69900-0x0000000180D69930
		public override void SetLength(long value); // 0x0000000180D69930-0x0000000180D69960
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D698D0-0x0000000180D69900
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000180D69960-0x0000000180D69990
		public override void Close(); // 0x0000000180D69650-0x0000000180D69680
		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData); // 0x0000000180D696B0-0x0000000180D697C0
		public int ReadLEShort(); // 0x0000000180D697F0-0x0000000180D698D0
		public int ReadLEInt(); // 0x0000000180D697C0-0x0000000180D697F0
	}
}
