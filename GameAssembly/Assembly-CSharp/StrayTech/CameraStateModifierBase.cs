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
	public abstract class CameraStateModifierBase : MonoBehaviour // TypeDefIndex: 14530
	{
		// Fields
		[SerializeField] // 0x0000000180253F20-0x0000000180253F60
		[Tooltip] // 0x0000000180253F20-0x0000000180253F60
		private float _transitionIntoEnabledDuration; // 0x20
		[SerializeField] // 0x0000000180254170-0x00000001802541B0
		[Tooltip] // 0x0000000180254170-0x00000001802541B0
		private float _transitionIntoDisabledDuration; // 0x24
		[SerializeField] // 0x000000018024B8D0-0x000000018024B910
		[Tooltip] // 0x000000018024B8D0-0x000000018024B910
		private int _priority; // 0x28
		private bool _transitioning; // 0x2C
		private float _transitionLerpT; // 0x30
		protected Vector3 _cameraTargetPosition; // 0x34
		protected Quaternion _cameraTargetRotation; // 0x40
	
		// Properties
		public abstract string Name { get; }
		public int Priority { get; } // 0x000000018043C680-0x000000018043C690 
		public float TransitionLerpT { get; } // 0x00000001806757B0-0x00000001806757C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoTransitionIn>d__19 : IEnumerator<object> // TypeDefIndex: 14531
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierBase <>4__this; // 0x20
			public float transitionDuration; // 0x28
			private float <elapsed>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoTransitionIn>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBD880-0x0000000180CBD9F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBD9F0-0x0000000180CBDA40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoTransitionOut>d__20 : IEnumerator<object> // TypeDefIndex: 14532
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierBase <>4__this; // 0x20
			public float transitionDuration; // 0x28
			private float <elapsed>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoTransitionOut>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBDA40-0x0000000180CBDC00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBDC00-0x0000000180CBDC50
		}
	
		// Constructors
		protected CameraStateModifierBase(); // 0x0000000180CA9640-0x0000000180CA9660
	
		// Methods
		public virtual void Initialize(); // 0x00000001803774A0-0x00000001803774B0
		protected abstract void CalculateModification(ICameraState cameraState, float deltaTime);
		public void ModifiyCamera(ICameraState cameraState, float deltaTime); // 0x0000000180CA90D0-0x0000000180CA9640
		public virtual bool Enable(); // 0x0000000180CA8F70-0x0000000180CA90D0
		public virtual void Disable(); // 0x0000000180CA8DB0-0x0000000180CA8E90
		public virtual void Cleanup(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x00000001802545D0-0x0000000180254620
		private IEnumerator DoTransitionIn(float transitionDuration); // 0x0000000180CA8E90-0x0000000180CA8F00
		[IteratorStateMachine] // 0x00000001802547A0-0x00000001802547F0
		private IEnumerator DoTransitionOut(float transitionDuration); // 0x0000000180CA8F00-0x0000000180CA8F70
	}
}
