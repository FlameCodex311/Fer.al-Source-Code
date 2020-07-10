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
	[AddComponentMenu] // 0x00000001801062A0-0x0000000180106320
	[RequireComponent] // 0x00000001801062A0-0x0000000180106320
	public class PressAnyButtonToJoinExample_GamePlayer : UnityEngine.MonoBehaviour // TypeDefIndex: 9242
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
		private Player player { get; } // 0x00000001815BD4B0-0x00000001815BD590 
	
		// Constructors
		public PressAnyButtonToJoinExample_GamePlayer(); // 0x00000001815B59A0-0x00000001815B59C0
	
		// Methods
		private void OnEnable(); // 0x00000001815BCFF0-0x00000001815BD030
		private void Update(); // 0x00000001815BD340-0x00000001815BD4B0
		private void GetInput(); // 0x00000001815BCF30-0x00000001815BCFF0
		private void ProcessInput(); // 0x00000001815BD030-0x00000001815BD340
	}
}
