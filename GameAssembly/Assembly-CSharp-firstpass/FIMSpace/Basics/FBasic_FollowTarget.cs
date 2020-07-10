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
	public class FBasic_FollowTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 9888
	{
		// Fields
		[Range] // 0x0000000180103F00-0x0000000180103F60
		[Tooltip] // 0x0000000180103F00-0x0000000180103F60
		public float MoveSpeed; // 0x18
		public Transform TargetTransform; // 0x20
		public Vector3 PositionOffsetInTargetSpace; // 0x28
		public EFUpdateClock UpdateClock; // 0x34
	
		// Constructors
		public FBasic_FollowTarget(); // 0x00000001815D5000-0x00000001815D5010
	
		// Methods
		private void Update(); // 0x00000001815D4FF0-0x00000001815D5000
		private void LateUpdate(); // 0x00000001815D4FE0-0x00000001815D4FF0
		private void FixedUpdate(); // 0x00000001815D4CE0-0x00000001815D4CF0
		private void Follow(); // 0x00000001815D4CF0-0x00000001815D4FE0
	}
}
