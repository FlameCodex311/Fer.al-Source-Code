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

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbersCard : ManagedBehaviour // TypeDefIndex: 15574
	{
		// Fields
		[Header] // 0x0000000180124D40-0x0000000180124D70
		public MeshCollider meshCollider; // 0x50
		public Renderer frontRenderer; // 0x58
		internal bool cardFlipped; // 0x60
		internal float randomRank; // 0x64
		internal RememberTheEmbers game; // 0x68
		internal EMatchObjectType MatchObjectType; // 0x70
		private float _slice; // 0x74
		private Vector3 _startPos; // 0x78
		private Vector3 _endPos; // 0x84
		private float _halfTime; // 0x90
		private Quaternion _faceUp; // 0x94
		private Quaternion _faceDown; // 0xA4
	
		// Nested types
		internal enum EMatchObjectType // TypeDefIndex: 15575
		{
			EMBER = 0,
			MATCH1 = 1,
			MATCH2 = 2,
			MATCH3 = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FlipObject>d__14 : IEnumerator<object> // TypeDefIndex: 15576
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbersCard <>4__this; // 0x20
			public bool inShowFront; // 0x28
			private float <t>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FlipObject>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181718B70-0x0000000181718E40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181718E40-0x0000000181718E90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowObject>d__15 : IEnumerator<object> // TypeDefIndex: 15577
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbersCard <>4__this; // 0x20
			public float inSlice; // 0x28
			public bool inShowFront; // 0x2C
			private float <t>5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowObject>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171EA40-0x000000018171EE90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171EE90-0x000000018171EEE0
		}
	
		// Constructors
		public RememberTheEmbersCard(); // 0x000000018170D040-0x000000018170D110
	
		// Methods
		public override void Awake(); // 0x000000018170CDE0-0x000000018170CE10
		[IteratorStateMachine] // 0x0000000180124FE0-0x0000000180125030
		internal IEnumerator FlipObject(bool inShowFront); // 0x000000018170CE10-0x000000018170CE80
		[IteratorStateMachine] // 0x0000000180125230-0x0000000180125280
		internal IEnumerator ShowObject(bool inShowFront, float inSlice); // 0x000000018170CFC0-0x000000018170D040
		private void OnMouseDown(); // 0x000000018170CE80-0x000000018170CFC0
	}
}
