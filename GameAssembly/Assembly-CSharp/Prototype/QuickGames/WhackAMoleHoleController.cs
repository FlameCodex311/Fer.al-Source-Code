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

namespace Prototype.QuickGames
{
	public class WhackAMoleHoleController : MonoBehaviour // TypeDefIndex: 15000
	{
		// Fields
		private WhackAMole parentController; // 0x20
		private GameObject contents; // 0x28
		private RectTransform contentRectTransform; // 0x30
		private Vector2 contentDownPosition; // 0x38
		private Vector2 contentUpPosition; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsDown>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsRare>k__BackingField; // 0x49
		private bool _isMoving; // 0x4A
		private Vector2 targetPosition; // 0x4C
		private Vector2 startPosition; // 0x54
		private float _moveTime; // 0x5C
		private float _currentTime; // 0x60
		private float _normalizedTime; // 0x64
	
		// Properties
		public bool IsDown { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		public bool IsRare { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C9D80-0x00000001803C9D90 0x00000001803C9DE0-0x00000001803C9DF0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MoveContents>d__25 : IEnumerator<object> // TypeDefIndex: 15001
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMoleHoleController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MoveContents>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A3EE80-0x0000000180A3F0B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A3F0B0-0x0000000180A3F100
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateMovement>d__26 : IEnumerator<object> // TypeDefIndex: 15002
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMoleHoleController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateMovement>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A3E5E0-0x0000000180A3E740
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A3E740-0x0000000180A3E790
		}
	
		// Constructors
		public WhackAMoleHoleController(); // 0x0000000180A452D0-0x0000000180A452E0
	
		// Methods
		public void SetUp(WhackAMole parent); // 0x0000000180A45110-0x0000000180A452D0
		public void ContentsClicked(); // 0x0000000180A44E80-0x0000000180A44F20
		public void ShowContents(); // 0x0000000180A44F20-0x0000000180A44F90
		public void HideContents(); // 0x0000000180A44F20-0x0000000180A44F90
		public void MakeRare(); // 0x0000000180A45020-0x0000000180A450B0
		public void MakeNormal(); // 0x0000000180A44F90-0x0000000180A45020
		[IteratorStateMachine] // 0x00000001802893A0-0x00000001802893F0
		private IEnumerator MoveContents(); // 0x0000000180A450B0-0x0000000180A45110
		[IteratorStateMachine] // 0x0000000180289540-0x0000000180289590
		private IEnumerator AnimateMovement(); // 0x0000000180A44E20-0x0000000180A44E80
	}
}
