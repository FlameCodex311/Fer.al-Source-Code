/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class QuickGamesHUD : ManagedBehaviour // TypeDefIndex: 14967
	{
		// Fields
		private QuickGamesBase _game; // 0x50
		private GameObject bg; // 0x58
		private GameObject fg; // 0x60
		public QuickGamesBackScrim quickGamesBackScrim; // 0x68
		public QuickGamesCommonHUD quickGamesCommonHUD; // 0x70
		public QuickGamesResults quickGamesResults; // 0x78
		public GameObject quickGamesRootPrefab; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject <quickGamesRoot>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Camera <quickGamesCamera>k__BackingField; // 0x90
	
		// Properties
		public GameObject quickGamesRoot { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		public Camera quickGamesCamera { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
	
		// Nested types
		[Serializable]
		public class QuickGamesBackScrim // TypeDefIndex: 14968
		{
			// Fields
			public GameObject scrim; // 0x10
	
			// Constructors
			public QuickGamesBackScrim(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class QuickGamesCommonHUD // TypeDefIndex: 14969
		{
			// Fields
			public GameObject group; // 0x10
			public WWTextMeshProUGUI textTimer; // 0x18
			public WWTextMeshProUGUI textInstruction; // 0x20
	
			// Constructors
			public QuickGamesCommonHUD(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class QuickGamesResults // TypeDefIndex: 14970
		{
			// Fields
			public GameObject groupAll; // 0x10
			public GameObject group1; // 0x18
			public RawImage imageResults1; // 0x20
			public WWTextMeshProUGUI textResults1; // 0x28
			public GameObject group2; // 0x30
			public RawImage imageResults2_1; // 0x38
			public RawImage imageResults2_2; // 0x40
			public WWTextMeshProUGUI textResults2_1; // 0x48
			public WWTextMeshProUGUI textResults2_2; // 0x50
			public GameObject group3; // 0x58
			public RawImage imageResults3_1; // 0x60
			public RawImage imageResults3_2; // 0x68
			public RawImage imageResults3_3; // 0x70
			public WWTextMeshProUGUI textResults3_1; // 0x78
			public WWTextMeshProUGUI textResults3_2; // 0x80
			public WWTextMeshProUGUI textResults3_3; // 0x88
	
			// Constructors
			public QuickGamesResults(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public QuickGamesHUD(); // 0x0000000180A56D70-0x0000000180A56DD0
	
		// Methods
		public override void UAwake(); // 0x0000000180A56960-0x0000000180A56D00
		public void Init(QuickGamesBase inGame); // 0x0000000180A56340-0x0000000180A564C0
		public void CloseAll(); // 0x0000000180A56220-0x0000000180A56340
		public void UpdateTimer(); // 0x0000000180A56D00-0x0000000180A56D70
		public void ShowTimer(bool inShow); // 0x0000000180A568E0-0x0000000180A56960
		private void MakeResults(QuickGamesBase.QuickGameReward inReward, RawImage inImageResult, WWTextMeshProUGUI inTextResult); // 0x0000000180A564C0-0x0000000180A56620
		public void ShowResults(List<QuickGamesBase.QuickGameReward> inRewards); // 0x0000000180A56620-0x0000000180A568E0
		public void BtnClicked_Close(); // 0x0000000180A56160-0x0000000180A56220
	}
}
