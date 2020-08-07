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
	[AddComponentMenu] // 0x0000000180260EB0-0x0000000180260F30
	[RequireComponent] // 0x0000000180260EB0-0x0000000180260F30
	public class CustomControllerDemo_Player : UnityEngine.MonoBehaviour // TypeDefIndex: 9396
	{
		// Fields
		public int playerId; // 0x18
		public float speed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private Player _player; // 0x30
		private CharacterController cc; // 0x38
	
		// Properties
		private Player player { get; } // 0x0000000180DCCC70-0x0000000180DCCCF0 
	
		// Constructors
		public CustomControllerDemo_Player(); // 0x0000000180DCCC50-0x0000000180DCCC70
	
		// Methods
		private void Awake(); // 0x0000000180DCC6C0-0x0000000180DCC700
		private void Update(); // 0x0000000180DCC700-0x0000000180DCCC50
	}
}
