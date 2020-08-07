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

// Image 60: Coffee.SoftMaskForUGUI.dll - Assembly: Coffee.SoftMaskForUGUI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7581-7585

namespace Coffee.UIExtensions
{
	public class SoftMask : Mask, IMeshModifier // TypeDefIndex: 7582
	{
		// Fields
		private static readonly List<SoftMask>[] s_TmpSoftMasks; // 0x00
		private static readonly Color[] s_ClearColors; // 0x08
		[SerializeField] // 0x0000000180213770-0x00000001802137C0
		[Tooltip] // 0x0000000180213770-0x00000001802137C0
		private DesamplingRate m_DesamplingRate; // 0x40
		[Range] // 0x0000000180213B50-0x0000000180213BC0
		[SerializeField] // 0x0000000180213B50-0x0000000180213BC0
		[Tooltip] // 0x0000000180213B50-0x0000000180213BC0
		private float m_Softness; // 0x44
		[SerializeField] // 0x0000000180213DF0-0x0000000180213E40
		[Tooltip] // 0x0000000180213DF0-0x0000000180213E40
		private bool m_IgnoreParent; // 0x48
		[SerializeField] // 0x0000000180214120-0x0000000180214170
		[Tooltip] // 0x0000000180214120-0x0000000180214170
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
		public DesamplingRate desamplingRate { get; set; } // 0x0000000180379F10-0x0000000180379F20 0x00000001820BFE90-0x00000001820BFEB0
		public float softness { get; set; } // 0x0000000180690330-0x0000000180690340 0x00000001820BFFD0-0x00000001820C0050
		public bool ignoreParent { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001820BFF50-0x00000001820BFF90
		public bool partOfParent { get; set; } // 0x00000001803C9D80-0x00000001803C9D90 0x00000001820BFF90-0x00000001820BFFD0
		public RenderTexture softMaskBuffer { get; } // 0x00000001820BFC10-0x00000001820BFE90 
		public bool hasChanged { get; private set; } // 0x00000001820BF930-0x00000001820BF9C0 0x00000001820BFEB0-0x00000001820BFF50
		public SoftMask parent { get; } // 0x000000018040ED60-0x000000018040ED70 
		private Material material { get; } // 0x00000001820BF9C0-0x00000001820BFB60 
		private Mesh mesh { get; } // 0x00000001820BFB60-0x00000001820BFC10 
	
		// Nested types
		public enum DesamplingRate // TypeDefIndex: 7583
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7584
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<SoftMask> <>9__61_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001820C0F80-0x00000001820C0FE0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetParent>b__61_0(SoftMask x); // 0x00000001820C0F20-0x00000001820C0F80
		}
	
		// Constructors
		public SoftMask(); // 0x00000001820BF8C0-0x00000001820BF930
		static SoftMask(); // 0x00000001820BF4D0-0x00000001820BF8C0
	
		// Methods
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001820BCE50-0x00000001820BCF40
		void IMeshModifier.ModifyMesh(VertexHelper verts); // 0x00000001820BE390-0x00000001820BE3F0
		public void ModifyMesh(Mesh inMesh); // 0x00000001820BD630-0x00000001820BD730
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera, Graphic g, int[] interactions); // 0x00000001820BD480-0x00000001820BD630
		public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000180380B60-0x0000000180380B70
		protected override void OnEnable(); // 0x00000001820BDA60-0x00000001820BDDB0
		protected override void OnDisable(); // 0x00000001820BD730-0x00000001820BDA60
		protected override void OnTransformParentChanged(); // 0x00000001820BDDC0-0x00000001820BDF80
		protected override void OnRectTransformDimensionsChange(); // 0x00000001820BDDB0-0x00000001820BDDC0
		private static void UpdateMaskTextures(); // 0x00000001820BF180-0x00000001820BF4D0
		private void UpdateMaskTexture(); // 0x00000001820BE3F0-0x00000001820BF180
		private void GetDesamplingSize(DesamplingRate rate, out int w, out int h); // 0x00000001820BCD30-0x00000001820BCE50
		private void ReleaseRT(ref RenderTexture tmpRT); // 0x00000001820BE010-0x00000001820BE090
		private void ReleaseObject(UnityEngine.Object obj); // 0x00000001820BDF80-0x00000001820BE010
		private void SetParent(SoftMask newParent); // 0x00000001820BE090-0x00000001820BE390
		private float GetPixelValue(int x, int y, int[] interactions); // 0x00000001820BCF40-0x00000001820BD480
	}
}
