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
	public class TwoHandedProp : UnityEngine.MonoBehaviour // TypeDefIndex: 9834
	{
		// Fields
		[Tooltip] // 0x0000000180218120-0x0000000180218150
		public Transform leftHandTarget; // 0x18
		private FullBodyBipedIK ik; // 0x20
		private Vector3 targetPosRelativeToRight; // 0x28
		private Quaternion targetRotRelativeToRight; // 0x34
	
		// Constructors
		public TwoHandedProp(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x000000018143FDA0-0x000000018143FFA0
		private void LateUpdate(); // 0x000000018143F890-0x000000018143FCA0
		private void AfterFBBIK(); // 0x000000018143F740-0x000000018143F890
		private void OnDestroy(); // 0x000000018143FCA0-0x000000018143FDA0
	}
}
