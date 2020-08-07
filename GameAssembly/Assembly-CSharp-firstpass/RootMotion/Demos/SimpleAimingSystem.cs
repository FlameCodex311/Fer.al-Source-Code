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
	public class SimpleAimingSystem : UnityEngine.MonoBehaviour // TypeDefIndex: 9784
	{
		// Fields
		[Tooltip] // 0x0000000180207310-0x0000000180207340
		public AimPoser aimPoser; // 0x18
		[Tooltip] // 0x0000000180207550-0x0000000180207580
		public AimIK aim; // 0x20
		[Tooltip] // 0x00000001802076C0-0x00000001802076F0
		public LookAtIK lookAt; // 0x28
		[Tooltip] // 0x00000001802078F0-0x0000000180207920
		public Animator animator; // 0x30
		[Tooltip] // 0x0000000180207BF0-0x0000000180207C20
		public float crossfadeTime; // 0x38
		[Tooltip] // 0x0000000180207DD0-0x0000000180207E00
		public float minAimDistance; // 0x3C
		private AimPoser.Pose aimPose; // 0x40
		private AimPoser.Pose lastPose; // 0x48
	
		// Constructors
		public SimpleAimingSystem(); // 0x00000001813827B0-0x00000001813827D0
	
		// Methods
		private void Start(); // 0x0000000181382770-0x00000001813827B0
		private void LateUpdate(); // 0x0000000181382080-0x00000001813821E0
		private void Pose(); // 0x00000001813824B0-0x0000000181382770
		private void LimitAimTarget(); // 0x00000001813821E0-0x00000001813824B0
		private void DirectCrossFade(string state, float target); // 0x0000000181381F80-0x0000000181382080
	}
}
