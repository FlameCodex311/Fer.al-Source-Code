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
	public class VRIKRootController : UnityEngine.MonoBehaviour // TypeDefIndex: 9494
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <pelvisTargetRight>k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181200DA0-0x0000000181200DC0 0x0000000181200DC0-0x0000000181200DD0
	
		// Constructors
		public VRIKRootController(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x00000001822904E0-0x00000001822905D0
		public void Calibrate(); // 0x00000001822905D0-0x0000000182290880
		public void Calibrate(VRIKCalibrator.CalibrationData data); // 0x0000000182290880-0x0000000182290A60
		private void OnPreUpdate(); // 0x0000000182290B60-0x00000001822912B0
		private void OnDestroy(); // 0x0000000182290A60-0x0000000182290B60
	}
}
