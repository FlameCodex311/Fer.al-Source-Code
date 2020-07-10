/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallSpawnerController : MonoBehaviour // TypeDefIndex: 15611
	{
		// Fields
		public float moveSpeed; // 0x20
		private Vector3 startPos; // 0x24
		private Vector3 posA; // 0x30
		private Vector3 posB; // 0x3C
		private Vector3 targetPos; // 0x48
		private Vector3 direction; // 0x54
		private bool isMoving; // 0x60
		private bool movingLeft; // 0x61
	
		// Constructors
		public BallFallSpawnerController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(); // 0x00000001817058B0-0x00000001817059B0
		public GameObject GetSpawnLocator(); // 0x0000000181705840-0x00000001817058B0
		public void StartMoving(); // 0x00000001817059B0-0x0000000181705A20
		public void StopMoving(); // 0x0000000180E83FC0-0x0000000180E83FD0
		public void ResetPosition(); // 0x0000000180E83FC0-0x0000000180E83FD0
		private void FixedUpdate(); // 0x0000000181705650-0x0000000181705840
	}
}
