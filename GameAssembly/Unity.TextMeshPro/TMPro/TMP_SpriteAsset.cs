/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 9005
	{
		// Fields
		internal Dictionary<uint, int> m_UnicodeLookup; // 0x30
		internal Dictionary<int, int> m_NameLookup; // 0x38
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_Version; // 0x48
		public Texture spriteSheet; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0x60
		public List<TMP_Sprite> spriteInfoList; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0x70
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0x78
		private static List<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get; internal set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x00000001805AD4A0-0x00000001805AD4D0 0x00000001803A1740-0x00000001803A1750
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9006
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> <>9__32_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> <>9__33_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001805CEC10-0x00000001805CEC70
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item); // 0x000000018058E5A0-0x000000018058E5C0
			internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c); // 0x000000018058E540-0x000000018058E560
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x00000001805AD420-0x00000001805AD4A0
	
		// Methods
		private void Awake(); // 0x00000001805AB9B0-0x00000001805ABA30
		private Material GetDefaultSpriteMaterial(); // 0x00000001805ABA30-0x00000001805ABB00
		public void UpdateLookupTables(); // 0x00000001805ACA70-0x00000001805ACE80
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x00000001805ABB00-0x00000001805ABB80
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x00000001805ABC60-0x00000001805ABCE0
		public int GetSpriteIndexFromName(string name); // 0x00000001805ABB80-0x00000001805ABC60
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001805AC3F0-0x00000001805AC620
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001805AC230-0x00000001805AC3F0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001805AC180-0x00000001805AC230
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x00000001805ABF50-0x00000001805AC180
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001805ABD90-0x00000001805ABF50
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001805ABCE0-0x00000001805ABD90
		public void SortGlyphTable(); // 0x00000001805AC950-0x00000001805ACA70
		internal void SortCharacterTable(); // 0x00000001805AC620-0x00000001805AC740
		internal void SortGlyphAndCharacterTables(); // 0x00000001805AC740-0x00000001805AC950
		private void UpgradeSpriteAsset(); // 0x00000001805ACE80-0x00000001805AD420
	}
}
