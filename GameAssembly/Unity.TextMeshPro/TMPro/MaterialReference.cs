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
	public struct MaterialReference // TypeDefIndex: 8748
	{
		// Fields
		public int index; // 0x00
		public TMP_FontAsset fontAsset; // 0x08
		public TMP_SpriteAsset spriteAsset; // 0x10
		public Material material; // 0x18
		public bool isDefaultMaterial; // 0x20
		public bool isFallbackMaterial; // 0x21
		public Material fallbackMaterial; // 0x28
		public float padding; // 0x30
		public int referenceCount; // 0x34
	
		// Constructors
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding); // 0x000000018020A950-0x000000018020AA10
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset); // 0x00000001810C0320-0x00000001810C08E0
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x00000001810C00D0-0x00000001810C0320
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x00000001810BFED0-0x00000001810C00D0
	}
}
