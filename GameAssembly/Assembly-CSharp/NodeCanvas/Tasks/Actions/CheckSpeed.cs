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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010CCD0-0x000000018010CD30
	[Description] // 0x000000018010CCD0-0x000000018010CD30
	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 14347
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		[SliderField] // 0x00000001800C58A0-0x00000001800C58C0
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018174B020-0x000000018174B070 
	
		// Constructors
		public CheckSpeed(); // 0x000000018174AFE0-0x000000018174B020
	
		// Methods
		protected override bool OnCheck(); // 0x000000018174AF10-0x000000018174AFE0
	}
}
