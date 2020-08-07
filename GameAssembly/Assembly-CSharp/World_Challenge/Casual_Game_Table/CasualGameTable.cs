/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge;
using World_Challenge.Casual_Game;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Casual_Game_Table
{
	public class CasualGameTable : WorldChallenge // TypeDefIndex: 14775
	{
		// Fields
		[Header] // 0x00000001802002A0-0x00000001802002D0
		public Transform tableCenter; // 0xA0
		public CasualGame casualGamePrefab; // 0xA8
		private CasualGame _casualGame; // 0xB0
		private ETableState _tableState; // 0xB8
	
		// Nested types
		private enum ETableState // TypeDefIndex: 14776
		{
			WAITING = 0,
			GAMESELECTED = 1,
			TUTORIAL_ASK = 2,
			TUTORIAL_SHOW = 3,
			PLAYING = 4,
			RESULTS = 5
		}
	
		// Constructors
		public CasualGameTable(); // 0x0000000180E6AF70-0x0000000180E6AF80
	
		// Methods
		public override void MStart(); // 0x0000000180E6ABA0-0x0000000180E6ABB0
		internal override void DialogNext(); // 0x0000000180E6A8C0-0x0000000180E6A900
		internal override void OptionSelected(int inIdx); // 0x0000000180E6ABB0-0x0000000180E6AEA0
		protected override void StartChallenge(); // 0x0000000180E6AEE0-0x0000000180E6AF20
		internal void GameReturn(CasualGame.EGamesResults inGamesResults); // 0x0000000180E6A9C0-0x0000000180E6AA00
		internal override void InitializeGame(); // 0x0000000180E6AA00-0x0000000180E6ABA0
		internal override void StartGame(); // 0x0000000180E6AF20-0x0000000180E6AF70
		internal override void ResetGame(); // 0x0000000180E6AEA0-0x0000000180E6AEE0
		internal override void EndGame(); // 0x0000000180E6A900-0x0000000180E6A9C0
	}
}
