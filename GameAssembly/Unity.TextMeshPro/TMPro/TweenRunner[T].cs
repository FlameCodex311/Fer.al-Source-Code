/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	internal class TweenRunner<T> // TypeDefIndex: 8765
		where T : struct, ITweenValue
	{
		// Fields
		protected UnityEngine.MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Start>d__2 : IEnumerator<object> // TypeDefIndex: 8766
		{
			// Fields
			private int <>1__state;
			private object <>2__current;
			public T tweenInfo;
			private float <elapsedTime>5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Start>d__2(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine] // 0x0000000180140E50-0x0000000180140EA0
		private static IEnumerator Start(T tweenInfo);
		public void Init(UnityEngine.MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}
}
