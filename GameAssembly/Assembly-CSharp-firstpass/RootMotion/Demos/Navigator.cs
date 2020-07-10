/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 9573
	{
		// Fields
		[Tooltip] // 0x00000001800E65E0-0x00000001800E6610
		public bool activeTargetSeeking; // 0x10
		[Tooltip] // 0x00000001800E6780-0x00000001800E67B0
		public float cornerRadius; // 0x14
		[Tooltip] // 0x00000001800E6880-0x00000001800E68B0
		public float recalculateOnPathDistance; // 0x18
		[Tooltip] // 0x00000001800E6940-0x00000001800E6970
		public float maxSampleDistance; // 0x1C
		[Tooltip] // 0x00000001800E6AD0-0x00000001800E6B00
		public float nextPathInterval; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private State <state>k__BackingField; // 0x30
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001807A1520-0x00000001807A1540 0x0000000181203B60-0x0000000181203B70
		public State state { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
	
		// Nested types
		public enum State // TypeDefIndex: 9574
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator(); // 0x0000000181837420-0x0000000181837490
	
		// Methods
		public void Initiate(Transform transform); // 0x0000000181836A50-0x0000000181836B00
		public void Update(Vector3 targetPosition); // 0x0000000181836B70-0x0000000181837120
		private void CalculatePath(Vector3 targetPosition); // 0x00000001818366B0-0x0000000181836720
		private bool Find(Vector3 targetPosition); // 0x0000000181836720-0x0000000181836990
		private void Stop(); // 0x0000000181836B00-0x0000000181836B70
		private float HorDistance(Vector3 p1, Vector3 p2); // 0x0000000181836990-0x0000000181836A50
		public void Visualize(); // 0x0000000181837120-0x0000000181837420
	}
}
