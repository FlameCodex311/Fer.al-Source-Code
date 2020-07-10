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
	[Category] // 0x00000001800E4880-0x00000001800E48E0
	[Name] // 0x00000001800E4880-0x00000001800E48E0
	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 14208
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public BBParameter<float> layerWeight; // 0x70
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x00000001815509B0-0x0000000181550B90 
	
		// Constructors
		public MecanimSetLayerWeight(); // 0x0000000181550970-0x00000001815509B0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815507A0-0x0000000181550820
		protected override void OnUpdate(); // 0x0000000181550820-0x0000000181550970
	}
}
