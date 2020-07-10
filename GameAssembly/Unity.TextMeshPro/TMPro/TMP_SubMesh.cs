/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[ExecuteAlways] // 0x000000018015B7E0-0x000000018015B870
	[RequireComponent] // 0x000000018015B7E0-0x000000018015B870
	[RequireComponent] // 0x000000018015B7E0-0x000000018015B870
	public class TMP_SubMesh : UnityEngine.MonoBehaviour // TypeDefIndex: 8849
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontAsset m_fontAsset; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material m_material; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_isDefaultMaterial; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_padding; // 0x4C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Renderer m_renderer; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Material material { get; set; } // 0x00000001811AB2E0-0x00000001811AB2F0 0x00000001811AB620-0x00000001811AB6B0
		public Material sharedMaterial { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001811AB140-0x00000001811AB170
		public Material fallbackMaterial { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001811AB4C0-0x00000001811AB620
		public Material fallbackSourceMaterial { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public bool isDefaultMaterial { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		public float padding { get; set; } // 0x0000000180487D30-0x0000000180487D40 0x0000000180DD2D50-0x0000000180DD2D60
		public Renderer renderer { get; } // 0x00000001811AB440-0x00000001811AB4C0 
		public MeshFilter meshFilter { get; } // 0x00000001811AB2F0-0x00000001811AB370 
		public Mesh mesh { get; set; } // 0x00000001811AB370-0x00000001811AB440 0x00000001803A27E0-0x00000001803A27F0
	
		// Constructors
		public TMP_SubMesh(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void OnEnable(); // 0x00000001811AAE50-0x00000001811AB050
		private void OnDisable(); // 0x00000001811AAD90-0x00000001811AAE50
		private void OnDestroy(); // 0x00000001811AAC90-0x00000001811AAD90
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x00000001811AA460-0x00000001811AA880
		public void DestroySelf(); // 0x00000001811AA930-0x00000001811AA9A0
		private Material GetMaterial(Material mat); // 0x00000001811AA9A0-0x00000001811AAB70
		private Material CreateMaterialInstance(Material source); // 0x00000001811AA880-0x00000001811AA930
		private Material GetSharedMaterial(); // 0x00000001811AAC00-0x00000001811AAC90
		private void SetSharedMaterial(Material mat); // 0x00000001811AB140-0x00000001811AB170
		public float GetPaddingForMaterial(); // 0x00000001811AAB70-0x00000001811AAC00
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001811AB250-0x00000001811AB2E0
		public void SetVerticesDirty(); // 0x00000001811AB170-0x00000001811AB250
		public void SetMaterialDirty(); // 0x00000001811AB050-0x00000001811AB140
		protected void UpdateMaterial(); // 0x00000001811AB050-0x00000001811AB140
	}
}
