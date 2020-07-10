/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class KerningTable // TypeDefIndex: 8786
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 8787
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <AddKerningPair>b__0(KerningPair item); // 0x00000001810E4060-0x00000001810E4090
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 8788
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item); // 0x00000001810E4060-0x00000001810E4090
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 8789
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoveKerningPair>b__0(KerningPair item); // 0x00000001810E4090-0x00000001810E40D0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8790
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<KerningPair, uint> <>9__7_0; // 0x08
			public static Func<KerningPair, uint> <>9__7_1; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001810E4290-0x00000001810E42F0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal uint <SortKerningPairs>b__7_0(KerningPair s); // 0x00000001810E4020-0x00000001810E4040
			internal uint <SortKerningPairs>b__7_1(KerningPair s); // 0x00000001810E4040-0x00000001810E4060
		}
	
		// Constructors
		public KerningTable(); // 0x00000001810BF0F0-0x00000001810BF150
	
		// Methods
		public void AddKerningPair(); // 0x00000001810BEB10-0x00000001810BEC80
		public int AddKerningPair(uint first, uint second, float offset); // 0x00000001810BEC80-0x00000001810BEDC0
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x00000001810BE9C0-0x00000001810BEB10
		public void RemoveKerningPair(int left, int right); // 0x00000001810BEE20-0x00000001810BEF10
		public void RemoveKerningPair(int index); // 0x00000001810BEDC0-0x00000001810BEE20
		public void SortKerningPairs(); // 0x00000001810BEF10-0x00000001810BF0F0
	}
}
