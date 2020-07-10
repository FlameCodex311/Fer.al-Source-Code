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
	public class IKExecutionOrder : UnityEngine.MonoBehaviour // TypeDefIndex: 9359
	{
		// Fields
		[Tooltip] // 0x0000000180135AA0-0x0000000180135AD0
		public IK[] IKComponents; // 0x18
		[Tooltip] // 0x0000000180135C60-0x0000000180135C90
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get; } // 0x0000000181C285C0-0x0000000181C28650 
	
		// Constructors
		public IKExecutionOrder(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x0000000181C28500-0x0000000181C28590
		private void Update(); // 0x0000000181C28590-0x0000000181C285C0
		private void FixedUpdate(); // 0x0000000181C283A0-0x0000000181C283D0
		private void LateUpdate(); // 0x0000000181C283D0-0x0000000181C28500
		private void FixTransforms(); // 0x0000000181C28290-0x0000000181C283A0
	}
}
