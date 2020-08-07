/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class LookAtController : UnityEngine.MonoBehaviour // TypeDefIndex: 10008
	{
		// Fields
		public LookAtIK ik; // 0x18
		[Header] // 0x0000000180282300-0x0000000180282360
		[Tooltip] // 0x0000000180282300-0x0000000180282360
		public Transform target; // 0x20
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float weight; // 0x28
		public Vector3 offset; // 0x2C
		[Tooltip] // 0x0000000180274710-0x0000000180274740
		public float targetSwitchSmoothTime; // 0x38
		[Tooltip] // 0x0000000180282860-0x0000000180282890
		public float weightSmoothTime; // 0x3C
		[Header] // 0x0000000180274B30-0x0000000180274B90
		[Tooltip] // 0x0000000180274B30-0x0000000180274B90
		public bool smoothTurnTowardsTarget; // 0x40
		[Tooltip] // 0x0000000180274DA0-0x0000000180274DD0
		public float maxRadiansDelta; // 0x44
		[Tooltip] // 0x00000001802762F0-0x0000000180276320
		public float maxMagnitudeDelta; // 0x48
		[Tooltip] // 0x00000001802765D0-0x0000000180276600
		public float slerpSpeed; // 0x4C
		[Tooltip] // 0x0000000180282E10-0x0000000180282E40
		public Vector3 pivotOffsetFromRoot; // 0x50
		[Tooltip] // 0x0000000180282F50-0x0000000180282F80
		public float minDistance; // 0x5C
		[Header] // 0x00000001802831C0-0x0000000180283240
		[Range] // 0x00000001802831C0-0x0000000180283240
		[Tooltip] // 0x00000001802831C0-0x0000000180283240
		public float maxRootAngle; // 0x60
		private Transform lastTarget; // 0x68
		private float switchWeight; // 0x70
		private float switchWeightV; // 0x74
		private float weightV; // 0x78
		private Vector3 lastPosition; // 0x7C
		private Vector3 dir; // 0x88
		private bool lastSmoothTowardsTarget; // 0x94
	
		// Properties
		private Vector3 pivot { get; } // 0x000000018163A860-0x000000018163AA00 
	
		// Constructors
		public LookAtController(); // 0x000000018163A7B0-0x000000018163A860
	
		// Methods
		private void Start(); // 0x000000018163A680-0x000000018163A7B0
		private void LateUpdate(); // 0x0000000181639810-0x000000018163A2D0
		private void ApplyMinDistance(); // 0x00000001816395F0-0x0000000181639810
		private void RootRotation(); // 0x000000018163A2D0-0x000000018163A680
	}
}
