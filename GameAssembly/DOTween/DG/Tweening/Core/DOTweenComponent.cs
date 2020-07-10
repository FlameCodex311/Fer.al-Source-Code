/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class DOTweenComponent : UnityEngine.MonoBehaviour, IDOTweenInit // TypeDefIndex: 5665
	{
		// Fields
		public int inspectorUpdater; // 0x18
		private float _unscaledTime; // 0x1C
		private float _unscaledDeltaTime; // 0x20
		private float _pausedTime; // 0x24
		private bool _duplicateToDestroy; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForCompletion>d__14 : IEnumerator<object> // TypeDefIndex: 5666
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForCompletion>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD80B0-0x0000000180BD8120
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD8120-0x0000000180BD8170
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForRewind>d__15 : IEnumerator<object> // TypeDefIndex: 5667
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForRewind>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD83A0-0x0000000180BD8430
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD8430-0x0000000180BD8480
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForKill>d__16 : IEnumerator<object> // TypeDefIndex: 5668
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForKill>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD8230-0x0000000180BD8280
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD8280-0x0000000180BD82D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForElapsedLoops>d__17 : IEnumerator<object> // TypeDefIndex: 5669
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
			public int elapsedLoops; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForElapsedLoops>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD8170-0x0000000180BD81E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD81E0-0x0000000180BD8230
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForPosition>d__18 : IEnumerator<object> // TypeDefIndex: 5670
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
			public float position; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForPosition>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD82D0-0x0000000180BD8350
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD8350-0x0000000180BD83A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <WaitForStart>d__19 : IEnumerator<object> // TypeDefIndex: 5671
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <WaitForStart>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180BD8480-0x0000000180BD84F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180BD84F0-0x0000000180BD8540
		}
	
		// Constructors
		public DOTweenComponent(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x0000000180BC2950-0x0000000180BC2B20
		private void Start(); // 0x0000000180BC38E0-0x0000000180BC39B0
		private void Update(); // 0x0000000180BC39B0-0x0000000180BC3DD0
		private void LateUpdate(); // 0x0000000180BC2F30-0x0000000180BC3070
		private void FixedUpdate(); // 0x0000000180BC2D80-0x0000000180BC2F30
		private void OnDrawGizmos(); // 0x0000000180BC3700-0x0000000180BC3870
		private void OnDestroy(); // 0x0000000180BC30C0-0x0000000180BC3700
		public void OnApplicationPause(bool pauseStatus); // 0x0000000180BC3070-0x0000000180BC30C0
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000180BC3870-0x0000000180BC38E0
		internal IEnumerator WaitForCompletion(Tween t); // 0x0000000180BC3DD0-0x0000000180BC3E30
		internal IEnumerator WaitForRewind(Tween t); // 0x0000000180BC3F70-0x0000000180BC3FD0
		internal IEnumerator WaitForKill(Tween t); // 0x0000000180BC3EA0-0x0000000180BC3F00
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops); // 0x0000000180BC3E30-0x0000000180BC3EA0
		internal IEnumerator WaitForPosition(Tween t, float position); // 0x0000000180BC3F00-0x0000000180BC3F70
		internal IEnumerator WaitForStart(Tween t); // 0x0000000180BC3FD0-0x0000000180BC4030
		internal static void Create(); // 0x0000000180BC2B20-0x0000000180BC2C50
		internal static void DestroyInstance(); // 0x0000000180BC2C50-0x0000000180BC2D80
	}
}
