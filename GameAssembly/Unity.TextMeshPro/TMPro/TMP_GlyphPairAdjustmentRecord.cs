/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 8796
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x00000001810D2AA0-0x00000001810D2AC0 0x00000001810D2AE0-0x00000001810D2AF0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x00000001810D2AC0-0x00000001810D2AE0 0x00000001810D2AF0-0x00000001810D2B00
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018036C620-0x000000018036C630
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x00000001810D2880-0x00000001810D28D0
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x00000001810D28D0-0x00000001810D2AA0
	}
}
