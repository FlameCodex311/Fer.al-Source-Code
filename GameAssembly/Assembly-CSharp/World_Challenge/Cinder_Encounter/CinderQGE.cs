/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;
using World_Challenge;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Cinder_Encounter
{
	public class CinderQGE : WorldChallenge // TypeDefIndex: 15613
	{
		// Fields
		[Header] // 0x000000018013CA40-0x000000018013CA70
		public QuickGamesBase quickGame; // 0xA0
		private QuickGamesBase _quickGame; // 0xA8
		private EState _state; // 0xB0
	
		// Nested types
		private enum EState // TypeDefIndex: 15614
		{
			WAITING = 0,
			PLAYING = 1,
			RESULTS = 2
		}
	
		// Constructors
		public CinderQGE(); // 0x0000000181706110-0x0000000181706120
	
		// Methods
		protected override void StartChallenge(); // 0x0000000181707830-0x0000000181707930
		internal override void DialogClose(); // 0x00000001817076D0-0x0000000181707770
		internal void QuickGameReturn(); // 0x0000000181707770-0x0000000181707830
		internal override void StartGame(); // 0x0000000181707930-0x0000000181707950
	}
}
