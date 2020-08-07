/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class CoinCatch : QuickGamesBase, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 14836
	{
		// Fields
		public GameObject instructions; // 0xF0
		public float instructionTime; // 0xF8
		public List<GameObject> catcherPrefabs; // 0x100
		public List<GameObject> coinPrefabs; // 0x108
		public GameObject deathVolumePrefab; // 0x110
		public int numCoins; // 0x118
		public int numRareCoins; // 0x11C
		public int rareValue; // 0x120
		public int rareSpawnWait; // 0x124
		public Sprite rareSprite; // 0x128
		private GameObject coinPrefab; // 0x130
		private GameObject catcherPrefab; // 0x138
		private GameObject board; // 0x140
		private GameObject foreground; // 0x148
		private GameObject catcher; // 0x150
		private List<CatchTargetController> catchTargets; // 0x158
		private RectTransform catcherRect; // 0x160
		private bool pointerDown; // 0x168
		private bool anchorSet; // 0x169
		private float pointerDownX; // 0x16C
		private bool forceLeftMovement; // 0x170
		private bool forceRightMovement; // 0x171
		private TargetJoint2D targetJoint; // 0x178
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject <DeathVolume>k__BackingField; // 0x180
	
		// Properties
		public GameObject DeathVolume { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF210-0x00000001803EF220 0x0000000180AD4130-0x0000000180AD4140
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__28 : IEnumerator<object> // TypeDefIndex: 14837
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CoinCatch <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE1C10-0x0000000180AE1D40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE1D40-0x0000000180AE1D90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__34 : IEnumerator<object> // TypeDefIndex: 14838
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CoinCatch <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE3BC0-0x0000000180AE3FB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE3FB0-0x0000000180AE4000
		}
	
		// Constructors
		public CoinCatch(); // 0x0000000180AD40F0-0x0000000180AD4130
	
		// Methods
		public override void MStart(); // 0x0000000180AD3CD0-0x0000000180AD3E10
		[IteratorStateMachine] // 0x0000000180224090-0x00000001802240E0
		public override IEnumerator ShowIntro(); // 0x0000000180AD4030-0x0000000180AD4090
		private void Initialize(); // 0x0000000180AD3620-0x0000000180AD3C10
		public override void QuickGameUpdate(); // 0x0000000180AD3E40-0x0000000180AD4030
		public void OnPointerDown(PointerEventData pointerEventData); // 0x0000000180AD3E10-0x0000000180AD3E30
		public void OnPointerUp(PointerEventData pointerEventData); // 0x0000000180AD3E30-0x0000000180AD3E40
		public void KillTarget(CatchTargetController catchTargetController); // 0x0000000180AD3C10-0x0000000180AD3CD0
		[IteratorStateMachine] // 0x0000000180225670-0x00000001802256C0
		public override IEnumerator ShowResults(); // 0x0000000180AD4090-0x0000000180AD40F0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
