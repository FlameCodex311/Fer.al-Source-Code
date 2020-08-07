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
	[AddComponentMenu] // 0x0000000180206DA0-0x0000000180206E60
	[DisallowMultipleComponent] // 0x0000000180206DA0-0x0000000180206E60
	[ExecuteAlways] // 0x0000000180206DA0-0x0000000180206E60
	[RequireComponent] // 0x0000000180206DA0-0x0000000180206E60
	[RequireComponent] // 0x0000000180206DA0-0x0000000180206E60
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 9056
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_hasFontAssetChanged; // 0xB38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB40
		private float m_previousLossyScaleY; // 0xB48
		private Vector3[] m_RectTransformCorners; // 0xB50
		private CanvasRenderer m_canvasRenderer; // 0xB58
		private Canvas m_canvas; // 0xB60
		private bool m_isFirstAllocation; // 0xB68
		private int m_max_characters; // 0xB6C
		private bool m_isMaskingEnabled; // 0xB70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material m_baseMaterial; // 0xB78
		private bool m_isScrollRegionSet; // 0xB80
		private int m_stencilID; // 0xB84
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector4 m_maskOffset; // 0xB88
		private Matrix4x4 m_EnvMapMatrix; // 0xB98
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBD8
		private int m_recursiveCountA; // 0xBDC
		private int loopCountA; // 0xBE0
		private bool m_isRebuildingLayout; // 0xBE4
	
		// Properties
		public override Material materialForRendering { get; } // 0x00000001818E63C0-0x00000001818E6430 
		public override bool autoSizeTextContainer { get; set; } // 0x0000000180D59690-0x0000000180D596A0 0x00000001818E6430-0x00000001818E64C0
		public override Mesh mesh { get; } // 0x00000001805CB970-0x00000001805CB980 
		public new CanvasRenderer canvasRenderer { get; } // 0x00000001818E6320-0x00000001818E63B0 
		public Vector4 maskOffset { get; set; } // 0x00000001818E63B0-0x00000001818E63C0 0x00000001818E64C0-0x00000001818E6510
	
		// Constructors
		public TextMeshProUGUI(); // 0x00000001818E6280-0x00000001818E6320
	
		// Methods
		protected override void Awake(); // 0x00000001818D0AE0-0x00000001818D0EE0
		protected override void OnEnable(); // 0x00000001818DFB50-0x00000001818DFD90
		protected override void OnDisable(); // 0x00000001818DF990-0x00000001818DFB50
		protected override void OnDestroy(); // 0x00000001818DF800-0x00000001818DF950
		protected override void LoadFontAsset(); // 0x00000001818DF0A0-0x00000001818DF7D0
		private Canvas GetCanvas(); // 0x00000001818DDD40-0x00000001818DDE80
		private void UpdateEnvMapMatrix(); // 0x00000001818E4980-0x00000001818E4CF0
		private void EnableMasking(); // 0x00000001818D1400-0x00000001818D1650
		private void DisableMasking(); // 0x00000001818D12C0-0x00000001818D1400
		private void UpdateMask(); // 0x00000001818E4DB0-0x00000001818E5430
		protected override Material GetMaterial(Material mat); // 0x00000001818DE390-0x00000001818DE4F0
		protected override Material[] GetMaterials(Material[] mats); // 0x00000001818DE4F0-0x00000001818DE720
		protected override void SetSharedMaterial(Material mat); // 0x0000000180D57F00-0x0000000180D57F50
		protected override Material[] GetSharedMaterials(); // 0x00000001818DEA20-0x00000001818DEC30
		protected override void SetSharedMaterials(Material[] materials); // 0x00000001818E4260-0x00000001818E4890
		protected override void SetOutlineThickness(float thickness); // 0x00000001818E3D50-0x00000001818E4000
		protected override void SetFaceColor(Color32 color); // 0x00000001818E3870-0x00000001818E39A0
		protected override void SetOutlineColor(Color32 color); // 0x00000001818E3C20-0x00000001818E3D50
		protected override void SetShaderDepth(); // 0x00000001818E40E0-0x00000001818E4260
		protected override void SetCulling(); // 0x00000001818E3440-0x00000001818E3870
		private void SetPerspectiveCorrection(); // 0x00000001818E4000-0x00000001818E40E0
		protected override float GetPaddingForMaterial(Material mat); // 0x00000001818DE870-0x00000001818DE950
		protected override float GetPaddingForMaterial(); // 0x00000001818DE950-0x00000001818DEA20
		private void SetMeshArrays(int size); // 0x00000001818E3B70-0x00000001818E3C20
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x00000001818E0420-0x00000001818E3440
		public override void ComputeMarginSize(); // 0x00000001818D1160-0x00000001818D1290
		protected override void OnDidApplyAnimationProperties(); // 0x00000001818DF950-0x00000001818DF990
		protected override void OnCanvasHierarchyChanged(); // 0x00000001818DF7D0-0x00000001818DF800
		protected override void OnTransformParentChanged(); // 0x00000001818E0140-0x00000001818E0190
		protected override void OnRectTransformDimensionsChange(); // 0x00000001818DFFA0-0x00000001818E0140
		internal override void InternalUpdate(); // 0x00000001818DEFB0-0x00000001818DF0A0
		private void OnPreRenderCanvas(); // 0x00000001818DFD90-0x00000001818DFFA0
		protected override void GenerateTextMesh(); // 0x00000001818D1680-0x00000001818DDD40
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x00000001818DEC30-0x00000001818DECE0
		protected override void SetActiveSubMeshes(bool state); // 0x00000001818E0280-0x00000001818E0420
		protected override Bounds GetCompoundBounds(); // 0x00000001818DDE80-0x00000001818DE390
		private void UpdateSDFScale(float scaleDelta); // 0x00000001818E56D0-0x00000001818E5B00
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x00000001818D0330-0x00000001818D0AE0
		public void CalculateLayoutInputHorizontal(); // 0x00000001818D0EE0-0x00000001818D0F70
		public void CalculateLayoutInputVertical(); // 0x00000001818D0F70-0x00000001818D1000
		public override void SetVerticesDirty(); // 0x00000001818E4890-0x00000001818E4980
		public override void SetLayoutDirty(); // 0x00000001818E39A0-0x00000001818E3A90
		public override void SetMaterialDirty(); // 0x00000001818E3A90-0x00000001818E3B70
		public override void SetAllDirty(); // 0x0000000180D53BD0-0x0000000180D53C20
		public override void Rebuild(CanvasUpdate update); // 0x00000001818E0190-0x00000001818E0280
		private void UpdateSubObjectPivot(); // 0x00000001818E5B00-0x00000001818E5C40
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001818DE720-0x00000001818DE870
		protected override void UpdateMaterial(); // 0x00000001818E5430-0x00000001818E5590
		public override void RecalculateClipping(); // 0x00000001805AEC70-0x00000001805AEC80
		public override void RecalculateMasking(); // 0x00000001805AEC80-0x00000001805AECA0
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001818D1290-0x00000001818D12C0
		public override void UpdateMeshPadding(); // 0x00000001818E5590-0x00000001818E56D0
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001818DEEB0-0x00000001818DEFB0
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x00000001818DEDE0-0x00000001818DEEB0
		public override void ForceMeshUpdate(); // 0x00000001818D1670-0x00000001818D1680
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x00000001818D1650-0x00000001818D1670
		public override TMP_TextInfo GetTextInfo(string text); // 0x00000001818DECE0-0x00000001818DEDE0
		public override void ClearMesh(); // 0x00000001818D1000-0x00000001818D1160
		public override void UpdateGeometry(Mesh mesh, int index); // 0x00000001818E4CF0-0x00000001818E4DB0
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001818E5C40-0x00000001818E5F60
		public override void UpdateVertexData(); // 0x00000001818E5F60-0x00000001818E6280
		public void UpdateFontAsset(); // 0x0000000180D58920-0x0000000180D58940
	}
}
