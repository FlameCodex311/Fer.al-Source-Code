/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[ExecuteAlways] // 0x00000001801F4A30-0x00000001801F4AC0
	[RequireComponent] // 0x00000001801F4A30-0x00000001801F4AC0
	[RequireComponent] // 0x00000001801F4A30-0x00000001801F4AC0
	public class TMP_SubMesh : UnityEngine.MonoBehaviour // TypeDefIndex: 9011
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_FontAsset m_fontAsset; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material m_material; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_isDefaultMaterial; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_padding; // 0x4C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Renderer m_renderer; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Material material { get; set; } // 0x00000001805B06C0-0x00000001805B06D0 0x00000001805B0A00-0x00000001805B0A90
		public Material sharedMaterial { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001805B0520-0x00000001805B0550
		public Material fallbackMaterial { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001805B08A0-0x00000001805B0A00
		public Material fallbackSourceMaterial { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public bool isDefaultMaterial { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		public float padding { get; set; } // 0x0000000180379EA0-0x0000000180379EB0 0x00000001805B0A90-0x00000001805B0AA0
		public Renderer renderer { get; } // 0x00000001805B0820-0x00000001805B08A0 
		public MeshFilter meshFilter { get; } // 0x00000001805B06D0-0x00000001805B0750 
		public Mesh mesh { get; set; } // 0x00000001805B0750-0x00000001805B0820 0x00000001804AF510-0x00000001804AF520
	
		// Constructors
		public TMP_SubMesh(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void OnEnable(); // 0x00000001805B0240-0x00000001805B0430
		private void OnDisable(); // 0x00000001805B0180-0x00000001805B0240
		private void OnDestroy(); // 0x00000001805B0080-0x00000001805B0180
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x00000001805AF870-0x00000001805AFC70
		public void DestroySelf(); // 0x00000001805AFD20-0x00000001805AFD90
		private Material GetMaterial(Material mat); // 0x00000001805AFD90-0x00000001805AFF60
		private Material CreateMaterialInstance(Material source); // 0x00000001805AFC70-0x00000001805AFD20
		private Material GetSharedMaterial(); // 0x00000001805AFFF0-0x00000001805B0080
		private void SetSharedMaterial(Material mat); // 0x00000001805B0520-0x00000001805B0550
		public float GetPaddingForMaterial(); // 0x00000001805AFF60-0x00000001805AFFF0
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001805B0630-0x00000001805B06C0
		public void SetVerticesDirty(); // 0x00000001805B0550-0x00000001805B0630
		public void SetMaterialDirty(); // 0x00000001805B0430-0x00000001805B0520
		protected void UpdateMaterial(); // 0x00000001805B0430-0x00000001805B0520
	}
}
