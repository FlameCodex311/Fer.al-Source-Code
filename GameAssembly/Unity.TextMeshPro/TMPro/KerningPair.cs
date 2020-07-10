/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class KerningPair // TypeDefIndex: 8785
	{
		// Fields
		[FormerlySerializedAs] // 0x0000000180149A50-0x0000000180149AA0
		[SerializeField] // 0x0000000180149A50-0x0000000180149AA0
		private uint m_FirstGlyph; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		[FormerlySerializedAs] // 0x0000000180149E80-0x0000000180149ED0
		[SerializeField] // 0x0000000180149E80-0x0000000180149ED0
		private uint m_SecondGlyph; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		[FormerlySerializedAs] // 0x000000018014A220-0x000000018014A250
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x00000001810BE9B0-0x00000001810BE9C0 
		public uint secondGlyph { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x000000018036CB50-0x000000018036CB60 
		public bool ignoreSpacingAdjustments { get; } // 0x0000000180736E00-0x0000000180736E10 
	
		// Constructors
		public KerningPair(); // 0x00000001810BE980-0x00000001810BE9B0
		public KerningPair(uint left, uint right, float offset); // 0x00000001810BE930-0x00000001810BE980
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x00000001810BE8D0-0x00000001810BE930
		static KerningPair(); // 0x00000001810BE850-0x00000001810BE8D0
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x00000001810BE840-0x00000001810BE850
	}
}
