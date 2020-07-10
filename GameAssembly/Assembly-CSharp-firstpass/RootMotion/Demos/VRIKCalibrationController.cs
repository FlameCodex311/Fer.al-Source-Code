/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class VRIKCalibrationController : UnityEngine.MonoBehaviour // TypeDefIndex: 9556
	{
		// Fields
		[Tooltip] // 0x00000001800E0410-0x00000001800E0440
		public VRIK ik; // 0x18
		[Tooltip] // 0x00000001800E0600-0x00000001800E0630
		public VRIKCalibrator.Settings settings; // 0x20
		[Tooltip] // 0x00000001800E0740-0x00000001800E0770
		public Transform headTracker; // 0x28
		[Tooltip] // 0x00000001800E09A0-0x00000001800E09D0
		public Transform bodyTracker; // 0x30
		[Tooltip] // 0x00000001800E0AA0-0x00000001800E0AD0
		public Transform leftHandTracker; // 0x38
		[Tooltip] // 0x00000001800E0C10-0x00000001800E0C40
		public Transform rightHandTracker; // 0x40
		[Tooltip] // 0x00000001800E0EB0-0x00000001800E0EE0
		public Transform leftFootTracker; // 0x48
		[Tooltip] // 0x00000001800E1070-0x00000001800E10A0
		public Transform rightFootTracker; // 0x50
		[Header] // 0x00000001800E12C0-0x00000001800E12F0
		public VRIKCalibrator.CalibrationData data; // 0x58
	
		// Constructors
		public VRIKCalibrationController(); // 0x00000001818402A0-0x0000000181840300
	
		// Methods
		private void LateUpdate(); // 0x00000001818400F0-0x00000001818402A0
	}
}
