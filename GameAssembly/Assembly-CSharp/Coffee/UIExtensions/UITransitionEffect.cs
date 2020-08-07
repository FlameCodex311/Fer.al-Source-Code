/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x0000000180213680-0x00000001802136B0
	public class UITransitionEffect : UIEffectBase // TypeDefIndex: 16353
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-Transition"; // Metadata: 0x007BBD93
		private static readonly ParameterTexture _ptex; // 0x00
		[SerializeField] // 0x0000000180213910-0x0000000180213960
		[Tooltip] // 0x0000000180213910-0x0000000180213960
		private EffectMode m_EffectMode; // 0x38
		[Range] // 0x0000000180213C20-0x0000000180213C90
		[SerializeField] // 0x0000000180213C20-0x0000000180213C90
		[Tooltip] // 0x0000000180213C20-0x0000000180213C90
		private float m_EffectFactor; // 0x3C
		[SerializeField] // 0x0000000180213F00-0x0000000180213F50
		[Tooltip] // 0x0000000180213F00-0x0000000180213F50
		private Texture m_TransitionTexture; // 0x40
		[SerializeField] // 0x00000001801F9760-0x00000001801F97B0
		[Tooltip] // 0x00000001801F9760-0x00000001801F97B0
		private EffectArea m_EffectArea; // 0x48
		[SerializeField] // 0x00000001801F9A10-0x00000001801F9A60
		[Tooltip] // 0x00000001801F9A10-0x00000001801F9A60
		private bool m_KeepAspectRatio; // 0x4C
		[Range] // 0x0000000180214680-0x00000001802146F0
		[SerializeField] // 0x0000000180214680-0x00000001802146F0
		[Tooltip] // 0x0000000180214680-0x00000001802146F0
		private float m_DissolveWidth; // 0x50
		[Range] // 0x0000000180214B50-0x0000000180214BC0
		[SerializeField] // 0x0000000180214B50-0x0000000180214BC0
		[Tooltip] // 0x0000000180214B50-0x0000000180214BC0
		private float m_DissolveSoftness; // 0x54
		[ColorUsage] // 0x0000000180214F90-0x0000000180214FF0
		[SerializeField] // 0x0000000180214F90-0x0000000180214FF0
		[Tooltip] // 0x0000000180214F90-0x0000000180214FF0
		private Color m_DissolveColor; // 0x58
		[SerializeField] // 0x0000000180215110-0x0000000180215160
		[Tooltip] // 0x0000000180215110-0x0000000180215160
		private bool m_PassRayOnHidden; // 0x68
		[Header] // 0x00000001801F9E80-0x00000001801F9ED0
		[SerializeField] // 0x00000001801F9E80-0x00000001801F9ED0
		private EffectPlayer m_Player; // 0x70
		private MaterialCache _materialCache; // 0x78
	
		// Properties
		public float effectFactor { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x00000001807920A0-0x0000000180792140
		public Texture transitionTexture { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x0000000180792180-0x0000000180792250
		public EffectMode effectMode { get; } // 0x000000018057D1C0-0x000000018057D1D0 
		public bool keepAspectRatio { get; set; } // 0x00000001805567D0-0x00000001805567E0 0x0000000180792140-0x0000000180792180
		public override ParameterTexture ptex { get; } // 0x0000000180791D60-0x0000000180791DC0 
		public float dissolveWidth { get; set; } // 0x0000000180791CE0-0x0000000180791CF0 0x0000000180791F30-0x0000000180791FD0
		public float dissolveSoftness { get; set; } // 0x0000000180791CD0-0x0000000180791CE0 0x0000000180791E90-0x0000000180791F30
		public Color dissolveColor { get; set; } // 0x0000000180791CC0-0x0000000180791CD0 0x0000000180791E30-0x0000000180791E90
		public float duration { get; set; } // 0x0000000180791CF0-0x0000000180791D60 0x0000000180791FD0-0x00000001807920A0
		public bool passRayOnHidden { get; set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
		public AnimatorUpdateMode updateMode { get; set; } // 0x0000000180791DC0-0x0000000180791E30 0x0000000180792250-0x00000001807922D0
		private EffectPlayer _player { get; } // 0x0000000180791C50-0x0000000180791CC0 
	
		// Nested types
		public enum EffectMode // TypeDefIndex: 16354
		{
			Fade = 1,
			Cutoff = 2,
			Dissolve = 3
		}
	
		// Constructors
		public UITransitionEffect(); // 0x0000000180791BA0-0x0000000180791C50
		static UITransitionEffect(); // 0x0000000180791B30-0x0000000180791BA0
	
		// Methods
		public void Show(); // 0x0000000180791900-0x0000000180791A30
		public void Hide(); // 0x0000000180790AD0-0x0000000180790C00
		public override void ModifyMaterial(); // 0x0000000180790C00-0x0000000180790F50
		public override void ModifyMesh(VertexHelper vh); // 0x0000000180790F50-0x0000000180791430
		protected override void OnEnable(); // 0x0000000180791580-0x0000000180791660
		protected override void OnDisable(); // 0x0000000180791430-0x0000000180791580
		protected override void SetDirty(); // 0x0000000180791660-0x0000000180791900
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Show>b__44_0(float f); // 0x0000000180791B20-0x0000000180791B30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Hide>b__45_0(float f); // 0x0000000180791A30-0x0000000180791A50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material <ModifyMaterial>b__46_0(); // 0x0000000180791A50-0x0000000180791B20
	}
}
