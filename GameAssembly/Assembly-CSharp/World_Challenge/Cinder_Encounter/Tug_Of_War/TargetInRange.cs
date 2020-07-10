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

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TargetInRange : TugOfWar // TypeDefIndex: 15616
	{
		// Fields
		[Header] // 0x000000018013CCF0-0x000000018013CD20
		public RectTransform hUDTarget; // 0x120
		public float targetMoveRange; // 0x128
		public float targetMoveTimeMin; // 0x12C
		public float targetMoveTimeMax; // 0x130
		public float targetNewPosMin; // 0x134
		public float targetNewPosMax; // 0x138
		public RectTransform hUDZone; // 0x140
		public Rigidbody2D hUDZoneRB; // 0x148
		public float zoneMoveRange; // 0x150
		public float zoneClickPower; // 0x154
		private float _currentTargetMoveTime; // 0x158
		private float _targetMoveTime; // 0x15C
		private float _currentTargetPos; // 0x160
		private Vector2 _targetPosStart; // 0x164
		private Vector2 _targetPosEnd; // 0x16C
		private Vector2 _zonePos; // 0x174
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AtStartPoint>d__17 : IEnumerator<object> // TypeDefIndex: 15617
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TargetInRange <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AtStartPoint>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817148E0-0x0000000181714A80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181714A80-0x0000000181714AD0
		}
	
		// Constructors
		public TargetInRange(); // 0x000000018170F3E0-0x000000018170F450
	
		// Methods
		internal override void OptionSelected(int inIdx); // 0x000000018170F060-0x000000018170F1C0
		[IteratorStateMachine] // 0x000000018013DFD0-0x000000018013E020
		protected override IEnumerator AtStartPoint(); // 0x000000018170E9B0-0x000000018170EA10
		protected override void ChallengeUpdate(); // 0x000000018170EB10-0x000000018170F060
		protected override void ProgressUpdate(); // 0x000000018170F1C0-0x000000018170F380
		protected override void ChallengeOver(); // 0x000000018170EA10-0x000000018170EB10
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private new IEnumerator <>n__0(); // 0x000000018170F380-0x000000018170F3E0
	}
}
