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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge
{
	public class WorldChallenge : ManagedBehaviour // TypeDefIndex: 14670
	{
		// Fields
		[Header] // 0x0000000180286830-0x0000000180286860
		public GameObject encounterHUD; // 0x50
		public NPCInteract nPCInteract; // 0x58
		public Transform nPCLocator; // 0x60
		public Transform playerStartPoint; // 0x68
		public float toPlayerStartTime; // 0x70
		public bool replayable; // 0x74
		[Header] // 0x00000001802336F0-0x0000000180233720
		public CinemachineVirtualCamera virtualCam; // 0x78
		public Transform cameraTargetPoint; // 0x80
		public float cameraTargetPointScaler; // 0x88
		internal EChallengeState challengeState; // 0x8C
		internal StartGame actionTask_inGame; // 0x90
		internal StartGameQGE actionTask_inGameQGE; // 0x98
	
		// Nested types
		internal enum EChallengeState // TypeDefIndex: 14671
		{
			WAITING = 0,
			MOVE2START = 1,
			DO_UPDATE = 2,
			NO_UPDATE = 3,
			WIN = 4,
			LOSE = 5
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MovePlayerToStart>d__13 : IEnumerator<object> // TypeDefIndex: 14672
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MovePlayerToStart>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819844F0-0x0000000181984B80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181984B80-0x0000000181984BD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AtStartPoint>d__14 : IEnumerator<object> // TypeDefIndex: 14673
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WorldChallenge <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AtStartPoint>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181981F00-0x0000000181981F50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181981F50-0x0000000181981FA0
		}
	
		// Constructors
		public WorldChallenge(); // 0x000000018197B2F0-0x000000018197B360
	
		// Methods
		public override void MStart(); // 0x0000000181988620-0x00000001819886F0
		internal virtual void OptionSelected(int inIdx); // 0x00000001819887B0-0x0000000181988810
		[IteratorStateMachine] // 0x0000000180286B90-0x0000000180286BE0
		protected virtual IEnumerator MovePlayerToStart(); // 0x0000000181988750-0x00000001819887B0
		[IteratorStateMachine] // 0x0000000180286D50-0x0000000180286DA0
		protected virtual IEnumerator AtStartPoint(); // 0x00000001819882B0-0x0000000181988310
		protected virtual void StartChallenge(); // 0x0000000181988810-0x00000001819888A0
		protected virtual void ChallengeUpdate(); // 0x00000001803774A0-0x00000001803774B0
		public override void MUpdate(); // 0x00000001819886F0-0x0000000181988750
		protected virtual void ChallengeOver(); // 0x0000000181988310-0x00000001819883F0
		internal virtual void DialogNext(); // 0x0000000181988590-0x00000001819885F0
		internal virtual void DialogClose(); // 0x0000000181988500-0x0000000181988590
		protected virtual void CloseChallenge(); // 0x00000001819883F0-0x0000000181988500
		internal virtual void InitializeGame(); // 0x00000001819885F0-0x0000000181988620
		internal virtual void StartGame(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void ResetGame(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void EndGame(); // 0x00000001808AB730-0x00000001808AB750
	}
}
