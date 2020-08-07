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
	[RequireComponent] // 0x000000018020BB10-0x000000018020BB60
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson // TypeDefIndex: 9797
	{
		// Fields
		private FullBodyBipedIK ik; // 0x90
	
		// Constructors
		public CharacterAnimationThirdPersonIK(); // 0x000000018136EB30-0x000000018136EB60
	
		// Methods
		protected override void Start(); // 0x000000018136EA70-0x000000018136EB30
		protected override void LateUpdate(); // 0x000000018136E510-0x000000018136E850
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp); // 0x000000018136E850-0x000000018136EA70
	}
}
