/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.TextCore;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class TMP_FontAssetUtilities // TypeDefIndex: 8792
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static List<int> k_SearchedFontAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x00000001810CAB70-0x00000001810CABD0 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x00000001810CAB10-0x00000001810CAB70
		public TMP_FontAssetUtilities(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001810C9E80-0x00000001810C9FF0
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001810C99A0-0x00000001810C9E80
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001810C9FF0-0x00000001810CA280
		private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character); // 0x00000001810CA280-0x00000001810CA910
		public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph); // 0x00000001810CA910-0x00000001810CAB10
	}
}
