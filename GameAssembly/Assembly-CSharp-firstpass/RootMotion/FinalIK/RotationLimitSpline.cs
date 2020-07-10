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
	[AddComponentMenu] // 0x0000000180173BE0-0x0000000180173C40
	[HelpURL] // 0x0000000180173BE0-0x0000000180173C40
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 9450
	{
		// Fields
		[Range] // 0x00000001800D6F30-0x00000001800D6F50
		public float twistLimit; // 0x38
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline(); // 0x00000001822893E0-0x00000001822893F0
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000182289340-0x0000000182289380
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000182289300-0x0000000182289340
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x00000001822893A0-0x00000001822893E0
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000182288E50-0x0000000182288E90
		public void SetSpline(Keyframe[] keyframes); // 0x0000000182289380-0x00000001822893A0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x0000000182288E90-0x0000000182288F70
		public Quaternion LimitSwing(Quaternion rotation); // 0x0000000182288F70-0x0000000182289300
	}
}
