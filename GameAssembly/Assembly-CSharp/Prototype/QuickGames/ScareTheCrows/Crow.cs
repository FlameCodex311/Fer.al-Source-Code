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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.ScareTheCrows
{
	internal class Crow : UnityEngine.MonoBehaviour // TypeDefIndex: 16276
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
		internal enum EState // TypeDefIndex: 16277
		{
			PECKING_UP = 0,
			PECKING_DOWN = 1,
			MOVING = 2,
			FLEEING = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CropAte>d__14 : IEnumerator<object> // TypeDefIndex: 16278
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Crow <>4__this; // 0x20
			private Transform <aCrop>5__2; // 0x28
			private Vector3 <startScale>5__3; // 0x30
			private float <t>5__4; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CropAte>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153A820-0x000000018153B010
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153B010-0x000000018153B060
		}
	
		// Constructors
		public Crow(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x0000000181525D70-0x0000000181525DD0
		internal void CrowUpdate(); // 0x0000000181525E30-0x0000000181526440
		private void Flap(); // 0x0000000181526440-0x00000001815264F0
		[IteratorStateMachine] // 0x00000001800B75A0-0x00000001800B75F0
		private IEnumerator CropAte(); // 0x0000000181525DD0-0x0000000181525E30
	}
}
