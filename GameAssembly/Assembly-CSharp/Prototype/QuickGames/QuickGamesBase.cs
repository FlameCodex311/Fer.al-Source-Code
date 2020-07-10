/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Tasks.Actions;
using Prototype;
using UnityEngine;
using World_Challenge.Cinder_Encounter;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class QuickGamesBase : ManagedBehaviour // TypeDefIndex: 16215
	{
		// Fields
		public static QuickGamesBase instance; // 0x00
		internal bool giveReward; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private QuickGameReward <GameReward>k__BackingField; // 0x58
		private int _worldEventId; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EQuickGamesState <QuickGamesState>k__BackingField; // 0x64
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EQuickGamesResults <QuickGamesResults>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EQuickGameRewardTier <QuickGameRewardTier>k__BackingField; // 0x6C
		public Dictionary<string, object> QuickGameCustomResults; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <DisplayTime>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private CraftIngredient <Ingredient>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private HarvestPoint <HarvestPoint>k__BackingField; // 0x88
		internal CinderQGE WorldChallenge; // 0x90
		internal StartGameQGE NodeActionStartGameQGE; // 0x98
		[Header] // 0x0000000180152C50-0x0000000180152C80
		public QuickGamesHUD quickGamesHUD; // 0xA0
		public string inGameInstructionsText; // 0xA8
		[Header] // 0x0000000180152E00-0x0000000180152E30
		public GameObject HUDElements; // 0xB0
		public float timeToComplete; // 0xB8
		public float timeForResults; // 0xBC
		public float timeForResultsGUI; // 0xC0
		public bool autoDestroyOnGameOver; // 0xC4
		[Header] // 0x0000000180152F40-0x0000000180152F70
		public float chanceOfQuickGame; // 0xC8
		public List<WinIngredient> winIngredients; // 0xD0
		protected float _currentTimeToComplete; // 0xD8
		protected QuickGamesHUD _quickGamesHUD; // 0xE0
		private int _previousDisplayTime; // 0xE8
	
		// Properties
		public QuickGameReward GameReward { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public int worldEventId { get; set; } // 0x00000001804A3730-0x00000001804A3740 0x000000018044E340-0x000000018044E350
		public EQuickGamesState QuickGamesState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804D0650-0x00000001804D0660 0x000000018044E320-0x000000018044E330
		public EQuickGamesResults QuickGamesResults { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAC60-0x00000001803DAC70 0x00000001803DAE50-0x00000001803DAE60
		public EQuickGameRewardTier QuickGameRewardTier { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAC70-0x00000001803DAC80 0x00000001803DAE60-0x00000001803DAE70
		public int DisplayTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803DAE10-0x00000001803DAE20 0x00000001803DAE70-0x00000001803DAE80
		public CraftIngredient Ingredient { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
		public HarvestPoint HarvestPoint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
	
		// Nested types
		public class QuickGameReward // TypeDefIndex: 16216
		{
			// Fields
			public int embers; // 0x10
			public string winIngredientDefId; // 0x18
			public int winIngreientAwardAmmount; // 0x20
			public string loseIngredientDefId; // 0x28
			public int loseIngreientAwardAmmount; // 0x30
	
			// Constructors
			public QuickGameReward(); // 0x0000000181532A50-0x0000000181532AA0
			public QuickGameReward(List<WinIngredient> inIngredients); // 0x00000001815328A0-0x0000000181532A50
	
			// Methods
			public void ClearRewards(); // 0x0000000181532860-0x00000001815328A0
		}
	
		public enum EQuickGamesState // TypeDefIndex: 16217
		{
			NONE = 0,
			INTRO = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EQuickGamesResults // TypeDefIndex: 16218
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		public enum EQuickGameRewardTier // TypeDefIndex: 16219
		{
			NONE = 0,
			BRONZE = 1,
			SILVER = 2,
			GOLD = 3,
			PRIZE = 4,
			CONSOLATION_PRIZE = 5
		}
	
		[Serializable]
		public class WinIngredient // TypeDefIndex: 16220
		{
			// Fields
			public float chanceOfIngredient; // 0x10
			[RootSelector] // 0x00000001800FF420-0x00000001800FF480
			public string defId; // 0x18
	
			// Constructors
			public WinIngredient(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__61 : IEnumerator<object> // TypeDefIndex: 16221
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuickGamesBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__61(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153E090-0x000000018153E120
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153E120-0x000000018153E170
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__65 : IEnumerator<object> // TypeDefIndex: 16222
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuickGamesBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__65(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181540570-0x0000000181540630
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181540630-0x0000000181540680
		}
	
		// Constructors
		public QuickGamesBase(); // 0x0000000181533850-0x0000000181533900
	
		// Methods
		public override void UAwake(); // 0x0000000181533570-0x00000001815337D0
		public override void MOnEnable(); // 0x0000000181532C40-0x0000000181532C80
		public override void MOnDisable(); // 0x0000000181532C00-0x0000000181532C40
		public override void MStart(); // 0x0000000181532C80-0x0000000181532CD0
		private void ShowTimer(bool inShow); // 0x0000000181533470-0x0000000181533570
		private void UpdateTimer(); // 0x00000001815337D0-0x0000000181533850
		private bool IsTimerShowing(); // 0x0000000181532B00-0x0000000181532C00
		[IteratorStateMachine] // 0x00000001801542F0-0x0000000180154340
		public virtual IEnumerator ShowIntro(); // 0x000000018152B740-0x000000018152B7A0
		public virtual void QuickGameUpdate(); // 0x00000001803581E0-0x00000001803581F0
		public override void MUpdate(); // 0x0000000181532CD0-0x0000000181532F10
		public void QuickGameResults(); // 0x0000000181533300-0x0000000181533340
		[IteratorStateMachine] // 0x0000000180154540-0x0000000180154590
		public virtual IEnumerator ShowResults(); // 0x0000000181527E70-0x0000000181527ED0
		private void QuickGameOver(); // 0x0000000181532F10-0x0000000181533300
		protected virtual QuickGameReward InitReward(); // 0x0000000181532AA0-0x0000000181532B00
		public Vector3 ScreenToWorld(Vector3 screenCoordinate); // 0x0000000181533400-0x0000000181533470
		public Vector3 ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint); // 0x0000000181533340-0x0000000181533400
	}
}
