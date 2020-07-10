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

namespace FIMSpace.Basics
{
	public class FBasic_Shared_PanelAnimations : UnityEngine.MonoBehaviour // TypeDefIndex: 9895
	{
		// Fields
		[Tooltip] // 0x0000000180105620-0x0000000180105650
		public float AnimationTime; // 0x18
		[Tooltip] // 0x00000001801056D0-0x0000000180105700
		public float EaseExtraValue; // 0x1C
		private Transform buttonTransform; // 0x20
		private Vector3 buttonInitPosition; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ClickAniamtion>d__6 : IEnumerator<object> // TypeDefIndex: 9896
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FBasic_Shared_PanelAnimations <>4__this; // 0x20
			private float <time>5__2; // 0x28
			private Vector3 <currentPos>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ClickAniamtion>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815ED080-0x00000001815ED470
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815ED470-0x00000001815ED4C0
		}
	
		// Constructors
		public FBasic_Shared_PanelAnimations(); // 0x00000001815D7750-0x00000001815D7770
	
		// Methods
		protected virtual void Start(); // 0x00000001815D76C0-0x00000001815D7750
		public virtual void Click(); // 0x00000001815D7650-0x00000001815D76C0
		[IteratorStateMachine] // 0x0000000180105980-0x00000001801059D0
		private IEnumerator ClickAniamtion(); // 0x00000001815D75F0-0x00000001815D7650
	}
}
