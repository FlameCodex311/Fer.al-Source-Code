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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x000000018020A8E0-0x000000018020A960
	[RequireComponent] // 0x000000018020A8E0-0x000000018020A960
	public class UIShadow : Shadow, IParameterTexture // TypeDefIndex: 16350
	{
		// Fields
		[FormerlySerializedAs] // 0x000000018020ACA0-0x000000018020AD30
		[Range] // 0x000000018020ACA0-0x000000018020AD30
		[SerializeField] // 0x000000018020ACA0-0x000000018020AD30
		[Tooltip] // 0x000000018020ACA0-0x000000018020AD30
		private float m_BlurFactor; // 0x40
		[SerializeField] // 0x000000018020B050-0x000000018020B0A0
		[Tooltip] // 0x000000018020B050-0x000000018020B0A0
		private ShadowStyle m_Style; // 0x44
		[HideInInspector] // 0x000000018020B280-0x000000018020B2C0
		[Obsolete] // 0x000000018020B280-0x000000018020B2C0
		[SerializeField] // 0x000000018020B280-0x000000018020B2C0
		private List<AdditionalShadow> m_AdditionalShadows; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <parameterIndex>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ParameterTexture <ptex>k__BackingField; // 0x58
		private int _graphicVertexCount; // 0x60
		private static readonly List<UIShadow> tmpShadows; // 0x00
		private UIEffect _uiEffect; // 0x68
		private static readonly List<UIVertex> s_Verts; // 0x08
	
		// Properties
		[Obsolete] // 0x00000001801FFB60-0x00000001801FFB90
		public float blur { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018078F350-0x000000018078F3D0
		public float blurFactor { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018078F2D0-0x000000018078F350
		public ShadowStyle style { get; set; } // 0x00000001804ADA70-0x00000001804ADA80 0x000000018078F3D0-0x000000018078F3E0
		public int parameterIndex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F8270-0x00000001803F8280 0x00000001803F82F0-0x00000001803F8300
		public ParameterTexture ptex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	
		// Nested types
		[Serializable]
		[Obsolete] // 0x00000001801E0130-0x00000001801E0140
		public class AdditionalShadow // TypeDefIndex: 16351
		{
			// Fields
			[FormerlySerializedAs] // 0x000000018020C040-0x000000018020C0A0
			[Range] // 0x000000018020C040-0x000000018020C0A0
			public float blur; // 0x10
			[FormerlySerializedAs] // 0x000000018020C310-0x000000018020C340
			public ShadowStyle style; // 0x14
			[FormerlySerializedAs] // 0x000000018020C450-0x000000018020C480
			public Color effectColor; // 0x18
			public Vector2 effectDistance; // 0x28
			public bool useGraphicAlpha; // 0x30
	
			// Constructors
			public AdditionalShadow(); // 0x0000000180778A50-0x0000000180778AC0
		}
	
		// Constructors
		public UIShadow(); // 0x000000018078F260-0x000000018078F2D0
		static UIShadow(); // 0x000000018078F1D0-0x000000018078F260
	
		// Methods
		protected override void OnEnable(); // 0x000000018078E640-0x000000018078E700
		protected override void OnDisable(); // 0x000000018078E590-0x000000018078E640
		public override void ModifyMesh(VertexHelper vh); // 0x000000018078DF50-0x000000018078E590
		private void _ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 effectDistance, ShadowStyle style, bool useGraphicAlpha); // 0x000000018078EBE0-0x000000018078F130
		private void _ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha); // 0x000000018078E700-0x000000018078EBE0
		private void _SetDirty(); // 0x000000018078F130-0x000000018078F1D0
	}
}
