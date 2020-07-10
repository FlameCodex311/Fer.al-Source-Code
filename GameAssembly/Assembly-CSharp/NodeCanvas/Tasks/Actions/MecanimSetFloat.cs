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
	[Category] // 0x00000001800E37C0-0x00000001800E3840
	[Description] // 0x00000001800E37C0-0x00000001800E3840
	[Name] // 0x00000001800E37C0-0x00000001800E3840
	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 14205
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get; } // 0x0000000181550120-0x00000001815501E0 
	
		// Constructors
		public MecanimSetFloat(); // 0x00000001815500D0-0x0000000181550120
	
		// Methods
		protected override void OnExecute(); // 0x000000018154FD50-0x000000018154FEC0
		protected override void OnUpdate(); // 0x000000018154FEC0-0x000000018154FFC0
		private float Get(); // 0x000000018154FC60-0x000000018154FD50
		private void Set(float newValue); // 0x000000018154FFC0-0x00000001815500D0
	}
}
