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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FTail
{
	public class FTail_Animator_MassUpdater : UnityEngine.MonoBehaviour // TypeDefIndex: 9869
	{
		// Fields
		protected List<FTail_AnimatorBase> tails; // 0x18
		private List<FTail_AnimatorBase> tailsQueue; // 0x20
		[Header] // 0x00000001800F6F50-0x00000001800F7000
		[Header] // 0x00000001800F6F50-0x00000001800F7000
		[Space] // 0x00000001800F6F50-0x00000001800F7000
		[Space] // 0x00000001800F6F50-0x00000001800F7000
		public EFUpdateClock UpdateClock; // 0x28
		public List<Transform> TailAnimatorsFrom; // 0x30
		[Header] // 0x00000001800F73A0-0x00000001800F7470
		[Header] // 0x00000001800F73A0-0x00000001800F7470
		[Space] // 0x00000001800F73A0-0x00000001800F7470
		[Space] // 0x00000001800F73A0-0x00000001800F7470
		[Tooltip] // 0x00000001800F73A0-0x00000001800F7470
		public bool GetFromWholeScene; // 0x38
		private static FTail_Animator_MassUpdater WholeSceneGetter; // 0x00
		public bool DelayedStart; // 0x39
		private bool initialized; // 0x3A
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Start>d__8 : IEnumerator<object> // TypeDefIndex: 9870
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FTail_Animator_MassUpdater <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Start>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B71460-0x0000000181B71840
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B71840-0x0000000181B7A370
		}
	
		// Constructors
		public FTail_Animator_MassUpdater(); // 0x0000000180407560-0x0000000180407570
		static FTail_Animator_MassUpdater(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		[IteratorStateMachine] // 0x00000001800F78B0-0x00000001800F7900
		protected virtual IEnumerator Start(); // 0x0000000181B6FD90-0x0000000181B6FDF0
		protected virtual void Update(); // 0x0000000181B70120-0x0000000181B70130
		private void LateUpdate(); // 0x0000000181B6FB40-0x0000000181B6FB50
		private void FixedUpdate(); // 0x0000000181B6FB30-0x0000000181B6FB40
		private void OnDisable(); // 0x0000000181B6FB50-0x0000000181B6FC70
		private void OnEnable(); // 0x0000000181B6FC70-0x0000000181B6FD90
		private void UpdateTails(); // 0x0000000181B6FDF0-0x0000000181B70120
		public void AddTailToUpdate(FTail_AnimatorBase tail); // 0x0000000181B6FA90-0x0000000181B6FB30
	}
}
