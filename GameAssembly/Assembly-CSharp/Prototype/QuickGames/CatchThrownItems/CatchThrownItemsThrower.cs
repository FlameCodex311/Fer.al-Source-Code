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

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsThrower : UnityEngine.MonoBehaviour // TypeDefIndex: 15054
	{
		// Fields
		public Transform throwPoint; // 0x18
		public int archDir; // 0x20
		internal CatchThrownItems game; // 0x28
		private EState _state; // 0x30
		private float _currentTime; // 0x34
		private Quaternion _startRotation; // 0x38
		private Quaternion _backRotation; // 0x48
		private CatchThrownItemsItem _currentItem; // 0x58
		public float rockAngleMin; // 0x60
		public float rockAngleMax; // 0x64
		public float rockTimeMin; // 0x68
		public float rockTimeMax; // 0x6C
		private bool _rockinBack; // 0x70
		private bool _rockin; // 0x71
		private float _currentRockTime; // 0x74
		private Quaternion _rockLeft; // 0x78
		private Quaternion _rockRight; // 0x88
	
		// Nested types
		private enum EState // TypeDefIndex: 15055
		{
			WAITING = 0,
			BACK = 1,
			SPAWN = 2,
			THROW = 3,
			LAUNCH = 4,
			FOLLOWTHROUGH = 5
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Rockin>d__19 : IEnumerator<object> // TypeDefIndex: 15056
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItemsThrower <>4__this; // 0x20
			private Transform <rocker>5__2; // 0x28
			private float <t>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Rockin>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE0980-0x0000000180AE0D90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE0D90-0x0000000180AE0DE0
		}
	
		// Constructors
		public CatchThrownItemsThrower(); // 0x0000000180AD29C0-0x0000000180AD29F0
	
		// Methods
		internal void Init(); // 0x0000000180AD2390-0x0000000180AD24D0
		[IteratorStateMachine] // 0x00000001801DFEB0-0x00000001801DFF00
		private IEnumerator Rockin(); // 0x0000000180AD24E0-0x0000000180AD2540
		private void OnDestroy(); // 0x0000000180AD24D0-0x0000000180AD24E0
		internal void ThrowerUpdate(); // 0x0000000180AD2540-0x0000000180AD29C0
	}
}
