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
	[AddComponentMenu] // 0x0000000180268210-0x0000000180268290
	[RequireComponent] // 0x0000000180268210-0x0000000180268290
	public class PressStartToJoinExample_GamePlayer : UnityEngine.MonoBehaviour // TypeDefIndex: 9411
	{
		// Fields
		public int gamePlayerId; // 0x18
		public float moveSpeed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private CharacterController cc; // 0x30
		private Vector3 moveVector; // 0x38
		private bool fire; // 0x44
	
		// Properties
		private Player player { get; } // 0x00000001810610B0-0x00000001810610C0 
	
		// Constructors
		public PressStartToJoinExample_GamePlayer(); // 0x0000000180DD0250-0x0000000180DD0270
	
		// Methods
		private void OnEnable(); // 0x0000000181060C00-0x0000000181060C40
		private void Update(); // 0x0000000181060F40-0x00000001810610B0
		private void GetInput(); // 0x0000000181060B50-0x0000000181060C00
		private void ProcessInput(); // 0x0000000181060C40-0x0000000181060F40
	}
}
