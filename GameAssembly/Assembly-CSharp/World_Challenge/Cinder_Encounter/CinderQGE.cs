/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;
using World_Challenge;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Cinder_Encounter
{
	public class CinderQGE : WorldChallenge // TypeDefIndex: 14768
	{
		// Fields
		[Header] // 0x00000001801FE220-0x00000001801FE250
		public QuickGamesBase quickGame; // 0xA0
		private QuickGamesBase _quickGame; // 0xA8
		private EState _state; // 0xB0
	
		// Nested types
		private enum EState // TypeDefIndex: 14769
		{
			WAITING = 0,
			PLAYING = 1,
			RESULTS = 2
		}
	
		// Constructors
		public CinderQGE(); // 0x0000000180E6AF70-0x0000000180E6AF80
	
		// Methods
		protected override void StartChallenge(); // 0x0000000180E6C610-0x0000000180E6C710
		internal override void DialogClose(); // 0x0000000180E6C4B0-0x0000000180E6C550
		internal void QuickGameReturn(); // 0x0000000180E6C550-0x0000000180E6C610
		internal override void StartGame(); // 0x0000000180E6C710-0x0000000180E6C730
	}
}
