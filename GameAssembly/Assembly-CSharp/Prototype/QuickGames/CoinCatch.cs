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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class CoinCatch : QuickGamesBase, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 16094
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject <DeathVolume>k__BackingField; // 0x180
	
		// Properties
		public GameObject DeathVolume { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018081E0E0-0x000000018081E0F0 0x000000018139CF90-0x000000018139CFA0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__28 : IEnumerator<object> // TypeDefIndex: 16095
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CoinCatch <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AD860-0x00000001813AD990
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AD990-0x00000001813AD9E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__34 : IEnumerator<object> // TypeDefIndex: 16096
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CoinCatch <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AEC10-0x00000001813AF020
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AF020-0x00000001813AF070
		}
	
		// Constructors
		public CoinCatch(); // 0x000000018139CF50-0x000000018139CF90
	
		// Methods
		public override void MStart(); // 0x000000018139CB20-0x000000018139CC60
		[IteratorStateMachine] // 0x0000000180105A60-0x0000000180105AB0
		public override IEnumerator ShowIntro(); // 0x000000018139CE90-0x000000018139CEF0
		private void Initialize(); // 0x000000018139C460-0x000000018139CA60
		public override void QuickGameUpdate(); // 0x000000018139CC90-0x000000018139CE90
		public void OnPointerDown(PointerEventData pointerEventData); // 0x000000018139CC60-0x000000018139CC80
		public void OnPointerUp(PointerEventData pointerEventData); // 0x000000018139CC80-0x000000018139CC90
		public void KillTarget(CatchTargetController catchTargetController); // 0x000000018139CA60-0x000000018139CB20
		[IteratorStateMachine] // 0x0000000180105C40-0x0000000180105C90
		public override IEnumerator ShowResults(); // 0x000000018139CEF0-0x000000018139CF50
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
