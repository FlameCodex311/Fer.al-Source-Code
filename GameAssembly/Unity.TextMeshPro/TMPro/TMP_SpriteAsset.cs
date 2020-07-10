/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 8843
	{
		// Fields
		internal Dictionary<uint, int> m_UnicodeLookup; // 0x30
		internal Dictionary<int, int> m_NameLookup; // 0x38
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_Version; // 0x48
		public Texture spriteSheet; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0x60
		public List<TMP_Sprite> spriteInfoList; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0x70
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0x78
		private static List<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get; internal set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x00000001811A8230-0x00000001811A8260 0x0000000180485C70-0x0000000180485C80
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8844
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> <>9__32_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> <>9__33_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001811C9F80-0x00000001811C9FE0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item); // 0x00000001810E3FF0-0x00000001810E4020
			internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c); // 0x00000001810E3F90-0x00000001810E3FB0
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x00000001811A81B0-0x00000001811A8230
	
		// Methods
		private void Awake(); // 0x00000001811A66E0-0x00000001811A6760
		private Material GetDefaultSpriteMaterial(); // 0x00000001811A6760-0x00000001811A6830
		public void UpdateLookupTables(); // 0x00000001811A77C0-0x00000001811A7BE0
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x00000001811A6830-0x00000001811A68B0
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x00000001811A6990-0x00000001811A6A10
		public int GetSpriteIndexFromName(string name); // 0x00000001811A68B0-0x00000001811A6990
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001811A7130-0x00000001811A7370
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001811A6F70-0x00000001811A7130
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001811A6EC0-0x00000001811A6F70
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x00000001811A6C80-0x00000001811A6EC0
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001811A6AC0-0x00000001811A6C80
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001811A6A10-0x00000001811A6AC0
		public void SortGlyphTable(); // 0x00000001811A76A0-0x00000001811A77C0
		internal void SortCharacterTable(); // 0x00000001811A7370-0x00000001811A7490
		internal void SortGlyphAndCharacterTables(); // 0x00000001811A7490-0x00000001811A76A0
		private void UpgradeSpriteAsset(); // 0x00000001811A7BE0-0x00000001811A81B0
	}
}
