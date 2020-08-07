/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public static class TMP_MaterialManager // TypeDefIndex: 8981
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 8982
		{
			// Fields
			public int baseID; // 0x10
			public Material baseMaterial; // 0x18
			public long fallbackID; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x0000000180373240-0x0000000180373250
		}
	
		private class MaskingMaterial // TypeDefIndex: 8983
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 8984
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetBaseMaterial>b__0(MaskingMaterial item); // 0x00000001805CEA10-0x00000001805CEA90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 8985
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <AddMaskingMaterial>b__0(MaskingMaterial item); // 0x00000001805CEA90-0x00000001805CEB10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 8986
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveStencilMaterial>b__0(MaskingMaterial item); // 0x00000001805CEB10-0x00000001805CEB90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 8987
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <ReleaseBaseMaterial>b__0(MaskingMaterial item); // 0x00000001805CEB90-0x00000001805CEC10
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x00000001805A6B80-0x00000001805A6D20
	
		// Methods
		private static void OnPreRender(Camera cam); // 0x00000001805A5A30-0x00000001805A5AC0
		private static void OnPreRenderCanvas(); // 0x00000001805A59A0-0x00000001805A5A30
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x00000001805A5580-0x00000001805A59A0
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x00000001805A64E0-0x00000001805A6770
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x00000001805A4980-0x00000001805A4AE0
		public static Material SetStencil(Material material, int stencilID); // 0x00000001805A6A70-0x00000001805A6B80
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x00000001805A3EA0-0x00000001805A4100
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x00000001805A6930-0x00000001805A6A70
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x00000001805A5AC0-0x00000001805A62F0
		public static void ClearMaterials(); // 0x00000001805A4360-0x00000001805A4520
		public static int GetStencilID(GameObject obj); // 0x00000001805A5160-0x00000001805A5580
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x00000001805A4F80-0x00000001805A5160
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x00000001805A4810-0x00000001805A4980
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x00000001805A4AE0-0x00000001805A4F80
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x00000001805A3D50-0x00000001805A3EA0
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x00000001805A6770-0x00000001805A6930
		public static void CleanupFallbackMaterials(); // 0x00000001805A4100-0x00000001805A4360
		public static void ReleaseFallbackMaterial(Material fallackMaterial); // 0x00000001805A62F0-0x00000001805A64E0
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x00000001805A4520-0x00000001805A4810
	}
}
