/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FIMSpace.Basics;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FTail
{
	public class FTail_Animator_MassUpdater : UnityEngine.MonoBehaviour // TypeDefIndex: 10327
	{
		// Fields
		protected List<FTail_AnimatorBase> tails; // 0x18
		private List<FTail_AnimatorBase> tailsQueue; // 0x20
		[Header] // 0x00000001801D5C20-0x00000001801D5CD0
		[Header] // 0x00000001801D5C20-0x00000001801D5CD0
		[Space] // 0x00000001801D5C20-0x00000001801D5CD0
		[Space] // 0x00000001801D5C20-0x00000001801D5CD0
		public EFUpdateClock UpdateClock; // 0x28
		public List<Transform> TailAnimatorsFrom; // 0x30
		[Header] // 0x00000001801D5F60-0x00000001801D6030
		[Header] // 0x00000001801D5F60-0x00000001801D6030
		[Space] // 0x00000001801D5F60-0x00000001801D6030
		[Space] // 0x00000001801D5F60-0x00000001801D6030
		[Tooltip] // 0x00000001801D5F60-0x00000001801D6030
		public bool GetFromWholeScene; // 0x38
		private static FTail_Animator_MassUpdater WholeSceneGetter; // 0x00
		public bool DelayedStart; // 0x39
		private bool initialized; // 0x3A
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Start>d__8 : IEnumerator<object> // TypeDefIndex: 10328
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FTail_Animator_MassUpdater <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Start>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181745300-0x00000001817456C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001817456C0-0x0000000181745710
		}
	
		// Constructors
		public FTail_Animator_MassUpdater(); // 0x0000000180568C50-0x0000000180569020
		static FTail_Animator_MassUpdater(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		[IteratorStateMachine] // 0x00000001801D6400-0x00000001801D6450
		protected virtual IEnumerator Start(); // 0x0000000181743C80-0x0000000181743CE0
		protected virtual void Update(); // 0x0000000181743FF0-0x0000000181744000
		private void LateUpdate(); // 0x0000000181743A30-0x0000000181743A40
		private void FixedUpdate(); // 0x0000000181743A20-0x0000000181743A30
		private void OnDisable(); // 0x0000000181743A40-0x0000000181743B60
		private void OnEnable(); // 0x0000000181743B60-0x0000000181743C80
		private void UpdateTails(); // 0x0000000181743CE0-0x0000000181743FF0
		public void AddTailToUpdate(FTail_AnimatorBase tail); // 0x0000000181743980-0x0000000181743A20
	}
}
