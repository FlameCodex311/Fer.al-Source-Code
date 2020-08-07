/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsData // TypeDefIndex: 15911
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x00000001811AE460-0x00000001811AE600 
		public bool IsNull { get; } // 0x00000001811AE400-0x00000001811AE410 
		public bool IsDouble { get; } // 0x00000001811AE2E0-0x00000001811AE330 
		public bool IsInt64 { get; } // 0x00000001811AE330-0x00000001811AE380 
		public bool IsBool { get; } // 0x00000001811AE210-0x00000001811AE260 
		public bool IsString { get; } // 0x00000001811AE410-0x00000001811AE460 
		public bool IsDictionary { get; } // 0x00000001811AE260-0x00000001811AE2E0 
		public bool IsList { get; } // 0x00000001811AE380-0x00000001811AE400 
		public double AsDouble { get; } // 0x00000001811AE110-0x00000001811AE150 
		public long AsInt64 { get; } // 0x00000001811AE150-0x00000001811AE190 
		public bool AsBool { get; } // 0x00000001811AE090-0x00000001811AE0D0 
		public string AsString { get; } // 0x00000001811AE1D0-0x00000001811AE210 
		public Dictionary<string, fsData> AsDictionary { get; } // 0x00000001811AE0D0-0x00000001811AE110 
		public List<fsData> AsList { get; } // 0x00000001811AE190-0x00000001811AE1D0 
	
		// Constructors
		public fsData(); // 0x0000000180880A40-0x0000000180880A60
		public fsData(bool boolean); // 0x00000001811ADFD0-0x00000001811AE030
		public fsData(double f); // 0x00000001811ADF70-0x00000001811ADFD0
		public fsData(long i); // 0x00000001811AE030-0x00000001811AE090
		public fsData(string str); // 0x0000000180400150-0x0000000180400180
		public fsData(Dictionary<string, fsData> dict); // 0x0000000180400150-0x0000000180400180
		public fsData(List<fsData> list); // 0x0000000180400150-0x0000000180400180
		static fsData(); // 0x00000001811ADE50-0x00000001811ADF70
	
		// Methods
		public static fsData CreateDictionary(); // 0x00000001811AD670-0x00000001811AD800
		public static fsData CreateList(); // 0x00000001811AD800-0x00000001811AD870
		public static fsData CreateList(int capacity); // 0x00000001811AD870-0x00000001811AD8F0
		internal void BecomeDictionary(); // 0x00000001811AD530-0x00000001811AD610
		internal fsData Clone(); // 0x00000001811AD610-0x00000001811AD670
		private T Cast<T>();
		public override string ToString(); // 0x00000001811ADE40-0x00000001811ADE50
		public override bool Equals(object obj); // 0x00000001811AD8F0-0x00000001811AD950
		public bool Equals(fsData other); // 0x00000001811AD950-0x00000001811ADE40
		public static bool operator ==(fsData a, fsData b); // 0x00000001811AE600-0x00000001811AE710
		public static bool operator !=(fsData a, fsData b); // 0x00000001811AE710-0x00000001811AE780
		public override int GetHashCode(); // 0x000000018076A540-0x000000018076A570
	}
}
