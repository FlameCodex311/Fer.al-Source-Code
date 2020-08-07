/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class QuickGamesController : NPCInteract // TypeDefIndex: 14965
	{
		// Fields
		[Header] // 0x0000000180276FE0-0x0000000180277010
		public Transform canvas; // 0x1C8
		public Transform list; // 0x1D0
		public Button button; // 0x1D8
		public QuickGamesBase[] quickGames; // 0x1E0
	
		// Nested types
		private class TmpGame : MonoBehaviour // TypeDefIndex: 14966
		{
			// Fields
			internal QuickGamesController Controller; // 0x20
	
			// Constructors
			public TmpGame(); // 0x00000001803743C0-0x00000001803743D0
	
			// Methods
			private void OnDestroy(); // 0x0000000180A5B900-0x0000000180A5B920
		}
	
		// Constructors
		public QuickGamesController(); // 0x0000000180A56150-0x0000000180A56160
	
		// Methods
		public override void MStart(); // 0x0000000180A55F30-0x0000000180A56100
		public override void PlayAudioAndFX(); // 0x0000000180A56100-0x0000000180A56150
		public void ButtonClicked(); // 0x0000000180A55D10-0x0000000180A55F30
		private void GameOver(); // 0x00000001803774A0-0x00000001803774B0
	}
}
