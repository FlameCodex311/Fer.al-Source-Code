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
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 8795
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint m_GlyphIndex; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x0000000180004180-0x0000000180004190 0x0000000180004650-0x0000000180004660
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x000000018020ADB0-0x000000018020ADC0 0x000000018020ADC0-0x000000018020ADD0
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x000000018020AD70-0x000000018020AD80
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x000000018020AD80-0x000000018020ADB0
	}
}
