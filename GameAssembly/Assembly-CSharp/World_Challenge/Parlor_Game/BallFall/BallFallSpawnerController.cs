/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallSpawnerController : MonoBehaviour // TypeDefIndex: 14766
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
		public BallFallSpawnerController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(); // 0x0000000180E6A730-0x0000000180E6A820
		public GameObject GetSpawnLocator(); // 0x0000000180E6A6C0-0x0000000180E6A730
		public void StartMoving(); // 0x0000000180E6A820-0x0000000180E6A890
		public void StopMoving(); // 0x00000001803CD8B0-0x00000001803CD8C0
		public void ResetPosition(); // 0x00000001803CD8B0-0x00000001803CD8C0
		private void FixedUpdate(); // 0x0000000180E6A4D0-0x0000000180E6A6C0
	}
}
