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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180222DB0-0x0000000180222E10
	[Name] // 0x0000000180222DB0-0x0000000180222E10
	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 15198
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180800E00-0x0000000180800FE0 
	
		// Constructors
		public MecanimCheckFloat(); // 0x0000000180800DC0-0x0000000180800E00
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180800CF0-0x0000000180800DC0
	}
}
