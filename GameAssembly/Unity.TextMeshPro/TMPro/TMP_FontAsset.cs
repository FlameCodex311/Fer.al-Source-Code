/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 8777
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_Version; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Font m_SourceFontFile; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FaceInfo m_FaceInfo; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<Glyph> m_GlyphTable; // 0xA8
		private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_Character> m_CharacterTable; // 0xB8
		private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
		private Texture2D m_AtlasTexture; // 0xC8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture2D[] m_AtlasTextures; // 0xD0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal int m_AtlasTextureIndex; // 0xD8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<GlyphRect> m_UsedGlyphRects; // 0xE0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<GlyphRect> m_FreeGlyphRects; // 0xE8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FaceInfo_Legacy m_fontInfo; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Texture2D atlas; // 0xF8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_AtlasWidth; // 0x100
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_AtlasHeight; // 0x104
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_AtlasPadding; // 0x108
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GlyphRenderMode m_AtlasRenderMode; // 0x10C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal List<TMP_Glyph> m_glyphInfoList; // 0x110
		[FormerlySerializedAs] // 0x0000000180148700-0x0000000180148740
		[SerializeField] // 0x0000000180148700-0x0000000180148740
		internal KerningTable m_KerningTable; // 0x118
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_FontAsset> fallbackFontAssets; // 0x128
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal FontAssetCreationSettings m_CreationSettings; // 0x138
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontWeightPair[] fontWeights; // 0x198
		public float normalStyle; // 0x1A0
		public float normalSpacingOffset; // 0x1A4
		public float boldStyle; // 0x1A8
		public float boldSpacing; // 0x1AC
		public byte italicStyle; // 0x1B0
		public byte tabSize; // 0x1B1
		private byte m_oldTabSize; // 0x1B2
		internal bool m_IsFontAssetLookupTablesDirty; // 0x1B3
		private List<Glyph> m_GlyphsToPack; // 0x1B8
		private List<Glyph> m_GlyphsPacked; // 0x1C0
		private List<Glyph> m_GlyphsToRender; // 0x1C8
		private List<uint> m_GlyphIndexList; // 0x1D0
		private List<TMP_Character> m_CharactersToAdd; // 0x1D8
		internal static uint[] s_GlyphIndexArray; // 0x00
		internal static List<uint> s_MissingCharacterList; // 0x08
	
		// Properties
		public string version { get; internal set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public Font sourceFontFile { get; internal set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x0000000180384C10-0x0000000180384C20 0x00000001804D0BE0-0x00000001804D0BF0
		public FaceInfo faceInfo { get; internal set; } // 0x00000001810D1D50-0x00000001810D1D90 0x00000001810D1E60-0x00000001810D1EA0
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x00000001810D1DA0-0x00000001810D1DE0 
		public List<TMP_Character> characterTable { get; internal set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x00000001810D1CC0-0x00000001810D1D00 
		public Texture2D atlasTexture { get; } // 0x00000001810D1C10-0x00000001810D1CC0 
		public Texture2D[] atlasTextures { get; set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x00000001804A0FC0-0x00000001804A0FD0 0x00000001804A0A50-0x00000001804A0A60
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x000000018037A250-0x000000018037A260 0x000000018037AA30-0x000000018037AA40
		[Obsolete] // 0x0000000180149430-0x0000000180149460
		public FaceInfo_Legacy fontInfo { get; } // 0x00000001803BD320-0x00000001803BD330 
		public int atlasWidth { get; internal set; } // 0x0000000180641680-0x0000000180641690 0x0000000180F7D930-0x0000000180F7D940
		public int atlasHeight { get; internal set; } // 0x00000001810D1BE0-0x00000001810D1BF0 0x00000001810D1DE0-0x00000001810D1DF0
		public int atlasPadding { get; internal set; } // 0x00000001810D1BF0-0x00000001810D1C00 0x00000001810D1DF0-0x00000001810D1E00
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x00000001810D1C00-0x00000001810D1C10 0x00000001810D1E00-0x00000001810D1E10
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x00000001803BD3D0-0x00000001803BD3E0 0x00000001803BE5F0-0x00000001803BE600
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x00000001803BD390-0x00000001803BD3A0 0x00000001803BE5B0-0x00000001803BE5C0
		public FontAssetCreationSettings creationSettings { get; set; } // 0x00000001810D1D00-0x00000001810D1D50 0x00000001810D1E10-0x00000001810D1E60
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x00000001810D1D90-0x00000001810D1DA0 0x00000001810D1EA0-0x00000001810D1EB0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8778
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_Character, uint> <>9__100_0; // 0x08
			public static Func<Glyph, uint> <>9__101_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001810E4230-0x00000001810E4290
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal uint <SortCharacterTable>b__100_0(TMP_Character c); // 0x00000001810E3F90-0x00000001810E3FB0
			internal uint <SortGlyphTable>b__101_0(Glyph c); // 0x00000001810E3FF0-0x00000001810E4020
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x00000001810D19E0-0x00000001810D1BE0
		static TMP_FontAsset(); // 0x00000001810D1960-0x00000001810D19E0
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x00000001810CB7C0-0x00000001810CB840
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x0074346B */); // 0x00000001810CB840-0x00000001810CBEE0
		private void Awake(); // 0x00000001810CB050-0x00000001810CB0D0
		internal void InitializeDictionaryLookupTables(); // 0x00000001810CCB20-0x00000001810CCFF0
		public void ReadFontAssetDefinition(); // 0x00000001810CCFF0-0x00000001810CDA40
		internal void SortCharacterTable(); // 0x00000001810CDA40-0x00000001810CDB60
		internal void SortGlyphTable(); // 0x00000001810CDD80-0x00000001810CDEA0
		internal void SortGlyphAndCharacterTables(); // 0x00000001810CDB60-0x00000001810CDD80
		public bool HasCharacter(int character); // 0x00000001810CC8B0-0x00000001810CC920
		public bool HasCharacter(char character); // 0x00000001810CC370-0x00000001810CC3E0
		public bool HasCharacter(char character, bool searchFallbacks); // 0x00000001810CC3E0-0x00000001810CC8B0
		private bool HasCharacter_Internal(char character, bool searchFallbacks); // 0x00000001810CC1C0-0x00000001810CC370
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x00000001810CC9E0-0x00000001810CCB20
		public bool HasCharacters(string text); // 0x00000001810CC920-0x00000001810CC9E0
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x00000001810CC000-0x00000001810CC100
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x00000001810CBEE0-0x00000001810CC000
		public bool TryAddCharacters(uint[] unicodes); // 0x00000001810CECD0-0x00000001810CECF0
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes); // 0x00000001810CECF0-0x00000001810CF620
		public bool TryAddCharacters(string characters); // 0x00000001810CECB0-0x00000001810CECD0
		public bool TryAddCharacters(string characters, out string missingCharacters); // 0x00000001810CF620-0x00000001810CFE40
		internal bool TryAddCharacter_Internal(uint unicode); // 0x00000001810CE770-0x00000001810CECB0
		internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph); // 0x00000001810CABD0-0x00000001810CB050
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x00000001810CDEA0-0x00000001810CE770
		internal uint GetGlyphIndex(uint unicode); // 0x00000001810CC100-0x00000001810CC1C0
		internal void UpdateAtlasTexture(); // 0x00000001810CFE40-0x00000001810D0280
		internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex); // 0x00000001810D0280-0x00000001810D0790
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x0074346F */); // 0x00000001810CB0D0-0x00000001810CB7C0
		private void UpgradeFontAsset(); // 0x00000001810D0790-0x00000001810D1590
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x00000001810D1590-0x00000001810D1960
	}
}
