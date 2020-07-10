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
	public static class VRIKCalibrator // TypeDefIndex: 9490
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 9491
		{
			// Fields
			[Tooltip] // 0x00000001800CBD90-0x00000001800CBDC0
			public float scaleMlp; // 0x10
			[Tooltip] // 0x00000001800CBF10-0x00000001800CBF40
			public Vector3 headTrackerForward; // 0x14
			[Tooltip] // 0x00000001800CC150-0x00000001800CC180
			public Vector3 headTrackerUp; // 0x20
			[Tooltip] // 0x00000001800CC2B0-0x00000001800CC2E0
			public Vector3 bodyTrackerForward; // 0x2C
			[Tooltip] // 0x00000001800CC6E0-0x00000001800CC710
			public Vector3 bodyTrackerUp; // 0x38
			[Tooltip] // 0x00000001800CC8B0-0x00000001800CC8E0
			public Vector3 handTrackerForward; // 0x44
			[Tooltip] // 0x00000001800CCB50-0x00000001800CCB80
			public Vector3 handTrackerUp; // 0x50
			[Tooltip] // 0x00000001800CCD60-0x00000001800CCD90
			public Vector3 footTrackerForward; // 0x5C
			[Tooltip] // 0x00000001800CD100-0x00000001800CD130
			public Vector3 footTrackerUp; // 0x68
			[Space] // 0x00000001800CD2B0-0x00000001800CD300
			[Tooltip] // 0x00000001800CD2B0-0x00000001800CD300
			public Vector3 headOffset; // 0x74
			[Tooltip] // 0x00000001800CD590-0x00000001800CD5C0
			public Vector3 handOffset; // 0x80
			[Tooltip] // 0x00000001800CDA80-0x00000001800CDAB0
			public float footForwardOffset; // 0x8C
			[Tooltip] // 0x00000001800CDC00-0x00000001800CDC30
			public float footInwardOffset; // 0x90
			[Range] // 0x00000001800CE000-0x00000001800CE060
			[Tooltip] // 0x00000001800CE000-0x00000001800CE060
			public float footHeadingOffset; // 0x94
			[Range] // 0x00000001800C20E0-0x00000001800C2100
			public float pelvisPositionWeight; // 0x98
			[Range] // 0x00000001800C20E0-0x00000001800C2100
			public float pelvisRotationWeight; // 0x9C
	
			// Constructors
			public Settings(); // 0x00000001822893F0-0x0000000182289540
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 9492
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
			public class Target // TypeDefIndex: 9493
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target(Transform t); // 0x000000018228A560-0x000000018228A620
	
				// Methods
				public void SetTo(Transform t); // 0x000000018228A4F0-0x000000018228A560
			}
	
			// Constructors
			public CalibrationData(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, Settings settings); // 0x0000000182290260-0x00000001822904E0
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018228E200-0x0000000182290260
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018228C7D0-0x000000018228D160
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018228D160-0x000000018228E200
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018228C4D0-0x000000018228C7D0
	}
}
