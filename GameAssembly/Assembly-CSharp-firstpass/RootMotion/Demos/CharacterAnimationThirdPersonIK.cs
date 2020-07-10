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
	[RequireComponent] // 0x00000001800D5540-0x00000001800D5590
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson // TypeDefIndex: 9510
	{
		// Fields
		private FullBodyBipedIK ik; // 0x90
	
		// Constructors
		public CharacterAnimationThirdPersonIK(); // 0x0000000181648020-0x0000000181648050
	
		// Methods
		protected override void Start(); // 0x0000000181647F60-0x0000000181648020
		protected override void LateUpdate(); // 0x00000001816479F0-0x0000000181647D40
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp); // 0x0000000181647D40-0x0000000181647F60
	}
}
