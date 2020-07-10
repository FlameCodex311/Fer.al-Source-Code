/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[SelectionBase] // 0x00000001800B36B0-0x00000001800B36C0
public class Match3Tile : MonoBehaviour // TypeDefIndex: 12994
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3TileType tileType; // 0x20
	public Animator tileAnimator; // 0x28
	public SpriteRenderer tileSprite; // 0x30
	private AnimatorOverrideController _overrideAnimatorController; // 0x38
	private GameObject _eggShineFx; // 0x40
	private int _tileHealth; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Moving>k__BackingField; // 0x4C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <LastMoveTime>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private BoosterType <Booster>k__BackingField; // 0x54
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3TileType <BoosterUnderlyingTileType>k__BackingField; // 0x58
	private bool _boosterTileReadyForRemoval; // 0x60

	// Properties
	public int TileHealth { get; } // 0x0000000180384C10-0x0000000180384C20 
	public bool Moving { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180478590-0x00000001804785A0 0x00000001810A69F0-0x00000001810A6A00
	public float LastMoveTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D20-0x0000000180487D30 0x0000000180DD2D90-0x0000000180DD2DA0
	public bool CanMatch { get; } // 0x00000001810A69A0-0x00000001810A69C0 
	public BoosterType Booster { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C60-0x0000000180369C70 0x00000001804D0B80-0x00000001804D0B90
	public bool IsBoosted { get; } // 0x00000001810A69C0-0x00000001810A69D0 
	public bool BoosterActivatedByUserOnly { get; } // 0x00000001810A6990-0x00000001810A69A0 
	public bool IsBoosterAnyColorBomb { get; } // 0x00000001810A69D0-0x00000001810A69F0 
	public Match3TileType TileType { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x00000001810A6A00-0x00000001810A6A10
	public Match3TileType BoosterUnderlyingTileType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 12995
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public Action<Match3Cell, bool> onMoveFinished; // 0x18
		public Match3Cell inCell; // 0x20

		// Constructors
		public <>c__DisplayClass40_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DropToCell>b__0(); // 0x00000001810BD5D0-0x00000001810BD710
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass41_0 // TypeDefIndex: 12996
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public Action<Match3Cell, bool> onMoveFinished; // 0x18
		public Match3Cell inCell; // 0x20

		// Constructors
		public <>c__DisplayClass41_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <MoveToCell>b__0(); // 0x00000001810BD710-0x00000001810BD790
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RemoveBoosterWhenReady>d__47 : IEnumerator<object> // TypeDefIndex: 12997
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3Tile <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RemoveBoosterWhenReady>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BCF10-0x00000001810BD210
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BD210-0x00000001810BD260
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 12998
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public BoosterType inBoosterType; // 0x18
		public Match3TileType inBaseBoosterType; // 0x20

		// Constructors
		public <>c__DisplayClass48_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoBoosterUpgradeInPlace>b__0(); // 0x00000001810BD790-0x00000001810BD7E0
	}

	// Constructors
	public Match3Tile(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void OnDestroy(); // 0x00000001810A4610-0x00000001810A46B0
	private void SetSprite(Sprite inSprite); // 0x00000001810A6310-0x00000001810A63F0
	private void SetAnimation(AnimationClip inAnimClip); // 0x00000001810A6180-0x00000001810A6300
	public void UpdateTileType(); // 0x00000001810A6660-0x00000001810A6990
	public void SetBoosterType(BoosterType inType, Match3TileType inUnderlyingType); // 0x00000001810A6300-0x00000001810A6310
	public void DropToCell(Match3Cell inCell, float inDuration, float delay = 0f /* Metadata: 0x007834EB */, Action<Match3Cell, bool> onMoveFinished = null); // 0x00000001810A3FB0-0x00000001810A4160
	public void MoveToCell(Match3Cell inCell, float inDuration, Action<Match3Cell, bool> onMoveFinished = null); // 0x00000001810A4480-0x00000001810A4610
	public void MoveBlocked(Vector3 inDirection, float inDuration); // 0x00000001810A42A0-0x00000001810A4480
	public bool OnTileMatched(bool clearedByPeacock = false /* Metadata: 0x007834EF */); // 0x00000001810A46B0-0x00000001810A49B0
	public void ActivateBoosterTile(); // 0x00000001810A37B0-0x00000001810A3A10
	public void RemoveBoosterTile(); // 0x00000001810A5EE0-0x00000001810A6080
	[IteratorStateMachine] // 0x000000018016E4C0-0x000000018016E510
	private IEnumerator RemoveBoosterWhenReady(); // 0x00000001810A6080-0x00000001810A60E0
	public void DoBoosterUpgradeInPlace(BoosterType inBoosterType, Match3TileType inBaseBoosterType); // 0x00000001810A3E60-0x00000001810A3FB0
	public void AddHealth(int inAmount); // 0x00000001810A3A10-0x00000001810A3D20
	public void ChangeToSpecialOrderTileType(Match3TileType inSpecialOrderType); // 0x00000001810A3D20-0x00000001810A3E60
	private void PlayStandardRemovalFx(); // 0x00000001810A5940-0x00000001810A5AF0
	private void PlayClearedByPeacockFx(); // 0x00000001810A5040-0x00000001810A51F0
	private void PlayTwinTroubleRemovalFx(); // 0x00000001810A5AF0-0x00000001810A5CA0
	private void PlayDoubleTwinTroubleRemovalFx(); // 0x00000001810A51F0-0x00000001810A53A0
	private void PlayFlyerHorizontalRemovalFx(); // 0x00000001810A5700-0x00000001810A5940
	private void PlayerFlyerVerticalRemovalFx(); // 0x00000001810A5CA0-0x00000001810A5EE0
	public void PlayBoosterFx(); // 0x00000001810A4B50-0x00000001810A4D90
	public void PlayBoosterSpawnInFx(); // 0x00000001810A4D90-0x00000001810A5040
	public void PlayBoosterActivatedFx(); // 0x00000001810A49B0-0x00000001810A4B50
	private void RemoveEggShineFx(); // 0x00000001810A60E0-0x00000001810A6180
	public void PlayEggShineFx(); // 0x00000001810A5550-0x00000001810A5700
	public void PlayEggHatchFx(); // 0x00000001810A53A0-0x00000001810A5550
	[DeMethodButton] // 0x000000018016E7D0-0x000000018016E830
	private void EditorUpdateTileType(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x000000018016EA40-0x000000018016EAA0
	private void MakeTilePeacock(); // 0x00000001810A4200-0x00000001810A42A0
	[DeMethodButton] // 0x000000018016ECB0-0x000000018016ED10
	private void MakeTileBomb(); // 0x00000001810A4160-0x00000001810A4180
	[DeMethodButton] // 0x000000018016F1A0-0x000000018016F200
	private void MakeTileFlyerHorizontal(); // 0x00000001810A41A0-0x00000001810A41C0
	[DeMethodButton] // 0x000000018016F550-0x000000018016F5B0
	private void MakeTileFlyerVertical(); // 0x00000001810A41C0-0x00000001810A41E0
	[DeMethodButton] // 0x000000018016FB10-0x000000018016FB70
	private void MakeTileEgg(); // 0x00000001810A4180-0x00000001810A41A0
	[DeMethodButton] // 0x0000000180170010-0x0000000180170070
	private void MakeTileNotEgg(); // 0x00000001810A41E0-0x00000001810A4200
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTileMatched>b__43_0(); // 0x00000001810A63F0-0x00000001810A6660
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ActivateBoosterTile>b__45_0(); // 0x00000001804157B0-0x00000001804157C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RemoveBoosterTile>b__46_0(); // 0x00000001804157B0-0x00000001804157C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <RemoveBoosterWhenReady>b__47_0(); // 0x00000001804785B0-0x00000001804785C0
}

