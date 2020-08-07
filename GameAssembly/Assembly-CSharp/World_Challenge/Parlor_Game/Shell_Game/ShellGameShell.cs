/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGameShell : ManagedBehaviour // TypeDefIndex: 14709
	{
		// Fields
		[Header] // 0x00000001801D27E0-0x00000001801D2810
		public MeshCollider meshCollider; // 0x50
		[Header] // 0x00000001801D2AC0-0x00000001801D2AF0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ActivatePortal>d__19 : IEnumerator<object> // TypeDefIndex: 14710
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ActivatePortal>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181981470-0x0000000181981EB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181981EB0-0x0000000181981F00
		}
	
		// Constructors
		public ShellGameShell(); // 0x0000000181980420-0x0000000181980480
	
		// Methods
		public override void MStart(); // 0x00000001819801E0-0x0000000181980230
		internal void Init(); // 0x0000000181980070-0x00000001819801E0
		internal void SetColor(); // 0x00000001819802C0-0x0000000181980420
		[IteratorStateMachine] // 0x00000001801D2FC0-0x00000001801D3010
		internal IEnumerator ActivatePortal(bool inHide); // 0x0000000181980000-0x0000000181980070
		private void OnMouseDown(); // 0x0000000181980230-0x00000001819802C0
	}
}
