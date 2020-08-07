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
	[Category] // 0x00000001802475D0-0x0000000180247630
	[Name] // 0x00000001802475D0-0x0000000180247630
	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 15306
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BB6200-0x0000000180BB63E0 
	
		// Constructors
		public MecanimSetIK(); // 0x0000000180BB61C0-0x0000000180BB6200
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB60A0-0x0000000180BB6130
		protected override void OnStop(); // 0x0000000180BB6130-0x0000000180BB61C0
		private void OnAnimatorIK(EventData<int> msg); // 0x0000000180BB5F70-0x0000000180BB60A0
	}
}
