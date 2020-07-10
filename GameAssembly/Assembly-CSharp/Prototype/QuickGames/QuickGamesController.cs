/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class QuickGamesController : NPCInteract // TypeDefIndex: 16223
	{
		// Fields
		[Header] // 0x00000001801570C0-0x00000001801570F0
		public Transform canvas; // 0x1C8
		public Transform list; // 0x1D0
		public Button button; // 0x1D8
		public QuickGamesBase[] quickGames; // 0x1E0
	
		// Nested types
		private class TmpGame : MonoBehaviour // TypeDefIndex: 16224
		{
			// Fields
			internal QuickGamesController Controller; // 0x20
	
			// Constructors
			public TmpGame(); // 0x0000000180E095D0-0x0000000180E095E0
	
			// Methods
			private void OnDestroy(); // 0x0000000181539F50-0x0000000181539F70
		}
	
		// Constructors
		public QuickGamesController(); // 0x0000000181533D60-0x0000000181533D70
	
		// Methods
		public override void MStart(); // 0x0000000181533B30-0x0000000181533D10
		public override void PlayAudioAndFX(); // 0x0000000181533D10-0x0000000181533D60
		public void ButtonClicked(); // 0x0000000181533900-0x0000000181533B30
		private void GameOver(); // 0x00000001803581E0-0x00000001803581F0
	}
}
