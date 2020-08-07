/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 8955
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8956
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018058E880-0x000000018058E8E0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x000000018058E560-0x000000018058E580
			internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x000000018058E580-0x000000018058E5A0
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x000000018057C7C0-0x000000018057C9C0
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x000000018057C5F0-0x000000018057C7C0
	}
}
