/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent] // 0x00000001800ED830-0x00000001800ED8A0
	[RequireComponent] // 0x00000001800ED830-0x00000001800ED8A0
	public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture // TypeDefIndex: 15498
	{
		// Fields
		protected static readonly Vector2[] splitedCharacterPosition; // 0x00
		protected static readonly List<UIVertex> tempVerts; // 0x08
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private int m_Version; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Material m_EffectMaterial; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <parameterIndex>k__BackingField; // 0x30
	
		// Properties
		public int parameterIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
		public virtual ParameterTexture ptex { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public Graphic targetGraphic { get; } // 0x0000000181484F30-0x0000000181484F40 
		public Material effectMaterial { get; } // 0x0000000180369B60-0x0000000180369B70 
	
		// Constructors
		protected UIEffectBase(); // 0x0000000180E095D0-0x0000000180E095E0
		static UIEffectBase(); // 0x0000000181484D80-0x0000000181484F30
	
		// Methods
		public virtual void ModifyMaterial(); // 0x0000000181484BA0-0x0000000181484C00
		protected override void OnEnable(); // 0x0000000181484CA0-0x0000000181484D50
		protected override void OnDisable(); // 0x0000000181484C00-0x0000000181484CA0
		protected virtual void SetDirty(); // 0x0000000181484D50-0x0000000181484D80
		protected override void OnDidApplyAnimationProperties(); // 0x00000001809E8060-0x00000001809E8080
	}
}
