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

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class MechSpiderLeg : UnityEngine.MonoBehaviour // TypeDefIndex: 9789
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
		public bool isStepping { get; } // 0x000000018137ADE0-0x000000018137ADF0 
		public Vector3 position { get; set; } // 0x000000018137ADF0-0x000000018137AE60 0x000000018137AE60-0x000000018137AEB0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Step>d__26 : IEnumerator<object> // TypeDefIndex: 9790
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MechSpiderLeg <>4__this; // 0x20
			public Vector3 stepStartPosition; // 0x28
			public Vector3 targetPosition; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Step>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181383520-0x0000000181383A80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181383A80-0x0000000181383AD0
		}
	
		// Constructors
		public MechSpiderLeg(); // 0x000000018137ADA0-0x000000018137ADE0
	
		// Methods
		private void Awake(); // 0x0000000181379EC0-0x0000000181379F00
		private void Start(); // 0x000000018137A640-0x000000018137A980
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance); // 0x0000000181379F00-0x000000018137A4F0
		private void OnEnable(); // 0x000000018137A4F0-0x000000018137A640
		private void Update(); // 0x000000018137AA20-0x000000018137ADA0
		[IteratorStateMachine] // 0x00000001802099C0-0x0000000180209A10
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition); // 0x000000018137A980-0x000000018137AA20
	}
}
