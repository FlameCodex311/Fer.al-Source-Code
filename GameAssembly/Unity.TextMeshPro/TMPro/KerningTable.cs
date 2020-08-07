/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class KerningTable // TypeDefIndex: 8948
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 8949
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <AddKerningPair>b__0(KerningPair item); // 0x000000018058E600-0x000000018058E630
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 8950
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item); // 0x000000018058E600-0x000000018058E630
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 8951
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveKerningPair>b__0(KerningPair item); // 0x000000018058E630-0x000000018058E670
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8952
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<KerningPair, uint> <>9__7_0; // 0x08
			public static Func<KerningPair, uint> <>9__7_1; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018058E820-0x000000018058E880
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal uint <SortKerningPairs>b__7_0(KerningPair s); // 0x000000018058E5C0-0x000000018058E5E0
			internal uint <SortKerningPairs>b__7_1(KerningPair s); // 0x000000018058E5E0-0x000000018058E600
		}
	
		// Constructors
		public KerningTable(); // 0x0000000180569D20-0x0000000180569D80
	
		// Methods
		public void AddKerningPair(); // 0x0000000180569760-0x00000001805698D0
		public int AddKerningPair(uint first, uint second, float offset); // 0x00000001805698D0-0x0000000180569A00
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x0000000180569620-0x0000000180569760
		public void RemoveKerningPair(int left, int right); // 0x0000000180569A60-0x0000000180569B50
		public void RemoveKerningPair(int index); // 0x0000000180569A00-0x0000000180569A60
		public void SortKerningPairs(); // 0x0000000180569B50-0x0000000180569D20
	}
}
