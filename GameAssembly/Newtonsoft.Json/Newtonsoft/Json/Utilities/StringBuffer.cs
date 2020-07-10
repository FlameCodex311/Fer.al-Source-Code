/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal struct StringBuffer // TypeDefIndex: 7873
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get; set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public bool IsEmpty { get; } // 0x000000018000CD20-0x000000018000CD50 
		public char[] InternalBuffer { get; } // 0x0000000180004C30-0x0000000180004C40 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize); // 0x000000018002D3E0-0x000000018002D410
		private StringBuffer(char[] buffer); // 0x000000018002D410-0x000000018002D570
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value); // 0x000000018002D130-0x000000018002D200
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count); // 0x000000018002D200-0x000000018002D2D0
		public void Clear(IArrayPool<char> bufferPool); // 0x000000018002D2D0-0x000000018002D310
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength); // 0x000000018002D310-0x000000018002D380
		public override string ToString(); // 0x000000018002D3B0-0x000000018002D3E0
		public string ToString(int start, int length); // 0x000000018002D380-0x000000018002D3B0
	}
}
