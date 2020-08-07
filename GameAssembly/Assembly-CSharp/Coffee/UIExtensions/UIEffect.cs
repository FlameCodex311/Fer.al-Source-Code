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
	[AddComponentMenu] // 0x00000001801FB240-0x00000001801FB2E0
	[DisallowMultipleComponent] // 0x00000001801FB240-0x00000001801FB2E0
	[ExecuteAlways] // 0x00000001801FB240-0x00000001801FB2E0
	[RequireComponent] // 0x00000001801FB240-0x00000001801FB2E0
	public class UIEffect : UIEffectBase // TypeDefIndex: 16339
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect"; // Metadata: 0x007BBCEE
		private static readonly ParameterTexture _ptex; // 0x00
		[FormerlySerializedAs] // 0x00000001801FB6E0-0x00000001801FB770
		[Range] // 0x00000001801FB6E0-0x00000001801FB770
		[SerializeField] // 0x00000001801FB6E0-0x00000001801FB770
		[Tooltip] // 0x00000001801FB6E0-0x00000001801FB770
		private float m_EffectFactor; // 0x38
		[Range] // 0x00000001801FCFB0-0x00000001801FD020
		[SerializeField] // 0x00000001801FCFB0-0x00000001801FD020
		[Tooltip] // 0x00000001801FCFB0-0x00000001801FD020
		private float m_ColorFactor; // 0x3C
		[FormerlySerializedAs] // 0x00000001801FD3A0-0x00000001801FD430
		[Range] // 0x00000001801FD3A0-0x00000001801FD430
		[SerializeField] // 0x00000001801FD3A0-0x00000001801FD430
		[Tooltip] // 0x00000001801FD3A0-0x00000001801FD430
		private float m_BlurFactor; // 0x40
		[FormerlySerializedAs] // 0x00000001801FD9C0-0x00000001801FDA30
		[SerializeField] // 0x00000001801FD9C0-0x00000001801FDA30
		[Tooltip] // 0x00000001801FD9C0-0x00000001801FDA30
		private EffectMode m_EffectMode; // 0x44
		[SerializeField] // 0x00000001801FDF00-0x00000001801FDF50
		[Tooltip] // 0x00000001801FDF00-0x00000001801FDF50
		private ColorMode m_ColorMode; // 0x48
		[SerializeField] // 0x00000001801FE1D0-0x00000001801FE220
		[Tooltip] // 0x00000001801FE1D0-0x00000001801FE220
		private BlurMode m_BlurMode; // 0x4C
		[SerializeField] // 0x00000001801FE590-0x00000001801FE5E0
		[Tooltip] // 0x00000001801FE590-0x00000001801FE5E0
		private bool m_AdvancedBlur; // 0x50
		[HideInInspector] // 0x00000001801FE790-0x00000001801FE7F0
		[Obsolete] // 0x00000001801FE790-0x00000001801FE7F0
		[Range] // 0x00000001801FE790-0x00000001801FE7F0
		[SerializeField] // 0x00000001801FE790-0x00000001801FE7F0
		private float m_ShadowBlur; // 0x54
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private ShadowStyle m_ShadowStyle; // 0x58
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private Color m_ShadowColor; // 0x5C
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private Vector2 m_EffectDistance; // 0x6C
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private bool m_UseGraphicAlpha; // 0x74
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private Color m_EffectColor; // 0x78
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private List<UIShadow.AdditionalShadow> m_AdditionalShadows; // 0x88
	
		// Properties
		[Obsolete] // 0x00000001801FAC00-0x00000001801FAC30
		public float toneLevel { get; set; } // 0x0000000180788790-0x00000001807887A0 0x000000018078C7A0-0x000000018078C830
		public float effectFactor { get; set; } // 0x0000000180788790-0x00000001807887A0 0x000000018078C710-0x000000018078C7A0
		public float colorFactor { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x000000018078C610-0x000000018078C6A0
		[Obsolete] // 0x00000001801FFB60-0x00000001801FFB90
		public float blur { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018078C580-0x000000018078C610
		[Obsolete] // 0x00000001801FAC00-0x00000001801FAC30
		public float blurFactor { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018078C4F0-0x000000018078C580
		[Obsolete] // 0x00000001801FFCD0-0x00000001801FFD00
		public EffectMode toneMode { get; } // 0x00000001804ADA70-0x00000001804ADA80 
		public EffectMode effectMode { get; } // 0x00000001804ADA70-0x00000001804ADA80 
		public ColorMode colorMode { get; } // 0x0000000180379ED0-0x0000000180379EE0 
		public BlurMode blurMode { get; } // 0x000000018078C430-0x000000018078C440 
		public Color effectColor { get; set; } // 0x000000018078C440-0x000000018078C490 0x000000018078C6A0-0x000000018078C710
		public override ParameterTexture ptex { get; } // 0x000000018078C490-0x000000018078C4F0 
	
		// Nested types
		public enum BlurEx // TypeDefIndex: 16340
		{
			None = 0,
			Ex = 1
		}
	
		// Constructors
		public UIEffect(); // 0x000000018078C330-0x000000018078C430
		static UIEffect(); // 0x000000018078C2C0-0x000000018078C330
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018078B2F0-0x000000018078C150
		protected override void SetDirty(); // 0x000000018078C150-0x000000018078C2C0
		private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global); // 0x000000018078AFE0-0x000000018078B2F0
	}
}
