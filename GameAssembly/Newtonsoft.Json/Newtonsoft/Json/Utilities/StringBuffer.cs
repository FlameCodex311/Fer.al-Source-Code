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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal struct StringBuffer // TypeDefIndex: 8039
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get; set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public bool IsEmpty { get; } // 0x00000001800A6550-0x00000001800A6560 
		public char[] InternalBuffer { get; } // 0x000000018001A8D0-0x000000018001A8E0 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize); // 0x00000001801449A0-0x00000001801449D0
		private StringBuffer(char[] buffer); // 0x00000001801449D0-0x0000000180144B00
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value); // 0x0000000180144700-0x00000001801447C0
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count); // 0x00000001801447C0-0x0000000180144890
		public void Clear(IArrayPool<char> bufferPool); // 0x0000000180144890-0x00000001801448D0
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength); // 0x00000001801448D0-0x0000000180144940
		public override string ToString(); // 0x0000000180144970-0x00000001801449A0
		public string ToString(int start, int length); // 0x0000000180144940-0x0000000180144970
	}
}
