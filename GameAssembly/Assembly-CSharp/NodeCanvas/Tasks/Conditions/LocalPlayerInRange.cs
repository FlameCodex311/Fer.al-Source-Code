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
	[Category] // 0x0000000180242A70-0x0000000180242AD0
	[Description] // 0x0000000180242A70-0x0000000180242AD0
	public class LocalPlayerInRange : ConditionTask<Transform> // TypeDefIndex: 15283
	{
		// Fields
		public BBParameter<float> range; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001808003C0-0x0000000180800640 
	
		// Constructors
		public LocalPlayerInRange(); // 0x0000000180800380-0x00000001808003C0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001808000C0-0x0000000180800250
		public override void OnDrawGizmosSelected(); // 0x0000000180800250-0x0000000180800380
	}
}
