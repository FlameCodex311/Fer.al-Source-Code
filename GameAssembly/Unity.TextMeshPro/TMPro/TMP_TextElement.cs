/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 9029
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TextElementType m_ElementType; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint m_Unicode; // 0x14
		private Glyph m_Glyph; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint m_GlyphIndex; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_Scale; // 0x24
	
		// Properties
		public TextElementType elementType { get; } // 0x00000001803FD450-0x00000001803FD460 
		public uint unicode { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public Glyph glyph { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public uint glyphIndex { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
		public float scale { get; set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018094A6A0-0x000000018094A6B0
	
		// Constructors
		public TMP_TextElement(); // 0x0000000180373240-0x0000000180373250
	}
}
