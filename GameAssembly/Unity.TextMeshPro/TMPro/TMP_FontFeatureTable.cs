/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 8798
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8799
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001810E42F0-0x00000001810E4350
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x00000001810E3FB0-0x00000001810E3FD0
			internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x00000001810E3FD0-0x00000001810E3FF0
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x00000001810D2090-0x00000001810D2290
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x00000001810D1EB0-0x00000001810D2090
	}
}
