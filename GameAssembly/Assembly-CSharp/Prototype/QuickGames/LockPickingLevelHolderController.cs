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

namespace Prototype.QuickGames
{
	public class LockPickingLevelHolderController : MonoBehaviour // TypeDefIndex: 16149
	{
		// Fields
		public List<Sprite> rewardSprites; // 0x20
		private Image rewardImage; // 0x28
		private Color startColor; // 0x30
		private Color revealColor; // 0x40
		private float revealTime; // 0x50
		private float elapsedTime; // 0x54
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RevealReward>d__7 : IEnumerator<object> // TypeDefIndex: 16150
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingLevelHolderController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RevealReward>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FC710-0x00000001813FC830
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FC830-0x00000001813FC880
		}
	
		// Constructors
		public LockPickingLevelHolderController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(int levelIndex); // 0x00000001813F1260-0x00000001813F1520
		[IteratorStateMachine] // 0x000000018012D420-0x000000018012D470
		public IEnumerator RevealReward(); // 0x00000001813F1200-0x00000001813F1260
	}
}
