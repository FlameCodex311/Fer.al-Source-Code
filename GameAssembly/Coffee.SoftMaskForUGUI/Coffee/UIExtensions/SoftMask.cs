/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Image 59: Coffee.SoftMaskForUGUI.dll - Assembly: Coffee.SoftMaskForUGUI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7415-7419

namespace Coffee.UIExtensions
{
	public class SoftMask : Mask, IMeshModifier // TypeDefIndex: 7416
	{
		// Fields
		private static readonly List<SoftMask>[] s_TmpSoftMasks; // 0x00
		private static readonly Color[] s_ClearColors; // 0x08
		[SerializeField] // 0x0000000180170F00-0x0000000180170F50
		[Tooltip] // 0x0000000180170F00-0x0000000180170F50
		private DesamplingRate m_DesamplingRate; // 0x40
		[Range] // 0x0000000180171130-0x00000001801711A0
		[SerializeField] // 0x0000000180171130-0x00000001801711A0
		[Tooltip] // 0x0000000180171130-0x00000001801711A0
		private float m_Softness; // 0x44
		[SerializeField] // 0x00000001801714B0-0x0000000180171500
		[Tooltip] // 0x00000001801714B0-0x0000000180171500
		private bool m_IgnoreParent; // 0x48
		[SerializeField] // 0x0000000180171680-0x00000001801716D0
		[Tooltip] // 0x0000000180171680-0x00000001801716D0
		private bool m_PartOfParent; // 0x49
		private static Shader s_SoftMaskShader; // 0x10
		private static Texture2D s_ReadTexture; // 0x18
		private static List<SoftMask> s_ActiveSoftMasks; // 0x20
		private static List<SoftMask> s_TempRelatables; // 0x28
		private static int s_StencilCompId; // 0x30
		private static int s_ColorMaskId; // 0x34
		private static int s_MainTexId; // 0x38
		private static int s_SoftnessId; // 0x3C
		private MaterialPropertyBlock _mpb; // 0x50
		private CommandBuffer _cb; // 0x58
		private Material _material; // 0x60
		private RenderTexture _softMaskBuffer; // 0x68
		private int _stencilDepth; // 0x70
		private Mesh _mesh; // 0x78
		private SoftMask _parent; // 0x80
		private List<SoftMask> _children; // 0x88
		private bool _hasChanged; // 0x90
	
		// Properties
		public DesamplingRate desamplingRate { get; set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001822C80D0-0x00000001822C80F0
		public float softness { get; set; } // 0x0000000180487D40-0x0000000180487D50 0x00000001822C8210-0x00000001822C8290
		public bool ignoreParent { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x00000001822C8190-0x00000001822C81D0
		public bool partOfParent { get; set; } // 0x00000001805E3A70-0x00000001805E3A80 0x00000001822C81D0-0x00000001822C8210
		public RenderTexture softMaskBuffer { get; } // 0x00000001822C7E50-0x00000001822C80D0 
		public bool hasChanged { get; private set; } // 0x00000001822C7B70-0x00000001822C7C00 0x00000001822C80F0-0x00000001822C8190
		public SoftMask parent { get; } // 0x000000018035FCB0-0x000000018035FCC0 
		private Material material { get; } // 0x00000001822C7C00-0x00000001822C7DA0 
		private Mesh mesh { get; } // 0x00000001822C7DA0-0x00000001822C7E50 
	
		// Nested types
		public enum DesamplingRate // TypeDefIndex: 7417
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7418
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<SoftMask> <>9__61_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001822C91E0-0x00000001822C9240
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetParent>b__61_0(SoftMask x); // 0x00000001822C9180-0x00000001822C91E0
		}
	
		// Constructors
		public SoftMask(); // 0x00000001822C7B00-0x00000001822C7B70
		static SoftMask(); // 0x00000001822C76E0-0x00000001822C7B00
	
		// Methods
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001822C4FC0-0x00000001822C50B0
		void IMeshModifier.ModifyMesh(VertexHelper verts); // 0x00000001822C6550-0x00000001822C65B0
		public void ModifyMesh(Mesh inMesh); // 0x00000001822C57D0-0x00000001822C58E0
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera, Graphic g, int[] interactions); // 0x00000001822C5620-0x00000001822C57D0
		public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x00000001803C29F0-0x00000001803C2A00
		protected override void OnEnable(); // 0x00000001822C5C10-0x00000001822C5F70
		protected override void OnDisable(); // 0x00000001822C58E0-0x00000001822C5C10
		protected override void OnTransformParentChanged(); // 0x00000001822C5F80-0x00000001822C6140
		protected override void OnRectTransformDimensionsChange(); // 0x00000001822C5F70-0x00000001822C5F80
		private static void UpdateMaskTextures(); // 0x00000001822C7380-0x00000001822C76E0
		private void UpdateMaskTexture(); // 0x00000001822C65B0-0x00000001822C7380
		private void GetDesamplingSize(DesamplingRate rate, out int w, out int h); // 0x00000001822C4EA0-0x00000001822C4FC0
		private void ReleaseRT(ref RenderTexture tmpRT); // 0x00000001822C61D0-0x00000001822C6250
		private void ReleaseObject(UnityEngine.Object obj); // 0x00000001822C6140-0x00000001822C61D0
		private void SetParent(SoftMask newParent); // 0x00000001822C6250-0x00000001822C6550
		private float GetPixelValue(int x, int y, int[] interactions); // 0x00000001822C50B0-0x00000001822C5620
	}
}
