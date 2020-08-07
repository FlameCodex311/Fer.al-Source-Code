/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 8960
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x000000018057D1D0-0x000000018057D1F0 0x000000018057D210-0x000000018057D220
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x000000018057D1F0-0x000000018057D210 0x000000018057D220-0x000000018057D230
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x000000018057D1C0-0x000000018057D1D0 0x000000018041B190-0x000000018041B1A0
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x000000018057CFA0-0x000000018057CFF0
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x000000018057CFF0-0x000000018057D1C0
	}
}
