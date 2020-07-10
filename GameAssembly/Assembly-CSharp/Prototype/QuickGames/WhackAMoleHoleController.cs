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

namespace Prototype.QuickGames
{
	public class WhackAMoleHoleController : MonoBehaviour // TypeDefIndex: 16258
	{
		// Fields
		private WhackAMole parentController; // 0x20
		private GameObject contents; // 0x28
		private RectTransform contentRectTransform; // 0x30
		private Vector2 contentDownPosition; // 0x38
		private Vector2 contentUpPosition; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsDown>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsRare>k__BackingField; // 0x49
		private bool _isMoving; // 0x4A
		private Vector2 targetPosition; // 0x4C
		private Vector2 startPosition; // 0x54
		private float _moveTime; // 0x5C
		private float _currentTime; // 0x60
		private float _normalizedTime; // 0x64
	
		// Properties
		public bool IsDown { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		public bool IsRare { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805E3A70-0x00000001805E3A80 0x000000018081E340-0x000000018081E350
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MoveContents>d__25 : IEnumerator<object> // TypeDefIndex: 16259
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMoleHoleController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MoveContents>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001816023E0-0x0000000181602610
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181602610-0x0000000181602660
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateMovement>d__26 : IEnumerator<object> // TypeDefIndex: 16260
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMoleHoleController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateMovement>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181601960-0x0000000181601AC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181601AC0-0x0000000181601B10
		}
	
		// Constructors
		public WhackAMoleHoleController(); // 0x0000000181608EB0-0x0000000181608EC0
	
		// Methods
		public void SetUp(WhackAMole parent); // 0x0000000181608CE0-0x0000000181608EB0
		public void ContentsClicked(); // 0x0000000181608A50-0x0000000181608AF0
		public void ShowContents(); // 0x0000000181608AF0-0x0000000181608B60
		public void HideContents(); // 0x0000000181608AF0-0x0000000181608B60
		public void MakeRare(); // 0x0000000181608BF0-0x0000000181608C80
		public void MakeNormal(); // 0x0000000181608B60-0x0000000181608BF0
		[IteratorStateMachine] // 0x000000018016AE90-0x000000018016AEE0
		private IEnumerator MoveContents(); // 0x0000000181608C80-0x0000000181608CE0
		[IteratorStateMachine] // 0x000000018016B110-0x000000018016B160
		private IEnumerator AnimateMovement(); // 0x00000001816089F0-0x0000000181608A50
	}
}
