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
	[AddComponentMenu] // 0x0000000180205D90-0x0000000180205E50
	[DisallowMultipleComponent] // 0x0000000180205D90-0x0000000180205E50
	[ExecuteAlways] // 0x0000000180205D90-0x0000000180205E50
	[RequireComponent] // 0x0000000180205D90-0x0000000180205E50
	[RequireComponent] // 0x0000000180205D90-0x0000000180205E50
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 9055
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_hasFontAssetChanged; // 0xB38
		private float m_previousLossyScaleY; // 0xB3C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Renderer m_renderer; // 0xB40
		private MeshFilter m_meshFilter; // 0xB48
		private bool m_isFirstAllocation; // 0xB50
		private int m_max_characters; // 0xB54
		private int m_max_numberOfLines; // 0xB58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_SubMesh[] m_subTextObjects; // 0xB60
		private bool m_isMaskingEnabled; // 0xB68
		private bool isMaskUpdateRequired; // 0xB69
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MaskingTypes m_maskType; // 0xB6C
		private Matrix4x4 m_EnvMapMatrix; // 0xB70
		private Vector3[] m_RectTransformCorners; // 0xBB0
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBB8
		private int loopCountA; // 0xBBC
		private bool m_currentAutoSizeMode; // 0xBC0
	
		// Properties
		public int sortingLayerID { get; set; } // 0x0000000180D598B0-0x0000000180D598E0 0x0000000180D59AA0-0x0000000180D59AD0
		public int sortingOrder { get; set; } // 0x0000000180D598E0-0x0000000180D59910 0x0000000180D59AD0-0x0000000180D59B00
		public override bool autoSizeTextContainer { get; set; } // 0x0000000180D59690-0x0000000180D596A0 0x0000000180D599A0-0x0000000180D59A90
		[Obsolete] // 0x0000000180206AF0-0x0000000180206B20
		public TextContainer textContainer { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public new Transform transform { get; } // 0x0000000180D59910-0x0000000180D599A0 
		public Renderer renderer { get; } // 0x0000000180D59820-0x0000000180D598B0 
		public override Mesh mesh { get; } // 0x0000000180D59740-0x0000000180D59820 
		public MeshFilter meshFilter { get; } // 0x0000000180D596B0-0x0000000180D59740 
		public MaskingTypes maskType { get; set; } // 0x0000000180D596A0-0x0000000180D596B0 0x0000000180D59A90-0x0000000180D59AA0
	
		// Constructors
		public TextMeshPro(); // 0x0000000180D595F0-0x0000000180D59690
	
		// Methods
		protected override void Awake(); // 0x0000000180D44960-0x0000000180D44F20
		protected override void OnEnable(); // 0x0000000180D53580-0x0000000180D53700
		protected override void OnDisable(); // 0x0000000180D53520-0x0000000180D53580
		protected override void OnDestroy(); // 0x0000000180D53440-0x0000000180D53500
		protected override void LoadFontAsset(); // 0x0000000180D52DB0-0x0000000180D53440
		private void UpdateEnvMapMatrix(); // 0x0000000180D585B0-0x0000000180D58920
		private void SetMask(MaskingTypes maskType); // 0x0000000180D572B0-0x0000000180D57500
		private void SetMaskCoordinates(Vector4 coords); // 0x0000000180D57210-0x0000000180D572B0
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x0000000180D570F0-0x0000000180D57210
		private void EnableMasking(); // 0x0000000180D45830-0x0000000180D45990
		private void DisableMasking(); // 0x0000000180D456D0-0x0000000180D45830
		private void UpdateMask(); // 0x0000000180D58960-0x0000000180D58A90
		protected override Material GetMaterial(Material mat); // 0x0000000180D523F0-0x0000000180D52520
		protected override Material[] GetMaterials(Material[] mats); // 0x0000000180D52520-0x0000000180D52740
		protected override void SetSharedMaterial(Material mat); // 0x0000000180D57F00-0x0000000180D57F50
		protected override Material[] GetSharedMaterials(); // 0x0000000180D52970-0x0000000180D52B80
		protected override void SetSharedMaterials(Material[] materials); // 0x0000000180D57F50-0x0000000180D58470
		protected override void SetOutlineThickness(float thickness); // 0x0000000180D57B10-0x0000000180D57C90
		protected override void SetFaceColor(Color32 color); // 0x0000000180D56F10-0x0000000180D57050
		protected override void SetOutlineColor(Color32 color); // 0x0000000180D579D0-0x0000000180D57B10
		private void CreateMaterialInstance(); // 0x0000000180D45600-0x0000000180D456D0
		protected override void SetShaderDepth(); // 0x0000000180D57D70-0x0000000180D57F00
		protected override void SetCulling(); // 0x0000000180D56B00-0x0000000180D56F10
		private void SetPerspectiveCorrection(); // 0x0000000180D57C90-0x0000000180D57D70
		protected override float GetPaddingForMaterial(Material mat); // 0x0000000180D52890-0x0000000180D52970
		protected override float GetPaddingForMaterial(); // 0x0000000180D52740-0x0000000180D52890
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x0000000180D53C20-0x0000000180D56B00
		public override void ComputeMarginSize(); // 0x0000000180D454D0-0x0000000180D45600
		protected override void OnDidApplyAnimationProperties(); // 0x0000000180D53500-0x0000000180D53520
		protected override void OnTransformParentChanged(); // 0x0000000180D53900-0x0000000180D53940
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180D538B0-0x0000000180D53900
		internal override void InternalUpdate(); // 0x0000000180D52CC0-0x0000000180D52DB0
		private void OnPreRenderObject(); // 0x0000000180D53700-0x0000000180D538B0
		protected override void GenerateTextMesh(); // 0x0000000180D459C0-0x0000000180D51EE0
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x0000000180D52B80-0x0000000180D52C30
		private void SetMeshFilters(bool state); // 0x0000000180D576C0-0x0000000180D579D0
		protected override void SetActiveSubMeshes(bool state); // 0x0000000180D53A30-0x0000000180D53BD0
		protected override void ClearSubMeshObjects(); // 0x0000000180D45330-0x0000000180D454D0
		protected override Bounds GetCompoundBounds(); // 0x0000000180D51EE0-0x0000000180D523F0
		private void UpdateSDFScale(float scaleDelta); // 0x0000000180D58D50-0x0000000180D590B0
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x0000000180D441B0-0x0000000180D44960
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x0000000180D57500-0x0000000180D575A0
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x0000000180D575A0-0x0000000180D576C0
		public override void SetVerticesDirty(); // 0x0000000180D58470-0x0000000180D585B0
		public override void SetLayoutDirty(); // 0x0000000180D57050-0x0000000180D570F0
		public override void SetMaterialDirty(); // 0x00000001805AECA0-0x00000001805AECC0
		public override void SetAllDirty(); // 0x0000000180D53BD0-0x0000000180D53C20
		public override void Rebuild(CanvasUpdate update); // 0x0000000180D53940-0x0000000180D53A30
		protected override void UpdateMaterial(); // 0x0000000180D58A90-0x0000000180D58C10
		public override void UpdateMeshPadding(); // 0x0000000180D58C10-0x0000000180D58D50
		public override void ForceMeshUpdate(); // 0x0000000180D45990-0x0000000180D459A0
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x0000000180D459A0-0x0000000180D459C0
		public override TMP_TextInfo GetTextInfo(string text); // 0x0000000180D52C30-0x0000000180D52CC0
		public override void ClearMesh(bool updateMesh); // 0x0000000180D451A0-0x0000000180D45330
		public override void UpdateGeometry(Mesh mesh, int index); // 0x0000000180D58940-0x0000000180D58960
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x0000000180D590B0-0x0000000180D59350
		public override void UpdateVertexData(); // 0x0000000180D59350-0x0000000180D595F0
		public void UpdateFontAsset(); // 0x0000000180D58920-0x0000000180D58940
		public void CalculateLayoutInputHorizontal(); // 0x0000000180D44F20-0x0000000180D45070
		public void CalculateLayoutInputVertical(); // 0x0000000180D45070-0x0000000180D451A0
	}
}
