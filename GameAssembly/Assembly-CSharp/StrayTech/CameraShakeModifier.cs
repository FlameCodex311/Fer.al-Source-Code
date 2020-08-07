/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class CameraShakeModifier : CameraStateModifierBase // TypeDefIndex: 14534
	{
		// Fields
		[SerializeField] // 0x0000000180255D30-0x0000000180255D70
		[Tooltip] // 0x0000000180255D30-0x0000000180255D70
		private AnimationCurve _shakeIntensityMultiplierCurve; // 0x50
		[SerializeField] // 0x0000000180255EC0-0x0000000180255F00
		[Tooltip] // 0x0000000180255EC0-0x0000000180255F00
		private float _shakeIntensity; // 0x58
		private Vector3 _positionOffset; // 0x5C
		private Quaternion _rotationOffset; // 0x68
		private float _shakeDuration; // 0x78
		private float _shakeLerpT; // 0x7C
	
		// Properties
		public override string Name { get; } // 0x0000000180CA8150-0x0000000180CA8180 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoCurveBasedCameraShake>d__10 : IEnumerator<object> // TypeDefIndex: 14535
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraShakeModifier <>4__this; // 0x20
			private float <elapsedTime>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoCurveBasedCameraShake>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBD600-0x0000000180CBD6E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBD6E0-0x0000000180CBD730
		}
	
		// Constructors
		public CameraShakeModifier(); // 0x0000000180CA8090-0x0000000180CA8150
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000180CA7A90-0x0000000180CA7F40
		public override bool Enable(); // 0x0000000180CA7FA0-0x0000000180CA8090
		[IteratorStateMachine] // 0x0000000180256050-0x00000001802560A0
		private IEnumerator DoCurveBasedCameraShake(); // 0x0000000180CA7F40-0x0000000180CA7FA0
	}
}
