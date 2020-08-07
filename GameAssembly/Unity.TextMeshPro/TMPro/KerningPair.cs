/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class KerningPair // TypeDefIndex: 8947
	{
		// Fields
		[FormerlySerializedAs] // 0x00000001801E2D40-0x00000001801E2D90
		[SerializeField] // 0x00000001801E2D40-0x00000001801E2D90
		private uint m_FirstGlyph; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		[FormerlySerializedAs] // 0x00000001801E30A0-0x00000001801E30F0
		[SerializeField] // 0x00000001801E30A0-0x00000001801E30F0
		private uint m_SecondGlyph; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		[FormerlySerializedAs] // 0x00000001801E3590-0x00000001801E35C0
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x0000000180569600-0x0000000180569610 
		public uint secondGlyph { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x0000000180379E90-0x0000000180379EA0 
		public bool ignoreSpacingAdjustments { get; } // 0x00000001804F1630-0x00000001804F1640 
	
		// Constructors
		public KerningPair(); // 0x00000001805695D0-0x0000000180569600
		public KerningPair(uint left, uint right, float offset); // 0x0000000180569580-0x00000001805695D0
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x0000000180569520-0x0000000180569580
		static KerningPair(); // 0x00000001805694A0-0x0000000180569520
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x0000000180569490-0x00000001805694A0
	}
}
