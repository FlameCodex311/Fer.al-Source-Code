/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	internal class TweenRunner<T> // TypeDefIndex: 8927
		where T : struct, ITweenValue
	{
		// Fields
		protected UnityEngine.MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Start>d__2 : IEnumerator<object> // TypeDefIndex: 8928
		{
			// Fields
			private int <>1__state;
			private object <>2__current;
			public T tweenInfo;
			private float <elapsedTime>5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Start>d__2(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine] // 0x00000001801DA260-0x00000001801DA2B0
		private static IEnumerator Start(T tweenInfo);
		public void Init(UnityEngine.MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}
}
