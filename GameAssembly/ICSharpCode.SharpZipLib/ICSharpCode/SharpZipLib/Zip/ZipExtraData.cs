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
	public sealed class ZipExtraData : IDisposable // TypeDefIndex: 7725
	{
		// Fields
		private int _index; // 0x10
		private int _readValueStart; // 0x14
		private int _readValueLength; // 0x18
		private MemoryStream _newEntry; // 0x20
		private byte[] _data; // 0x28
	
		// Properties
		public int ValueLength { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public int UnreadCount { get; } // 0x0000000181EAD3A0-0x0000000181EAD420 
	
		// Constructors
		public ZipExtraData(byte[] data); // 0x0000000181EAD330-0x0000000181EAD3A0
	
		// Methods
		public bool Find(int headerID); // 0x0000000181EACDF0-0x0000000181EACEC0
		public long ReadLong(); // 0x0000000181EAD140-0x0000000181EAD190
		public int ReadInt(); // 0x0000000181EAD040-0x0000000181EAD140
		public int ReadShort(); // 0x0000000181EAD270-0x0000000181EAD300
		public int ReadByte(); // 0x0000000181EACEC0-0x0000000181EACF30
		public void Skip(int amount); // 0x0000000181EAD300-0x0000000181EAD330
		private void ReadCheck(int length); // 0x0000000181EACF30-0x0000000181EAD040
		private int ReadShortInternal(); // 0x0000000181EAD190-0x0000000181EAD270
		public void Dispose(); // 0x0000000181EACDD0-0x0000000181EACDF0
	}
}
