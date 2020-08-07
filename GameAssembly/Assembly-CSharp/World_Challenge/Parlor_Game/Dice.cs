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

namespace World_Challenge.Parlor_Game
{
	[RequireComponent] // 0x000000018028C8D0-0x000000018028C950
	[RequireComponent] // 0x000000018028C8D0-0x000000018028C950
	public class Dice : MonoBehaviour // TypeDefIndex: 14686
	{
		// Fields
		[Header] // 0x00000001801EA050-0x00000001801EA080
		public Rigidbody body; // 0x20
		public MeshCollider meshCollider; // 0x28
		[Tooltip] // 0x000000018028CBD0-0x000000018028CC00
		public Transform[] sideLocators; // 0x30
		internal DiceManager diceManager; // 0x38
		internal int faceValue; // 0x40
		internal bool canSelect; // 0x44
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Shoot>d__6 : IEnumerator<object> // TypeDefIndex: 14687
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Shoot>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E81950-0x0000000180E81D20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E81D20-0x0000000180E81D70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Reset>d__10 : IEnumerator<object> // TypeDefIndex: 14688
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Reset>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E801D0-0x0000000180E807E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E807E0-0x0000000180E80830
		}
	
		// Constructors
		public Dice(); // 0x0000000180E70EC0-0x0000000180E70ED0
	
		// Methods
		[IteratorStateMachine] // 0x000000018028CCF0-0x000000018028CD40
		internal IEnumerator Shoot(); // 0x0000000180E70E60-0x0000000180E70EC0
		internal void GetFaceValue(); // 0x0000000180E70C50-0x0000000180E70D60
		private void OnMouseDown(); // 0x0000000180E70D60-0x0000000180E70D90
		private void OnMouseUp(); // 0x0000000180E70D90-0x0000000180E70DC0
		[IteratorStateMachine] // 0x000000018028CEA0-0x000000018028CEF0
		internal IEnumerator Reset(int inSpawnLocationIndex, Vector3 inOffset, float inRotateAngle); // 0x0000000180E70DC0-0x0000000180E70E60
	}
}
