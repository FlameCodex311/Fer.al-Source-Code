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
	[AddComponentMenu] // 0x000000018013FB80-0x000000018013FC40
	[DisallowMultipleComponent] // 0x000000018013FB80-0x000000018013FC40
	[ExecuteAlways] // 0x000000018013FB80-0x000000018013FC40
	[RequireComponent] // 0x000000018013FB80-0x000000018013FC40
	[RequireComponent] // 0x000000018013FB80-0x000000018013FC40
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 8751
	{
		// Fields
		private bool m_currentAutoSizeMode; // 0xB38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_hasFontAssetChanged; // 0xB39
		private float m_previousLossyScaleY; // 0xB3C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Renderer m_renderer; // 0xB40
		private MeshFilter m_meshFilter; // 0xB48
		private bool m_isFirstAllocation; // 0xB50
		private int m_max_characters; // 0xB54
		private int m_max_numberOfLines; // 0xB58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_SubMesh[] m_subTextObjects; // 0xB60
		private bool m_isMaskingEnabled; // 0xB68
		private bool isMaskUpdateRequired; // 0xB69
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private MaskingTypes m_maskType; // 0xB6C
		private Matrix4x4 m_EnvMapMatrix; // 0xB70
		private Vector3[] m_RectTransformCorners; // 0xBB0
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBB8
		private int loopCountA; // 0xBBC
	
		// Properties
		public int sortingLayerID { get; set; } // 0x00000001818A1270-0x00000001818A12A0 0x00000001818A1470-0x00000001818A14A0
		public int sortingOrder { get; set; } // 0x00000001818A12A0-0x00000001818A12D0 0x00000001818A14A0-0x00000001818A14D0
		public override bool autoSizeTextContainer { get; set; } // 0x00000001818A1050-0x00000001818A1060 0x00000001818A1360-0x00000001818A1460
		[Obsolete] // 0x0000000180140300-0x0000000180140330
		public TextContainer textContainer { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public new Transform transform { get; } // 0x00000001818A12D0-0x00000001818A1360 
		public Renderer renderer { get; } // 0x00000001818A11E0-0x00000001818A1270 
		public override Mesh mesh { get; } // 0x00000001818A1100-0x00000001818A11E0 
		public MeshFilter meshFilter { get; } // 0x00000001818A1070-0x00000001818A1100 
		public MaskingTypes maskType { get; set; } // 0x00000001818A1060-0x00000001818A1070 0x00000001818A1460-0x00000001818A1470
	
		// Constructors
		public TextMeshPro(); // 0x00000001818A0FB0-0x00000001818A1050
	
		// Methods
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x000000018189EEF0-0x000000018189EF90
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x000000018189EF90-0x000000018189F0B0
		public override void SetVerticesDirty(); // 0x000000018189FEC0-0x00000001818A0010
		public override void SetLayoutDirty(); // 0x000000018189EA30-0x000000018189EAD0
		public override void SetMaterialDirty(); // 0x000000018080E070-0x000000018080E090
		public override void SetAllDirty(); // 0x000000018189B920-0x000000018189B970
		public override void Rebuild(CanvasUpdate update); // 0x000000018189B680-0x000000018189B770
		protected override void UpdateMaterial(); // 0x00000001818A0500-0x00000001818A0680
		public override void UpdateMeshPadding(); // 0x00000001818A0680-0x00000001818A07C0
		public override void ForceMeshUpdate(); // 0x000000018188D5D0-0x000000018188D5E0
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x000000018188D5E0-0x000000018188D600
		public override TMP_TextInfo GetTextInfo(string text); // 0x000000018189A960-0x000000018189A9F0
		public override void ClearMesh(bool updateMesh); // 0x000000018188CDB0-0x000000018188CF50
		public override void UpdateGeometry(Mesh mesh, int index); // 0x00000001818A03A0-0x00000001818A03D0
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001818A0B30-0x00000001818A0D80
		public override void UpdateVertexData(); // 0x00000001818A0D80-0x00000001818A0FB0
		public void UpdateFontAsset(); // 0x00000001818A0380-0x00000001818A03A0
		public void CalculateLayoutInputHorizontal(); // 0x000000018188CB20-0x000000018188CC80
		public void CalculateLayoutInputVertical(); // 0x000000018188CC80-0x000000018188CDB0
		protected override void Awake(); // 0x000000018188C540-0x000000018188CB20
		protected override void OnEnable(); // 0x000000018189B2C0-0x000000018189B440
		protected override void OnDisable(); // 0x000000018189B260-0x000000018189B2C0
		protected override void OnDestroy(); // 0x000000018189B180-0x000000018189B240
		protected override void LoadFontAsset(); // 0x000000018189AAE0-0x000000018189B180
		private void UpdateEnvMapMatrix(); // 0x00000001818A0010-0x00000001818A0380
		private void SetMask(MaskingTypes maskType); // 0x000000018189EC90-0x000000018189EEF0
		private void SetMaskCoordinates(Vector4 coords); // 0x000000018189EBF0-0x000000018189EC90
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x000000018189EAD0-0x000000018189EBF0
		private void EnableMasking(); // 0x000000018188D470-0x000000018188D5D0
		private void DisableMasking(); // 0x000000018188D310-0x000000018188D470
		private void UpdateMask(); // 0x00000001818A03D0-0x00000001818A0500
		protected override Material GetMaterial(Material mat); // 0x000000018189A0E0-0x000000018189A210
		protected override Material[] GetMaterials(Material[] mats); // 0x000000018189A210-0x000000018189A450
		protected override void SetSharedMaterial(Material mat); // 0x000000018189F920-0x000000018189F970
		protected override Material[] GetSharedMaterials(); // 0x000000018189A680-0x000000018189A8B0
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018189F970-0x000000018189FEC0
		protected override void SetOutlineThickness(float thickness); // 0x000000018189F520-0x000000018189F6A0
		protected override void SetFaceColor(Color32 color); // 0x000000018189E8F0-0x000000018189EA30
		protected override void SetOutlineColor(Color32 color); // 0x000000018189F3E0-0x000000018189F520
		private void CreateMaterialInstance(); // 0x000000018188D240-0x000000018188D310
		protected override void SetShaderDepth(); // 0x000000018189F780-0x000000018189F920
		protected override void SetCulling(); // 0x000000018189E4B0-0x000000018189E8F0
		private void SetPerspectiveCorrection(); // 0x000000018189F6A0-0x000000018189F780
		protected override float GetPaddingForMaterial(Material mat); // 0x000000018189A5A0-0x000000018189A680
		protected override float GetPaddingForMaterial(); // 0x000000018189A450-0x000000018189A5A0
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x000000018189B970-0x000000018189E4B0
		public override void ComputeMarginSize(); // 0x000000018188D100-0x000000018188D240
		protected override void OnDidApplyAnimationProperties(); // 0x000000018189B240-0x000000018189B260
		protected override void OnTransformParentChanged(); // 0x000000018189B640-0x000000018189B680
		protected override void OnRectTransformDimensionsChange(); // 0x000000018189B5F0-0x000000018189B640
		internal override void InternalUpdate(); // 0x000000018189A9F0-0x000000018189AAE0
		private void OnPreRenderObject(); // 0x000000018189B440-0x000000018189B5F0
		protected override void GenerateTextMesh(); // 0x000000018188D600-0x0000000181899BC0
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x000000018189A8B0-0x000000018189A960
		private void SetMeshFilters(bool state); // 0x000000018189F0B0-0x000000018189F3E0
		protected override void SetActiveSubMeshes(bool state); // 0x000000018189B770-0x000000018189B920
		protected override void ClearSubMeshObjects(); // 0x000000018188CF50-0x000000018188D100
		protected override Bounds GetCompoundBounds(); // 0x0000000181899BC0-0x000000018189A0E0
		private void UpdateSDFScale(float scaleDelta); // 0x00000001818A07C0-0x00000001818A0B30
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x000000018188BEA0-0x000000018188C540
	}
}
