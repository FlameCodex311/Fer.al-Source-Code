/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal sealed class EnumNameValueCache<TEnum> // TypeDefIndex: 7078
		where TEnum : struct, IComparable, IFormattable
	{
		// Fields
		private static EnumNameValueCache<TEnum> cgQSKcLQtQfbpbkhJZbwNacwBwhD;
		private readonly ADictionary<string, TEnum> CUrJNaZhqqqBMbHtTsHDIviUqFc;
		private readonly string[] jxdcgvDAxvmxryXjKrUVKLjFIuy;
		private readonly long[] DOGjWfNqXhJwrYMCygTRCsZHQkS;
	
		// Properties
		public static EnumNameValueCache<TEnum> Default { get; }
		public int Count { get; }
	
		// Constructors
		private EnumNameValueCache();
	
		// Methods
		public static void Free();
		public TEnum GetValue(string name);
		public bool TryGetValue(string name, out TEnum value);
		public string GetName(long value);
		public bool TryGetName(long value, out string name);
		public TEnum GetValueAt(int index);
		public string GetNameAt(int index);
		public int IndexOf(string name);
		public int IndexOf(long value);
		public bool Contains(string name);
		public bool Contains(long value);
	}
}
