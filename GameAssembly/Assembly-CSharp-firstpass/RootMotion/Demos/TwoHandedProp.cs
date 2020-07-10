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
	public class TwoHandedProp : UnityEngine.MonoBehaviour // TypeDefIndex: 9547
	{
		// Fields
		[Tooltip] // 0x00000001800DEC20-0x00000001800DEC50
		public Transform leftHandTarget; // 0x18
		private FullBodyBipedIK ik; // 0x20
		private Vector3 targetPosRelativeToRight; // 0x28
		private Quaternion targetRotRelativeToRight; // 0x34
	
		// Constructors
		public TwoHandedProp(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x000000018183E590-0x000000018183E7A0
		private void LateUpdate(); // 0x000000018183E060-0x000000018183E490
		private void AfterFBBIK(); // 0x000000018183DF00-0x000000018183E060
		private void OnDestroy(); // 0x000000018183E490-0x000000018183E590
	}
}
