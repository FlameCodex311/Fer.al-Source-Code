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
	public class VRIKCalibrationController : UnityEngine.MonoBehaviour // TypeDefIndex: 9843
	{
		// Fields
		[Tooltip] // 0x000000018021AD70-0x000000018021ADA0
		public VRIK ik; // 0x18
		[Tooltip] // 0x000000018021B180-0x000000018021B1B0
		public VRIKCalibrator.Settings settings; // 0x20
		[Tooltip] // 0x000000018021B330-0x000000018021B360
		public Transform headTracker; // 0x28
		[Tooltip] // 0x000000018021B510-0x000000018021B540
		public Transform bodyTracker; // 0x30
		[Tooltip] // 0x000000018021B8A0-0x000000018021B8D0
		public Transform leftHandTracker; // 0x38
		[Tooltip] // 0x000000018021BAB0-0x000000018021BAE0
		public Transform rightHandTracker; // 0x40
		[Tooltip] // 0x000000018021BE10-0x000000018021BE40
		public Transform leftFootTracker; // 0x48
		[Tooltip] // 0x000000018021BFE0-0x000000018021C010
		public Transform rightFootTracker; // 0x50
		[Header] // 0x000000018021C180-0x000000018021C1B0
		public VRIKCalibrator.CalibrationData data; // 0x58
	
		// Constructors
		public VRIKCalibrationController(); // 0x0000000181440FC0-0x0000000181441020
	
		// Methods
		private void LateUpdate(); // 0x0000000181440E10-0x0000000181440FC0
	}
}
