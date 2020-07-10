/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E3BE0-0x00000001800E3C90
	[Name] // 0x00000001800E3BE0-0x00000001800E3C90
	[EventReceiver] // 0x00000001800E3BE0-0x00000001800E3C90
	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 14206
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181550360-0x0000000181550550 
	
		// Constructors
		public MecanimSetIK(); // 0x0000000181550320-0x0000000181550360
	
		// Methods
		public void OnAnimatorIK(); // 0x00000001815501E0-0x0000000181550320
	}
}
