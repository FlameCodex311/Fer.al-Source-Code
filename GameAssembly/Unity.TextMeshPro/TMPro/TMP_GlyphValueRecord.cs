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
	public struct TMP_GlyphValueRecord // TypeDefIndex: 8958
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_XPlacement; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_YPlacement; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_XAdvance; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; set; } // 0x00000001800076A0-0x00000001800076B0 0x00000001800076C0-0x00000001800076D0
		public float yPlacement { get; set; } // 0x00000001800076B0-0x00000001800076C0 0x00000001800076D0-0x00000001800079C0
		public float xAdvance { get; set; } // 0x0000000180006DE0-0x0000000180006DF0 0x0000000180006E20-0x0000000180006E30
		public float yAdvance { get; set; } // 0x0000000180006DF0-0x0000000180006E00 0x0000000180006E30-0x0000000180006E60
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x0000000180007650-0x0000000180007670
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x0000000180007670-0x00000001800076A0
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x0000000180007140-0x00000001800071A0
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x000000018057D230-0x000000018057D250
	}
}
