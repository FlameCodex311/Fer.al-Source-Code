/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 77: Coffee.UIParticle.dll - Assembly: Coffee.UIParticle, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9143-9148

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class UIParticle : MaskableGraphic // TypeDefIndex: 9144
	{
		// Fields
		private static readonly int s_IdMainTex; // 0x00
		private static readonly List<Vector3> s_Vertices; // 0x08
		private static readonly List<UIParticle> s_TempRelatables; // 0x10
		private static readonly List<UIParticle> s_ActiveParticles; // 0x18
		[SerializeField] // 0x000000018021D2C0-0x000000018021D310
		[Tooltip] // 0x000000018021D2C0-0x000000018021D310
		private ParticleSystem m_ParticleSystem; // 0xC8
		[SerializeField] // 0x000000018021D620-0x000000018021D670
		[Tooltip] // 0x000000018021D620-0x000000018021D670
		private UIParticle m_TrailParticle; // 0xD0
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private bool m_IsTrail; // 0xD8
		[SerializeField] // 0x000000018021DCA0-0x000000018021DCF0
		[Tooltip] // 0x000000018021DCA0-0x000000018021DCF0
		private float m_Scale; // 0xDC
		[SerializeField] // 0x000000018021DFD0-0x000000018021E020
		[Tooltip] // 0x000000018021DFD0-0x000000018021E020
		private bool m_IgnoreParent; // 0xE0
		[SerializeField] // 0x000000018021E250-0x000000018021E2A0
		[Tooltip] // 0x000000018021E250-0x000000018021E2A0
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
		public override Texture mainTexture { get; } // 0x00000001820C40A0-0x00000001820C42F0 
		public override Material material { get; set; } // 0x00000001820C42F0-0x00000001820C43A0 0x00000001820C4460-0x00000001820C45E0
		public float scale { get; set; } // 0x00000001820C43A0-0x00000001820C4440 0x00000001820C45E0-0x00000001820C45F0
		public bool ignoreParent { get; set; } // 0x0000000180DBB6E0-0x0000000180DBB6F0 0x00000001820C4440-0x00000001820C4460
		public bool isRoot { get; } // 0x00000001820C4040-0x00000001820C40A0 
		public override bool raycastTarget { get; set; } // 0x0000000180380950-0x0000000180380960 0x0000000180455C30-0x0000000180455C40
		public ParticleSystem cachedParticleSystem { get; } // 0x00000001820C3FB0-0x00000001820C4040 
	
		// Nested types
		[Serializable]
		public class AnimatableProperty : ISerializationCallbackReceiver // TypeDefIndex: 9145
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string m_Name; // 0x10
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private ShaderPropertyType m_Type; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <id>k__BackingField; // 0x1C
	
			// Properties
			public int id { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
			public ShaderPropertyType type { get; } // 0x00000001803F46B0-0x00000001803F46C0 
	
			// Nested types
			public enum ShaderPropertyType // TypeDefIndex: 9146
			{
				Color = 0,
				Vector = 1,
				Float = 2,
				Range = 3,
				Texture = 4
			}
	
			// Constructors
			public AnimatableProperty(); // 0x00000001820C1000-0x00000001820C1050
	
			// Methods
			public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
			public void OnAfterDeserialize(); // 0x00000001820C0FE0-0x00000001820C1000
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9147
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<UIParticle> <>9__46_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001820C10B0-0x00000001820C1110
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetParent>b__46_0(UIParticle x); // 0x00000001820C1050-0x00000001820C10B0
		}
	
		// Constructors
		public UIParticle(); // 0x00000001820C3F30-0x00000001820C3FB0
		static UIParticle(); // 0x00000001820C3E30-0x00000001820C3F30
	
		// Methods
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001820C1C00-0x00000001820C1CF0
		protected override void OnEnable(); // 0x00000001820C1EE0-0x00000001820C2320
		protected override void OnDisable(); // 0x00000001820C1CF0-0x00000001820C1EE0
		protected override void UpdateGeometry(); // 0x00000001803774A0-0x00000001803774B0
		protected override void OnTransformParentChanged(); // 0x00000001820C2320-0x00000001820C2460
		protected override void OnDidApplyAnimationProperties(); // 0x00000001803774A0-0x00000001803774B0
		private static void UpdateMeshes(); // 0x00000001820C3CC0-0x00000001820C3E30
		private void UpdateMesh(); // 0x00000001820C2B40-0x00000001820C3CC0
		private void CheckTrail(); // 0x00000001820C18C0-0x00000001820C1C00
		private void SetParent(UIParticle newParent); // 0x00000001820C2460-0x00000001820C2760
		private void UpdateAnimatableMaterialProperties(); // 0x00000001820C2760-0x00000001820C2B40
	}
}
