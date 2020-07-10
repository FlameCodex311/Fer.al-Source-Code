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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class QuickGamesHUD : ManagedBehaviour // TypeDefIndex: 16225
	{
		// Fields
		private QuickGamesBase _game; // 0x50
		private GameObject bg; // 0x58
		private GameObject fg; // 0x60
		public QuickGamesBackScrim quickGamesBackScrim; // 0x68
		public QuickGamesCommonHUD quickGamesCommonHUD; // 0x70
		public QuickGamesResults quickGamesResults; // 0x78
		public GameObject quickGamesRootPrefab; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject <quickGamesRoot>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Camera <quickGamesCamera>k__BackingField; // 0x90
	
		// Properties
		public GameObject quickGamesRoot { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public Camera quickGamesCamera { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382A80-0x0000000180382A90 0x000000018049D4D0-0x000000018049D4E0
	
		// Nested types
		[Serializable]
		public class QuickGamesBackScrim // TypeDefIndex: 16226
		{
			// Fields
			public GameObject scrim; // 0x10
	
			// Constructors
			public QuickGamesBackScrim(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		public class QuickGamesCommonHUD // TypeDefIndex: 16227
		{
			// Fields
			public GameObject group; // 0x10
			public WWTextMeshProUGUI textTimer; // 0x18
			public WWTextMeshProUGUI textInstruction; // 0x20
	
			// Constructors
			public QuickGamesCommonHUD(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		public class QuickGamesResults // TypeDefIndex: 16228
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
			public QuickGamesResults(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public QuickGamesHUD(); // 0x00000001815349D0-0x0000000181534A30
	
		// Methods
		public override void UAwake(); // 0x00000001815345B0-0x0000000181534960
		public void Init(QuickGamesBase inGame); // 0x0000000181533F60-0x00000001815340F0
		public void CloseAll(); // 0x0000000181533E40-0x0000000181533F60
		public void UpdateTimer(); // 0x0000000181534960-0x00000001815349D0
		public void ShowTimer(bool inShow); // 0x0000000181534530-0x00000001815345B0
		private void MakeResults(QuickGamesBase.QuickGameReward inReward, RawImage inImageResult, WWTextMeshProUGUI inTextResult); // 0x00000001815340F0-0x0000000181534260
		public void ShowResults(List<QuickGamesBase.QuickGameReward> inRewards); // 0x0000000181534260-0x0000000181534530
		public void BtnClicked_Close(); // 0x0000000181533D70-0x0000000181533E40
	}
}
