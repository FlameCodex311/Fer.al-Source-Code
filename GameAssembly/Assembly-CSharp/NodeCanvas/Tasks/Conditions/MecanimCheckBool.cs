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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802228F0-0x0000000180222950
	[Name] // 0x00000001802228F0-0x0000000180222950
	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 15197
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180800B10-0x0000000180800CF0 
	
		// Constructors
		public MecanimCheckBool(); // 0x0000000180800AD0-0x0000000180800B10
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180800A30-0x0000000180800AD0
	}
}
