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
	public struct TMP_GlyphValueRecord // TypeDefIndex: 8794
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_XPlacement; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_YPlacement; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_XAdvance; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; set; } // 0x000000018001B100-0x000000018001B110 0x0000000180006980-0x0000000180006A00
		public float yPlacement { get; set; } // 0x000000018020AE00-0x000000018020AE10 0x000000018001FC60-0x000000018001FC70
		public float xAdvance { get; set; } // 0x000000018020A590-0x000000018020A5A0 0x000000018001FC20-0x000000018001FC30
		public float yAdvance { get; set; } // 0x000000018020A5A0-0x000000018020A5B0 0x000000018001FC40-0x000000018001FC50
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x0000000180010AB0-0x0000000180010AD0
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x000000018020ADD0-0x000000018020AE00
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x000000018020A8D0-0x000000018020A930
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x000000018079CF00-0x000000018079CF20
	}
}
