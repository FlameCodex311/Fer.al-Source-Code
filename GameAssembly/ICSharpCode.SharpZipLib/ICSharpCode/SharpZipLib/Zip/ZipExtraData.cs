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
	public sealed class ZipExtraData : IDisposable // TypeDefIndex: 7559
	{
		// Fields
		private int _index; // 0x10
		private int _readValueStart; // 0x14
		private int _readValueLength; // 0x18
		private MemoryStream _newEntry; // 0x20
		private byte[] _data; // 0x28
	
		// Properties
		public int ValueLength { get; } // 0x0000000180367710-0x0000000180367720 
		public int UnreadCount { get; } // 0x0000000180D66170-0x0000000180D66200 
	
		// Constructors
		public ZipExtraData(byte[] data); // 0x0000000180D66100-0x0000000180D66170
	
		// Methods
		public bool Find(int headerID); // 0x0000000180D65BA0-0x0000000180D65C70
		public long ReadLong(); // 0x0000000180D65F00-0x0000000180D65F50
		public int ReadInt(); // 0x0000000180D65DF0-0x0000000180D65F00
		public int ReadShort(); // 0x0000000180D66040-0x0000000180D660D0
		public int ReadByte(); // 0x0000000180D65C70-0x0000000180D65CE0
		public void Skip(int amount); // 0x0000000180D660D0-0x0000000180D66100
		private void ReadCheck(int length); // 0x0000000180D65CE0-0x0000000180D65DF0
		private int ReadShortInternal(); // 0x0000000180D65F50-0x0000000180D66040
		public void Dispose(); // 0x0000000180D65B80-0x0000000180D65BA0
	}
}
