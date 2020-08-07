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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class QuickGamesBase : ManagedBehaviour // TypeDefIndex: 14957
	{
		// Fields
		public static QuickGamesBase instance; // 0x00
		internal bool giveReward; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private QuickGameReward <GameReward>k__BackingField; // 0x58
		private int _worldEventId; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EQuickGamesState <QuickGamesState>k__BackingField; // 0x64
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EQuickGamesResults <QuickGamesResults>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EQuickGameRewardTier <QuickGameRewardTier>k__BackingField; // 0x6C
		public Dictionary<string, object> QuickGameCustomResults; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <DisplayTime>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CraftIngredient <Ingredient>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HarvestPoint <HarvestPoint>k__BackingField; // 0x88
		internal CinderQGE WorldChallenge; // 0x90
		internal StartGameQGE NodeActionStartGameQGE; // 0x98
		[Header] // 0x0000000180270FC0-0x0000000180270FF0
		public QuickGamesHUD quickGamesHUD; // 0xA0
		public string inGameInstructionsText; // 0xA8
		[Header] // 0x0000000180271270-0x00000001802712A0
		public GameObject HUDElements; // 0xB0
		public float timeToComplete; // 0xB8
		public float timeForResults; // 0xBC
		public float timeForResultsGUI; // 0xC0
		public bool autoDestroyOnGameOver; // 0xC4
		[Header] // 0x00000001802713B0-0x00000001802713E0
		public float chanceOfQuickGame; // 0xC8
		public List<WinIngredient> winIngredients; // 0xD0
		protected float _currentTimeToComplete; // 0xD8
		protected QuickGamesHUD _quickGamesHUD; // 0xE0
		private int _previousDisplayTime; // 0xE8
	
		// Properties
		public QuickGameReward GameReward { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public int worldEventId { get; set; } // 0x00000001804ADA80-0x00000001804ADA90 0x00000001804ADAB0-0x00000001804ADAC0
		public EQuickGamesState QuickGamesState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804C5F20-0x00000001804C5F30 0x00000001808D4EB0-0x00000001808D4EC0
		public EQuickGamesResults QuickGamesResults { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806F4980-0x00000001806F4990 0x00000001806F4B40-0x00000001806F4B50
		public EQuickGameRewardTier QuickGameRewardTier { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806F4990-0x00000001806F49A0 0x00000001806F4B50-0x00000001806F4B60
		public int DisplayTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803959E0-0x00000001803959F0 0x00000001804793B0-0x00000001804793C0
		public CraftIngredient Ingredient { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
		public HarvestPoint HarvestPoint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
	
		// Nested types
		public class QuickGameReward // TypeDefIndex: 14958
		{
			// Fields
			public int embers; // 0x10
			public string winIngredientDefId; // 0x18
			public int winIngreientAwardAmmount; // 0x20
			public string loseIngredientDefId; // 0x28
			public int loseIngreientAwardAmmount; // 0x30
	
			// Constructors
			public QuickGameReward(); // 0x0000000180A54EA0-0x0000000180A54EF0
			public QuickGameReward(List<WinIngredient> inIngredients); // 0x0000000180A54CF0-0x0000000180A54EA0
	
			// Methods
			public void ClearRewards(); // 0x0000000180A54CB0-0x0000000180A54CF0
		}
	
		public enum EQuickGamesState // TypeDefIndex: 14959
		{
			NONE = 0,
			INTRO = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EQuickGamesResults // TypeDefIndex: 14960
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		public enum EQuickGameRewardTier // TypeDefIndex: 14961
		{
			NONE = 0,
			BRONZE = 1,
			SILVER = 2,
			GOLD = 3,
			PRIZE = 4,
			CONSOLATION_PRIZE = 5
		}
	
		[Serializable]
		public class WinIngredient // TypeDefIndex: 14962
		{
			// Fields
			public float chanceOfIngredient; // 0x10
			[RootSelector] // 0x000000018021B930-0x000000018021B990
			public string defId; // 0x18
	
			// Constructors
			public WinIngredient(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__61 : IEnumerator<object> // TypeDefIndex: 14963
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuickGamesBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__61(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5F5D0-0x0000000180A5F660
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5F660-0x0000000180A5F6B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__65 : IEnumerator<object> // TypeDefIndex: 14964
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuickGamesBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__65(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A61480-0x0000000180A61540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61540-0x0000000180A61590
		}
	
		// Constructors
		public QuickGamesBase(); // 0x0000000180A55C60-0x0000000180A55D10
	
		// Methods
		public override void UAwake(); // 0x0000000180A55980-0x0000000180A55BE0
		public override void MOnEnable(); // 0x0000000180A55090-0x0000000180A550D0
		public override void MOnDisable(); // 0x0000000180A55050-0x0000000180A55090
		public override void MStart(); // 0x0000000180A550D0-0x0000000180A55120
		private void ShowTimer(bool inShow); // 0x0000000180A55890-0x0000000180A55980
		private void UpdateTimer(); // 0x0000000180A55BE0-0x0000000180A55C60
		private bool IsTimerShowing(); // 0x0000000180A54F50-0x0000000180A55050
		[IteratorStateMachine] // 0x0000000180273F90-0x0000000180273FE0
		public virtual IEnumerator ShowIntro(); // 0x0000000180A4DD60-0x0000000180A4DDC0
		public virtual void QuickGameUpdate(); // 0x00000001803774A0-0x00000001803774B0
		public override void MUpdate(); // 0x0000000180A55120-0x0000000180A55360
		public void QuickGameResults(); // 0x0000000180A55730-0x0000000180A55770
		[IteratorStateMachine] // 0x0000000180274280-0x00000001802742D0
		public virtual IEnumerator ShowResults(); // 0x0000000180A4A590-0x0000000180A4A5F0
		private void QuickGameOver(); // 0x0000000180A55360-0x0000000180A55730
		protected virtual QuickGameReward InitReward(); // 0x0000000180A54EF0-0x0000000180A54F50
		public Vector3 ScreenToWorld(Vector3 screenCoordinate); // 0x0000000180A55820-0x0000000180A55890
		public Vector3 ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint); // 0x0000000180A55770-0x0000000180A55820
	}
}
