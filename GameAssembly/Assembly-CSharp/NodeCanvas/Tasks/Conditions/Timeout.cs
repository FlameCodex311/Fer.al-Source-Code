/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802414D0-0x0000000180241530
	[Description] // 0x00000001802414D0-0x0000000180241530
	public class Timeout : ConditionTask // TypeDefIndex: 15276
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180807560-0x00000001808075E0 
	
		// Constructors
		public Timeout(); // 0x0000000180807510-0x0000000180807560
	
		// Methods
		protected override void OnEnable(); // 0x0000000180807480-0x0000000180807510
		protected override void OnDisable(); // 0x00000001808073F0-0x0000000180807480
		private void MoveNext(); // 0x00000001808072E0-0x0000000180807390
		protected override bool OnCheck(); // 0x0000000180807390-0x00000001808073F0
	}
}
