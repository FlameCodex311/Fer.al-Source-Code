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

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipFile : IEnumerable, IDisposable // TypeDefIndex: 7561
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
		public string Password { set; } // 0x0000000180D69500-0x0000000180D69650
		private bool HaveKeys { get; } // 0x0000000180D694F0-0x0000000180D69500 
		public bool IsStreamOwner { get; set; } // 0x0000000180478660-0x0000000180478670 0x00000001807009C0-0x00000001807009D0
		public long Count { get; } // 0x0000000180D694D0-0x0000000180D694F0 
	
		// Nested types
		public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e); // TypeDefIndex: 7562; 0x0000000180463900-0x0000000180464110
	
		[Flags] // 0x00000001800B36B0-0x00000001800B36C0
		private enum HeaderTest // TypeDefIndex: 7563
		{
			Extract = 1,
			Header = 2
		}
	
		private class ZipEntryEnumerator : IEnumerator // TypeDefIndex: 7564
		{
			// Fields
			private ZipEntry[] array; // 0x10
			private int index; // 0x18
	
			// Properties
			public object Current { get; } // 0x0000000180D64970-0x0000000180D649B0 
	
			// Constructors
			public ZipEntryEnumerator(ZipEntry[] entries); // 0x000000018084ED20-0x000000018084ED50
	
			// Methods
			public void Reset(); // 0x00000001807813B0-0x00000001807813C0
			public bool MoveNext(); // 0x0000000180D64940-0x0000000180D64970
		}
	
		private class PartialInputStream : Stream // TypeDefIndex: 7565
		{
			// Fields
			private ZipFile zipFile_; // 0x28
			private Stream baseStream_; // 0x30
			private long start_; // 0x38
			private long length_; // 0x40
			private long readPos_; // 0x48
			private long end_; // 0x50
	
			// Properties
			public override long Position { get; set; } // 0x0000000180D5C9C0-0x0000000180D5C9D0 0x0000000180D5C9D0-0x0000000180D5CA90
			public override long Length { get; } // 0x0000000180369B30-0x0000000180369B40 
			public override bool CanWrite { get; } // 0x00000001803C28F0-0x00000001803C2900 
			public override bool CanSeek { get; } // 0x00000001803C29F0-0x00000001803C2A00 
			public override bool CanRead { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
			// Constructors
			public PartialInputStream(ZipFile zipFile, long start, long length); // 0x0000000180D5C910-0x0000000180D5C9C0
	
			// Methods
			public override int ReadByte(); // 0x0000000180D5C510-0x0000000180D5C640
			public override void Close(); // 0x00000001803581E0-0x00000001803581F0
			public override int Read(byte[] buffer, int offset, int count); // 0x0000000180D5C640-0x0000000180D5C790
			public override void Write(byte[] buffer, int offset, int count); // 0x0000000180D5C8C0-0x0000000180D5C910
			public override void SetLength(long value); // 0x0000000180D5C870-0x0000000180D5C8C0
			public override long Seek(long offset, SeekOrigin origin); // 0x0000000180D5C790-0x0000000180D5C870
			public override void Flush(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public ZipFile(FileStream file); // 0x0000000180D69300-0x0000000180D694D0
	
		// Methods
		private void OnKeysRequired(string fileName); // 0x0000000180D676A0-0x0000000180D67780
		~ZipFile(); // 0x000000018072E430-0x000000018072E4D0
		public void Close(); // 0x0000000180D662F0-0x0000000180D66350
		public IEnumerator GetEnumerator(); // 0x0000000180D66C50-0x0000000180D66CF0
		public int FindEntry(string name, bool ignoreCase); // 0x0000000180D66AE0-0x0000000180D66C50
		public Stream GetInputStream(ZipEntry entry); // 0x0000000180D66CF0-0x0000000180D66FE0
		public Stream GetInputStream(long entryIndex); // 0x0000000180D66FE0-0x0000000180D67480
		private long TestLocalHeader(ZipEntry entry, HeaderTest tests); // 0x0000000180D683B0-0x0000000180D69300
		private void PostUpdateCleanup(); // 0x0000000180D67780-0x0000000180D677E0
		void IDisposable.Dispose(); // 0x0000000180D662F0-0x0000000180D66350
		private void DisposeInternal(bool disposing); // 0x0000000180D66960-0x0000000180D66AD0
		protected virtual void Dispose(bool disposing); // 0x0000000180D66AD0-0x0000000180D66AE0
		private ushort ReadLEUshort(); // 0x0000000180D682C0-0x0000000180D683B0
		private uint ReadLEUint(); // 0x0000000180D68200-0x0000000180D68240
		private ulong ReadLEUlong(); // 0x0000000180D68240-0x0000000180D682C0
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData); // 0x0000000180D67480-0x0000000180D67690
		private void ReadEntries(); // 0x0000000180D677E0-0x0000000180D68200
		private long LocateEntry(ZipEntry entry); // 0x0000000180D67690-0x0000000180D676A0
		private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry); // 0x0000000180D66350-0x0000000180D66960
		private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry); // 0x0000000180D66200-0x0000000180D662F0
	}
}
