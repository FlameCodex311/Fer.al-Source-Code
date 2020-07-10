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
	[AddComponentMenu] // 0x000000018016F8A0-0x000000018016F900
	[HelpURL] // 0x000000018016F8A0-0x000000018016F900
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 9445
	{
		// Fields
		[Range] // 0x00000001800D6F30-0x00000001800D6F50
		public float limit; // 0x38
		[Range] // 0x00000001800D6F30-0x00000001800D6F50
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle(); // 0x0000000182286200-0x0000000182286220
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000182286180-0x00000001822861C0
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000182286140-0x0000000182286180
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x00000001822861C0-0x0000000182286200
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000182285DA0-0x0000000182285DE0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x0000000182285DE0-0x0000000182285EC0
		private Quaternion LimitSwing(Quaternion rotation); // 0x0000000182285EC0-0x0000000182286140
	}
}
