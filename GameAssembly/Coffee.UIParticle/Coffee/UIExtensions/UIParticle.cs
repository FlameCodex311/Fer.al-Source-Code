/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 76: Coffee.UIParticle.dll - Assembly: Coffee.UIParticle, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8977-8982

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class UIParticle : MaskableGraphic // TypeDefIndex: 8978
	{
		// Fields
		private static readonly int s_IdMainTex; // 0x00
		private static readonly List<Vector3> s_Vertices; // 0x08
		private static readonly List<UIParticle> s_TempRelatables; // 0x10
		private static readonly List<UIParticle> s_ActiveParticles; // 0x18
		[SerializeField] // 0x00000001800BCF70-0x00000001800BCFC0
		[Tooltip] // 0x00000001800BCF70-0x00000001800BCFC0
		private ParticleSystem m_ParticleSystem; // 0xC8
		[SerializeField] // 0x00000001800BD160-0x00000001800BD1B0
		[Tooltip] // 0x00000001800BD160-0x00000001800BD1B0
		private UIParticle m_TrailParticle; // 0xD0
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private bool m_IsTrail; // 0xD8
		[SerializeField] // 0x00000001800BD4A0-0x00000001800BD4F0
		[Tooltip] // 0x00000001800BD4A0-0x00000001800BD4F0
		private float m_Scale; // 0xDC
		[SerializeField] // 0x00000001800BD710-0x00000001800BD760
		[Tooltip] // 0x00000001800BD710-0x00000001800BD760
		private bool m_IgnoreParent; // 0xE0
		[SerializeField] // 0x00000001800BD910-0x00000001800BD960
		[Tooltip] // 0x00000001800BD910-0x00000001800BD960
		private AnimatableProperty[] m_AnimatableProperties; // 0xE8
		private static MaterialPropertyBlock s_Mpb; // 0x20
		private Mesh _mesh; // 0xF0
		private ParticleSystemRenderer _renderer; // 0xF8
		private UIParticle _parent; // 0x100
		private List<UIParticle> _children; // 0x108
		private Matrix4x4 scaleaMatrix; // 0x110
		private Vector3 _oldPos; // 0x150
		private static ParticleSystem.Particle[] s_Particles; // 0x28
	
		// Properties
		public override Texture mainTexture { get; } // 0x00000001822CC360-0x00000001822CC5B0 
		public override Material material { get; set; } // 0x00000001822CC5B0-0x00000001822CC660 0x00000001822CC720-0x00000001822CC8A0
		public float scale { get; set; } // 0x00000001822CC660-0x00000001822CC700 0x00000001822CC8A0-0x00000001822CC8D0
		public bool ignoreParent { get; set; } // 0x000000018081E0D0-0x000000018081E0E0 0x00000001822CC700-0x00000001822CC720
		public bool isRoot { get; } // 0x00000001822CC300-0x00000001822CC360 
		public override bool raycastTarget { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x0000000180E07060-0x0000000180E07070
		public ParticleSystem cachedParticleSystem { get; } // 0x00000001822CC270-0x00000001822CC300 
	
		// Nested types
		[Serializable]
		public class AnimatableProperty : ISerializationCallbackReceiver // TypeDefIndex: 8979
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string m_Name; // 0x10
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private ShaderPropertyType m_Type; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <id>k__BackingField; // 0x1C
	
			// Properties
			public int id { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
			public ShaderPropertyType type { get; } // 0x0000000180367710-0x0000000180367720 
	
			// Nested types
			public enum ShaderPropertyType // TypeDefIndex: 8980
			{
				Color = 0,
				Vector = 1,
				Float = 2,
				Range = 3,
				Texture = 4
			}
	
			// Constructors
			public AnimatableProperty(); // 0x00000001822C9260-0x00000001822C92B0
	
			// Methods
			public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
			public void OnAfterDeserialize(); // 0x00000001822C9240-0x00000001822C9260
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8981
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<UIParticle> <>9__46_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001822C9310-0x00000001822C9370
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetParent>b__46_0(UIParticle x); // 0x00000001822C92B0-0x00000001822C9310
		}
	
		// Constructors
		public UIParticle(); // 0x00000001822CC1F0-0x00000001822CC270
		static UIParticle(); // 0x00000001822CC0F0-0x00000001822CC1F0
	
		// Methods
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001822C9E70-0x00000001822C9F60
		protected override void OnEnable(); // 0x00000001822CA150-0x00000001822CA5B0
		protected override void OnDisable(); // 0x00000001822C9F60-0x00000001822CA150
		protected override void UpdateGeometry(); // 0x00000001803581E0-0x00000001803581F0
		protected override void OnTransformParentChanged(); // 0x00000001822CA5B0-0x00000001822CA6F0
		protected override void OnDidApplyAnimationProperties(); // 0x00000001803581E0-0x00000001803581F0
		private static void UpdateMeshes(); // 0x00000001822CBF80-0x00000001822CC0F0
		private void UpdateMesh(); // 0x00000001822CADF0-0x00000001822CBF80
		private void CheckTrail(); // 0x00000001822C9B30-0x00000001822C9E70
		private void SetParent(UIParticle newParent); // 0x00000001822CA6F0-0x00000001822CA9F0
		private void UpdateAnimatableMaterialProperties(); // 0x00000001822CA9F0-0x00000001822CADF0
	}
}
