/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge;
using World_Challenge.Casual_Game;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Casual_Game_Table
{
	public class CasualGameTable : WorldChallenge // TypeDefIndex: 15620
	{
		// Fields
		[Header] // 0x000000018013F330-0x000000018013F360
		public Transform tableCenter; // 0xA0
		public CasualGame casualGamePrefab; // 0xA8
		private CasualGame _casualGame; // 0xB0
		private ETableState _tableState; // 0xB8
	
		// Nested types
		private enum ETableState // TypeDefIndex: 15621
		{
			WAITING = 0,
			GAMESELECTED = 1,
			TUTORIAL_ASK = 2,
			TUTORIAL_SHOW = 3,
			PLAYING = 4,
			RESULTS = 5
		}
	
		// Constructors
		public CasualGameTable(); // 0x0000000181706110-0x0000000181706120
	
		// Methods
		public override void MStart(); // 0x0000000181705D30-0x0000000181705D40
		internal override void DialogNext(); // 0x0000000181705A50-0x0000000181705A90
		internal override void OptionSelected(int inIdx); // 0x0000000181705D40-0x0000000181706040
		protected override void StartChallenge(); // 0x0000000181706080-0x00000001817060C0
		internal void GameReturn(CasualGame.EGamesResults inGamesResults); // 0x0000000181705B50-0x0000000181705B90
		internal override void InitializeGame(); // 0x0000000181705B90-0x0000000181705D30
		internal override void StartGame(); // 0x00000001817060C0-0x0000000181706110
		internal override void ResetGame(); // 0x0000000181706040-0x0000000181706080
		internal override void EndGame(); // 0x0000000181705A90-0x0000000181705B50
	}
}
