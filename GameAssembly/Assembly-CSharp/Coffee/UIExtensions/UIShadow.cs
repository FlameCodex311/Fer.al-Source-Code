/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800FDB90-0x00000001800FDC10
	[RequireComponent] // 0x00000001800FDB90-0x00000001800FDC10
	public class UIShadow : Shadow, IParameterTexture // TypeDefIndex: 15511
	{
		// Fields
		[FormerlySerializedAs] // 0x00000001800FE040-0x00000001800FE0D0
		[Range] // 0x00000001800FE040-0x00000001800FE0D0
		[SerializeField] // 0x00000001800FE040-0x00000001800FE0D0
		[Tooltip] // 0x00000001800FE040-0x00000001800FE0D0
		private float m_BlurFactor; // 0x40
		[SerializeField] // 0x00000001800FE250-0x00000001800FE2A0
		[Tooltip] // 0x00000001800FE250-0x00000001800FE2A0
		private ShadowStyle m_Style; // 0x44
		[HideInInspector] // 0x00000001800FE470-0x00000001800FE4B0
		[Obsolete] // 0x00000001800FE470-0x00000001800FE4B0
		[SerializeField] // 0x00000001800FE470-0x00000001800FE4B0
		private List<AdditionalShadow> m_AdditionalShadows; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <parameterIndex>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ParameterTexture <ptex>k__BackingField; // 0x58
		private int _graphicVertexCount; // 0x60
		private static readonly List<UIShadow> tmpShadows; // 0x00
		private UIEffect _uiEffect; // 0x68
		private static readonly List<UIVertex> s_Verts; // 0x08
	
		// Properties
		[Obsolete] // 0x00000001800F4A30-0x00000001800F4A60
		public float blur { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000181489460-0x00000001814894E0
		public float blurFactor { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x00000001814893E0-0x0000000181489460
		public ShadowStyle style { get; set; } // 0x0000000180478650-0x0000000180478660 0x00000001814894E0-0x00000001814894F0
		public int parameterIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BA0-0x0000000180369BB0 0x0000000180478850-0x0000000180478860
		public ParameterTexture ptex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
	
		// Nested types
		[Serializable]
		[Obsolete] // 0x00000001800B80C0-0x00000001800B80D0
		public class AdditionalShadow // TypeDefIndex: 15512
		{
			// Fields
			[FormerlySerializedAs] // 0x00000001800FEF60-0x00000001800FEFC0
			[Range] // 0x00000001800FEF60-0x00000001800FEFC0
			public float blur; // 0x10
			[FormerlySerializedAs] // 0x00000001800FF1D0-0x00000001800FF200
			public ShadowStyle style; // 0x14
			[FormerlySerializedAs] // 0x00000001800FF480-0x00000001800FF4B0
			public Color effectColor; // 0x18
			public Vector2 effectDistance; // 0x28
			public bool useGraphicAlpha; // 0x30
	
			// Constructors
			public AdditionalShadow(); // 0x000000018146F870-0x000000018146F8E0
		}
	
		// Constructors
		public UIShadow(); // 0x0000000181489370-0x00000001814893E0
		static UIShadow(); // 0x00000001814892E0-0x0000000181489370
	
		// Methods
		protected override void OnEnable(); // 0x0000000181488790-0x0000000181488850
		protected override void OnDisable(); // 0x0000000181488750-0x0000000181488790
		public override void ModifyMesh(VertexHelper vh); // 0x0000000181488100-0x0000000181488750
		private void _ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 effectDistance, ShadowStyle style, bool useGraphicAlpha); // 0x0000000181488CF0-0x0000000181489240
		private void _ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha); // 0x0000000181488850-0x0000000181488CF0
		private void _SetDirty(); // 0x0000000181489240-0x00000001814892E0
	}
}
