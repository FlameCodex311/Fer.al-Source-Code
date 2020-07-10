/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsData // TypeDefIndex: 15306
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x000000018138D5E0-0x000000018138D780 
		public bool IsNull { get; } // 0x0000000180BB2860-0x0000000180BB2870 
		public bool IsDouble { get; } // 0x000000018138D470-0x000000018138D4C0 
		public bool IsInt64 { get; } // 0x000000018138D4C0-0x000000018138D510 
		public bool IsBool { get; } // 0x000000018138D3A0-0x000000018138D3F0 
		public bool IsString { get; } // 0x000000018138D590-0x000000018138D5E0 
		public bool IsDictionary { get; } // 0x000000018138D3F0-0x000000018138D470 
		public bool IsList { get; } // 0x000000018138D510-0x000000018138D590 
		public double AsDouble { get; } // 0x000000018138D2A0-0x000000018138D2E0 
		public long AsInt64 { get; } // 0x000000018138D2E0-0x000000018138D320 
		public bool AsBool { get; } // 0x000000018138D220-0x000000018138D260 
		public string AsString { get; } // 0x000000018138D360-0x000000018138D3A0 
		public Dictionary<string, fsData> AsDictionary { get; } // 0x000000018138D260-0x000000018138D2A0 
		public List<fsData> AsList { get; } // 0x000000018138D320-0x000000018138D360 
	
		// Constructors
		public fsData(); // 0x00000001807F6BC0-0x00000001807F6BE0
		public fsData(bool boolean); // 0x000000018138D160-0x000000018138D1C0
		public fsData(double f); // 0x000000018138D100-0x000000018138D160
		public fsData(long i); // 0x000000018138D1C0-0x000000018138D220
		public fsData(string str); // 0x000000018037D3F0-0x000000018037D420
		public fsData(Dictionary<string, fsData> dict); // 0x000000018037D3F0-0x000000018037D420
		public fsData(List<fsData> list); // 0x000000018037D3F0-0x000000018037D420
		static fsData(); // 0x000000018138CFE0-0x000000018138D100
	
		// Methods
		public static fsData CreateDictionary(); // 0x000000018138C7F0-0x000000018138C980
		public static fsData CreateList(); // 0x000000018138C980-0x000000018138C9F0
		public static fsData CreateList(int capacity); // 0x000000018138C9F0-0x000000018138CA70
		internal void BecomeDictionary(); // 0x000000018138C6B0-0x000000018138C790
		internal fsData Clone(); // 0x000000018138C790-0x000000018138C7F0
		private T Cast<T>();
		public override string ToString(); // 0x000000018138CFD0-0x000000018138CFE0
		public override bool Equals(object obj); // 0x000000018138CA70-0x000000018138CAD0
		public bool Equals(fsData other); // 0x000000018138CAD0-0x000000018138CFD0
		public static bool operator ==(fsData a, fsData b); // 0x000000018138D780-0x000000018138D890
		public static bool operator !=(fsData a, fsData b); // 0x000000018138D890-0x000000018138D900
		public override int GetHashCode(); // 0x000000018075E590-0x000000018075E5C0
	}
}
