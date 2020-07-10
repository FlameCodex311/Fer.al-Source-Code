/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMP_MaterialManager // TypeDefIndex: 8819
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 8820
		{
			// Fields
			public int baseID; // 0x10
			public Material baseMaterial; // 0x18
			public long fallbackID; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		private class MaskingMaterial // TypeDefIndex: 8821
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 8822
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetBaseMaterial>b__0(MaskingMaterial item); // 0x00000001811C9D80-0x00000001811C9E00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 8823
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <AddMaskingMaterial>b__0(MaskingMaterial item); // 0x00000001811C9E00-0x00000001811C9E80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 8824
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoveStencilMaterial>b__0(MaskingMaterial item); // 0x00000001811C9E80-0x00000001811C9F00
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 8825
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <ReleaseBaseMaterial>b__0(MaskingMaterial item); // 0x00000001811C9F00-0x00000001811C9F80
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x00000001811A1480-0x00000001811A1620
	
		// Methods
		private static void OnPreRender(Camera cam); // 0x00000001811A02C0-0x00000001811A0350
		private static void OnPreRenderCanvas(); // 0x00000001811A0230-0x00000001811A02C0
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x000000018119FE00-0x00000001811A0230
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x00000001811A0DD0-0x00000001811A1070
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x000000018119F1C0-0x000000018119F330
		public static Material SetStencil(Material material, int stencilID); // 0x00000001811A1370-0x00000001811A1480
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x000000018119E6D0-0x000000018119E940
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x00000001811A1230-0x00000001811A1370
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x00000001811A0350-0x00000001811A0BD0
		public static void ClearMaterials(); // 0x000000018119EBA0-0x000000018119ED60
		public static int GetStencilID(GameObject obj); // 0x000000018119F9D0-0x000000018119FE00
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x000000018119F7F0-0x000000018119F9D0
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x000000018119F050-0x000000018119F1C0
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x000000018119F330-0x000000018119F7F0
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x000000018119E580-0x000000018119E6D0
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x00000001811A1070-0x00000001811A1230
		public static void CleanupFallbackMaterials(); // 0x000000018119E940-0x000000018119EBA0
		public static void ReleaseFallbackMaterial(Material fallackMaterial); // 0x00000001811A0BD0-0x00000001811A0DD0
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x000000018119ED60-0x000000018119F050
	}
}
