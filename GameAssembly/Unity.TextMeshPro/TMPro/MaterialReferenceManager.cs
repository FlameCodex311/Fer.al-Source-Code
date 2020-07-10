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
	public class MaterialReferenceManager // TypeDefIndex: 8747
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x00000001810BFDA0-0x00000001810BFED0 
	
		// Constructors
		public MaterialReferenceManager(); // 0x00000001810BFCD0-0x00000001810BFDA0
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x00000001810BF330-0x00000001810BF3F0
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x00000001810BF280-0x00000001810BF330
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x00000001810BF730-0x00000001810BF7F0
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x00000001810BF4E0-0x00000001810BF590
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x00000001810BF650-0x00000001810BF730
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x00000001810BF590-0x00000001810BF650
		public static void AddFontMaterial(int hashCode, Material material); // 0x00000001810BF460-0x00000001810BF4E0
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x00000001810BF3F0-0x00000001810BF460
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x00000001810BF1E0-0x00000001810BF280
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x00000001810BF150-0x00000001810BF1E0
		public bool Contains(TMP_FontAsset font); // 0x00000001810BF860-0x00000001810BF8D0
		public bool Contains(TMP_SpriteAsset sprite); // 0x00000001810BF7F0-0x00000001810BF860
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x00000001810BFA40-0x00000001810BFAD0
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x00000001810BF9D0-0x00000001810BFA40
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x00000001810BFC40-0x00000001810BFCD0
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x00000001810BFBD0-0x00000001810BFC40
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x00000001810BF940-0x00000001810BF9D0
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x00000001810BF8D0-0x00000001810BF940
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x00000001810BFB40-0x00000001810BFBD0
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x00000001810BFAD0-0x00000001810BFB40
	}
}
