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
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 8959
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint m_GlyphIndex; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x0000000180004EC0-0x0000000180004ED0 0x0000000180007630-0x0000000180007640
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x0000000180007620-0x0000000180007630 0x0000000180007640-0x0000000180007650
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x00000001800075E0-0x00000001800075F0
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x00000001800075F0-0x0000000180007620
	}
}
