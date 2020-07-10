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
	public class FBBIKArmBending : UnityEngine.MonoBehaviour // TypeDefIndex: 9367
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public Vector3 bendDirectionOffsetLeft; // 0x20
		public Vector3 bendDirectionOffsetRight; // 0x2C
		public Vector3 characterSpaceBendOffsetLeft; // 0x38
		public Vector3 characterSpaceBendOffsetRight; // 0x44
		private Quaternion leftHandTargetRotation; // 0x50
		private Quaternion rightHandTargetRotation; // 0x60
		private bool initiated; // 0x70
	
		// Constructors
		public FBBIKArmBending(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void LateUpdate(); // 0x0000000181824550-0x0000000181824D50
		private void OnPostFBBIK(); // 0x0000000181824E50-0x0000000181825100
		private void OnDestroy(); // 0x0000000181824D50-0x0000000181824E50
	}
}
