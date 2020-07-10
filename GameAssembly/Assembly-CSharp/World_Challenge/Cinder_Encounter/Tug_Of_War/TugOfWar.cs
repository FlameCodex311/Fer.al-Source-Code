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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TugOfWar : WorldChallenge // TypeDefIndex: 15618
	{
		// Fields
		[Header] // 0x000000018013E6A0-0x000000018013E6D0
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AtStartPoint>d__19 : IEnumerator<object> // TypeDefIndex: 15619
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TugOfWar <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AtStartPoint>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181714AD0-0x0000000181715080
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181715080-0x00000001817150D0
		}
	
		// Constructors
		public TugOfWar(); // 0x0000000181714380-0x00000001817143B0
	
		// Methods
		public override void MStart(); // 0x0000000181714180-0x0000000181714280
		internal override void OptionSelected(int inIdx); // 0x0000000181714280-0x00000001817142D0
		private Transform FindName(Transform inParent, string inName); // 0x0000000181714080-0x0000000181714180
		[IteratorStateMachine] // 0x000000018013E7A0-0x000000018013E7F0
		protected override IEnumerator AtStartPoint(); // 0x000000018170F380-0x000000018170F3E0
		protected override void ChallengeUpdate(); // 0x0000000181713B00-0x0000000181713F60
		protected override void ChallengeOver(); // 0x0000000181713A20-0x0000000181713B00
		protected virtual void ProgressUpdate(); // 0x00000001817142D0-0x0000000181714350
		protected override void CloseChallenge(); // 0x0000000181713F60-0x0000000181714080
		internal override void StartGame(); // 0x0000000181714350-0x0000000181714370
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181714370-0x0000000181714380
	}
}
