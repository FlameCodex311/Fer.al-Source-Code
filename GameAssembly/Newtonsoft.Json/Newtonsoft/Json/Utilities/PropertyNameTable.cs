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
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class PropertyNameTable // TypeDefIndex: 7832
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		private class Entry // TypeDefIndex: 7833
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			internal Entry(string value, int hashCode, Entry next); // 0x0000000180588CA0-0x0000000180588CF0
		}
	
		// Constructors
		static PropertyNameTable(); // 0x0000000180595110-0x0000000180595150
		public PropertyNameTable(); // 0x0000000180595150-0x00000001805951A0
	
		// Methods
		public string Get(char[] key, int start, int length); // 0x0000000180594C90-0x0000000180594EE0
		public string Add(string key); // 0x0000000180594AE0-0x0000000180594C90
		private string AddEntry(string str, int hashCode); // 0x0000000180594850-0x0000000180594AE0
		private void Grow(); // 0x0000000180594EE0-0x0000000180595060
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length); // 0x0000000180595060-0x0000000180595110
	}
}
