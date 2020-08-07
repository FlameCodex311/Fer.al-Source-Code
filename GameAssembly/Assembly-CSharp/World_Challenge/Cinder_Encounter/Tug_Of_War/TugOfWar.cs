/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TugOfWar : WorldChallenge // TypeDefIndex: 14773
	{
		// Fields
		[Header] // 0x00000001801FF670-0x00000001801FF6A0
		public LineRenderer theRope; // 0xA0
		public Transform playerRopeEnd; // 0xA8
		public Transform cinderRopeEnd; // 0xB0
		public RectTransform hUDProgress; // 0xB8
		public float progressFullSize; // 0xC0
		public float progressTimeScaler; // 0xC4
		public float worldMoveRange; // 0xC8
		protected float progressScaler; // 0xCC
		private Vector2 _progressSize; // 0xD0
		private float _currentWorldMove; // 0xD8
		private Transform _cinderMouth; // 0xE0
		private Transform _playerMouth; // 0xE8
		private Vector3 _cinderWinPos; // 0xF0
		private Vector3 _cinderLosePos; // 0xFC
		private Vector3 _playerWinPos; // 0x108
		private Vector3 _playerLosePos; // 0x114
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AtStartPoint>d__19 : IEnumerator<object> // TypeDefIndex: 14774
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TugOfWar <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AtStartPoint>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78660-0x0000000180E78BF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E78BF0-0x0000000180E78C40
		}
	
		// Constructors
		public TugOfWar(); // 0x0000000180E77F50-0x0000000180E77F80
	
		// Methods
		public override void MStart(); // 0x0000000180E77D50-0x0000000180E77E50
		internal override void OptionSelected(int inIdx); // 0x0000000180E77E50-0x0000000180E77EA0
		private Transform FindName(Transform inParent, string inName); // 0x0000000180E77C50-0x0000000180E77D50
		[IteratorStateMachine] // 0x00000001801FF800-0x00000001801FF850
		protected override IEnumerator AtStartPoint(); // 0x0000000180E73110-0x0000000180E73170
		protected override void ChallengeUpdate(); // 0x0000000180E776E0-0x0000000180E77B30
		protected override void ChallengeOver(); // 0x0000000180E77600-0x0000000180E776E0
		protected virtual void ProgressUpdate(); // 0x0000000180E77EA0-0x0000000180E77F20
		protected override void CloseChallenge(); // 0x0000000180E77B30-0x0000000180E77C50
		internal override void StartGame(); // 0x0000000180E77F20-0x0000000180E77F40
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180E77F40-0x0000000180E77F50
	}
}
