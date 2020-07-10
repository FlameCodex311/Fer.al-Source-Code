/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class PlayerMouseSpriteExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9238
	{
		// Fields
		[Tooltip] // 0x00000001801049A0-0x00000001801049D0
		public int playerId; // 0x18
		[Tooltip] // 0x0000000180104CD0-0x0000000180104D00
		public string horizontalAction; // 0x20
		[Tooltip] // 0x0000000180104E30-0x0000000180104E60
		public string verticalAction; // 0x28
		[Tooltip] // 0x0000000180104F10-0x0000000180104F40
		public string wheelAction; // 0x30
		[Tooltip] // 0x0000000180105020-0x0000000180105050
		public string leftButtonAction; // 0x38
		[Tooltip] // 0x00000001801051B0-0x00000001801051E0
		public string rightButtonAction; // 0x40
		[Tooltip] // 0x0000000180105430-0x0000000180105460
		public string middleButtonAction; // 0x48
		[Tooltip] // 0x00000001801054E0-0x0000000180105510
		public float distanceFromCamera; // 0x50
		[Tooltip] // 0x0000000180105570-0x00000001801055A0
		public float spriteScale; // 0x54
		[Tooltip] // 0x0000000180105650-0x0000000180105680
		public GameObject pointerPrefab; // 0x58
		[Tooltip] // 0x0000000180105700-0x0000000180105730
		public GameObject clickEffectPrefab; // 0x60
		[Tooltip] // 0x00000001801059D0-0x0000000180105A00
		public bool hideHardwarePointer; // 0x68
		[NonSerialized]
		private GameObject pointer; // 0x70
		[NonSerialized]
		private PlayerMouse mouse; // 0x78
	
		// Constructors
		public PlayerMouseSpriteExample(); // 0x00000001815B9350-0x00000001815B93E0
	
		// Methods
		private void Awake(); // 0x00000001815B8890-0x00000001815B8D20
		private void Update(); // 0x00000001815B9030-0x00000001815B9350
		private void CreateClickEffect(Color color); // 0x00000001815B8D20-0x00000001815B8F40
		private void OnScreenPositionChanged(Vector2 position); // 0x00000001815B8F40-0x00000001815B9030
	}
}
