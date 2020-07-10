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

namespace Prototype.QuickGames
{
	public class CatchObject : QuickGamesBase // TypeDefIndex: 16090
	{
		// Fields
		public Transform objectToCatch; // 0xF0
		public Transform catcher; // 0xF8
		public int numberOfCatchSlots; // 0x100
		public float slotBorderMinDist; // 0x104
		public float slotBorderMaxDist; // 0x108
		public float objectToCatchMoveSpeed; // 0x10C
		public float catcherOffsetForWinLoss; // 0x110
		public ECatchDirection catchDirection; // 0x114
		private int _catcherSlotIndex; // 0x118
		private int _objectToCatchSlotIndex; // 0x11C
		private Vector3 _objectToCatchPosition; // 0x120
		private Vector3 _objectToCatchDirection; // 0x12C
		private Vector3[] _catcherLocations; // 0x138
		private Quaternion[] _catcherRotations; // 0x140
		private Renderer _objectToCatchRenderer; // 0x148
	
		// Nested types
		public enum ECatchDirection // TypeDefIndex: 16091
		{
			DOWN = 0,
			UP = 1,
			LEFT = 2,
			RIGHT = 3,
			OUT = 4,
			IN = 5
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FinishGame>d__18 : IEnumerator<object> // TypeDefIndex: 16092
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchObject <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FinishGame>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A8A20-0x00000001813A8B90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A8B90-0x00000001813A8BE0
		}
	
		// Constructors
		public CatchObject(); // 0x00000001813982F0-0x0000000181398330
	
		// Methods
		public override void MStart(); // 0x0000000181396EE0-0x0000000181397940
		public override void QuickGameUpdate(); // 0x0000000181398090-0x00000001813982F0
		[IteratorStateMachine] // 0x0000000180104C80-0x0000000180104CD0
		private IEnumerator FinishGame(); // 0x0000000181396E80-0x0000000181396EE0
		private void MoveObjectToCatch(); // 0x0000000181397F90-0x0000000181398090
		private void MoveCatcher(); // 0x0000000181397940-0x0000000181397F90
	}
}
