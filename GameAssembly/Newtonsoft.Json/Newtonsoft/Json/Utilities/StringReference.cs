/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000180248D70-0x0000000180248DC0
	internal struct StringReference // TypeDefIndex: 8015
	{
		// Fields
		private readonly char[] _chars; // 0x00
		private readonly int _startIndex; // 0x08
		private readonly int _length; // 0x0C
	
		// Properties
		public char this[int i] { get => default; } // 0x0000000180144B40-0x0000000180144CB0 
		public char[] Chars { get; } // 0x000000018001A8D0-0x000000018001A8E0 
		public int StartIndex { get; } // 0x00000001800213D0-0x00000001800213E0 
		public int Length { get; } // 0x0000000180030DA0-0x0000000180030DB0 
	
		// Constructors
		public StringReference(char[] chars, int startIndex, int length); // 0x0000000180144B30-0x0000000180144B40
	
		// Methods
		public override string ToString(); // 0x0000000180144B00-0x0000000180144B30
	}
}
