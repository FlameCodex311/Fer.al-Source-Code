/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent] // 0x00000001801F4EC0-0x00000001801F4F30
	[RequireComponent] // 0x00000001801F4EC0-0x00000001801F4F30
	public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture // TypeDefIndex: 16337
	{
		// Fields
		protected static readonly Vector2[] splitedCharacterPosition; // 0x00
		protected static readonly List<UIVertex> tempVerts; // 0x08
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private int m_Version; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Material m_EffectMaterial; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <parameterIndex>k__BackingField; // 0x30
	
		// Properties
		public int parameterIndex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
		public virtual ParameterTexture ptex { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public Graphic targetGraphic { get; } // 0x0000000180789490-0x00000001807894A0 
		public Material effectMaterial { get; } // 0x00000001803745B0-0x00000001803745C0 
	
		// Constructors
		protected UIEffectBase(); // 0x00000001803743C0-0x00000001803743D0
		static UIEffectBase(); // 0x00000001807892F0-0x0000000180789490
	
		// Methods
		public virtual void ModifyMaterial(); // 0x00000001807890B0-0x0000000180789110
		protected override void OnEnable(); // 0x0000000180789220-0x00000001807892C0
		protected override void OnDisable(); // 0x0000000180789110-0x0000000180789220
		protected virtual void SetDirty(); // 0x00000001807892C0-0x00000001807892F0
		protected override void OnDidApplyAnimationProperties(); // 0x00000001803B6890-0x00000001803B68B0
	}
}
