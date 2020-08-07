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
	public class MaterialReferenceManager // TypeDefIndex: 8913
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x000000018056A980-0x000000018056AAB0 
	
		// Constructors
		public MaterialReferenceManager(); // 0x000000018056A8B0-0x000000018056A980
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x0000000180569F60-0x000000018056A020
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x0000000180569EB0-0x0000000180569F60
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x000000018056A350-0x000000018056A410
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x000000018056A110-0x000000018056A1C0
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018056A280-0x000000018056A350
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018056A1C0-0x000000018056A280
		public static void AddFontMaterial(int hashCode, Material material); // 0x000000018056A090-0x000000018056A110
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x000000018056A020-0x000000018056A090
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x0000000180569E10-0x0000000180569EB0
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x0000000180569D80-0x0000000180569E10
		public bool Contains(TMP_FontAsset font); // 0x000000018056A480-0x000000018056A4F0
		public bool Contains(TMP_SpriteAsset sprite); // 0x000000018056A410-0x000000018056A480
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018056A650-0x000000018056A6D0
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018056A5E0-0x000000018056A650
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018056A830-0x000000018056A8B0
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018056A7C0-0x000000018056A830
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018056A560-0x000000018056A5E0
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018056A4F0-0x000000018056A560
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x000000018056A740-0x000000018056A7C0
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x000000018056A6D0-0x000000018056A740
	}
}
