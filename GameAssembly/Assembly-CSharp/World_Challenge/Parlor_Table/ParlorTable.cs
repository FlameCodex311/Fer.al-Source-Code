/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge;
using World_Challenge.Parlor_Game;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Table
{
	public class ParlorTable : WorldChallenge // TypeDefIndex: 14684
	{
		// Fields
		[Header] // 0x000000018028B2C0-0x000000018028B2F0
		public Transform tableCenter; // 0xA0
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int wagerIndex; // 0xA8
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int gameIndex; // 0xAC
		public ParlorGame[] parlorGames; // 0xB0
		internal ParlorGame _parlorGame; // 0xB8
		private ETableState _tableState; // 0xC0
	
		// Nested types
		private enum ETableState // TypeDefIndex: 14685
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
		public ParlorTable(); // 0x000000018197B2F0-0x000000018197B360
	
		// Methods
		internal override void DialogNext(); // 0x000000018197ABA0-0x000000018197AC10
		internal override void OptionSelected(int inIdx); // 0x000000018197AEF0-0x000000018197B280
		protected override void StartChallenge(); // 0x000000018197B2B0-0x000000018197B2F0
		internal void GameReturn(ParlorGame.EGamesResults inGamesResults); // 0x000000018197ACD0-0x000000018197AD10
		internal override void InitializeGame(); // 0x000000018197AD10-0x000000018197AEF0
		internal override void StartGame(); // 0x000000018197B2B0-0x000000018197B2F0
		internal override void ResetGame(); // 0x000000018197B280-0x000000018197B2B0
		internal override void EndGame(); // 0x000000018197AC10-0x000000018197ACD0
	}
}
