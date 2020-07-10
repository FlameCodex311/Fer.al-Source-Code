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
	public abstract class CameraStateModifierBase : MonoBehaviour // TypeDefIndex: 13863
	{
		// Fields
		[SerializeField] // 0x0000000180129110-0x0000000180129150
		[Tooltip] // 0x0000000180129110-0x0000000180129150
		private float _transitionIntoEnabledDuration; // 0x20
		[SerializeField] // 0x00000001801293B0-0x00000001801293F0
		[Tooltip] // 0x00000001801293B0-0x00000001801293F0
		private float _transitionIntoDisabledDuration; // 0x24
		[SerializeField] // 0x000000018011F3C0-0x000000018011F400
		[Tooltip] // 0x000000018011F3C0-0x000000018011F400
		private int _priority; // 0x28
		private bool _transitioning; // 0x2C
		private float _transitionLerpT; // 0x30
		protected Vector3 _cameraTargetPosition; // 0x34
		protected Quaternion _cameraTargetRotation; // 0x40
	
		// Properties
		public abstract string Name { get; }
		public int Priority { get; } // 0x000000018038E0E0-0x000000018038E0F0 
		public float TransitionLerpT { get; } // 0x0000000180485990-0x00000001804859A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoTransitionIn>d__19 : IEnumerator<object> // TypeDefIndex: 13864
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierBase <>4__this; // 0x20
			public float transitionDuration; // 0x28
			private float <elapsed>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoTransitionIn>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018135EC70-0x000000018135EDF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018135EDF0-0x000000018135EE40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoTransitionOut>d__20 : IEnumerator<object> // TypeDefIndex: 13865
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierBase <>4__this; // 0x20
			public float transitionDuration; // 0x28
			private float <elapsed>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoTransitionOut>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018135EE40-0x000000018135F000
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018135F000-0x000000018135F050
		}
	
		// Constructors
		protected CameraStateModifierBase(); // 0x000000018134AD00-0x000000018134AD20
	
		// Methods
		public virtual void Initialize(); // 0x00000001803581E0-0x00000001803581F0
		protected abstract void CalculateModification(ICameraState cameraState, float deltaTime);
		public void ModifiyCamera(ICameraState cameraState, float deltaTime); // 0x000000018134A790-0x000000018134AD00
		public virtual bool Enable(); // 0x000000018134A630-0x000000018134A790
		public virtual void Disable(); // 0x000000018134A470-0x000000018134A550
		public virtual void Cleanup(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001801295C0-0x0000000180129610
		private IEnumerator DoTransitionIn(float transitionDuration); // 0x000000018134A550-0x000000018134A5C0
		[IteratorStateMachine] // 0x0000000180129720-0x0000000180129770
		private IEnumerator DoTransitionOut(float transitionDuration); // 0x000000018134A5C0-0x000000018134A630
	}
}
