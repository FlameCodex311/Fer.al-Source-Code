/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipFile : IEnumerable, IDisposable // TypeDefIndex: 7727
	{
		// Fields
		public KeysRequiredEventHandler KeysRequired; // 0x10
		private bool isDisposed_; // 0x18
		private string name_; // 0x20
		private string comment_; // 0x28
		private string rawPassword_; // 0x30
		private Stream baseStream_; // 0x38
		private bool isStreamOwner; // 0x40
		private long offsetOfFirstEntry; // 0x48
		private ZipEntry[] entries_; // 0x50
		private byte[] key; // 0x58
		private UseZip64 useZip64_; // 0x60
		private ArrayList updates_; // 0x68
		private Hashtable updateIndex_; // 0x70
		private IArchiveStorage archiveStorage_; // 0x78
		private IDynamicDataSource updateDataSource_; // 0x80
		private int bufferSize_; // 0x88
		private IEntryFactory updateEntryFactory_; // 0x90
	
		// Properties
		public string Password { set; } // 0x0000000181EB0600-0x0000000181EB0750
		private bool HaveKeys { get; } // 0x0000000181EB05F0-0x0000000181EB0600 
		public bool IsStreamOwner { get; set; } // 0x0000000180455BA0-0x0000000180455BB0 0x0000000180455C20-0x0000000180455C30
		public long Count { get; } // 0x0000000181EB05D0-0x0000000181EB05F0 
	
		// Nested types
		public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e); // TypeDefIndex: 7728; 0x00000001804D5DB0-0x00000001804D62B0
	
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		private enum HeaderTest // TypeDefIndex: 7729
		{
			Extract = 1,
			Header = 2
		}
	
		private class ZipEntryEnumerator : IEnumerator // TypeDefIndex: 7730
		{
			// Fields
			private ZipEntry[] array; // 0x10
			private int index; // 0x18
	
			// Properties
			public object Current { get; } // 0x0000000181EABC00-0x0000000181EABC40 
	
			// Constructors
			public ZipEntryEnumerator(ZipEntry[] entries); // 0x0000000181188B60-0x0000000181188B90
	
			// Methods
			public void Reset(); // 0x00000001810467B0-0x00000001810467C0
			public bool MoveNext(); // 0x0000000181EABBD0-0x0000000181EABC00
		}
	
		private class PartialInputStream : Stream // TypeDefIndex: 7731
		{
			// Fields
			private ZipFile zipFile_; // 0x28
			private Stream baseStream_; // 0x30
			private long start_; // 0x38
			private long length_; // 0x40
			private long readPos_; // 0x48
			private long end_; // 0x50
	
			// Properties
			public override long Position { get; set; } // 0x0000000181EA42E0-0x0000000181EA42F0 0x0000000181EA42F0-0x0000000181EA43A0
			public override long Length { get; } // 0x00000001803C7290-0x00000001803C72A0 
			public override bool CanWrite { get; } // 0x0000000180380950-0x0000000180380960 
			public override bool CanSeek { get; } // 0x0000000180380B60-0x0000000180380B70 
			public override bool CanRead { get; } // 0x0000000180380B60-0x0000000180380B70 
	
			// Constructors
			public PartialInputStream(ZipFile zipFile, long start, long length); // 0x0000000181EA4230-0x0000000181EA42E0
	
			// Methods
			public override int ReadByte(); // 0x0000000181EA3E40-0x0000000181EA3F60
			public override void Close(); // 0x00000001803774A0-0x00000001803774B0
			public override int Read(byte[] buffer, int offset, int count); // 0x0000000181EA3F60-0x0000000181EA40B0
			public override void Write(byte[] buffer, int offset, int count); // 0x0000000181EA41E0-0x0000000181EA4230
			public override void SetLength(long value); // 0x0000000181EA4190-0x0000000181EA41E0
			public override long Seek(long offset, SeekOrigin origin); // 0x0000000181EA40B0-0x0000000181EA4190
			public override void Flush(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public ZipFile(FileStream file); // 0x0000000181EB0410-0x0000000181EB05D0
	
		// Methods
		private void OnKeysRequired(string fileName); // 0x0000000181EAE820-0x0000000181EAE900
		~ZipFile(); // 0x00000001804575C0-0x0000000180457660
		public void Close(); // 0x0000000181EAD500-0x0000000181EAD560
		public IEnumerator GetEnumerator(); // 0x0000000181EADE20-0x0000000181EADEC0
		public int FindEntry(string name, bool ignoreCase); // 0x0000000181EADCC0-0x0000000181EADE20
		public Stream GetInputStream(ZipEntry entry); // 0x0000000181EADEC0-0x0000000181EAE1A0
		public Stream GetInputStream(long entryIndex); // 0x0000000181EAE1A0-0x0000000181EAE610
		private long TestLocalHeader(ZipEntry entry, HeaderTest tests); // 0x0000000181EAF510-0x0000000181EB0410
		private void PostUpdateCleanup(); // 0x0000000181EAE900-0x0000000181EAE960
		void IDisposable.Dispose(); // 0x0000000181EAD500-0x0000000181EAD560
		private void DisposeInternal(bool disposing); // 0x0000000181EADB40-0x0000000181EADCB0
		protected virtual void Dispose(bool disposing); // 0x0000000181EADCB0-0x0000000181EADCC0
		private ushort ReadLEUshort(); // 0x0000000181EAF420-0x0000000181EAF510
		private uint ReadLEUint(); // 0x0000000181EAF360-0x0000000181EAF3A0
		private ulong ReadLEUlong(); // 0x0000000181EAF3A0-0x0000000181EAF420
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData); // 0x0000000181EAE610-0x0000000181EAE810
		private void ReadEntries(); // 0x0000000181EAE960-0x0000000181EAF360
		private long LocateEntry(ZipEntry entry); // 0x0000000181EAE810-0x0000000181EAE820
		private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry); // 0x0000000181EAD560-0x0000000181EADB40
		private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry); // 0x0000000181EAD420-0x0000000181EAD500
	}
}
