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
	[AddComponentMenu] // 0x0000000180264D90-0x0000000180264E10
	[RequireComponent] // 0x0000000180264D90-0x0000000180264E10
	public class EightPlayersExample_Player : UnityEngine.MonoBehaviour // TypeDefIndex: 9402
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
		public EightPlayersExample_Player(); // 0x0000000180DD0250-0x0000000180DD0270
	
		// Methods
		private void Awake(); // 0x0000000180DCFC60-0x0000000180DCFCA0
		private void Initialize(); // 0x0000000180DCFD40-0x0000000180DCFDB0
		private void Update(); // 0x0000000180DD00B0-0x0000000180DD0250
		private void GetInput(); // 0x0000000180DCFCA0-0x0000000180DCFD40
		private void ProcessInput(); // 0x0000000180DCFDB0-0x0000000180DD00B0
	}
}
