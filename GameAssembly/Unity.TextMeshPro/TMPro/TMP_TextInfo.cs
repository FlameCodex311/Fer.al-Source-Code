﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_TextInfo // TypeDefIndex: 9031
	{
		// Fields
		private static Vector2 k_InfinityVectorPositive; // 0x00
		private static Vector2 k_InfinityVectorNegative; // 0x08
		public TMP_Text textComponent; // 0x10
		public int characterCount; // 0x18
		public int spriteCount; // 0x1C
		public int spaceCount; // 0x20
		public int wordCount; // 0x24
		public int linkCount; // 0x28
		public int lineCount; // 0x2C
		public int pageCount; // 0x30
		public int materialCount; // 0x34
		public TMP_CharacterInfo[] characterInfo; // 0x38
		public TMP_WordInfo[] wordInfo; // 0x40
		public TMP_LinkInfo[] linkInfo; // 0x48
		public TMP_LineInfo[] lineInfo; // 0x50
		public TMP_PageInfo[] pageInfo; // 0x58
		public TMP_MeshInfo[] meshInfo; // 0x60
		private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68
	
		// Constructors
		public TMP_TextInfo(); // 0x0000000180D39BB0-0x0000000180D39C60
		public TMP_TextInfo(TMP_Text textComponent); // 0x0000000180D39A90-0x0000000180D39BB0
		static TMP_TextInfo(); // 0x0000000180D399E0-0x0000000180D39A90
	
		// Methods
		public void Clear(); // 0x0000000180D392C0-0x0000000180D39350
		public void ClearMeshInfo(bool updateMesh); // 0x0000000180D391A0-0x0000000180D39230
		public void ClearAllMeshInfo(); // 0x0000000180D38DD0-0x0000000180D38E60
		public void ResetVertexLayout(bool isVolumetric); // 0x0000000180D39940-0x0000000180D399E0
		public void ClearUnusedVertices(MaterialReference[] materials); // 0x0000000180D39230-0x0000000180D392C0
		public void ClearLineInfo(); // 0x0000000180D38E60-0x0000000180D391A0
		public TMP_MeshInfo[] CopyMeshInfoVertexData(); // 0x0000000180D39350-0x0000000180D39940
		public static void Resize<T>(ref T[] array, int size);
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
	}
}
