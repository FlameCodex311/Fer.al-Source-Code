/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.ScareTheCrows
{
	internal class Crow : UnityEngine.MonoBehaviour // TypeDefIndex: 15018
	{
		// Fields
		internal ScareTheCrows Game; // 0x18
		internal float currentStateTimer; // 0x20
		internal int peckCount; // 0x24
		internal Transform currentCrop; // 0x28
		private float _flapTime; // 0x30
		private bool _flapUp; // 0x34
		internal Vector3 moveDir; // 0x38
		internal Vector3 endPosition; // 0x44
		private RawImage _crowImage; // 0x50
		internal EState state; // 0x58
	
		// Nested types
		internal enum EState // TypeDefIndex: 15019
		{
			PECKING_UP = 0,
			PECKING_DOWN = 1,
			MOVING = 2,
			FLEEING = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CropAte>d__14 : IEnumerator<object> // TypeDefIndex: 15020
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Crow <>4__this; // 0x20
			private Transform <aCrop>5__2; // 0x28
			private Vector3 <startScale>5__3; // 0x30
			private float <t>5__4; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CropAte>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5C1C0-0x0000000180A5C970
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5C970-0x0000000180A5C9C0
		}
	
		// Constructors
		public Crow(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180A48580-0x0000000180A485E0
		internal void CrowUpdate(); // 0x0000000180A48640-0x0000000180A48C20
		private void Flap(); // 0x0000000180A48C20-0x0000000180A48CD0
		[IteratorStateMachine] // 0x00000001802953E0-0x0000000180295430
		private IEnumerator CropAte(); // 0x0000000180A485E0-0x0000000180A48640
	}
}
