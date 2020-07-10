/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_FlyMovement : UnityEngine.MonoBehaviour // TypeDefIndex: 9887
	{
		// Fields
		[Tooltip] // 0x0000000180103480-0x00000001801034B0
		public float MainSpeed; // 0x18
		[Tooltip] // 0x0000000180103630-0x0000000180103660
		public Vector3 RangeValue; // 0x1C
		[Tooltip] // 0x00000001801037E0-0x0000000180103810
		public float RangeMul; // 0x28
		[Tooltip] // 0x0000000180103AC0-0x0000000180103AF0
		public float AddYSin; // 0x2C
		public float AddYSinTimeSpeed; // 0x30
		[Tooltip] // 0x0000000180103CF0-0x0000000180103D20
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
		public FBasic_FlyMovement(); // 0x00000001815D4C50-0x00000001815D4CE0
	
		// Methods
		private void Start(); // 0x00000001815D4650-0x00000001815D4750
		private void Update(); // 0x00000001815D4750-0x00000001815D4C50
	}
}
