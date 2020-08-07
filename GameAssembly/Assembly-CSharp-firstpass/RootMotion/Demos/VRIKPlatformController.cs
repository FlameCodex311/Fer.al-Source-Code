/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class VRIKPlatformController : UnityEngine.MonoBehaviour // TypeDefIndex: 9845
	{
		// Fields
		public VRIK ik; // 0x18
		public Transform trackingSpace; // 0x20
		public Transform platform; // 0x28
		public bool moveToPlatform; // 0x30
		private Transform lastPlatform; // 0x38
		private Vector3 lastPosition; // 0x40
		private Quaternion lastRotation; // 0x4C
	
		// Constructors
		public VRIKPlatformController(); // 0x0000000181441740-0x00000001814417B0
	
		// Methods
		private void LateUpdate(); // 0x0000000181441020-0x0000000181441740
	}
}
