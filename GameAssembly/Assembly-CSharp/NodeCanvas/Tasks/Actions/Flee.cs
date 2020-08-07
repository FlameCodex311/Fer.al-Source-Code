/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180262E00-0x0000000180262E60
	[Description] // 0x0000000180262E00-0x0000000180262E60
	public class Flee : ActionTask<NavMeshAgent> // TypeDefIndex: 15399
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> fledDistance; // 0x78
		public BBParameter<float> lookAhead; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BACE50-0x0000000180BACE90 
	
		// Constructors
		public Flee(); // 0x0000000180BACDC0-0x0000000180BACE50
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAC6B0-0x0000000180BAC920
		protected override void OnUpdate(); // 0x0000000180BAC9B0-0x0000000180BACDC0
		protected override void OnPause(); // 0x00000001804F1140-0x00000001804F1160
		protected override void OnStop(); // 0x0000000180BAC920-0x0000000180BAC9B0
	}
}
