/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public class BodyTilt : OffsetModifier // TypeDefIndex: 9458
	{
		// Fields
		[Tooltip] // 0x00000001800B7B40-0x00000001800B7B70
		public float tiltSpeed; // 0x30
		[Tooltip] // 0x00000001800B7EC0-0x00000001800B7EF0
		public float tiltSensitivity; // 0x34
		[Tooltip] // 0x00000001800B8030-0x00000001800B8060
		public OffsetPose poseLeft; // 0x38
		[Tooltip] // 0x00000001800B8030-0x00000001800B8060
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt(); // 0x000000018181F6B0-0x000000018181F6D0
	
		// Methods
		protected override void Start(); // 0x000000018181F660-0x000000018181F6B0
		protected override void OnModifyOffset(); // 0x000000018181F3B0-0x000000018181F660
	}
}
