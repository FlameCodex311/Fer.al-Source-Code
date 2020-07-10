/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class CameraShakeModifier : CameraStateModifierBase // TypeDefIndex: 13867
	{
		// Fields
		[SerializeField] // 0x000000018012BF00-0x000000018012BF40
		[Tooltip] // 0x000000018012BF00-0x000000018012BF40
		private AnimationCurve _shakeIntensityMultiplierCurve; // 0x50
		[SerializeField] // 0x000000018012C240-0x000000018012C280
		[Tooltip] // 0x000000018012C240-0x000000018012C280
		private float _shakeIntensity; // 0x58
		private Vector3 _positionOffset; // 0x5C
		private Quaternion _rotationOffset; // 0x68
		private float _shakeDuration; // 0x78
		private float _shakeLerpT; // 0x7C
	
		// Properties
		public override string Name { get; } // 0x0000000181349A30-0x0000000181349A60 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoCurveBasedCameraShake>d__10 : IEnumerator<object> // TypeDefIndex: 13868
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraShakeModifier <>4__this; // 0x20
			private float <elapsedTime>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoCurveBasedCameraShake>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018135E9F0-0x000000018135EAD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018135EAD0-0x000000018135EB20
		}
	
		// Constructors
		public CameraShakeModifier(); // 0x0000000181349970-0x0000000181349A30
	
		// Methods
		protected override void CalculateModification(ICameraState cameraState, float deltaTime); // 0x0000000181349370-0x0000000181349820
		public override bool Enable(); // 0x0000000181349880-0x0000000181349970
		[IteratorStateMachine] // 0x000000018012C660-0x000000018012C6B0
		private IEnumerator DoCurveBasedCameraShake(); // 0x0000000181349820-0x0000000181349880
	}
}
