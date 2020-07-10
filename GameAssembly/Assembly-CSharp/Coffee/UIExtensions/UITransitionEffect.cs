/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x0000000180102EF0-0x0000000180102F20
	public class UITransitionEffect : UIEffectBase // TypeDefIndex: 15514
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-Transition"; // Metadata: 0x00784C23
		private static readonly ParameterTexture _ptex; // 0x00
		[SerializeField] // 0x0000000180103080-0x00000001801030D0
		[Tooltip] // 0x0000000180103080-0x00000001801030D0
		private EffectMode m_EffectMode; // 0x38
		[Range] // 0x0000000180103330-0x00000001801033A0
		[SerializeField] // 0x0000000180103330-0x00000001801033A0
		[Tooltip] // 0x0000000180103330-0x00000001801033A0
		private float m_EffectFactor; // 0x3C
		[SerializeField] // 0x0000000180103510-0x0000000180103560
		[Tooltip] // 0x0000000180103510-0x0000000180103560
		private Texture m_TransitionTexture; // 0x40
		[SerializeField] // 0x00000001800EF290-0x00000001800EF2E0
		[Tooltip] // 0x00000001800EF290-0x00000001800EF2E0
		private EffectArea m_EffectArea; // 0x48
		[SerializeField] // 0x00000001800EF4F0-0x00000001800EF540
		[Tooltip] // 0x00000001800EF4F0-0x00000001800EF540
		private bool m_KeepAspectRatio; // 0x4C
		[Range] // 0x0000000180103DD0-0x0000000180103E40
		[SerializeField] // 0x0000000180103DD0-0x0000000180103E40
		[Tooltip] // 0x0000000180103DD0-0x0000000180103E40
		private float m_DissolveWidth; // 0x50
		[Range] // 0x00000001801042E0-0x0000000180104350
		[SerializeField] // 0x00000001801042E0-0x0000000180104350
		[Tooltip] // 0x00000001801042E0-0x0000000180104350
		private float m_DissolveSoftness; // 0x54
		[ColorUsage] // 0x00000001801044E0-0x0000000180104540
		[SerializeField] // 0x00000001801044E0-0x0000000180104540
		[Tooltip] // 0x00000001801044E0-0x0000000180104540
		private Color m_DissolveColor; // 0x58
		[SerializeField] // 0x00000001801048A0-0x00000001801048F0
		[Tooltip] // 0x00000001801048A0-0x00000001801048F0
		private bool m_PassRayOnHidden; // 0x68
		[Header] // 0x00000001800EF790-0x00000001800EF7E0
		[SerializeField] // 0x00000001800EF790-0x00000001800EF7E0
		private EffectPlayer m_Player; // 0x70
		private MaterialCache _materialCache; // 0x78
	
		// Properties
		public float effectFactor { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x000000018148BEF0-0x000000018148BF90
		public Texture transitionTexture { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x000000018148BFD0-0x000000018148C0A0
		public EffectMode effectMode { get; } // 0x00000001804999D0-0x00000001804999E0 
		public bool keepAspectRatio { get; set; } // 0x0000000180478590-0x00000001804785A0 0x000000018148BF90-0x000000018148BFD0
		public override ParameterTexture ptex { get; } // 0x000000018148BBB0-0x000000018148BC10 
		public float dissolveWidth { get; set; } // 0x0000000180487D20-0x0000000180487D30 0x000000018148BD80-0x000000018148BE20
		public float dissolveSoftness { get; set; } // 0x0000000180487CF0-0x0000000180487D00 0x000000018148BCE0-0x000000018148BD80
		public Color dissolveColor { get; set; } // 0x00000001804D5330-0x00000001804D5340 0x000000018148BC80-0x000000018148BCE0
		public float duration { get; set; } // 0x000000018148BB40-0x000000018148BBB0 0x000000018148BE20-0x000000018148BEF0
		public bool passRayOnHidden { get; set; } // 0x0000000180622650-0x0000000180622660 0x00000001804638B0-0x00000001804638C0
		public AnimatorUpdateMode updateMode { get; set; } // 0x000000018148BC10-0x000000018148BC80 0x000000018148C0A0-0x000000018148C120
		private EffectPlayer _player { get; } // 0x000000018148BAE0-0x000000018148BB40 
	
		// Nested types
		public enum EffectMode // TypeDefIndex: 15515
		{
			Fade = 1,
			Cutoff = 2,
			Dissolve = 3
		}
	
		// Constructors
		public UITransitionEffect(); // 0x000000018148BA30-0x000000018148BAE0
		static UITransitionEffect(); // 0x000000018148B9C0-0x000000018148BA30
	
		// Methods
		public void Show(); // 0x000000018148B7A0-0x000000018148B8C0
		public void Hide(); // 0x000000018148AB20-0x000000018148AC40
		public override void ModifyMaterial(); // 0x000000018148AC40-0x000000018148AF20
		public override void ModifyMesh(VertexHelper vh); // 0x000000018148AF20-0x000000018148B3D0
		protected override void OnEnable(); // 0x000000018148B4A0-0x000000018148B570
		protected override void OnDisable(); // 0x000000018148B3D0-0x000000018148B4A0
		protected override void SetDirty(); // 0x000000018148B570-0x000000018148B7A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Show>b__44_0(float f); // 0x000000018148B9B0-0x000000018148B9C0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Hide>b__45_0(float f); // 0x000000018148B8C0-0x000000018148B8E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Material <ModifyMaterial>b__46_0(); // 0x000000018148B8E0-0x000000018148B9B0
	}
}
