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
	[AddComponentMenu] // 0x000000018026E6D0-0x000000018026E730
	[HelpURL] // 0x000000018026E6D0-0x000000018026E730
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 9979
	{
		// Fields
		[Range] // 0x000000018020FC30-0x000000018020FC50
		public float limit; // 0x38
		[Range] // 0x000000018020FC30-0x000000018020FC50
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle(); // 0x000000018163FF70-0x000000018163FFF0
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x000000018163FEF0-0x000000018163FF30
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x000000018163FEB0-0x000000018163FEF0
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x000000018163FF30-0x000000018163FF70
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x000000018163FB00-0x000000018163FB40
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018163FB40-0x000000018163FC30
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018163FC30-0x000000018163FEB0
	}
}
