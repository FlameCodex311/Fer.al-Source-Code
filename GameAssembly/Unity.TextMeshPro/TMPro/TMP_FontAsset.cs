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

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 8939
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_Version; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Font m_SourceFontFile; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FaceInfo m_FaceInfo; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<Glyph> m_GlyphTable; // 0xA8
		private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_Character> m_CharacterTable; // 0xB8
		private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
		private Texture2D m_AtlasTexture; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture2D[] m_AtlasTextures; // 0xD0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal int m_AtlasTextureIndex; // 0xD8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<GlyphRect> m_UsedGlyphRects; // 0xE0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<GlyphRect> m_FreeGlyphRects; // 0xE8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FaceInfo_Legacy m_fontInfo; // 0xF0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Texture2D atlas; // 0xF8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_AtlasWidth; // 0x100
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_AtlasHeight; // 0x104
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_AtlasPadding; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GlyphRenderMode m_AtlasRenderMode; // 0x10C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal List<TMP_Glyph> m_glyphInfoList; // 0x110
		[FormerlySerializedAs] // 0x00000001801E0930-0x00000001801E0970
		[SerializeField] // 0x00000001801E0930-0x00000001801E0970
		internal KerningTable m_KerningTable; // 0x118
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_FontAsset> fallbackFontAssets; // 0x128
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal FontAssetCreationSettings m_CreationSettings; // 0x138
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public string version { get; internal set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public Font sourceFontFile { get; internal set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x0000000180379ED0-0x0000000180379EE0 0x00000001804D99A0-0x00000001804D99B0
		public FaceInfo faceInfo { get; internal set; } // 0x000000018057C450-0x000000018057C490 0x000000018057C580-0x000000018057C5C0
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x000000018057C4A0-0x000000018057C4E0 
		public List<TMP_Character> characterTable { get; internal set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018049F9C0-0x000000018049F9D0
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x000000018057C3C0-0x000000018057C400 
		public Texture2D atlasTexture { get; } // 0x000000018057C300-0x000000018057C3B0 
		public Texture2D[] atlasTextures { get; set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x000000018057C4E0-0x000000018057C4F0 0x000000018057C5E0-0x000000018057C5F0
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x000000018037DDD0-0x000000018037DDE0 0x00000001804296B0-0x00000001804296C0
		[Obsolete] // 0x00000001801E29C0-0x00000001801E29F0
		public FaceInfo_Legacy fontInfo { get; } // 0x000000018037DDB0-0x000000018037DDC0 
		public int atlasWidth { get; internal set; } // 0x000000018057C3B0-0x000000018057C3C0 0x000000018057C520-0x000000018057C530
		public int atlasHeight { get; internal set; } // 0x000000018057C2D0-0x000000018057C2E0 0x000000018057C4F0-0x000000018057C500
		public int atlasPadding { get; internal set; } // 0x000000018057C2E0-0x000000018057C2F0 0x000000018057C500-0x000000018057C510
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x000000018057C2F0-0x000000018057C300 0x000000018057C510-0x000000018057C520
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x00000001803EF220-0x00000001803EF230 0x00000001803B7C20-0x00000001803B7C30
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x0000000180383C00-0x0000000180383C10 0x000000018057C5C0-0x000000018057C5D0
		public FontAssetCreationSettings creationSettings { get; set; } // 0x000000018057C400-0x000000018057C450 0x000000018057C530-0x000000018057C580
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x000000018057C490-0x000000018057C4A0 0x000000018057C5D0-0x000000018057C5E0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8940
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_Character, uint> <>9__100_0; // 0x08
			public static Func<Glyph, uint> <>9__101_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018058E7C0-0x000000018058E820
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal uint <SortCharacterTable>b__100_0(TMP_Character c); // 0x000000018058E540-0x000000018058E560
			internal uint <SortGlyphTable>b__101_0(Glyph c); // 0x000000018058E5A0-0x000000018058E5C0
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x000000018057C0D0-0x000000018057C2D0
		static TMP_FontAsset(); // 0x000000018057C050-0x000000018057C0D0
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x00000001805760A0-0x0000000180576120
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x00778131 */); // 0x0000000180576120-0x00000001805767B0
		private void Awake(); // 0x0000000180575970-0x00000001805759F0
		internal void InitializeDictionaryLookupTables(); // 0x00000001805773A0-0x0000000180577860
		public void ReadFontAssetDefinition(); // 0x0000000180577860-0x0000000180578290
		internal void SortCharacterTable(); // 0x0000000180578290-0x00000001805783B0
		internal void SortGlyphTable(); // 0x00000001805785D0-0x00000001805786F0
		internal void SortGlyphAndCharacterTables(); // 0x00000001805783B0-0x00000001805785D0
		public bool HasCharacter(int character); // 0x0000000180577140-0x00000001805771B0
		public bool HasCharacter(char character); // 0x0000000180576C20-0x0000000180576C90
		public bool HasCharacter(char character, bool searchFallbacks); // 0x0000000180576C90-0x0000000180577140
		private bool HasCharacter_Internal(char character, bool searchFallbacks); // 0x0000000180576A70-0x0000000180576C20
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x0000000180577270-0x00000001805773A0
		public bool HasCharacters(string text); // 0x00000001805771B0-0x0000000180577270
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x00000001805768C0-0x00000001805769B0
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x00000001805767B0-0x00000001805768C0
		public bool TryAddCharacters(uint[] unicodes); // 0x00000001805794C0-0x00000001805794E0
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes); // 0x00000001805794E0-0x0000000180579DE0
		public bool TryAddCharacters(string characters); // 0x00000001805794A0-0x00000001805794C0
		public bool TryAddCharacters(string characters, out string missingCharacters); // 0x0000000180579DE0-0x000000018057A5E0
		internal bool TryAddCharacter_Internal(uint unicode); // 0x0000000180578F80-0x00000001805794A0
		internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph); // 0x0000000180575500-0x0000000180575970
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x00000001805786F0-0x0000000180578F80
		internal uint GetGlyphIndex(uint unicode); // 0x00000001805769B0-0x0000000180576A70
		internal void UpdateAtlasTexture(); // 0x000000018057A5E0-0x000000018057AA00
		internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex); // 0x000000018057AA00-0x000000018057AF00
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x00778135 */); // 0x00000001805759F0-0x00000001805760A0
		private void UpgradeFontAsset(); // 0x000000018057AF00-0x000000018057BC90
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x000000018057BC90-0x000000018057C050
	}
}
