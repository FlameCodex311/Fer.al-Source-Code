/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800EE320-0x00000001800EE350
	public class UIDissolve : UIEffectBase // TypeDefIndex: 15499
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-Dissolve"; // Metadata: 0x00784B5E
		private static readonly ParameterTexture _ptex; // 0x00
		[FormerlySerializedAs] // 0x00000001800EE500-0x00000001800EE590
		[Range] // 0x00000001800EE500-0x00000001800EE590
		[SerializeField] // 0x00000001800EE500-0x00000001800EE590
		[Tooltip] // 0x00000001800EE500-0x00000001800EE590
		private float m_EffectFactor; // 0x38
		[Range] // 0x00000001800EE870-0x00000001800EE8E0
		[SerializeField] // 0x00000001800EE870-0x00000001800EE8E0
		[Tooltip] // 0x00000001800EE870-0x00000001800EE8E0
		private float m_Width; // 0x3C
		[Range] // 0x00000001800EEAB0-0x00000001800EEB20
		[SerializeField] // 0x00000001800EEAB0-0x00000001800EEB20
		[Tooltip] // 0x00000001800EEAB0-0x00000001800EEB20
		private float m_Softness; // 0x40
		[ColorUsage] // 0x00000001800EEDC0-0x00000001800EEE20
		[SerializeField] // 0x00000001800EEDC0-0x00000001800EEE20
		[Tooltip] // 0x00000001800EEDC0-0x00000001800EEE20
		private Color m_Color; // 0x44
		[SerializeField] // 0x00000001800EF000-0x00000001800EF050
		[Tooltip] // 0x00000001800EF000-0x00000001800EF050
		private ColorMode m_ColorMode; // 0x54
		[SerializeField] // 0x00000001800EF160-0x00000001800EF1B0
		[Tooltip] // 0x00000001800EF160-0x00000001800EF1B0
		private Texture m_NoiseTexture; // 0x58
		[SerializeField] // 0x00000001800EF290-0x00000001800EF2E0
		[Tooltip] // 0x00000001800EF290-0x00000001800EF2E0
		protected EffectArea m_EffectArea; // 0x60
		[SerializeField] // 0x00000001800EF4F0-0x00000001800EF540
		[Tooltip] // 0x00000001800EF4F0-0x00000001800EF540
		private bool m_KeepAspectRatio; // 0x64
		[Header] // 0x00000001800EF790-0x00000001800EF7E0
		[SerializeField] // 0x00000001800EF790-0x00000001800EF7E0
		private EffectPlayer m_Player; // 0x68
		[HideInInspector] // 0x00000001800EF890-0x00000001800EF8F0
		[Obsolete] // 0x00000001800EF890-0x00000001800EF8F0
		[Range] // 0x00000001800EF890-0x00000001800EF8F0
		[SerializeField] // 0x00000001800EF890-0x00000001800EF8F0
		private float m_Duration; // 0x70
		[HideInInspector] // 0x00000001800EFC60-0x00000001800EFCA0
		[Obsolete] // 0x00000001800EFC60-0x00000001800EFCA0
		[SerializeField] // 0x00000001800EFC60-0x00000001800EFCA0
		private AnimatorUpdateMode m_UpdateMode; // 0x74
		private MaterialCache _materialCache; // 0x78
	
		// Properties
		[Obsolete] // 0x00000001800F1360-0x00000001800F1390
		public float location { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x00000001812839C0-0x0000000181283A60
		public float effectFactor { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x00000001812832C0-0x0000000181283360
		public float width { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x0000000181283E20-0x0000000181283EC0
		public float softness { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000181283D00-0x0000000181283DA0
		public Color color { get; set; } // 0x00000001812834F0-0x0000000181283500 0x0000000181283850-0x00000001812838B0
		public Texture noiseTexture { get; set; } // 0x0000000181283680-0x0000000181283700 0x0000000181283BB0-0x0000000181283C80
		public EffectArea effectArea { get; set; } // 0x00000001804A3730-0x00000001804A3740 0x0000000181283980-0x00000001812839A0
		public bool keepAspectRatio { get; set; } // 0x0000000180EF8A10-0x0000000180EF8A20 0x00000001812839A0-0x00000001812839C0
		public ColorMode colorMode { get; } // 0x0000000180369C60-0x0000000180369C70 
		[Obsolete] // 0x00000001800F1540-0x00000001800F1570
		public bool play { get; set; } // 0x0000000181283700-0x0000000181283780 0x0000000181283C80-0x0000000181283D00
		[Obsolete] // 0x00000001800B80C0-0x00000001800B80D0
		public bool loop { get; set; } // 0x0000000181283600-0x0000000181283680 0x0000000181283B30-0x0000000181283BB0
		public float duration { get; set; } // 0x0000000181283500-0x0000000181283580 0x00000001812838B0-0x0000000181283980
		[Obsolete] // 0x00000001800B80C0-0x00000001800B80D0
		public float loopDelay { get; set; } // 0x0000000181283580-0x0000000181283600 0x0000000181283A60-0x0000000181283B30
		public AnimatorUpdateMode updateMode { get; set; } // 0x00000001812837E0-0x0000000181283850 0x0000000181283DA0-0x0000000181283E20
		public override ParameterTexture ptex { get; } // 0x0000000181283780-0x00000001812837E0 
		private EffectPlayer _player { get; } // 0x0000000181283480-0x00000001812834F0 
	
		// Constructors
		public UIDissolve(); // 0x00000001812833D0-0x0000000181283480
		static UIDissolve(); // 0x0000000181283360-0x00000001812833D0
	
		// Methods
		public override void ModifyMaterial(); // 0x00000001812821F0-0x0000000181282540
		public override void ModifyMesh(VertexHelper vh); // 0x0000000181282540-0x0000000181282AA0
		protected override void SetDirty(); // 0x0000000181282F10-0x0000000181283170
		public void Play(); // 0x0000000181282E90-0x0000000181282F10
		public void Stop(); // 0x0000000181283170-0x00000001812831F0
		protected override void OnEnable(); // 0x0000000181282C60-0x0000000181282E90
		protected override void OnDisable(); // 0x0000000181282AA0-0x0000000181282C60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Material <ModifyMaterial>b__56_0(); // 0x00000001812831F0-0x00000001812832C0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnEnable>b__61_0(float f); // 0x00000001812832C0-0x0000000181283360
	}
}
