/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800FC9A0-0x00000001800FC9F0
	internal struct StringReference // TypeDefIndex: 7849
	{
		// Fields
		private readonly char[] _chars; // 0x00
		private readonly int _startIndex; // 0x08
		private readonly int _length; // 0x0C
	
		// Properties
		public char this[int i] { get => default; } // 0x000000018002D5B0-0x000000018002D720 
		public char[] Chars { get; } // 0x0000000180004C30-0x0000000180004C40 
		public int StartIndex { get; } // 0x0000000180004AB0-0x0000000180004AC0 
		public int Length { get; } // 0x00000001800060E0-0x00000001800060F0 
	
		// Constructors
		public StringReference(char[] chars, int startIndex, int length); // 0x000000018002D5A0-0x000000018002D5B0
	
		// Methods
		public override string ToString(); // 0x000000018002D570-0x000000018002D5A0
	}
}
