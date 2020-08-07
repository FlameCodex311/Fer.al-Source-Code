/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001801F5C90-0x00000001801F5CC0
	public class UIDissolve : UIEffectBase // TypeDefIndex: 16338
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-Dissolve"; // Metadata: 0x007BBCCE
		private static readonly ParameterTexture _ptex; // 0x00
		[FormerlySerializedAs] // 0x00000001801F7250-0x00000001801F72E0
		[Range] // 0x00000001801F7250-0x00000001801F72E0
		[SerializeField] // 0x00000001801F7250-0x00000001801F72E0
		[Tooltip] // 0x00000001801F7250-0x00000001801F72E0
		private float m_EffectFactor; // 0x38
		[Range] // 0x00000001801F77C0-0x00000001801F7830
		[SerializeField] // 0x00000001801F77C0-0x00000001801F7830
		[Tooltip] // 0x00000001801F77C0-0x00000001801F7830
		private float m_Width; // 0x3C
		[Range] // 0x00000001801F7A00-0x00000001801F7A70
		[SerializeField] // 0x00000001801F7A00-0x00000001801F7A70
		[Tooltip] // 0x00000001801F7A00-0x00000001801F7A70
		private float m_Softness; // 0x40
		[ColorUsage] // 0x00000001801F7D40-0x00000001801F7DA0
		[SerializeField] // 0x00000001801F7D40-0x00000001801F7DA0
		[Tooltip] // 0x00000001801F7D40-0x00000001801F7DA0
		private Color m_Color; // 0x44
		[SerializeField] // 0x00000001801F92E0-0x00000001801F9330
		[Tooltip] // 0x00000001801F92E0-0x00000001801F9330
		private ColorMode m_ColorMode; // 0x54
		[SerializeField] // 0x00000001801F9560-0x00000001801F95B0
		[Tooltip] // 0x00000001801F9560-0x00000001801F95B0
		private Texture m_NoiseTexture; // 0x58
		[SerializeField] // 0x00000001801F9760-0x00000001801F97B0
		[Tooltip] // 0x00000001801F9760-0x00000001801F97B0
		protected EffectArea m_EffectArea; // 0x60
		[SerializeField] // 0x00000001801F9A10-0x00000001801F9A60
		[Tooltip] // 0x00000001801F9A10-0x00000001801F9A60
		private bool m_KeepAspectRatio; // 0x64
		[Header] // 0x00000001801F9E80-0x00000001801F9ED0
		[SerializeField] // 0x00000001801F9E80-0x00000001801F9ED0
		private EffectPlayer m_Player; // 0x68
		[HideInInspector] // 0x00000001801FA1F0-0x00000001801FA250
		[Obsolete] // 0x00000001801FA1F0-0x00000001801FA250
		[Range] // 0x00000001801FA1F0-0x00000001801FA250
		[SerializeField] // 0x00000001801FA1F0-0x00000001801FA250
		private float m_Duration; // 0x70
		[HideInInspector] // 0x00000001801FA700-0x00000001801FA740
		[Obsolete] // 0x00000001801FA700-0x00000001801FA740
		[SerializeField] // 0x00000001801FA700-0x00000001801FA740
		private AnimatorUpdateMode m_UpdateMode; // 0x74
		private MaterialCache _materialCache; // 0x78
	
		// Properties
		[Obsolete] // 0x00000001801FAC00-0x00000001801FAC30
		public float location { get; set; } // 0x0000000180788790-0x00000001807887A0 0x0000000180788BB0-0x0000000180788C50
		public float effectFactor { get; set; } // 0x0000000180788790-0x00000001807887A0 0x00000001807884E0-0x0000000180788580
		public float width { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x0000000180789010-0x00000001807890B0
		public float softness { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x0000000180788EF0-0x0000000180788F90
		public Color color { get; set; } // 0x0000000180788710-0x0000000180788720 0x0000000180788A40-0x0000000180788AA0
		public Texture noiseTexture { get; set; } // 0x0000000180788880-0x0000000180788900 0x0000000180788DA0-0x0000000180788E70
		public EffectArea effectArea { get; set; } // 0x00000001804ADA80-0x00000001804ADA90 0x0000000180788B70-0x0000000180788B90
		public bool keepAspectRatio { get; set; } // 0x00000001804CDB10-0x00000001804CDB20 0x0000000180788B90-0x0000000180788BB0
		public ColorMode colorMode { get; } // 0x0000000180379EE0-0x0000000180379EF0 
		[Obsolete] // 0x00000001801FAE00-0x00000001801FAE30
		public bool play { get; set; } // 0x0000000180788900-0x0000000180788970 0x0000000180788E70-0x0000000180788EF0
		[Obsolete] // 0x00000001801E0130-0x00000001801E0140
		public bool loop { get; set; } // 0x0000000180788810-0x0000000180788880 0x0000000180788D20-0x0000000180788DA0
		public float duration { get; set; } // 0x0000000180788720-0x0000000180788790 0x0000000180788AA0-0x0000000180788B70
		[Obsolete] // 0x00000001801E0130-0x00000001801E0140
		public float loopDelay { get; set; } // 0x00000001807887A0-0x0000000180788810 0x0000000180788C50-0x0000000180788D20
		public AnimatorUpdateMode updateMode { get; set; } // 0x00000001807889D0-0x0000000180788A40 0x0000000180788F90-0x0000000180789010
		public override ParameterTexture ptex { get; } // 0x0000000180788970-0x00000001807889D0 
		private EffectPlayer _player { get; } // 0x00000001807886A0-0x0000000180788710 
	
		// Constructors
		public UIDissolve(); // 0x00000001807885F0-0x00000001807886A0
		static UIDissolve(); // 0x0000000180788580-0x00000001807885F0
	
		// Methods
		public override void ModifyMaterial(); // 0x0000000180787610-0x0000000180787960
		public override void ModifyMesh(VertexHelper vh); // 0x0000000180787960-0x0000000180787EB0
		protected override void SetDirty(); // 0x0000000180788150-0x00000001807883A0
		public void Play(); // 0x00000001807880D0-0x0000000180788150
		public void Stop(); // 0x00000001807883A0-0x0000000180788410
		protected override void OnEnable(); // 0x0000000180788000-0x00000001807880D0
		protected override void OnDisable(); // 0x0000000180787EB0-0x0000000180788000
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material <ModifyMaterial>b__56_0(); // 0x0000000180788410-0x00000001807884E0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnEnable>b__61_0(float f); // 0x00000001807884E0-0x0000000180788580
	}
}
