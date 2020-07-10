/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 8867
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TextElementType m_ElementType; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint m_Unicode; // 0x14
		private Glyph m_Glyph; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint m_GlyphIndex; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_Scale; // 0x24
	
		// Properties
		public TextElementType elementType { get; } // 0x0000000180375540-0x0000000180375550 
		public uint unicode { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		public Glyph glyph { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public uint glyphIndex { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public float scale { get; set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001811F74C0-0x00000001811F74D0
	
		// Constructors
		public TMP_TextElement(); // 0x000000018036B6C0-0x000000018036B6D0
	}
}
