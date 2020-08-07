/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class PressStartToJoinExample_Assigner : UnityEngine.MonoBehaviour // TypeDefIndex: 9409
	{
		// Fields
		private static PressStartToJoinExample_Assigner instance; // 0x00
		public int maxPlayers; // 0x18
		private List<PlayerMap> playerMap; // 0x20
		private int gamePlayerIdCounter; // 0x28
	
		// Nested types
		private class PlayerMap // TypeDefIndex: 9410
		{
			// Fields
			public int rewiredPlayerId; // 0x10
			public int gamePlayerId; // 0x14
	
			// Constructors
			public PlayerMap(int rewiredPlayerId, int gamePlayerId); // 0x00000001804A4420-0x00000001804A4460
		}
	
		// Constructors
		public PressStartToJoinExample_Assigner(); // 0x0000000181060B40-0x0000000181060B50
	
		// Methods
		public static Player GetRewiredPlayer(int gamePlayerId); // 0x00000001810607B0-0x0000000181060A50
		private void Awake(); // 0x0000000181060730-0x00000001810607A0
		private void Update(); // 0x0000000181060A50-0x0000000181060B40
		private void AssignNextPlayer(int rewiredPlayerId); // 0x00000001810603C0-0x0000000181060730
		private int GetNextGamePlayerId(); // 0x00000001810607A0-0x00000001810607B0
	}
}
