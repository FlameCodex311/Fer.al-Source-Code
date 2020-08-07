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

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TargetInRange : TugOfWar // TypeDefIndex: 14771
	{
		// Fields
		[Header] // 0x00000001801FE650-0x00000001801FE680
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AtStartPoint>d__17 : IEnumerator<object> // TypeDefIndex: 14772
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TargetInRange <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AtStartPoint>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78480-0x0000000180E78610
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E78610-0x0000000180E78660
		}
	
		// Constructors
		public TargetInRange(); // 0x0000000180E73170-0x0000000180E731E0
	
		// Methods
		internal override void OptionSelected(int inIdx); // 0x0000000180E72DF0-0x0000000180E72F50
		[IteratorStateMachine] // 0x00000001801FE8B0-0x00000001801FE900
		protected override IEnumerator AtStartPoint(); // 0x0000000180E72760-0x0000000180E727C0
		protected override void ChallengeUpdate(); // 0x0000000180E728B0-0x0000000180E72DF0
		protected override void ProgressUpdate(); // 0x0000000180E72F50-0x0000000180E73110
		protected override void ChallengeOver(); // 0x0000000180E727C0-0x0000000180E728B0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private new IEnumerator <>n__0(); // 0x0000000180E73110-0x0000000180E73170
	}
}
