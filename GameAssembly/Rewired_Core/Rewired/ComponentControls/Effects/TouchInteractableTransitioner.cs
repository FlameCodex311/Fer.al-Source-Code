/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls;
using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x00000001801546A0-0x0000000180154720
	[ExecuteInEditMode] // 0x00000001801546A0-0x0000000180154720
	[RequireComponent] // 0x00000001801546A0-0x0000000180154720
	public sealed class TouchInteractableTransitioner : UnityEngine.MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler // TypeDefIndex: 5827
	{
		// Fields
		[CustomObfuscation] // 0x0000000180154BB0-0x0000000180154C10
		[SerializeField] // 0x0000000180154BB0-0x0000000180154C10
		[Tooltip] // 0x0000000180154BB0-0x0000000180154C10
		private bool _visible; // 0x18
		[Bitmask] // 0x0000000180154ED0-0x0000000180154F70
		[CustomObfuscation] // 0x0000000180154ED0-0x0000000180154F70
		[SerializeField] // 0x0000000180154ED0-0x0000000180154F70
		[Tooltip] // 0x0000000180154ED0-0x0000000180154F70
		private TouchInteractable.TransitionTypeFlags _transitionType; // 0x1C
		[CustomObfuscation] // 0x0000000180151480-0x00000001801514E0
		[SerializeField] // 0x0000000180151480-0x00000001801514E0
		[Tooltip] // 0x0000000180151480-0x00000001801514E0
		private ColorBlock _transitionColorTint; // 0x20
		[CustomObfuscation] // 0x00000001801555C0-0x0000000180155620
		[SerializeField] // 0x00000001801555C0-0x0000000180155620
		[Tooltip] // 0x00000001801555C0-0x0000000180155620
		private SpriteState _transitionSpriteState; // 0x78
		[CustomObfuscation] // 0x0000000180156C60-0x0000000180156CC0
		[SerializeField] // 0x0000000180156C60-0x0000000180156CC0
		[Tooltip] // 0x0000000180156C60-0x0000000180156CC0
		private AnimationTriggers _transitionAnimationTriggers; // 0x98
		[CustomObfuscation] // 0x0000000180151FE0-0x0000000180152040
		[SerializeField] // 0x0000000180151FE0-0x0000000180152040
		[Tooltip] // 0x0000000180151FE0-0x0000000180152040
		private Graphic _targetGraphic; // 0xA0
		[CustomObfuscation] // 0x00000001801571F0-0x0000000180157250
		[SerializeField] // 0x00000001801571F0-0x0000000180157250
		[Tooltip] // 0x00000001801571F0-0x0000000180157250
		private bool _syncFadeDurationWithTransitionEvent; // 0xA8
		[CustomObfuscation] // 0x00000001801575A0-0x0000000180157600
		[SerializeField] // 0x00000001801575A0-0x0000000180157600
		[Tooltip] // 0x00000001801575A0-0x0000000180157600
		private bool _syncColorTintWithTransitionEvent; // 0xA9
		private TouchInteractable.InteractionState mPICZYrNYhUJdchMmZHBJgfeuVU; // 0xAC
	
		// Properties
		public bool visible { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x00000001814432B0-0x0000000181443330
		public TouchInteractable.TransitionTypeFlags transitionType { get; set; } // 0x000000018037E420-0x000000018037E430 0x00000001814446C0-0x00000001814446D0
		public ColorBlock transitionColorTint { get; set; } // 0x0000000181443F90-0x0000000181443FD0 0x0000000181444590-0x0000000181444650
		public SpriteState transitionSpriteState { get; set; } // 0x0000000181443FD0-0x0000000181443FF0 0x0000000181444650-0x00000001814446C0
		public AnimationTriggers transitionAnimationTriggers { get; set; } // 0x0000000180369B70-0x0000000180369B80 0x0000000181444570-0x0000000181444590
		public Graphic targetGraphic { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001814444E0-0x0000000181444570
		public bool syncFadeDurationWithTransitionEvent { get; set; } // 0x000000018073CF80-0x000000018073CF90 0x0000000181444430-0x00000001814444E0
		public bool syncColorTintWithTransitionEvent { get; set; } // 0x0000000180759E00-0x0000000180759E10 0x00000001814443F0-0x0000000181444430
		public Image image { get; set; } // 0x0000000181443F10-0x0000000181443F90 0x00000001814442F0-0x00000001814443F0
		public Animator animator { get; } // 0x0000000181443EC0-0x0000000181443F10 
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchInteractableTransitioner(); // 0x0000000181443D80-0x0000000181443EC0
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Awake(); // 0x0000000181442C20-0x0000000181442D10
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnEnable(); // 0x0000000181442E80-0x0000000181442EB0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnDisable(); // 0x0000000181442E70-0x0000000181442E80
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnValidate(); // 0x0000000181443090-0x00000001814432B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Reset(); // 0x0000000181443330-0x0000000181443390
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnCanvasGroupWasChanged(); // 0x0000000181442E00-0x0000000181442E70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnAnimationPropertiesWereApplied(); // 0x0000000181442E00-0x0000000181442E70
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x0000000181442E00-0x0000000181442E70
		private void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x0000000181442E00-0x0000000181442E70
		private void vQItACpvQdVvDThyFEokrAlWHpk(bool param_0000c727); // 0x00000001814446D0-0x00000001814446F0
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000c728, bool param_0000c729); // 0x0000000181442DF0-0x0000000181442E00
		private bool xDlyBuvNkVnisWaDfdGdVigncyt(); // 0x00000001814446F0-0x0000000181444750
		private void lXXihxaGwUqiAesOLyAhYAOaHUTF(); // 0x0000000181443FF0-0x00000001814442F0
		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(TouchInteractable.InteractionState param_0000c72a, bool param_0000c72b); // 0x0000000181443390-0x0000000181443830
		private void EqHRSTidijHvHCzjafITwRmHRek(Color param_0000c72c, bool param_0000c72d); // 0x0000000181442D10-0x0000000181442DF0
		private void ZTgcHEUFatyMOsotIsfeFdGabwT(Sprite param_0000c72e); // 0x0000000181443CD0-0x0000000181443D80
		private void WDCQCdpqVqalHhBdpcWeKLDbEKBn(string param_0000c72f); // 0x0000000181443830-0x0000000181443CD0
		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args); // 0x0000000181442EB0-0x0000000181443090
		public void OnVisibilityChanged(bool state); // 0x00000001814432B0-0x0000000181443330
	}
}
