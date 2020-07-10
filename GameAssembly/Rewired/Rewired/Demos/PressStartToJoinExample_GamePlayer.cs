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
	[AddComponentMenu] // 0x0000000180106570-0x00000001801065F0
	[RequireComponent] // 0x0000000180106570-0x00000001801065F0
	public class PressStartToJoinExample_GamePlayer : UnityEngine.MonoBehaviour // TypeDefIndex: 9245
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
		private Player player { get; } // 0x00000001815BE2E0-0x00000001815BE2F0 
	
		// Constructors
		public PressStartToJoinExample_GamePlayer(); // 0x00000001815B59A0-0x00000001815B59C0
	
		// Methods
		private void OnEnable(); // 0x00000001815BDE20-0x00000001815BDE60
		private void Update(); // 0x00000001815BE170-0x00000001815BE2E0
		private void GetInput(); // 0x00000001815BDD60-0x00000001815BDE20
		private void ProcessInput(); // 0x00000001815BDE60-0x00000001815BE170
	}
}
