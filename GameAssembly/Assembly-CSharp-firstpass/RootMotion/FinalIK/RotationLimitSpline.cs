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
	[AddComponentMenu] // 0x0000000180271E30-0x0000000180271E90
	[HelpURL] // 0x0000000180271E30-0x0000000180271E90
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 9984
	{
		// Fields
		[Range] // 0x000000018020FC30-0x000000018020FC50
		public float twistLimit; // 0x38
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline(); // 0x0000000182021AF0-0x0000000182021B00
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x0000000182021A50-0x0000000182021A90
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x0000000182021A10-0x0000000182021A50
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000182021AB0-0x0000000182021AF0
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000182021560-0x00000001820215A0
		public void SetSpline(Keyframe[] keyframes); // 0x0000000182021A90-0x0000000182021AB0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x00000001820215A0-0x0000000182021680
		public Quaternion LimitSwing(Quaternion rotation); // 0x0000000182021680-0x0000000182021A10
	}
}
