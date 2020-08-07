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
	[Category] // 0x0000000180247310-0x0000000180247390
	[Description] // 0x0000000180247310-0x0000000180247390
	[Name] // 0x0000000180247310-0x0000000180247390
	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 15305
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get; } // 0x0000000180BB5EB0-0x0000000180BB5F70 
	
		// Constructors
		public MecanimSetFloat(); // 0x0000000180BB5E60-0x0000000180BB5EB0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB5AE0-0x0000000180BB5C50
		protected override void OnUpdate(); // 0x0000000180BB5C50-0x0000000180BB5D50
		private float Get(); // 0x0000000180BB59F0-0x0000000180BB5AE0
		private void Set(float newValue); // 0x0000000180BB5D50-0x0000000180BB5E60
	}
}
