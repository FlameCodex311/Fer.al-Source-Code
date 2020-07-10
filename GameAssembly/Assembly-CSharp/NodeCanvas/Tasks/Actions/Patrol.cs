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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800FF550-0x00000001800FF5B0
	[Description] // 0x00000001800FF550-0x00000001800FF5B0
	public class Patrol : ActionTask<NavMeshAgent> // TypeDefIndex: 14299
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> targetList; // 0x68
		public BBParameter<PatrolMode> patrolMode; // 0x70
		public BBParameter<float> speed; // 0x78
		public BBParameter<float> keepDistance; // 0x80
		private int index; // 0x88
		private Vector3? lastRequest; // 0x8C
	
		// Properties
		protected override string info { get; } // 0x0000000181557D30-0x0000000181557D70 
	
		// Nested types
		public enum PatrolMode // TypeDefIndex: 14300
		{
			Progressive = 0,
			Random = 1
		}
	
		// Constructors
		public Patrol(); // 0x0000000181557CA0-0x0000000181557D30
	
		// Methods
		protected override void OnExecute(); // 0x00000001815574B0-0x0000000181557940
		protected override void OnUpdate(); // 0x00000001815579F0-0x0000000181557CA0
		protected override void OnPause(); // 0x000000018090E380-0x000000018090E3A0
		protected override void OnStop(); // 0x0000000181557940-0x00000001815579F0
		public override void OnDrawGizmosSelected(); // 0x0000000181557260-0x00000001815574B0
	}
}
