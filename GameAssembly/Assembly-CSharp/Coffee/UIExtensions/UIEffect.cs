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
	[AddComponentMenu] // 0x00000001800F1A40-0x00000001800F1AE0
	[DisallowMultipleComponent] // 0x00000001800F1A40-0x00000001800F1AE0
	[ExecuteAlways] // 0x00000001800F1A40-0x00000001800F1AE0
	[RequireComponent] // 0x00000001800F1A40-0x00000001800F1AE0
	public class UIEffect : UIEffectBase // TypeDefIndex: 15500
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect"; // Metadata: 0x00784B7E
		private static readonly ParameterTexture _ptex; // 0x00
		[FormerlySerializedAs] // 0x00000001800F1EE0-0x00000001800F1F70
		[Range] // 0x00000001800F1EE0-0x00000001800F1F70
		[SerializeField] // 0x00000001800F1EE0-0x00000001800F1F70
		[Tooltip] // 0x00000001800F1EE0-0x00000001800F1F70
		private float m_EffectFactor; // 0x38
		[Range] // 0x00000001800F2350-0x00000001800F23C0
		[SerializeField] // 0x00000001800F2350-0x00000001800F23C0
		[Tooltip] // 0x00000001800F2350-0x00000001800F23C0
		private float m_ColorFactor; // 0x3C
		[FormerlySerializedAs] // 0x00000001800F26B0-0x00000001800F2740
		[Range] // 0x00000001800F26B0-0x00000001800F2740
		[SerializeField] // 0x00000001800F26B0-0x00000001800F2740
		[Tooltip] // 0x00000001800F26B0-0x00000001800F2740
		private float m_BlurFactor; // 0x40
		[FormerlySerializedAs] // 0x00000001800F2970-0x00000001800F29E0
		[SerializeField] // 0x00000001800F2970-0x00000001800F29E0
		[Tooltip] // 0x00000001800F2970-0x00000001800F29E0
		private EffectMode m_EffectMode; // 0x44
		[SerializeField] // 0x00000001800F2D10-0x00000001800F2D60
		[Tooltip] // 0x00000001800F2D10-0x00000001800F2D60
		private ColorMode m_ColorMode; // 0x48
		[SerializeField] // 0x00000001800F2FC0-0x00000001800F3010
		[Tooltip] // 0x00000001800F2FC0-0x00000001800F3010
		private BlurMode m_BlurMode; // 0x4C
		[SerializeField] // 0x00000001800F3250-0x00000001800F32A0
		[Tooltip] // 0x00000001800F3250-0x00000001800F32A0
		private bool m_AdvancedBlur; // 0x50
		[HideInInspector] // 0x00000001800F3470-0x00000001800F34D0
		[Obsolete] // 0x00000001800F3470-0x00000001800F34D0
		[Range] // 0x00000001800F3470-0x00000001800F34D0
		[SerializeField] // 0x00000001800F3470-0x00000001800F34D0
		private float m_ShadowBlur; // 0x54
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private ShadowStyle m_ShadowStyle; // 0x58
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private Color m_ShadowColor; // 0x5C
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private Vector2 m_EffectDistance; // 0x6C
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private bool m_UseGraphicAlpha; // 0x74
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private Color m_EffectColor; // 0x78
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private List<UIShadow.AdditionalShadow> m_AdditionalShadows; // 0x88
	
		// Properties
		[Obsolete] // 0x00000001800F1360-0x00000001800F1390
		public float toneLevel { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x0000000181285690-0x0000000181285720
		public float effectFactor { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x0000000181285600-0x0000000181285690
		public float colorFactor { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x0000000181285500-0x0000000181285590
		[Obsolete] // 0x00000001800F4A30-0x00000001800F4A60
		public float blur { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000181285470-0x0000000181285500
		[Obsolete] // 0x00000001800F1360-0x00000001800F1390
		public float blurFactor { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x00000001812853E0-0x0000000181285470
		[Obsolete] // 0x00000001800F4C80-0x00000001800F4CB0
		public EffectMode toneMode { get; } // 0x0000000180478650-0x0000000180478660 
		public EffectMode effectMode { get; } // 0x0000000180478650-0x0000000180478660 
		public ColorMode colorMode { get; } // 0x0000000180384C10-0x0000000180384C20 
		public BlurMode blurMode { get; } // 0x00000001804D0660-0x00000001804D0670 
		public Color effectColor { get; set; } // 0x0000000181285330-0x0000000181285380 0x0000000181285590-0x0000000181285600
		public override ParameterTexture ptex { get; } // 0x0000000181285380-0x00000001812853E0 
	
		// Nested types
		public enum BlurEx // TypeDefIndex: 15501
		{
			None = 0,
			Ex = 1
		}
	
		// Constructors
		public UIEffect(); // 0x0000000181285230-0x0000000181285330
		static UIEffect(); // 0x00000001812851C0-0x0000000181285230
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x00000001812841D0-0x0000000181285040
		protected override void SetDirty(); // 0x0000000181285040-0x00000001812851C0
		private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global); // 0x0000000181283EC0-0x00000001812841D0
	}
}
