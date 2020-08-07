/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_FlyMovement : UnityEngine.MonoBehaviour // TypeDefIndex: 10341
	{
		// Fields
		[Tooltip] // 0x00000001801E29F0-0x00000001801E2A20
		public float MainSpeed; // 0x18
		[Tooltip] // 0x00000001801E2B60-0x00000001801E2B90
		public Vector3 RangeValue; // 0x1C
		[Tooltip] // 0x00000001801E2D90-0x00000001801E2DC0
		public float RangeMul; // 0x28
		[Tooltip] // 0x00000001801E2F50-0x00000001801E2F80
		public float AddYSin; // 0x2C
		public float AddYSinTimeSpeed; // 0x30
		[Tooltip] // 0x00000001801E3140-0x00000001801E3170
		public float RotateForwardSpeed; // 0x34
		private float time; // 0x38
		private Vector3 offset; // 0x3C
		private Vector3 initPos; // 0x48
		private Vector3 preOffsetNoYAdd; // 0x54
		private Vector3 posOffsetNoYAdd; // 0x60
		private Vector3 speeds; // 0x6C
		private Vector3 randomVector1; // 0x78
		private Vector3 randomVector2; // 0x84
	
		// Constructors
		public FBasic_FlyMovement(); // 0x000000018107E8E0-0x000000018107E970
	
		// Methods
		private void Start(); // 0x000000018107E300-0x000000018107E3F0
		private void Update(); // 0x000000018107E3F0-0x000000018107E8E0
	}
}
