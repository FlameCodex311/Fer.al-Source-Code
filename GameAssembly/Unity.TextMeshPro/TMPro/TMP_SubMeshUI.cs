/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[ExecuteAlways] // 0x00000001800B36B0-0x00000001800B36C0
	public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 8850
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontAsset m_fontAsset; // 0xC8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_SpriteAsset m_spriteAsset; // 0xD0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material m_material; // 0xD8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material m_sharedMaterial; // 0xE0
		private Material m_fallbackMaterial; // 0xE8
		private Material m_fallbackSourceMaterial; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_isDefaultMaterial; // 0xF8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_padding; // 0xFC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasRenderer m_canvasRenderer; // 0x100
		private Mesh m_mesh; // 0x108
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI m_TextComponent; // 0x110
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x118
		private bool m_materialDirty; // 0x119
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_materialReferenceIndex; // 0x11C
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		public override Texture mainTexture { get; } // 0x00000001811A9FE0-0x00000001811AA0B0 
		public override Material material { get; set; } // 0x00000001811AA120-0x00000001811AA130 0x00000001811AA350-0x00000001811AA450
		public Material sharedMaterial { get; set; } // 0x00000001804A0FC0-0x00000001804A0FD0 0x00000001811AA450-0x00000001811AA460
		public Material fallbackMaterial { get; set; } // 0x000000018037A250-0x000000018037A260 0x00000001811AA1E0-0x00000001811AA340
		public Material fallbackSourceMaterial { get; set; } // 0x00000001803BD320-0x00000001803BD330 0x00000001803BE540-0x00000001803BE550
		public override Material materialForRendering { get; } // 0x00000001811AA0B0-0x00000001811AA120 
		public bool isDefaultMaterial { get; set; } // 0x00000001811A9FD0-0x00000001811A9FE0 0x00000001811AA340-0x00000001811AA350
		public float padding { get; set; } // 0x0000000180DD2010-0x0000000180DD2020 0x0000000180DD2190-0x0000000180DD21A0
		public new CanvasRenderer canvasRenderer { get; } // 0x00000001811A9F40-0x00000001811A9FD0 
		public Mesh mesh { get; set; } // 0x00000001811AA130-0x00000001811AA1E0 0x00000001803BE5E0-0x00000001803BE5F0
	
		// Constructors
		public TMP_SubMeshUI(); // 0x00000001811A5740-0x00000001811A5750
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x00000001811A8D30-0x00000001811A90C0
		protected override void OnEnable(); // 0x00000001811A9950-0x00000001811A99A0
		protected override void OnDisable(); // 0x00000001811A9820-0x00000001811A9950
		protected override void OnDestroy(); // 0x00000001811A9690-0x00000001811A9820
		protected override void OnTransformParentChanged(); // 0x00000001811A99A0-0x00000001811A9A00
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001811A9360-0x00000001811A94B0
		public float GetPaddingForMaterial(); // 0x00000001811A94B0-0x00000001811A9550
		public float GetPaddingForMaterial(Material mat); // 0x00000001811A9550-0x00000001811A95F0
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001811A9EB0-0x00000001811A9F40
		public override void SetAllDirty(); // 0x00000001803581E0-0x00000001803581F0
		public override void SetVerticesDirty(); // 0x00000001811A9C10-0x00000001811A9D00
		public override void SetLayoutDirty(); // 0x00000001803581E0-0x00000001803581F0
		public override void SetMaterialDirty(); // 0x00000001811A9A70-0x00000001811A9AB0
		public void SetPivotDirty(); // 0x00000001811A9AB0-0x00000001811A9B40
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001811A9170-0x00000001811A91B0
		protected override void UpdateGeometry(); // 0x00000001811A9D00-0x00000001811A9D50
		public override void Rebuild(CanvasUpdate update); // 0x00000001811A9A00-0x00000001811A9A40
		public void RefreshMaterial(); // 0x000000018080E070-0x000000018080E090
		protected override void UpdateMaterial(); // 0x00000001811A9D50-0x00000001811A9EB0
		public override void RecalculateClipping(); // 0x00000001811A9A40-0x00000001811A9A50
		public override void RecalculateMasking(); // 0x00000001811A9A50-0x00000001811A9A70
		private Material GetMaterial(); // 0x00000001804A0FC0-0x00000001804A0FD0
		private Material GetMaterial(Material mat); // 0x00000001811A91B0-0x00000001811A9360
		private Material CreateMaterialInstance(Material source); // 0x00000001811A90C0-0x00000001811A9170
		private Material GetSharedMaterial(); // 0x00000001811A95F0-0x00000001811A9690
		private void SetSharedMaterial(Material mat); // 0x00000001811A9B40-0x00000001811A9C10
	}
}
