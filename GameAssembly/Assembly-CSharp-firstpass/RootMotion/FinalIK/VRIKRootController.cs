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
	public class VRIKRootController : UnityEngine.MonoBehaviour // TypeDefIndex: 10028
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <pelvisTargetRight>k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180CB5AC0-0x0000000180CB5AE0 0x0000000180CB5AE0-0x0000000180CB5AF0
	
		// Constructors
		public VRIKRootController(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x00000001820289C0-0x0000000182028AB0
		public void Calibrate(); // 0x0000000182028AB0-0x0000000182028D50
		public void Calibrate(VRIKCalibrator.CalibrationData data); // 0x0000000182028D50-0x0000000182028F30
		private void OnPreUpdate(); // 0x0000000182029030-0x0000000182029740
		private void OnDestroy(); // 0x0000000182028F30-0x0000000182029030
	}
}
