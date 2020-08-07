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
	[Category] // 0x0000000180264A00-0x0000000180264A60
	[Name] // 0x0000000180264A00-0x0000000180264A60
	public class MoveToPosition : ActionTask<NavMeshAgent> // TypeDefIndex: 15401
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> keepDistance; // 0x78
		private Vector3? lastRequest; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BB8450-0x0000000180BB8490 
	
		// Constructors
		public MoveToPosition(); // 0x0000000180BB83E0-0x0000000180BB8450
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB7F20-0x0000000180BB80D0
		protected override void OnUpdate(); // 0x0000000180BB8170-0x0000000180BB83E0
		protected override void OnStop(); // 0x0000000180BB80D0-0x0000000180BB8170
		protected override void OnPause(); // 0x00000001804F1140-0x00000001804F1160
	}
}
