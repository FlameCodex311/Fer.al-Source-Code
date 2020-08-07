/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class AimController : UnityEngine.MonoBehaviour // TypeDefIndex: 9985
	{
		// Fields
		[Tooltip] // 0x0000000180207550-0x0000000180207580
		public AimIK ik; // 0x18
		[Range] // 0x0000000180274180-0x00000001802741E0
		[Tooltip] // 0x0000000180274180-0x00000001802741E0
		public float weight; // 0x20
		[Header] // 0x00000001802744D0-0x0000000180274530
		[Tooltip] // 0x00000001802744D0-0x0000000180274530
		public Transform target; // 0x28
		[Tooltip] // 0x0000000180274710-0x0000000180274740
		public float targetSwitchSmoothTime; // 0x30
		[Tooltip] // 0x0000000180274780-0x00000001802747B0
		public float weightSmoothTime; // 0x34
		[Header] // 0x0000000180274B30-0x0000000180274B90
		[Tooltip] // 0x0000000180274B30-0x0000000180274B90
		public bool smoothTurnTowardsTarget; // 0x38
		[Tooltip] // 0x0000000180274DA0-0x0000000180274DD0
		public float maxRadiansDelta; // 0x3C
		[Tooltip] // 0x00000001802762F0-0x0000000180276320
		public float maxMagnitudeDelta; // 0x40
		[Tooltip] // 0x00000001802765D0-0x0000000180276600
		public float slerpSpeed; // 0x44
		[Tooltip] // 0x0000000180276710-0x0000000180276740
		public Vector3 pivotOffsetFromRoot; // 0x48
		[Tooltip] // 0x0000000180276930-0x0000000180276960
		public float minDistance; // 0x54
		[Tooltip] // 0x0000000180276AC0-0x0000000180276AF0
		public Vector3 offset; // 0x58
		[Header] // 0x0000000180276F40-0x0000000180276FC0
		[Range] // 0x0000000180276F40-0x0000000180276FC0
		[Tooltip] // 0x0000000180276F40-0x0000000180276FC0
		public float maxRootAngle; // 0x64
		[Tooltip] // 0x0000000180277210-0x0000000180277240
		public bool turnToTarget; // 0x68
		[Tooltip] // 0x0000000180277350-0x0000000180277380
		public float turnToTargetTime; // 0x6C
		[Header] // 0x0000000180277750-0x00000001802777B0
		[Tooltip] // 0x0000000180277750-0x00000001802777B0
		public bool useAnimatedAimDirection; // 0x70
		[Tooltip] // 0x0000000180277A10-0x0000000180277A40
		public Vector3 animatedAimDirection; // 0x74
		private Transform lastTarget; // 0x80
		private float switchWeight; // 0x88
		private float switchWeightV; // 0x8C
		private float weightV; // 0x90
		private Vector3 lastPosition; // 0x94
		private Vector3 dir; // 0xA0
		private bool lastSmoothTowardsTarget; // 0xAC
		private bool turningToTarget; // 0xAD
		private float turnToTargetMlp; // 0xB0
		private float turnToTargetMlpV; // 0xB4
	
		// Properties
		private Vector3 pivot { get; } // 0x0000000181422960-0x0000000181422B00 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <TurnToTarget>d__33 : IEnumerator<object> // TypeDefIndex: 9986
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public AimController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <TurnToTarget>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181440150-0x00000001814402A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814402A0-0x00000001814402F0
		}
	
		// Constructors
		public AimController(); // 0x0000000181422880-0x0000000181422960
	
		// Methods
		private void Start(); // 0x00000001814226C0-0x0000000181422820
		private void LateUpdate(); // 0x00000001814216C0-0x00000001814222B0
		private void ApplyMinDistance(); // 0x00000001814214A0-0x00000001814216C0
		private void RootRotation(); // 0x00000001814222B0-0x00000001814226C0
		[IteratorStateMachine] // 0x0000000180277C40-0x0000000180277C90
		private IEnumerator TurnToTarget(); // 0x0000000181422820-0x0000000181422880
	}
}
