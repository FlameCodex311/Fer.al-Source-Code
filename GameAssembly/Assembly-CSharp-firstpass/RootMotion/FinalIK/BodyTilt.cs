/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class BodyTilt : OffsetModifier // TypeDefIndex: 9992
	{
		// Fields
		[Tooltip] // 0x0000000180279720-0x0000000180279750
		public float tiltSpeed; // 0x30
		[Tooltip] // 0x0000000180279A10-0x0000000180279A40
		public float tiltSensitivity; // 0x34
		[Tooltip] // 0x0000000180279B20-0x0000000180279B50
		public OffsetPose poseLeft; // 0x38
		[Tooltip] // 0x0000000180279B20-0x0000000180279B50
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt(); // 0x0000000181424DB0-0x0000000181424DD0
	
		// Methods
		protected override void Start(); // 0x0000000181424D60-0x0000000181424DB0
		protected override void OnModifyOffset(); // 0x0000000181424AC0-0x0000000181424D60
	}
}
