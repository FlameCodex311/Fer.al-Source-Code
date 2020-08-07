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

namespace Prototype.QuickGames
{
	public class CatchObject : QuickGamesBase // TypeDefIndex: 14832
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
		public enum ECatchDirection // TypeDefIndex: 14833
		{
			DOWN = 0,
			UP = 1,
			LEFT = 2,
			RIGHT = 3,
			OUT = 4,
			IN = 5
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FinishGame>d__18 : IEnumerator<object> // TypeDefIndex: 14834
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchObject <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FinishGame>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADF070-0x0000000180ADF1D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADF1D0-0x0000000180ADF220
		}
	
		// Constructors
		public CatchObject(); // 0x0000000180ACF640-0x0000000180ACF680
	
		// Methods
		public override void MStart(); // 0x0000000180ACE2C0-0x0000000180ACECD0
		public override void QuickGameUpdate(); // 0x0000000180ACF3F0-0x0000000180ACF640
		[IteratorStateMachine] // 0x0000000180222FF0-0x0000000180223040
		private IEnumerator FinishGame(); // 0x0000000180ACE260-0x0000000180ACE2C0
		private void MoveObjectToCatch(); // 0x0000000180ACF2F0-0x0000000180ACF3F0
		private void MoveCatcher(); // 0x0000000180ACECD0-0x0000000180ACF2F0
	}
}
