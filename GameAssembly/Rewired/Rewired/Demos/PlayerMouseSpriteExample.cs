/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class PlayerMouseSpriteExample : UnityEngine.MonoBehaviour // TypeDefIndex: 9404
	{
		// Fields
		[Tooltip] // 0x0000000180266670-0x00000001802666A0
		public int playerId; // 0x18
		[Tooltip] // 0x00000001802667E0-0x0000000180266810
		public string horizontalAction; // 0x20
		[Tooltip] // 0x00000001802668B0-0x00000001802668E0
		public string verticalAction; // 0x28
		[Tooltip] // 0x0000000180266980-0x00000001802669B0
		public string wheelAction; // 0x30
		[Tooltip] // 0x0000000180266DB0-0x0000000180266DE0
		public string leftButtonAction; // 0x38
		[Tooltip] // 0x0000000180266F10-0x0000000180266F40
		public string rightButtonAction; // 0x40
		[Tooltip] // 0x0000000180266FC0-0x0000000180266FF0
		public string middleButtonAction; // 0x48
		[Tooltip] // 0x0000000180267100-0x0000000180267130
		public float distanceFromCamera; // 0x50
		[Tooltip] // 0x0000000180267200-0x0000000180267230
		public float spriteScale; // 0x54
		[Tooltip] // 0x0000000180267410-0x0000000180267440
		public GameObject pointerPrefab; // 0x58
		[Tooltip] // 0x00000001802674D0-0x0000000180267500
		public GameObject clickEffectPrefab; // 0x60
		[Tooltip] // 0x00000001802675D0-0x0000000180267600
		public bool hideHardwarePointer; // 0x68
		[NonSerialized]
		private GameObject pointer; // 0x70
		[NonSerialized]
		private PlayerMouse mouse; // 0x78
	
		// Constructors
		public PlayerMouseSpriteExample(); // 0x0000000180DD3A60-0x0000000180DD3AF0
	
		// Methods
		private void Awake(); // 0x0000000180DD2FF0-0x0000000180DD3460
		private void Update(); // 0x0000000180DD3750-0x0000000180DD3A60
		private void CreateClickEffect(Color color); // 0x0000000180DD3460-0x0000000180DD3670
		private void OnScreenPositionChanged(Vector2 position); // 0x0000000180DD3670-0x0000000180DD3750
	}
}
