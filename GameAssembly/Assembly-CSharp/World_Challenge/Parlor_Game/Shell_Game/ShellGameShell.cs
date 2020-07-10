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

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGameShell : ManagedBehaviour // TypeDefIndex: 15554
	{
		// Fields
		[Header] // 0x0000000180114D90-0x0000000180114DC0
		public MeshCollider meshCollider; // 0x50
		[Header] // 0x0000000180114E90-0x0000000180114EC0
		public Renderer portalPlane; // 0x58
		internal bool hasBall; // 0x60
		internal bool isInPortal; // 0x61
		internal bool right; // 0x62
		internal int spotsMoved; // 0x64
		internal int shuffleIndex; // 0x68
		internal int potentialShuffleIndex; // 0x6C
		internal int shellPortalColorIndex; // 0x70
		internal Transform portalTrans1; // 0x78
		internal Transform portalTrans2; // 0x80
		internal ShellGame game; // 0x88
		private float _td; // 0x90
		private float _portalThirds; // 0x94
		private Vector3 _portalOpenScale; // 0x98
		private Renderer _portalPlane2; // 0xA8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ActivatePortal>d__19 : IEnumerator<object> // TypeDefIndex: 15555
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGameShell <>4__this; // 0x20
			public bool inHide; // 0x28
			private Vector3 <shellStart>5__2; // 0x2C
			private Vector3 <shellEnd>5__3; // 0x38
			private float <t>5__4; // 0x44
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ActivatePortal>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F34BC0-0x0000000181F35640
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F35640-0x0000000181F35690
		}
	
		// Constructors
		public ShellGameShell(); // 0x0000000181F33B40-0x0000000181F33BA0
	
		// Methods
		public override void MStart(); // 0x0000000181F338F0-0x0000000181F33940
		internal void Init(); // 0x0000000181F33770-0x0000000181F338F0
		internal void SetColor(); // 0x0000000181F339D0-0x0000000181F33B40
		[IteratorStateMachine] // 0x0000000180115020-0x0000000180115070
		internal IEnumerator ActivatePortal(bool inHide); // 0x0000000181F33700-0x0000000181F33770
		private void OnMouseDown(); // 0x0000000181F33940-0x0000000181F339D0
	}
}
