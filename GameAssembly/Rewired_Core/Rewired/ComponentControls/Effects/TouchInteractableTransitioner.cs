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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x00000001801EFA90-0x00000001801EFB10
	[ExecuteInEditMode] // 0x00000001801EFA90-0x00000001801EFB10
	[RequireComponent] // 0x00000001801EFA90-0x00000001801EFB10
	public sealed class TouchInteractableTransitioner : UnityEngine.MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler // TypeDefIndex: 5986
	{
		// Fields
		[CustomObfuscation] // 0x00000001801EFFF0-0x00000001801F0050
		[SerializeField] // 0x00000001801EFFF0-0x00000001801F0050
		[Tooltip] // 0x00000001801EFFF0-0x00000001801F0050
		private bool _visible; // 0x18
		[Bitmask] // 0x00000001801F0350-0x00000001801F03F0
		[CustomObfuscation] // 0x00000001801F0350-0x00000001801F03F0
		[SerializeField] // 0x00000001801F0350-0x00000001801F03F0
		[Tooltip] // 0x00000001801F0350-0x00000001801F03F0
		private TouchInteractable.TransitionTypeFlags _transitionType; // 0x1C
		[CustomObfuscation] // 0x00000001801ECDC0-0x00000001801ECE20
		[SerializeField] // 0x00000001801ECDC0-0x00000001801ECE20
		[Tooltip] // 0x00000001801ECDC0-0x00000001801ECE20
		private ColorBlock _transitionColorTint; // 0x20
		[CustomObfuscation] // 0x00000001801F0C70-0x00000001801F0CD0
		[SerializeField] // 0x00000001801F0C70-0x00000001801F0CD0
		[Tooltip] // 0x00000001801F0C70-0x00000001801F0CD0
		private SpriteState _transitionSpriteState; // 0x78
		[CustomObfuscation] // 0x00000001801F0F00-0x00000001801F0F60
		[SerializeField] // 0x00000001801F0F00-0x00000001801F0F60
		[Tooltip] // 0x00000001801F0F00-0x00000001801F0F60
		private AnimationTriggers _transitionAnimationTriggers; // 0x98
		[CustomObfuscation] // 0x00000001801ED710-0x00000001801ED770
		[SerializeField] // 0x00000001801ED710-0x00000001801ED770
		[Tooltip] // 0x00000001801ED710-0x00000001801ED770
		private Graphic _targetGraphic; // 0xA0
		[CustomObfuscation] // 0x00000001801F1620-0x00000001801F1680
		[SerializeField] // 0x00000001801F1620-0x00000001801F1680
		[Tooltip] // 0x00000001801F1620-0x00000001801F1680
		private bool _syncFadeDurationWithTransitionEvent; // 0xA8
		[CustomObfuscation] // 0x00000001801F2C10-0x00000001801F2C70
		[SerializeField] // 0x00000001801F2C10-0x00000001801F2C70
		[Tooltip] // 0x00000001801F2C10-0x00000001801F2C70
		private bool _syncColorTintWithTransitionEvent; // 0xA9
		private TouchInteractable.InteractionState mPICZYrNYhUJdchMmZHBJgfeuVU; // 0xAC
	
		// Properties
		public bool visible { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x0000000180920A80-0x0000000180920B00
		public TouchInteractable.TransitionTypeFlags transitionType { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x0000000180921E70-0x0000000180921E80
		public ColorBlock transitionColorTint { get; set; } // 0x0000000180921740-0x0000000180921780 0x0000000180921D40-0x0000000180921E00
		public SpriteState transitionSpriteState { get; set; } // 0x0000000180921780-0x00000001809217A0 0x0000000180921E00-0x0000000180921E70
		public AnimationTriggers transitionAnimationTriggers { get; set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180921D20-0x0000000180921D40
		public Graphic targetGraphic { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x0000000180921C90-0x0000000180921D20
		public bool syncFadeDurationWithTransitionEvent { get; set; } // 0x0000000180921730-0x0000000180921740 0x0000000180921BE0-0x0000000180921C90
		public bool syncColorTintWithTransitionEvent { get; set; } // 0x0000000180921720-0x0000000180921730 0x0000000180921BA0-0x0000000180921BE0
		public Image image { get; set; } // 0x00000001809216A0-0x0000000180921720 0x0000000180921AA0-0x0000000180921BA0
		public Animator animator { get; } // 0x0000000180921650-0x00000001809216A0 
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchInteractableTransitioner(); // 0x0000000180921510-0x0000000180921650
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Awake(); // 0x0000000180920400-0x00000001809204F0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnEnable(); // 0x0000000180920660-0x0000000180920690
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDisable(); // 0x0000000180920650-0x0000000180920660
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnValidate(); // 0x0000000180920860-0x0000000180920A80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Reset(); // 0x0000000180920B00-0x0000000180920B60
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnCanvasGroupWasChanged(); // 0x00000001809205E0-0x0000000180920650
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnAnimationPropertiesWereApplied(); // 0x00000001809205E0-0x0000000180920650
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001809205E0-0x0000000180920650
		private void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x00000001809205E0-0x0000000180920650
		private void vQItACpvQdVvDThyFEokrAlWHpk(bool param_0000c997); // 0x0000000180921E80-0x0000000180921EA0
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000c998, bool param_0000c999); // 0x00000001809205D0-0x00000001809205E0
		private bool xDlyBuvNkVnisWaDfdGdVigncyt(); // 0x0000000180921EA0-0x0000000180921F00
		private void lXXihxaGwUqiAesOLyAhYAOaHUTF(); // 0x00000001809217A0-0x0000000180921AA0
		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(TouchInteractable.InteractionState param_0000c99a, bool param_0000c99b); // 0x0000000180920B60-0x0000000180920FF0
		private void EqHRSTidijHvHCzjafITwRmHRek(Color param_0000c99c, bool param_0000c99d); // 0x00000001809204F0-0x00000001809205D0
		private void ZTgcHEUFatyMOsotIsfeFdGabwT(Sprite param_0000c99e); // 0x0000000180921470-0x0000000180921510
		private void WDCQCdpqVqalHhBdpcWeKLDbEKBn(string param_0000c99f); // 0x0000000180920FF0-0x0000000180921470
		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args); // 0x0000000180920690-0x0000000180920860
		public void OnVisibilityChanged(bool state); // 0x0000000180920A80-0x0000000180920B00
	}
}
