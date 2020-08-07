/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[ExecuteAlways] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 9012
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_FontAsset m_fontAsset; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_SpriteAsset m_spriteAsset; // 0xD0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material m_material; // 0xD8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material m_sharedMaterial; // 0xE0
		private Material m_fallbackMaterial; // 0xE8
		private Material m_fallbackSourceMaterial; // 0xF0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_isDefaultMaterial; // 0xF8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_padding; // 0xFC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasRenderer m_canvasRenderer; // 0x100
		private Mesh m_mesh; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI m_TextComponent; // 0x110
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x118
		private bool m_materialDirty; // 0x119
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_materialReferenceIndex; // 0x11C
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		public override Texture mainTexture { get; } // 0x00000001805AF230-0x00000001805AF300 
		public override Material material { get; set; } // 0x00000001805AF370-0x00000001805AF520 0x00000001805AF760-0x00000001805AF850
		public Material sharedMaterial { get; set; } // 0x000000018057C4E0-0x000000018057C4F0 0x00000001805AF860-0x00000001805AF870
		public Material fallbackMaterial { get; set; } // 0x000000018037DDD0-0x000000018037DDE0 0x00000001805AF5E0-0x00000001805AF740
		public Material fallbackSourceMaterial { get; set; } // 0x000000018037DDB0-0x000000018037DDC0 0x00000001805AF740-0x00000001805AF750
		public override Material materialForRendering { get; } // 0x00000001805AF300-0x00000001805AF370 
		public bool isDefaultMaterial { get; set; } // 0x00000001805AF220-0x00000001805AF230 0x00000001805AF750-0x00000001805AF760
		public float padding { get; set; } // 0x00000001805AF5D0-0x00000001805AF5E0 0x00000001805AF850-0x00000001805AF860
		public new CanvasRenderer canvasRenderer { get; } // 0x00000001805AF190-0x00000001805AF220 
		public Mesh mesh { get; set; } // 0x00000001805AF520-0x00000001805AF5D0 0x00000001803B50D0-0x00000001803B50E0
	
		// Constructors
		public TMP_SubMeshUI(); // 0x00000001805AAB70-0x00000001805AAB80
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x00000001805ADF80-0x00000001805AE300
		protected override void OnEnable(); // 0x00000001805AEB80-0x00000001805AEBD0
		protected override void OnDisable(); // 0x00000001805AEA50-0x00000001805AEB80
		protected override void OnDestroy(); // 0x00000001805AE8C0-0x00000001805AEA50
		protected override void OnTransformParentChanged(); // 0x00000001805AEBD0-0x00000001805AEC30
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001805AE5A0-0x00000001805AE6F0
		public float GetPaddingForMaterial(); // 0x00000001805AE6F0-0x00000001805AE790
		public float GetPaddingForMaterial(Material mat); // 0x00000001805AE790-0x00000001805AE820
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001805AF100-0x00000001805AF190
		public override void SetAllDirty(); // 0x00000001803774A0-0x00000001803774B0
		public override void SetVerticesDirty(); // 0x00000001805AEE60-0x00000001805AEF50
		public override void SetLayoutDirty(); // 0x00000001803774A0-0x00000001803774B0
		public override void SetMaterialDirty(); // 0x00000001805AECC0-0x00000001805AED00
		public void SetPivotDirty(); // 0x00000001805AED00-0x00000001805AED90
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001805AE3B0-0x00000001805AE3F0
		protected override void UpdateGeometry(); // 0x00000001805AEF50-0x00000001805AEFA0
		public override void Rebuild(CanvasUpdate update); // 0x00000001805AEC30-0x00000001805AEC70
		public void RefreshMaterial(); // 0x00000001805AECA0-0x00000001805AECC0
		protected override void UpdateMaterial(); // 0x00000001805AEFA0-0x00000001805AF100
		public override void RecalculateClipping(); // 0x00000001805AEC70-0x00000001805AEC80
		public override void RecalculateMasking(); // 0x00000001805AEC80-0x00000001805AECA0
		private Material GetMaterial(); // 0x000000018057C4E0-0x000000018057C4F0
		private Material GetMaterial(Material mat); // 0x00000001805AE3F0-0x00000001805AE5A0
		private Material CreateMaterialInstance(Material source); // 0x00000001805AE300-0x00000001805AE3B0
		private Material GetSharedMaterial(); // 0x00000001805AE820-0x00000001805AE8C0
		private void SetSharedMaterial(Material mat); // 0x00000001805AED90-0x00000001805AEE60
	}
}
