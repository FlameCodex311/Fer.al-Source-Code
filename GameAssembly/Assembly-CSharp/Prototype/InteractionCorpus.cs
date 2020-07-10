/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class InteractionCorpus : Interactable // TypeDefIndex: 16059
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static InteractionCorpus <currentCorpus>k__BackingField; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AudioClip _audioClip; // 0x1A0
		private AudioClip _priorClip; // 0x1A8
		private Animator _animator; // 0x1B0
		private SkinnedMeshRenderer[] _playerRenderers; // 0x1B8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private CharacterController <controller>k__BackingField; // 0x1C0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ActorMoverNavType <playerNavType>k__BackingField; // 0x1C8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _useColorChangeAction; // 0x1CC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorChangeRed; // 0x1D0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorChangeGreen; // 0x1E0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _colorChangeBlue; // 0x1F0
		private GameObject _model; // 0x200
		private Vector3 _moveDirection; // 0x208
		private Vector3 _moveVector; // 0x214
		private float _rotate; // 0x220
		private bool _shaking; // 0x224
		public string uniqueActionName; // 0x228
		public string uniqueActionAnimation; // 0x230
		public Texture uniqueActionTexture; // 0x238
		[RootSelector] // 0x00000001800F8370-0x00000001800F83D0
		public string uniqueActionCraftableItemId; // 0x240
		private bool _collectedUniqueActionCraftableItem; // 0x248
	
		// Properties
		public static InteractionCorpus currentCorpus { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001813A57A0-0x00000001813A57E0 0x00000001813A57F0-0x00000001813A5830
		public CharacterController controller { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001813A5790-0x00000001813A57A0 0x0000000180CB8030-0x0000000180CB8040
		public ActorMoverNavType playerNavType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001813A57E0-0x00000001813A57F0 0x00000001813A5830-0x00000001813A5840
	
		// Constructors
		public InteractionCorpus(); // 0x00000001813A56D0-0x00000001813A5790
	}
}
