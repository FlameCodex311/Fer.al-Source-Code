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
	[Category] // 0x0000000180247CD0-0x0000000180247D30
	[Name] // 0x0000000180247CD0-0x0000000180247D30
	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 15308
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public BBParameter<float> layerWeight; // 0x70
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x0000000180BB6830-0x0000000180BB69F0 
	
		// Constructors
		public MecanimSetLayerWeight(); // 0x0000000180BB67F0-0x0000000180BB6830
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB6620-0x0000000180BB66A0
		protected override void OnUpdate(); // 0x0000000180BB66A0-0x0000000180BB67F0
	}
}
