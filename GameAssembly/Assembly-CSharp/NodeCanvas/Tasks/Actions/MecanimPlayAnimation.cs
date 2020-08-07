/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180246770-0x00000001802467D0
	[Name] // 0x0000000180246770-0x00000001802467D0
	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 15303
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> stateName; // 0x70
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public float transitTime; // 0x78
		public bool waitUntilFinish; // 0x7C
		private AnimatorStateInfo stateInfo; // 0x80
		private bool played; // 0xA4
	
		// Properties
		protected override string info { get; } // 0x0000000180BB5730-0x0000000180BB57A0 
	
		// Constructors
		public MecanimPlayAnimation(); // 0x0000000180BB56F0-0x0000000180BB5730
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB5380-0x0000000180BB5550
		protected override void OnUpdate(); // 0x0000000180BB5550-0x0000000180BB56F0
	}
}
