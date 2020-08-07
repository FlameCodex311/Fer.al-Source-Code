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
	public class TwistRelaxer : UnityEngine.MonoBehaviour // TypeDefIndex: 9950
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip] // 0x000000018025A420-0x000000018025A450
		public Transform parent; // 0x20
		[Tooltip] // 0x000000018025A5F0-0x000000018025A620
		public Transform child; // 0x28
		[Range] // 0x000000018025A840-0x000000018025A8A0
		[Tooltip] // 0x000000018025A840-0x000000018025A8A0
		public float weight; // 0x30
		[Range] // 0x000000018025BD00-0x000000018025BD60
		[Tooltip] // 0x000000018025BD00-0x000000018025BD60
		public float parentChildCrossfade; // 0x34
		[Range] // 0x000000018025BFC0-0x000000018025C020
		[Tooltip] // 0x000000018025BFC0-0x000000018025C020
		public float twistAngleOffset; // 0x38
		private Vector3 twistAxis; // 0x3C
		private Vector3 axis; // 0x48
		private Vector3 axisRelativeToParentDefault; // 0x54
		private Vector3 axisRelativeToChildDefault; // 0x60
	
		// Constructors
		public TwistRelaxer(); // 0x0000000182023C30-0x0000000182023CD0
	
		// Methods
		public void Relax(); // 0x0000000182023230-0x00000001820236D0
		private void Start(); // 0x00000001820236D0-0x0000000182023C30
		private void OnPostUpdate(); // 0x00000001820231C0-0x0000000182023230
		private void LateUpdate(); // 0x0000000182023040-0x00000001820230B0
		private void OnDestroy(); // 0x00000001820230B0-0x00000001820231C0
	}
}
