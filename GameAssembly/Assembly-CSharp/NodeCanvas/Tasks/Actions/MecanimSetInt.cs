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
	[Category] // 0x0000000180247A40-0x0000000180247AC0
	[Description] // 0x0000000180247A40-0x0000000180247AC0
	[Name] // 0x0000000180247A40-0x0000000180247AC0
	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 15307
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BB6560-0x0000000180BB6620 
	
		// Constructors
		public MecanimSetInt(); // 0x0000000180BB6520-0x0000000180BB6560
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB63E0-0x0000000180BB6520
	}
}
