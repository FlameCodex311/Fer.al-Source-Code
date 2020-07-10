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
	[Category] // 0x00000001800E2E70-0x00000001800E2ED0
	[Name] // 0x00000001800E2E70-0x00000001800E2ED0
	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 14203
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> stateName; // 0x70
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float transitTime; // 0x78
		public bool waitUntilFinish; // 0x7C
		private AnimatorStateInfo stateInfo; // 0x80
		private bool played; // 0xA4
	
		// Properties
		protected override string info { get; } // 0x000000018154F9A0-0x000000018154FA10 
	
		// Constructors
		public MecanimPlayAnimation(); // 0x000000018154F960-0x000000018154F9A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154F5E0-0x000000018154F7B0
		protected override void OnUpdate(); // 0x000000018154F7B0-0x000000018154F960
	}
}
