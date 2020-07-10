/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using Prototype;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge
{
	public class WorldChallenge : ManagedBehaviour // TypeDefIndex: 15522
	{
		// Fields
		[Header] // 0x0000000180105950-0x0000000180105980
		public GameObject encounterHUD; // 0x50
		public NPCInteract nPCInteract; // 0x58
		public Transform nPCLocator; // 0x60
		public Transform playerStartPoint; // 0x68
		public float toPlayerStartTime; // 0x70
		public bool replayable; // 0x74
		[Header] // 0x0000000180105A30-0x0000000180105A60
		public CinemachineVirtualCamera virtualCam; // 0x78
		public Transform cameraTargetPoint; // 0x80
		public float cameraTargetPointScaler; // 0x88
		internal EChallengeState challengeState; // 0x8C
		internal StartGame actionTask_inGame; // 0x90
		internal StartGameQGE actionTask_inGameQGE; // 0x98
	
		// Nested types
		internal enum EChallengeState // TypeDefIndex: 15523
		{
			WAITING = 0,
			MOVE2START = 1,
			DO_UPDATE = 2,
			NO_UPDATE = 3,
			WIN = 4,
			LOSE = 5
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MovePlayerToStart>d__13 : IEnumerator<object> // TypeDefIndex: 15524
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WorldChallenge <>4__this; // 0x20
			private Vector3 <startPos>5__2; // 0x28
			private Quaternion <startRotation>5__3; // 0x34
			private Quaternion <endRotation>5__4; // 0x44
			private float <t>5__5; // 0x54
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MovePlayerToStart>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F37920-0x0000000181F37FD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F37FD0-0x0000000181F38020
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AtStartPoint>d__14 : IEnumerator<object> // TypeDefIndex: 15525
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WorldChallenge <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AtStartPoint>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F35690-0x0000000181F356E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F356E0-0x0000000181F35730
		}
	
		// Constructors
		public WorldChallenge(); // 0x0000000181F2F5B0-0x0000000181F2F620
	
		// Methods
		public override void MStart(); // 0x0000000181F3B320-0x0000000181F3B3F0
		internal virtual void OptionSelected(int inIdx); // 0x0000000181F3B4B0-0x0000000181F3B510
		[IteratorStateMachine] // 0x0000000180105B20-0x0000000180105B70
		protected virtual IEnumerator MovePlayerToStart(); // 0x0000000181F3B450-0x0000000181F3B4B0
		[IteratorStateMachine] // 0x0000000180105DA0-0x0000000180105DF0
		protected virtual IEnumerator AtStartPoint(); // 0x0000000181F3AF90-0x0000000181F3AFF0
		protected virtual void StartChallenge(); // 0x0000000181F3B510-0x0000000181F3B5A0
		protected virtual void ChallengeUpdate(); // 0x00000001803581E0-0x00000001803581F0
		public override void MUpdate(); // 0x0000000181F3B3F0-0x0000000181F3B450
		protected virtual void ChallengeOver(); // 0x0000000181F3AFF0-0x0000000181F3B0D0
		internal virtual void DialogNext(); // 0x0000000181F3B270-0x0000000181F3B2D0
		internal virtual void DialogClose(); // 0x0000000181F3B1E0-0x0000000181F3B270
		protected virtual void CloseChallenge(); // 0x0000000181F3B0D0-0x0000000181F3B1E0
		internal virtual void InitializeGame(); // 0x0000000181F3B2F0-0x0000000181F3B320
		internal virtual void StartGame(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void ResetGame(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void EndGame(); // 0x0000000181F3B2D0-0x0000000181F3B2F0
	}
}
