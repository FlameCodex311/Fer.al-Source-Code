/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public class AimController : UnityEngine.MonoBehaviour // TypeDefIndex: 9451
	{
		// Fields
		[Tooltip] // 0x00000001800CF6D0-0x00000001800CF700
		public AimIK ik; // 0x18
		[Range] // 0x0000000180174F90-0x0000000180174FF0
		[Tooltip] // 0x0000000180174F90-0x0000000180174FF0
		public float weight; // 0x20
		[Header] // 0x0000000180175260-0x00000001801752C0
		[Tooltip] // 0x0000000180175260-0x00000001801752C0
		public Transform target; // 0x28
		[Tooltip] // 0x00000001800C2150-0x00000001800C2180
		public float targetSwitchSmoothTime; // 0x30
		[Tooltip] // 0x0000000180175710-0x0000000180175740
		public float weightSmoothTime; // 0x34
		[Header] // 0x00000001800B3770-0x00000001800B37D0
		[Tooltip] // 0x00000001800B3770-0x00000001800B37D0
		public bool smoothTurnTowardsTarget; // 0x38
		[Tooltip] // 0x00000001800B3C40-0x00000001800B3C70
		public float maxRadiansDelta; // 0x3C
		[Tooltip] // 0x00000001800B3E20-0x00000001800B3E50
		public float maxMagnitudeDelta; // 0x40
		[Tooltip] // 0x00000001800B3FF0-0x00000001800B4020
		public float slerpSpeed; // 0x44
		[Tooltip] // 0x00000001800B41A0-0x00000001800B41D0
		public Vector3 pivotOffsetFromRoot; // 0x48
		[Tooltip] // 0x00000001800B55B0-0x00000001800B55E0
		public float minDistance; // 0x54
		[Tooltip] // 0x00000001800B5710-0x00000001800B5740
		public Vector3 offset; // 0x58
		[Header] // 0x00000001800B5860-0x00000001800B58E0
		[Range] // 0x00000001800B5860-0x00000001800B58E0
		[Tooltip] // 0x00000001800B5860-0x00000001800B58E0
		public float maxRootAngle; // 0x64
		[Tooltip] // 0x00000001800B5AF0-0x00000001800B5B20
		public bool turnToTarget; // 0x68
		[Tooltip] // 0x00000001800B5C80-0x00000001800B5CB0
		public float turnToTargetTime; // 0x6C
		[Header] // 0x00000001800B5EE0-0x00000001800B5F40
		[Tooltip] // 0x00000001800B5EE0-0x00000001800B5F40
		public bool useAnimatedAimDirection; // 0x70
		[Tooltip] // 0x00000001800B6170-0x00000001800B61A0
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
		private Vector3 pivot { get; } // 0x000000018181D170-0x000000018181D310 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <TurnToTarget>d__33 : IEnumerator<object> // TypeDefIndex: 9452
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public AimController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <TurnToTarget>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018183F360-0x000000018183F4C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018183F4C0-0x000000018183F510
		}
	
		// Constructors
		public AimController(); // 0x000000018181D090-0x000000018181D170
	
		// Methods
		private void Start(); // 0x000000018181CEC0-0x000000018181D030
		private void LateUpdate(); // 0x000000018181BE70-0x000000018181CAA0
		private void ApplyMinDistance(); // 0x000000018181BC50-0x000000018181BE70
		private void RootRotation(); // 0x000000018181CAA0-0x000000018181CEC0
		[IteratorStateMachine] // 0x00000001800B6370-0x00000001800B63C0
		private IEnumerator TurnToTarget(); // 0x000000018181D030-0x000000018181D090
	}
}
