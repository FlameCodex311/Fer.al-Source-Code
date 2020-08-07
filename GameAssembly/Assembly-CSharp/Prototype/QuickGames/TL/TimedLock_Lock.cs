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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.TL
{
	public class TimedLock_Lock : MonoBehaviour // TypeDefIndex: 15010
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ERewardType <RewardType>k__BackingField; // 0x20
		public Transform keyhole; // 0x28
		public Transform key; // 0x30
		public Transform reward; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TimedLock <Game>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Rotating>k__BackingField; // 0x48
		internal RawImage rewardImage; // 0x50
		private RawImage _lockImage; // 0x58
		private RawImage _keyImage; // 0x60
		private RawImage _keyholeImage; // 0x68
		private Vector3 _keyStartPosition; // 0x70
	
		// Properties
		internal ERewardType RewardType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
		public TimedLock Game { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public bool Rotating { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
	
		// Nested types
		internal enum ERewardType // TypeDefIndex: 15011
		{
			EMBER = 0,
			REWARD = 1,
			NONE = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartRotate>d__22 : IEnumerator<object> // TypeDefIndex: 15012
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock_Lock <>4__this; // 0x20
			private int <direction>5__2; // 0x28
			private float <rotateSpeed>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartRotate>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A43440-0x0000000180A435E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A435E0-0x0000000180A43630
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Flash>d__23 : IEnumerator<object> // TypeDefIndex: 15013
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public bool inPass; // 0x20
			public TimedLock_Lock <>4__this; // 0x28
			private Color <result>5__2; // 0x30
			private int <i>5__3; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Flash>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A3EA90-0x0000000180A3EE30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A3EE30-0x0000000180A3EE80
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <TryLock>d__24 : IEnumerator<object> // TypeDefIndex: 15014
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock_Lock <>4__this; // 0x20
			public bool inPass; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <TryLock>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A44070-0x0000000180A44290
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A44290-0x0000000180A442E0
		}
	
		// Constructors
		public TimedLock_Lock(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void Awake(); // 0x0000000180A3DAF0-0x0000000180A3DC80
		[IteratorStateMachine] // 0x000000018028F330-0x000000018028F380
		public IEnumerator StartRotate(); // 0x0000000180A3DCF0-0x0000000180A3DD50
		[IteratorStateMachine] // 0x000000018028F510-0x000000018028F560
		internal IEnumerator Flash(bool inPass); // 0x0000000180A3DC80-0x0000000180A3DCF0
		[IteratorStateMachine] // 0x000000018028F7A0-0x000000018028F7F0
		internal IEnumerator TryLock(bool inPass); // 0x0000000180A3DD50-0x0000000180A3DDC0
	}
}
