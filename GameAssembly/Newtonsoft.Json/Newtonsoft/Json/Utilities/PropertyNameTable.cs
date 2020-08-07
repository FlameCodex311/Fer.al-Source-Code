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
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class PropertyNameTable // TypeDefIndex: 7998
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		private class Entry // TypeDefIndex: 7999
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			internal Entry(string value, int hashCode, Entry next); // 0x000000018065F880-0x000000018065F8D0
		}
	
		// Constructors
		static PropertyNameTable(); // 0x0000000180C2D250-0x0000000180C2D290
		public PropertyNameTable(); // 0x0000000180C2D290-0x0000000180C2D2E0
	
		// Methods
		public string Get(char[] key, int start, int length); // 0x0000000180C2CDF0-0x0000000180C2D030
		public string Add(string key); // 0x0000000180C2CC40-0x0000000180C2CDF0
		private string AddEntry(string str, int hashCode); // 0x0000000180C2C9D0-0x0000000180C2CC40
		private void Grow(); // 0x0000000180C2D030-0x0000000180C2D1A0
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length); // 0x0000000180C2D1A0-0x0000000180C2D250
	}
}
