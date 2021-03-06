﻿/*
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
	[Category] // 0x00000001802791B0-0x0000000180279210
	[Description] // 0x00000001802791B0-0x0000000180279210
	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 15450
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		[SliderField] // 0x0000000180225480-0x00000001802254A0
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180CBFF40-0x0000000180CBFF90 
	
		// Constructors
		public CheckSpeed(); // 0x0000000180CBFF00-0x0000000180CBFF40
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180CBFE30-0x0000000180CBFF00
	}
}
