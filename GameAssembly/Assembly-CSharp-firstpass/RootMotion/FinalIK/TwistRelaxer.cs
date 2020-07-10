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
	public class TwistRelaxer : UnityEngine.MonoBehaviour // TypeDefIndex: 9416
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip] // 0x0000000180159DB0-0x0000000180159DE0
		public Transform parent; // 0x20
		[Tooltip] // 0x0000000180159F80-0x0000000180159FB0
		public Transform child; // 0x28
		[Range] // 0x000000018015A0F0-0x000000018015A150
		[Tooltip] // 0x000000018015A0F0-0x000000018015A150
		public float weight; // 0x30
		[Range] // 0x000000018015A4A0-0x000000018015A500
		[Tooltip] // 0x000000018015A4A0-0x000000018015A500
		public float parentChildCrossfade; // 0x34
		[Range] // 0x000000018015A760-0x000000018015A7C0
		[Tooltip] // 0x000000018015A760-0x000000018015A7C0
		public float twistAngleOffset; // 0x38
		private Vector3 twistAxis; // 0x3C
		private Vector3 axis; // 0x48
		private Vector3 axisRelativeToParentDefault; // 0x54
		private Vector3 axisRelativeToChildDefault; // 0x60
	
		// Constructors
		public TwistRelaxer(); // 0x000000018228B580-0x000000018228B620
	
		// Methods
		public void Relax(); // 0x000000018228AB50-0x000000018228B000
		private void Start(); // 0x000000018228B000-0x000000018228B580
		private void OnPostUpdate(); // 0x000000018228AAE0-0x000000018228AB50
		private void LateUpdate(); // 0x000000018228A960-0x000000018228A9D0
		private void OnDestroy(); // 0x000000018228A9D0-0x000000018228AAE0
	}
}
