/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public sealed class fsData // TypeDefIndex: 9118
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x00000001818EE430-0x00000001818EE5F0 
		public bool IsNull { get; } // 0x0000000180BB2860-0x0000000180BB2870 
		public bool IsDouble { get; } // 0x00000001818EE270-0x00000001818EE2C0 
		public bool IsInt64 { get; } // 0x00000001818EE2C0-0x00000001818EE310 
		public bool IsUInt64 { get; } // 0x00000001818EE3E0-0x00000001818EE430 
		public bool IsBool { get; } // 0x00000001818EE1A0-0x00000001818EE1F0 
		public bool IsString { get; } // 0x00000001818EE390-0x00000001818EE3E0 
		public bool IsDictionary { get; } // 0x00000001818EE1F0-0x00000001818EE270 
		public bool IsList { get; } // 0x00000001818EE310-0x00000001818EE390 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public double AsDouble { get; } // 0x00000001818EE060-0x00000001818EE0A0 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public long AsInt64 { get; } // 0x00000001818EE0A0-0x00000001818EE0E0 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public ulong AsUInt64 { get; } // 0x00000001818EE160-0x00000001818EE1A0 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public bool AsBool { get; } // 0x00000001818EDFE0-0x00000001818EE020 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public string AsString { get; } // 0x00000001818EE120-0x00000001818EE160 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public Dictionary<string, fsData> AsDictionary { get; } // 0x00000001818EE020-0x00000001818EE060 
		[DebuggerBrowsable] // 0x00000001800E9820-0x00000001800E9840
		public List<fsData> AsList { get; } // 0x00000001818EE0E0-0x00000001818EE120 
	
		// Constructors
		public fsData(); // 0x00000001807F6BC0-0x00000001807F6BE0
		public fsData(bool boolean); // 0x00000001818EDF20-0x00000001818EDF80
		public fsData(double f); // 0x00000001818EDEC0-0x00000001818EDF20
		public fsData(long i); // 0x00000001818EDE60-0x00000001818EDEC0
		public fsData(ulong i); // 0x00000001818EDF80-0x00000001818EDFE0
		public fsData(string str); // 0x000000018037D3F0-0x000000018037D420
		public fsData(Dictionary<string, fsData> dict); // 0x000000018037D3F0-0x000000018037D420
		public fsData(List<fsData> list); // 0x000000018037D3F0-0x000000018037D420
		static fsData(); // 0x00000001818EDD40-0x00000001818EDE60
	
		// Methods
		public static fsData CreateDictionary(); // 0x00000001818ED5C0-0x00000001818ED6B0
		public static fsData CreateList(); // 0x00000001818ED730-0x00000001818ED7A0
		public static fsData CreateList(int capacity); // 0x00000001818ED6B0-0x00000001818ED730
		internal void BecomeDictionary(); // 0x00000001818ED500-0x00000001818ED560
		internal fsData Clone(); // 0x00000001818ED560-0x00000001818ED5C0
		private T Cast<T>();
		public override string ToString(); // 0x00000001818EDD30-0x00000001818EDD40
		public override bool Equals(object obj); // 0x00000001818EDCD0-0x00000001818EDD30
		public bool Equals(fsData other); // 0x00000001818ED7A0-0x00000001818EDCD0
		public static bool operator ==(fsData a, fsData b); // 0x00000001818EE5F0-0x00000001818EE700
		public static bool operator !=(fsData a, fsData b); // 0x00000001818EE700-0x00000001818EE770
		public override int GetHashCode(); // 0x000000018075E590-0x000000018075E5C0
	}
}
