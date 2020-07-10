/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.TL
{
	public class TimedLock_Lock : MonoBehaviour // TypeDefIndex: 16268
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ERewardType <RewardType>k__BackingField; // 0x20
		public Transform keyhole; // 0x28
		public Transform key; // 0x30
		public Transform reward; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TimedLock <Game>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Rotating>k__BackingField; // 0x48
		internal RawImage rewardImage; // 0x50
		private RawImage _lockImage; // 0x58
		private RawImage _keyImage; // 0x60
		private RawImage _keyholeImage; // 0x68
		private Vector3 _keyStartPosition; // 0x70
	
		// Properties
		internal ERewardType RewardType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public TimedLock Game { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public bool Rotating { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
	
		// Nested types
		internal enum ERewardType // TypeDefIndex: 16269
		{
			EMBER = 0,
			REWARD = 1,
			NONE = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartRotate>d__22 : IEnumerator<object> // TypeDefIndex: 16270
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock_Lock <>4__this; // 0x20
			private int <direction>5__2; // 0x28
			private float <rotateSpeed>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartRotate>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181606A40-0x0000000181606BE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181606BE0-0x0000000181606C30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Flash>d__23 : IEnumerator<object> // TypeDefIndex: 16271
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public bool inPass; // 0x20
			public TimedLock_Lock <>4__this; // 0x28
			private Color <result>5__2; // 0x30
			private int <i>5__3; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Flash>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181601FD0-0x0000000181602390
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181602390-0x00000001816023E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <TryLock>d__24 : IEnumerator<object> // TypeDefIndex: 16272
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock_Lock <>4__this; // 0x20
			public bool inPass; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <TryLock>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001816079C0-0x0000000181607BF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181607BF0-0x0000000181607C40
		}
	
		// Constructors
		public TimedLock_Lock(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void Awake(); // 0x0000000181600E40-0x0000000181600FE0
		[IteratorStateMachine] // 0x0000000180173D20-0x0000000180173D70
		public IEnumerator StartRotate(); // 0x0000000181601050-0x00000001816010B0
		[IteratorStateMachine] // 0x0000000180174060-0x00000001801740B0
		internal IEnumerator Flash(bool inPass); // 0x0000000181600FE0-0x0000000181601050
		[IteratorStateMachine] // 0x0000000180174560-0x00000001801745B0
		internal IEnumerator TryLock(bool inPass); // 0x00000001816010B0-0x0000000181601120
	}
}
