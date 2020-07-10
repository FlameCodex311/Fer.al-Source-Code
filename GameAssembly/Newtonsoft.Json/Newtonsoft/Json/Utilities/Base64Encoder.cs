/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class Base64Encoder // TypeDefIndex: 7827
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder(TextWriter writer); // 0x000000018057F1A0-0x000000018057F210
	
		// Methods
		public void Encode(byte[] buffer, int index, int count); // 0x000000018057ECF0-0x000000018057F0A0
		public void Flush(); // 0x000000018057F0A0-0x000000018057F170
		private void WriteChars(char[] chars, int index, int count); // 0x000000018057F170-0x000000018057F1A0
	}
}
