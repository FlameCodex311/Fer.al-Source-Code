/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class PressStartToJoinExample_Assigner : UnityEngine.MonoBehaviour // TypeDefIndex: 9243
	{
		// Fields
		private static PressStartToJoinExample_Assigner instance; // 0x00
		public int maxPlayers; // 0x18
		private List<PlayerMap> playerMap; // 0x20
		private int gamePlayerIdCounter; // 0x28
	
		// Nested types
		private class PlayerMap // TypeDefIndex: 9244
		{
			// Fields
			public int rewiredPlayerId; // 0x10
			public int gamePlayerId; // 0x14
	
			// Constructors
			public PlayerMap(int rewiredPlayerId, int gamePlayerId); // 0x00000001804F7840-0x00000001804F7880
		}
	
		// Constructors
		public PressStartToJoinExample_Assigner(); // 0x00000001815BDD50-0x00000001815BDD60
	
		// Methods
		public static Player GetRewiredPlayer(int gamePlayerId); // 0x00000001815BD9A0-0x00000001815BDC50
		private void Awake(); // 0x00000001815BD920-0x00000001815BD990
		private void Update(); // 0x00000001815BDC50-0x00000001815BDD50
		private void AssignNextPlayer(int rewiredPlayerId); // 0x00000001815BD590-0x00000001815BD920
		private int GetNextGamePlayerId(); // 0x00000001815BD990-0x00000001815BD9A0
	}
}
