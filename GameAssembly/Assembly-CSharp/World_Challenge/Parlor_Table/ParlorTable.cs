/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge;
using World_Challenge.Parlor_Game;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Table
{
	public class ParlorTable : WorldChallenge // TypeDefIndex: 15529
	{
		// Fields
		[Header] // 0x0000000180106D30-0x0000000180106D60
		public Transform tableCenter; // 0xA0
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public int wagerIndex; // 0xA8
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public int gameIndex; // 0xAC
		public ParlorGame[] parlorGames; // 0xB0
		internal ParlorGame _parlorGame; // 0xB8
		private ETableState _tableState; // 0xC0
	
		// Nested types
		private enum ETableState // TypeDefIndex: 15530
		{
			WAITING = 0,
			GAMESELECTED = 1,
			TUTORIAL_ASK = 2,
			TUTORIAL_SHOW = 3,
			PLACE_WAGER = 4,
			PLAYING = 5,
			RESULTS = 6
		}
	
		// Constructors
		public ParlorTable(); // 0x0000000181F2F5B0-0x0000000181F2F620
	
		// Methods
		internal override void DialogNext(); // 0x0000000181F2EE50-0x0000000181F2EEC0
		internal override void OptionSelected(int inIdx); // 0x0000000181F2F1B0-0x0000000181F2F540
		protected override void StartChallenge(); // 0x0000000181F2F570-0x0000000181F2F5B0
		internal void GameReturn(ParlorGame.EGamesResults inGamesResults); // 0x0000000181F2EF80-0x0000000181F2EFC0
		internal override void InitializeGame(); // 0x0000000181F2EFC0-0x0000000181F2F1B0
		internal override void StartGame(); // 0x0000000181F2F570-0x0000000181F2F5B0
		internal override void ResetGame(); // 0x0000000181F2F540-0x0000000181F2F570
		internal override void EndGame(); // 0x0000000181F2EEC0-0x0000000181F2EF80
	}
}
