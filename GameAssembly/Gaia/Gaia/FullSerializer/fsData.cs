/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public sealed class fsData // TypeDefIndex: 9290
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x0000000181513F70-0x0000000181514130 
		public bool IsNull { get; } // 0x00000001811AE400-0x00000001811AE410 
		public bool IsDouble { get; } // 0x0000000181513DB0-0x0000000181513E00 
		public bool IsInt64 { get; } // 0x0000000181513E00-0x0000000181513E50 
		public bool IsUInt64 { get; } // 0x0000000181513F20-0x0000000181513F70 
		public bool IsBool { get; } // 0x0000000181513CE0-0x0000000181513D30 
		public bool IsString { get; } // 0x0000000181513ED0-0x0000000181513F20 
		public bool IsDictionary { get; } // 0x0000000181513D30-0x0000000181513DB0 
		public bool IsList { get; } // 0x0000000181513E50-0x0000000181513ED0 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public double AsDouble { get; } // 0x0000000181513BA0-0x0000000181513BE0 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public long AsInt64 { get; } // 0x0000000181513BE0-0x0000000181513C20 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public ulong AsUInt64 { get; } // 0x0000000181513CA0-0x0000000181513CE0 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public bool AsBool { get; } // 0x0000000181513B20-0x0000000181513B60 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public string AsString { get; } // 0x0000000181513C60-0x0000000181513CA0 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public Dictionary<string, fsData> AsDictionary { get; } // 0x0000000181513B60-0x0000000181513BA0 
		[DebuggerBrowsable] // 0x00000001801ED1E0-0x00000001801ED200
		public List<fsData> AsList { get; } // 0x0000000181513C20-0x0000000181513C60 
	
		// Constructors
		public fsData(); // 0x0000000180880A40-0x0000000180880A60
		public fsData(bool boolean); // 0x0000000181513A60-0x0000000181513AC0
		public fsData(double f); // 0x0000000181513A00-0x0000000181513A60
		public fsData(long i); // 0x00000001815139A0-0x0000000181513A00
		public fsData(ulong i); // 0x0000000181513AC0-0x0000000181513B20
		public fsData(string str); // 0x0000000180400150-0x0000000180400180
		public fsData(Dictionary<string, fsData> dict); // 0x0000000180400150-0x0000000180400180
		public fsData(List<fsData> list); // 0x0000000180400150-0x0000000180400180
		static fsData(); // 0x0000000181513880-0x00000001815139A0
	
		// Methods
		public static fsData CreateDictionary(); // 0x0000000181513110-0x0000000181513200
		public static fsData CreateList(); // 0x0000000181513280-0x00000001815132F0
		public static fsData CreateList(int capacity); // 0x0000000181513200-0x0000000181513280
		internal void BecomeDictionary(); // 0x0000000181513050-0x00000001815130B0
		internal fsData Clone(); // 0x00000001815130B0-0x0000000181513110
		private T Cast<T>();
		public override string ToString(); // 0x0000000181513870-0x0000000181513880
		public override bool Equals(object obj); // 0x0000000181513810-0x0000000181513870
		public bool Equals(fsData other); // 0x00000001815132F0-0x0000000181513810
		public static bool operator ==(fsData a, fsData b); // 0x0000000181514130-0x0000000181514240
		public static bool operator !=(fsData a, fsData b); // 0x0000000181514240-0x00000001815142B0
		public override int GetHashCode(); // 0x000000018076A540-0x000000018076A570
	}
}
