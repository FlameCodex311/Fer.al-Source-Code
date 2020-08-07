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
	public static class VRIKCalibrator // TypeDefIndex: 10024
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 10025
		{
			// Fields
			[Tooltip] // 0x000000018028B260-0x000000018028B290
			public float scaleMlp; // 0x10
			[Tooltip] // 0x000000018028B360-0x000000018028B390
			public Vector3 headTrackerForward; // 0x14
			[Tooltip] // 0x000000018028C740-0x000000018028C770
			public Vector3 headTrackerUp; // 0x20
			[Tooltip] // 0x000000018028C8A0-0x000000018028C8D0
			public Vector3 bodyTrackerForward; // 0x2C
			[Tooltip] // 0x000000018028CA00-0x000000018028CA30
			public Vector3 bodyTrackerUp; // 0x38
			[Tooltip] // 0x000000018028CB00-0x000000018028CB30
			public Vector3 handTrackerForward; // 0x44
			[Tooltip] // 0x000000018028CC00-0x000000018028CC30
			public Vector3 handTrackerUp; // 0x50
			[Tooltip] // 0x000000018028CD80-0x000000018028CDB0
			public Vector3 footTrackerForward; // 0x5C
			[Tooltip] // 0x000000018028CE70-0x000000018028CEA0
			public Vector3 footTrackerUp; // 0x68
			[Space] // 0x000000018028D020-0x000000018028D070
			[Tooltip] // 0x000000018028D020-0x000000018028D070
			public Vector3 headOffset; // 0x74
			[Tooltip] // 0x000000018028D330-0x000000018028D360
			public Vector3 handOffset; // 0x80
			[Tooltip] // 0x000000018028D470-0x000000018028D4A0
			public float footForwardOffset; // 0x8C
			[Tooltip] // 0x000000018028D5C0-0x000000018028D5F0
			public float footInwardOffset; // 0x90
			[Range] // 0x000000018028D700-0x000000018028D760
			[Tooltip] // 0x000000018028D700-0x000000018028D760
			public float footHeadingOffset; // 0x94
			[Range] // 0x00000001801D3630-0x00000001801D3650
			public float pelvisPositionWeight; // 0x98
			[Range] // 0x00000001801D3630-0x00000001801D3650
			public float pelvisRotationWeight; // 0x9C
	
			// Constructors
			public Settings(); // 0x0000000182021B00-0x0000000182021C50
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 10026
		{
			// Fields
			public float scale; // 0x10
			public Target head; // 0x18
			public Target leftHand; // 0x20
			public Target rightHand; // 0x28
			public Target pelvis; // 0x30
			public Target leftFoot; // 0x38
			public Target rightFoot; // 0x40
			public Target leftLegGoal; // 0x48
			public Target rightLegGoal; // 0x50
			public Vector3 pelvisTargetRight; // 0x58
			public float pelvisPositionWeight; // 0x64
			public float pelvisRotationWeight; // 0x68
	
			// Nested types
			[Serializable]
			public class Target // TypeDefIndex: 10027
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target(Transform t); // 0x0000000182022C40-0x0000000182022D00
	
				// Methods
				public void SetTo(Transform t); // 0x0000000182022BD0-0x0000000182022C40
			}
	
			// Constructors
			public CalibrationData(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, Settings settings); // 0x0000000182028750-0x00000001820289C0
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x00000001820267F0-0x0000000182028750
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x0000000182024E60-0x00000001820257E0
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x00000001820257E0-0x00000001820267F0
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x0000000182024B80-0x0000000182024E60
	}
}
