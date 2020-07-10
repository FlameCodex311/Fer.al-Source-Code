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
	[AddComponentMenu] // 0x00000001801707D0-0x0000000180170830
	[HelpURL] // 0x00000001801707D0-0x0000000180170830
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 9446
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float zeroAxisDisplayOffset; // 0x44
		private Quaternion lastRotation; // 0x48
		private float lastAngle; // 0x58
	
		// Constructors
		public RotationLimitHinge(); // 0x00000001822866C0-0x0000000182286740
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000182286640-0x0000000182286680
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000182286600-0x0000000182286640
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000182286680-0x00000001822866C0
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000182286220-0x0000000182286260
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x00000001822865B0-0x0000000182286600
		private Quaternion LimitHinge(Quaternion rotation); // 0x0000000182286260-0x00000001822865B0
	}
}
