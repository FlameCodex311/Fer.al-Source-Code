/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 9860
	{
		// Fields
		[Tooltip] // 0x0000000180221B30-0x0000000180221B60
		public bool activeTargetSeeking; // 0x10
		[Tooltip] // 0x0000000180221CD0-0x0000000180221D00
		public float cornerRadius; // 0x14
		[Tooltip] // 0x0000000180221F40-0x0000000180221F70
		public float recalculateOnPathDistance; // 0x18
		[Tooltip] // 0x0000000180222160-0x0000000180222190
		public float maxSampleDistance; // 0x1C
		[Tooltip] // 0x00000001802223B0-0x00000001802223E0
		public float nextPathInterval; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private State <state>k__BackingField; // 0x30
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001806757C0-0x00000001806757E0 0x0000000180CA4690-0x0000000180CA46A0
		public State state { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
	
		// Nested types
		public enum State // TypeDefIndex: 9861
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator(); // 0x000000018137DEA0-0x000000018137DF10
	
		// Methods
		public void Initiate(Transform transform); // 0x000000018137D4F0-0x000000018137D5A0
		public void Update(Vector3 targetPosition); // 0x000000018137D610-0x000000018137DBC0
		private void CalculatePath(Vector3 targetPosition); // 0x000000018137D150-0x000000018137D1C0
		private bool Find(Vector3 targetPosition); // 0x000000018137D1C0-0x000000018137D430
		private void Stop(); // 0x000000018137D5A0-0x000000018137D610
		private float HorDistance(Vector3 p1, Vector3 p2); // 0x000000018137D430-0x000000018137D4F0
		public void Visualize(); // 0x000000018137DBC0-0x000000018137DEA0
	}
}
