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
	public class FBasic_FollowTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 10342
	{
		// Fields
		[Range] // 0x00000001801E3290-0x00000001801E32F0
		[Tooltip] // 0x00000001801E3290-0x00000001801E32F0
		public float MoveSpeed; // 0x18
		public Transform TargetTransform; // 0x20
		public Vector3 PositionOffsetInTargetSpace; // 0x28
		public EFUpdateClock UpdateClock; // 0x34
	
		// Constructors
		public FBasic_FollowTarget(); // 0x000000018107EC80-0x000000018107EC90
	
		// Methods
		private void Update(); // 0x000000018107EC70-0x000000018107EC80
		private void LateUpdate(); // 0x000000018107EC60-0x000000018107EC70
		private void FixedUpdate(); // 0x000000018107E970-0x000000018107E980
		private void Follow(); // 0x000000018107E980-0x000000018107EC60
	}
}
