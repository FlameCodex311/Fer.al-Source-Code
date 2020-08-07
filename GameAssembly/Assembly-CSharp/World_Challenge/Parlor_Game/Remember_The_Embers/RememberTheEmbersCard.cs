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

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbersCard : ManagedBehaviour // TypeDefIndex: 14729
	{
		// Fields
		[Header] // 0x00000001801DF490-0x00000001801DF4C0
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
		internal enum EMatchObjectType // TypeDefIndex: 14730
		{
			EMBER = 0,
			MATCH1 = 1,
			MATCH2 = 2,
			MATCH3 = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FlipObject>d__14 : IEnumerator<object> // TypeDefIndex: 14731
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbersCard <>4__this; // 0x20
			public bool inShowFront; // 0x28
			private float <t>5__2; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FlipObject>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819825D0-0x0000000181982890
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181982890-0x00000001819828E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowObject>d__15 : IEnumerator<object> // TypeDefIndex: 14732
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbersCard <>4__this; // 0x20
			public float inSlice; // 0x28
			public bool inShowFront; // 0x2C
			private float <t>5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowObject>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181985E40-0x00000001819862B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819862B0-0x0000000181986300
		}
	
		// Constructors
		public RememberTheEmbersCard(); // 0x000000018197C630-0x000000018197C700
	
		// Methods
		public override void Awake(); // 0x000000018197C450-0x000000018197C480
		[IteratorStateMachine] // 0x00000001801DF950-0x00000001801DF9A0
		internal IEnumerator FlipObject(bool inShowFront); // 0x000000018197C480-0x000000018197C4F0
		[IteratorStateMachine] // 0x00000001801DFB00-0x00000001801DFB50
		internal IEnumerator ShowObject(bool inShowFront, float inSlice); // 0x000000018197C5B0-0x000000018197C630
		private void OnMouseDown(); // 0x000000018197C4F0-0x000000018197C5B0
	}
}
