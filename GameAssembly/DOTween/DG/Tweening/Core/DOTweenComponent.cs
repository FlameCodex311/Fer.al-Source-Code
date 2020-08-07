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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class DOTweenComponent : UnityEngine.MonoBehaviour, IDOTweenInit // TypeDefIndex: 5824
	{
		// Fields
		public int inspectorUpdater; // 0x18
		private float _unscaledTime; // 0x1C
		private float _unscaledDeltaTime; // 0x20
		private float _pausedTime; // 0x24
		private bool _duplicateToDestroy; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForCompletion>d__14 : IEnumerator<object> // TypeDefIndex: 5825
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForCompletion>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B0D0-0x000000018179B130
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B130-0x000000018179B180
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForRewind>d__15 : IEnumerator<object> // TypeDefIndex: 5826
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForRewind>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B3B0-0x000000018179B440
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B440-0x000000018179B490
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForKill>d__16 : IEnumerator<object> // TypeDefIndex: 5827
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForKill>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B240-0x000000018179B290
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B290-0x000000018179B2E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForElapsedLoops>d__17 : IEnumerator<object> // TypeDefIndex: 5828
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
			public int elapsedLoops; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForElapsedLoops>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B180-0x000000018179B1F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B1F0-0x000000018179B240
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForPosition>d__18 : IEnumerator<object> // TypeDefIndex: 5829
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
			public float position; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForPosition>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B2E0-0x000000018179B360
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B360-0x000000018179B3B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <WaitForStart>d__19 : IEnumerator<object> // TypeDefIndex: 5830
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <WaitForStart>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018179B490-0x000000018179B4F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018179B4F0-0x000000018179B540
		}
	
		// Constructors
		public DOTweenComponent(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000181785FD0-0x00000001817861A0
		private void Start(); // 0x0000000181786F50-0x0000000181787020
		private void Update(); // 0x0000000181787020-0x0000000181787440
		private void LateUpdate(); // 0x00000001817865B0-0x00000001817866F0
		private void FixedUpdate(); // 0x0000000181786400-0x00000001817865B0
		private void OnDrawGizmos(); // 0x0000000181786D80-0x0000000181786EE0
		private void OnDestroy(); // 0x0000000181786740-0x0000000181786D80
		public void OnApplicationPause(bool pauseStatus); // 0x00000001817866F0-0x0000000181786740
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000181786EE0-0x0000000181786F50
		internal IEnumerator WaitForCompletion(Tween t); // 0x0000000181787440-0x00000001817874A0
		internal IEnumerator WaitForRewind(Tween t); // 0x00000001817875E0-0x0000000181787640
		internal IEnumerator WaitForKill(Tween t); // 0x0000000181787510-0x0000000181787570
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops); // 0x00000001817874A0-0x0000000181787510
		internal IEnumerator WaitForPosition(Tween t, float position); // 0x0000000181787570-0x00000001817875E0
		internal IEnumerator WaitForStart(Tween t); // 0x0000000181787640-0x00000001817876A0
		internal static void Create(); // 0x00000001817861A0-0x00000001817862D0
		internal static void DestroyInstance(); // 0x00000001817862D0-0x0000000181786400
	}
}
