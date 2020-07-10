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

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsThrower : UnityEngine.MonoBehaviour // TypeDefIndex: 16312
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
		private enum EState // TypeDefIndex: 16313
		{
			WAITING = 0,
			BACK = 1,
			SPAWN = 2,
			THROW = 3,
			LAUNCH = 4,
			FOLLOWTHROUGH = 5
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Rockin>d__19 : IEnumerator<object> // TypeDefIndex: 16314
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchThrownItemsThrower <>4__this; // 0x20
			private Transform <rocker>5__2; // 0x28
			private float <t>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Rockin>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AC620-0x00000001813ACA40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ACA40-0x00000001813ACA90
		}
	
		// Constructors
		public CatchThrownItemsThrower(); // 0x000000018139B750-0x000000018139B780
	
		// Methods
		internal void Init(); // 0x000000018139B110-0x000000018139B250
		[IteratorStateMachine] // 0x00000001800CF200-0x00000001800CF250
		private IEnumerator Rockin(); // 0x000000018139B260-0x000000018139B2C0
		private void OnDestroy(); // 0x000000018139B250-0x000000018139B260
		internal void ThrowerUpdate(); // 0x000000018139B2C0-0x000000018139B750
	}
}
