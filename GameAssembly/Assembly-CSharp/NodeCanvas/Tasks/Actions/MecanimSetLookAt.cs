/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180248040-0x00000001802480A0
	[Name] // 0x0000000180248040-0x00000001802480A0
	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 15309
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB6C70-0x0000000180BB6CB0 
	
		// Constructors
		public MecanimSetLookAt(); // 0x0000000180BB6C30-0x0000000180BB6C70
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB6B10-0x0000000180BB6BA0
		protected override void OnStop(); // 0x0000000180BB6BA0-0x0000000180BB6C30
		private void OnAnimatorIK(EventData<int> msg); // 0x0000000180BB69F0-0x0000000180BB6B10
	}
}
