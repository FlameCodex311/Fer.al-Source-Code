/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180264C40-0x0000000180264CA0
	[Description] // 0x0000000180264C40-0x0000000180264CA0
	public class Patrol : ActionTask<NavMeshAgent> // TypeDefIndex: 15402
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> targetList; // 0x68
		public BBParameter<PatrolMode> patrolMode; // 0x70
		public BBParameter<float> speed; // 0x78
		public BBParameter<float> keepDistance; // 0x80
		private int index; // 0x88
		private Vector3? lastRequest; // 0x8C
	
		// Properties
		protected override string info { get; } // 0x0000000180BBE7E0-0x0000000180BBE820 
	
		// Nested types
		public enum PatrolMode // TypeDefIndex: 15403
		{
			Progressive = 0,
			Random = 1
		}
	
		// Constructors
		public Patrol(); // 0x0000000180BBE750-0x0000000180BBE7E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBDFC0-0x0000000180BBE410
		protected override void OnUpdate(); // 0x0000000180BBE4B0-0x0000000180BBE750
		protected override void OnPause(); // 0x00000001804F1140-0x00000001804F1160
		protected override void OnStop(); // 0x0000000180BBE410-0x0000000180BBE4B0
		public override void OnDrawGizmosSelected(); // 0x0000000180BBDD70-0x0000000180BBDFC0
	}
}
