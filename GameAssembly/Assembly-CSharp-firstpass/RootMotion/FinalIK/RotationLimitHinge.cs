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
	[AddComponentMenu] // 0x0000000180270400-0x0000000180270460
	[HelpURL] // 0x0000000180270400-0x0000000180270460
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 9980
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float zeroAxisDisplayOffset; // 0x44
		private Quaternion lastRotation; // 0x48
		private float lastAngle; // 0x58
	
		// Constructors
		public RotationLimitHinge(); // 0x0000000181640520-0x00000001816405F0
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x00000001816404A0-0x00000001816404E0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x0000000181640460-0x00000001816404A0
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x00000001816404E0-0x0000000181640520
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x000000018163FFF0-0x0000000181640030
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x0000000181640410-0x0000000181640460
		private Quaternion LimitHinge(Quaternion rotation); // 0x0000000181640030-0x0000000181640410
	}
}
