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
	[AddComponentMenu] // 0x0000000180267F30-0x0000000180267FB0
	[RequireComponent] // 0x0000000180267F30-0x0000000180267FB0
	public class PressAnyButtonToJoinExample_GamePlayer : UnityEngine.MonoBehaviour // TypeDefIndex: 9408
	{
		// Fields
		public int playerId; // 0x18
		public float moveSpeed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private CharacterController cc; // 0x30
		private Vector3 moveVector; // 0x38
		private bool fire; // 0x44
	
		// Properties
		private Player player { get; } // 0x0000000180DD79D0-0x0000000180DD7AB0 
	
		// Constructors
		public PressAnyButtonToJoinExample_GamePlayer(); // 0x0000000180DD0250-0x0000000180DD0270
	
		// Methods
		private void OnEnable(); // 0x0000000180DD7520-0x0000000180DD7560
		private void Update(); // 0x0000000180DD7860-0x0000000180DD79D0
		private void GetInput(); // 0x0000000180DD7470-0x0000000180DD7520
		private void ProcessInput(); // 0x0000000180DD7560-0x0000000180DD7860
	}
}
