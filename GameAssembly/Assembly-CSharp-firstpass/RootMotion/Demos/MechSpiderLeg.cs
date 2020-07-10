/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class MechSpiderLeg : UnityEngine.MonoBehaviour // TypeDefIndex: 9502
	{
		// Fields
		public MechSpider mechSpider; // 0x18
		public MechSpiderLeg unSync; // 0x20
		public Vector3 offset; // 0x28
		public float minDelay; // 0x34
		public float maxOffset; // 0x38
		public float stepSpeed; // 0x3C
		public float footHeight; // 0x40
		public float velocityPrediction; // 0x44
		public float raycastFocus; // 0x48
		public AnimationCurve yOffset; // 0x50
		public ParticleSystem sand; // 0x58
		private IK ik; // 0x60
		private float stepProgress; // 0x68
		private float lastStepTime; // 0x6C
		private Vector3 defaultPosition; // 0x70
		private RaycastHit hit; // 0x7C
	
		// Properties
		public bool isStepping { get; } // 0x0000000181834420-0x0000000181834430 
		public Vector3 position { get; set; } // 0x0000000181834430-0x00000001818344A0 0x00000001818344A0-0x00000001818344F0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Step>d__26 : IEnumerator<object> // TypeDefIndex: 9503
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MechSpiderLeg <>4__this; // 0x20
			public Vector3 stepStartPosition; // 0x28
			public Vector3 targetPosition; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Step>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018183EBC0-0x000000018183F130
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018183F130-0x000000018183F180
		}
	
		// Constructors
		public MechSpiderLeg(); // 0x00000001818343E0-0x0000000181834420
	
		// Methods
		private void Awake(); // 0x00000001818334D0-0x0000000181833510
		private void Start(); // 0x0000000181833C60-0x0000000181833FB0
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance); // 0x0000000181833510-0x0000000181833B10
		private void OnEnable(); // 0x0000000181833B10-0x0000000181833C60
		private void Update(); // 0x0000000181834050-0x00000001818343E0
		[IteratorStateMachine] // 0x00000001800D2660-0x00000001800D26B0
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition); // 0x0000000181833FB0-0x0000000181834050
	}
}
