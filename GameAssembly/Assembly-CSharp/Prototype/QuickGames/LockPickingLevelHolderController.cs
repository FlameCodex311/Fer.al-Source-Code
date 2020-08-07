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

namespace Prototype.QuickGames
{
	public class LockPickingLevelHolderController : MonoBehaviour // TypeDefIndex: 14891
	{
		// Fields
		public List<Sprite> rewardSprites; // 0x20
		private Image rewardImage; // 0x28
		private Color startColor; // 0x30
		private Color revealColor; // 0x40
		private float revealTime; // 0x50
		private float elapsedTime; // 0x54
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RevealReward>d__7 : IEnumerator<object> // TypeDefIndex: 14892
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingLevelHolderController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RevealReward>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809936A0-0x00000001809937C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809937C0-0x0000000180993810
		}
	
		// Constructors
		public LockPickingLevelHolderController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(int levelIndex); // 0x00000001809886D0-0x0000000180988980
		[IteratorStateMachine] // 0x000000018024BCF0-0x000000018024BD40
		public IEnumerator RevealReward(); // 0x0000000180988670-0x00000001809886D0
	}
}
