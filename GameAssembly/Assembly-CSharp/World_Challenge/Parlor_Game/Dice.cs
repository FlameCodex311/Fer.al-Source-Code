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

namespace World_Challenge.Parlor_Game
{
	[RequireComponent] // 0x0000000180107020-0x00000001801070A0
	[RequireComponent] // 0x0000000180107020-0x00000001801070A0
	public class Dice : MonoBehaviour // TypeDefIndex: 15531
	{
		// Fields
		[Header] // 0x0000000180107350-0x0000000180107380
		public Rigidbody body; // 0x20
		public MeshCollider meshCollider; // 0x28
		[Tooltip] // 0x0000000180107470-0x00000001801074A0
		public Transform[] sideLocators; // 0x30
		internal DiceManager diceManager; // 0x38
		internal int faceValue; // 0x40
		internal bool canSelect; // 0x44
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Shoot>d__6 : IEnumerator<object> // TypeDefIndex: 15532
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Shoot>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171E610-0x000000018171E9F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171E9F0-0x000000018171EA40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Reset>d__10 : IEnumerator<object> // TypeDefIndex: 15533
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice <>4__this; // 0x20
			public int inSpawnLocationIndex; // 0x28
			public Vector3 inOffset; // 0x2C
			public float inRotateAngle; // 0x38
			private Quaternion <startRot>5__2; // 0x3C
			private Quaternion <endRot>5__3; // 0x4C
			private Vector3 <startPos>5__4; // 0x5C
			private Vector3 <endPos>5__5; // 0x68
			private float <td>5__6; // 0x74
			private float <t>5__7; // 0x78
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Reset>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171CC60-0x000000018171D2A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171D2A0-0x000000018171D2F0
		}
	
		// Constructors
		public Dice(); // 0x000000018170C240-0x000000018170C250
	
		// Methods
		[IteratorStateMachine] // 0x0000000180107690-0x00000001801076E0
		internal IEnumerator Shoot(); // 0x000000018170C1E0-0x000000018170C240
		internal void GetFaceValue(); // 0x000000018170BFC0-0x000000018170C0E0
		private void OnMouseDown(); // 0x000000018170C0E0-0x000000018170C110
		private void OnMouseUp(); // 0x000000018170C110-0x000000018170C140
		[IteratorStateMachine] // 0x00000001801077E0-0x0000000180107830
		internal IEnumerator Reset(int inSpawnLocationIndex, Vector3 inOffset, float inRotateAngle); // 0x000000018170C140-0x000000018170C1E0
	}
}
