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
	[AddComponentMenu] // 0x00000001801045F0-0x0000000180104670
	[RequireComponent] // 0x00000001801045F0-0x0000000180104670
	public class EightPlayersExample_Player : UnityEngine.MonoBehaviour // TypeDefIndex: 9236
	{
		// Fields
		public int playerId; // 0x18
		public float moveSpeed; // 0x1C
		public float bulletSpeed; // 0x20
		public GameObject bulletPrefab; // 0x28
		private Player player; // 0x30
		private CharacterController cc; // 0x38
		private Vector3 moveVector; // 0x40
		private bool fire; // 0x4C
		[NonSerialized]
		private bool initialized; // 0x4D
	
		// Constructors
		public EightPlayersExample_Player(); // 0x00000001815B59A0-0x00000001815B59C0
	
		// Methods
		private void Awake(); // 0x00000001815B5390-0x00000001815B53D0
		private void Initialize(); // 0x00000001815B5470-0x00000001815B54F0
		private void Update(); // 0x00000001815B5800-0x00000001815B59A0
		private void GetInput(); // 0x00000001815B53D0-0x00000001815B5470
		private void ProcessInput(); // 0x00000001815B54F0-0x00000001815B5800
	}
}
