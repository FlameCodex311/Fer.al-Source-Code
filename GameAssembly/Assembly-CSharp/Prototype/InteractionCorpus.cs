/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class InteractionCorpus : Interactable // TypeDefIndex: 14829
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static InteractionCorpus <currentCorpus>k__BackingField; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AudioClip _audioClip; // 0x1A0
		private AudioClip _priorClip; // 0x1A8
		private Animator _animator; // 0x1B0
		private SkinnedMeshRenderer[] _playerRenderers; // 0x1B8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CharacterController <controller>k__BackingField; // 0x1C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActorMoverNavType <playerNavType>k__BackingField; // 0x1C8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _useColorChangeAction; // 0x1CC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorChangeRed; // 0x1D0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorChangeGreen; // 0x1E0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _colorChangeBlue; // 0x1F0
		private GameObject _model; // 0x200
		private Vector3 _moveDirection; // 0x208
		private Vector3 _moveVector; // 0x214
		private float _rotate; // 0x220
		private bool _shaking; // 0x224
		public string uniqueActionName; // 0x228
		public string uniqueActionAnimation; // 0x230
		public Texture uniqueActionTexture; // 0x238
		[RootSelector] // 0x00000001802221F0-0x0000000180222250
		public string uniqueActionCraftableItemId; // 0x240
		private bool _collectedUniqueActionCraftableItem; // 0x248
	
		// Properties
		public static InteractionCorpus currentCorpus { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180ADC7E0-0x0000000180ADC820 0x0000000180ADC840-0x0000000180ADC880
		public CharacterController controller { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180ADC7D0-0x0000000180ADC7E0 0x0000000180ADC830-0x0000000180ADC840
		public ActorMoverNavType playerNavType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180ADC820-0x0000000180ADC830 0x0000000180ADC880-0x0000000180ADC890
	
		// Constructors
		public InteractionCorpus(); // 0x0000000180ADC710-0x0000000180ADC7D0
	}
}
