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
	[AddComponentMenu] // 0x0000000180102E70-0x0000000180102EF0
	[RequireComponent] // 0x0000000180102E70-0x0000000180102EF0
	public class CustomControllerDemo_Player : UnityEngine.MonoBehaviour // TypeDefIndex: 9230
	{
		// Fields
		public int playerId; // 0x18
		public float speed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private Player _player; // 0x30
		private CharacterController cc; // 0x38
	
		// Properties
		private Player player { get; } // 0x00000001815B26A0-0x00000001815B2720 
	
		// Constructors
		public CustomControllerDemo_Player(); // 0x00000001815B2680-0x00000001815B26A0
	
		// Methods
		private void Awake(); // 0x00000001815B20E0-0x00000001815B2120
		private void Update(); // 0x00000001815B2120-0x00000001815B2680
	}
}
