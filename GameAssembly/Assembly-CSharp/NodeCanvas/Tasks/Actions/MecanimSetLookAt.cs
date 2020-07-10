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
	[Category] // 0x00000001800E4ED0-0x00000001800E4F80
	[Name] // 0x00000001800E4ED0-0x00000001800E4F80
	[EventReceiver] // 0x00000001800E4ED0-0x00000001800E4F80
	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 14209
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181550D00-0x0000000181550D40 
	
		// Constructors
		public MecanimSetLookAt(); // 0x0000000181550CC0-0x0000000181550D00
	
		// Methods
		public void OnAnimatorIK(); // 0x0000000181550B90-0x0000000181550CC0
	}
}
