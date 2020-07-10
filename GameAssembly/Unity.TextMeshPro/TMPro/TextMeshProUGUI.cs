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
	[AddComponentMenu] // 0x00000001801404B0-0x0000000180140570
	[DisallowMultipleComponent] // 0x00000001801404B0-0x0000000180140570
	[ExecuteAlways] // 0x00000001801404B0-0x0000000180140570
	[RequireComponent] // 0x00000001801404B0-0x0000000180140570
	[RequireComponent] // 0x00000001801404B0-0x0000000180140570
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 8752
	{
		// Fields
		private bool m_isRebuildingLayout; // 0xB38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_hasFontAssetChanged; // 0xB39
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB40
		private float m_previousLossyScaleY; // 0xB48
		private Vector3[] m_RectTransformCorners; // 0xB50
		private CanvasRenderer m_canvasRenderer; // 0xB58
		private Canvas m_canvas; // 0xB60
		private bool m_isFirstAllocation; // 0xB68
		private int m_max_characters; // 0xB6C
		private bool m_isMaskingEnabled; // 0xB70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material m_baseMaterial; // 0xB78
		private bool m_isScrollRegionSet; // 0xB80
		private int m_stencilID; // 0xB84
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector4 m_maskOffset; // 0xB88
		private Matrix4x4 m_EnvMapMatrix; // 0xB98
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBD8
		private int m_recursiveCountA; // 0xBDC
		private int loopCountA; // 0xBE0
	
		// Properties
		public override Material materialForRendering { get; } // 0x0000000181DB5E30-0x0000000181DB5EA0 
		public override bool autoSizeTextContainer { get; set; } // 0x00000001818A1050-0x00000001818A1060 0x0000000181DB5EA0-0x0000000181DB5F30
		public override Mesh mesh { get; } // 0x00000001811C6C50-0x00000001811C6C60 
		public new CanvasRenderer canvasRenderer { get; } // 0x0000000181DB5D90-0x0000000181DB5E20 
		public Vector4 maskOffset { get; set; } // 0x0000000181DB5E20-0x0000000181DB5E30 0x0000000181DB5F30-0x0000000181DB6F90
	
		// Constructors
		public TextMeshProUGUI(); // 0x0000000181DB5CF0-0x0000000181DB5D90
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x0000000181DA0AC0-0x0000000181DA0B50
		public void CalculateLayoutInputVertical(); // 0x0000000181DA0B50-0x0000000181DA0BE0
		public override void SetVerticesDirty(); // 0x0000000181DB4370-0x0000000181DB4460
		public override void SetLayoutDirty(); // 0x0000000181DB3420-0x0000000181DB3510
		public override void SetMaterialDirty(); // 0x0000000181DB3510-0x0000000181DB35F0
		public override void SetAllDirty(); // 0x000000018189B920-0x000000018189B970
		public override void Rebuild(CanvasUpdate update); // 0x0000000181DAFF50-0x0000000181DB0040
		private void UpdateSubObjectPivot(); // 0x0000000181DB5600-0x0000000181DB5750
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x0000000181DAE460-0x0000000181DAE5B0
		protected override void UpdateMaterial(); // 0x0000000181DB4F20-0x0000000181DB5080
		public override void RecalculateClipping(); // 0x00000001811A9A40-0x00000001811A9A50
		public override void RecalculateMasking(); // 0x00000001811A9A50-0x00000001811A9A70
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000181DA0E90-0x0000000181DA0EC0
		public override void UpdateMeshPadding(); // 0x0000000181DB5080-0x0000000181DB51C0
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000181DAEC10-0x0000000181DAED20
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000181DAEB40-0x0000000181DAEC10
		public override void ForceMeshUpdate(); // 0x0000000181DA1280-0x0000000181DA1290
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x0000000181DA1260-0x0000000181DA1280
		public override TMP_TextInfo GetTextInfo(string text); // 0x0000000181DAEA40-0x0000000181DAEB40
		public override void ClearMesh(); // 0x0000000181DA0BE0-0x0000000181DA0D50
		public override void UpdateGeometry(Mesh mesh, int index); // 0x0000000181DB47D0-0x0000000181DB4890
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x0000000181DB5750-0x0000000181DB5A30
		public override void UpdateVertexData(); // 0x0000000181DB5A30-0x0000000181DB5CF0
		public void UpdateFontAsset(); // 0x00000001818A0380-0x00000001818A03A0
		protected override void Awake(); // 0x0000000181DA06A0-0x0000000181DA0AC0
		protected override void OnEnable(); // 0x0000000181DAF900-0x0000000181DAFB40
		protected override void OnDisable(); // 0x0000000181DAF740-0x0000000181DAF900
		protected override void OnDestroy(); // 0x0000000181DAF5B0-0x0000000181DAF700
		protected override void LoadFontAsset(); // 0x0000000181DAEE10-0x0000000181DAF580
		private Canvas GetCanvas(); // 0x0000000181DADA50-0x0000000181DADBA0
		private void UpdateEnvMapMatrix(); // 0x0000000181DB4460-0x0000000181DB47D0
		private void EnableMasking(); // 0x0000000181DA1000-0x0000000181DA1260
		private void DisableMasking(); // 0x0000000181DA0EC0-0x0000000181DA1000
		private void UpdateMask(); // 0x0000000181DB4890-0x0000000181DB4F20
		protected override Material GetMaterial(Material mat); // 0x0000000181DAE0C0-0x0000000181DAE220
		protected override Material[] GetMaterials(Material[] mats); // 0x0000000181DAE220-0x0000000181DAE460
		protected override void SetSharedMaterial(Material mat); // 0x000000018189F920-0x000000018189F970
		protected override Material[] GetSharedMaterials(); // 0x0000000181DAE760-0x0000000181DAE990
		protected override void SetSharedMaterials(Material[] materials); // 0x0000000181DB3D00-0x0000000181DB4370
		protected override void SetOutlineThickness(float thickness); // 0x0000000181DB37E0-0x0000000181DB3AA0
		protected override void SetFaceColor(Color32 color); // 0x0000000181DB32F0-0x0000000181DB3420
		protected override void SetOutlineColor(Color32 color); // 0x0000000181DB36B0-0x0000000181DB37E0
		protected override void SetShaderDepth(); // 0x0000000181DB3B80-0x0000000181DB3D00
		protected override void SetCulling(); // 0x0000000181DB2EA0-0x0000000181DB32F0
		private void SetPerspectiveCorrection(); // 0x0000000181DB3AA0-0x0000000181DB3B80
		protected override float GetPaddingForMaterial(Material mat); // 0x0000000181DAE5B0-0x0000000181DAE690
		protected override float GetPaddingForMaterial(); // 0x0000000181DAE690-0x0000000181DAE760
		private void SetMeshArrays(int size); // 0x0000000181DB35F0-0x0000000181DB36B0
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x0000000181DB01F0-0x0000000181DB2EA0
		public override void ComputeMarginSize(); // 0x0000000181DA0D50-0x0000000181DA0E90
		protected override void OnDidApplyAnimationProperties(); // 0x0000000181DAF700-0x0000000181DAF740
		protected override void OnCanvasHierarchyChanged(); // 0x0000000181DAF580-0x0000000181DAF5B0
		protected override void OnTransformParentChanged(); // 0x0000000181DAFF00-0x0000000181DAFF50
		protected override void OnRectTransformDimensionsChange(); // 0x0000000181DAFD50-0x0000000181DAFF00
		internal override void InternalUpdate(); // 0x0000000181DAED20-0x0000000181DAEE10
		private void OnPreRenderCanvas(); // 0x0000000181DAFB40-0x0000000181DAFD50
		protected override void GenerateTextMesh(); // 0x0000000181DA1290-0x0000000181DADA50
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x0000000181DAE990-0x0000000181DAEA40
		protected override void SetActiveSubMeshes(bool state); // 0x0000000181DB0040-0x0000000181DB01F0
		protected override Bounds GetCompoundBounds(); // 0x0000000181DADBA0-0x0000000181DAE0C0
		private void UpdateSDFScale(float scaleDelta); // 0x0000000181DB51C0-0x0000000181DB5600
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x0000000181DA0000-0x0000000181DA06A0
	}
}
