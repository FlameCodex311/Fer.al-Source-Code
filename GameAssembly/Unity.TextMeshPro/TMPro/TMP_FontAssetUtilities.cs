/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.TextCore;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class TMP_FontAssetUtilities // TypeDefIndex: 8954
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static List<int> k_SearchedFontAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x00000001805754A0-0x0000000180575500 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x0000000180575440-0x00000001805754A0
		public TMP_FontAssetUtilities(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001805747D0-0x0000000180574940
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x0000000180574300-0x00000001805747D0
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x0000000180574940-0x0000000180574BD0
		private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character); // 0x0000000180574BD0-0x0000000180575240
		public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph); // 0x0000000180575240-0x0000000180575440
	}
}
