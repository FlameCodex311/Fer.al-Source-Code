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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[SelectionBase] // 0x00000001801CDAD0-0x00000001801CDAE0
public class Match3Tile : MonoBehaviour // TypeDefIndex: 10659
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3TileType tileType; // 0x20
	public Animator tileAnimator; // 0x28
	public SpriteRenderer tileSprite; // 0x30
	private AnimatorOverrideController _overrideAnimatorController; // 0x38
	private GameObject _eggShineFx; // 0x40
	private int _tileHealth; // 0x48
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Moving>k__BackingField; // 0x4C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <LastMoveTime>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BoosterType <Booster>k__BackingField; // 0x54
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3TileType <BoosterUnderlyingTileType>k__BackingField; // 0x58
	private bool _boosterTileReadyForRemoval; // 0x60

	// Properties
	public int TileHealth { get; } // 0x0000000180379ED0-0x0000000180379EE0 
	public bool Moving { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805567D0-0x00000001805567E0 0x00000001807E32B0-0x00000001807E32C0
	public float LastMoveTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180791CE0-0x0000000180791CF0 0x00000001807E32A0-0x00000001807E32B0
	public bool CanMatch { get; } // 0x00000001807E3240-0x00000001807E3260 
	public BoosterType Booster { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EE0-0x0000000180379EF0 0x00000001807E3290-0x00000001807E32A0
	public bool IsBoosted { get; } // 0x00000001807E3260-0x00000001807E3270 
	public bool BoosterActivatedByUserOnly { get; } // 0x00000001807E3230-0x00000001807E3240 
	public bool IsBoosterAnyColorBomb { get; } // 0x00000001807E3270-0x00000001807E3290 
	public Match3TileType TileType { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001807E32C0-0x00000001807E32D0
	public Match3TileType BoosterUnderlyingTileType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 10660
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public Action<Match3Cell, bool> onMoveFinished; // 0x18
		public Match3Cell inCell; // 0x20

		// Constructors
		public <>c__DisplayClass40_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DropToCell>b__0(); // 0x00000001807F0F30-0x00000001807F1070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass41_0 // TypeDefIndex: 10661
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public Action<Match3Cell, bool> onMoveFinished; // 0x18
		public Match3Cell inCell; // 0x20

		// Constructors
		public <>c__DisplayClass41_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <MoveToCell>b__0(); // 0x00000001807F1070-0x00000001807F10F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RemoveBoosterWhenReady>d__47 : IEnumerator<object> // TypeDefIndex: 10662
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3Tile <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RemoveBoosterWhenReady>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807EEF10-0x00000001807EF200
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807EF200-0x00000001807F0C00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 10663
	{
		// Fields
		public Match3Tile <>4__this; // 0x10
		public BoosterType inBoosterType; // 0x18
		public Match3TileType inBaseBoosterType; // 0x20

		// Constructors
		public <>c__DisplayClass48_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoBoosterUpgradeInPlace>b__0(); // 0x00000001807F10F0-0x00000001807F1140
	}

	// Constructors
	public Match3Tile(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnDestroy(); // 0x00000001807E0DF0-0x00000001807E0E90
	private void SetSprite(Sprite inSprite); // 0x00000001807E2BD0-0x00000001807E2CB0
	private void SetAnimation(AnimationClip inAnimClip); // 0x00000001807E2A40-0x00000001807E2BC0
	public void UpdateTileType(); // 0x00000001807E2F20-0x00000001807E3230
	public void SetBoosterType(BoosterType inType, Match3TileType inUnderlyingType); // 0x00000001807E2BC0-0x00000001807E2BD0
	public void DropToCell(Match3Cell inCell, float inDuration, float delay = 0f /* Metadata: 0x0077BFA6 */, Action<Match3Cell, bool> onMoveFinished = null); // 0x00000001807E0790-0x00000001807E0940
	public void MoveToCell(Match3Cell inCell, float inDuration, Action<Match3Cell, bool> onMoveFinished = null); // 0x00000001807E0C60-0x00000001807E0DF0
	public void MoveBlocked(Vector3 inDirection, float inDuration); // 0x00000001807E0A80-0x00000001807E0C60
	public bool OnTileMatched(bool clearedByPeacock = false /* Metadata: 0x0077BFAA */); // 0x00000001807E0E90-0x00000001807E1190
	public void ActivateBoosterTile(); // 0x00000001807DFE20-0x00000001807E0070
	public void RemoveBoosterTile(); // 0x00000001807E27A0-0x00000001807E2940
	[IteratorStateMachine] // 0x00000001802482A0-0x00000001802482F0
	private IEnumerator RemoveBoosterWhenReady(); // 0x00000001807E2940-0x00000001807E29A0
	public void DoBoosterUpgradeInPlace(BoosterType inBoosterType, Match3TileType inBaseBoosterType); // 0x00000001807E0640-0x00000001807E0790
	public void AddHealth(int inAmount); // 0x00000001807E0070-0x00000001807E0500
	public void ChangeToSpecialOrderTileType(Match3TileType inSpecialOrderType); // 0x00000001807E0500-0x00000001807E0640
	private void PlayStandardRemovalFx(); // 0x00000001807E2230-0x00000001807E23D0
	private void PlayClearedByPeacockFx(); // 0x00000001807E1960-0x00000001807E1B00
	private void PlayTwinTroubleRemovalFx(); // 0x00000001807E23D0-0x00000001807E2570
	private void PlayDoubleTwinTroubleRemovalFx(); // 0x00000001807E1B00-0x00000001807E1CA0
	private void PlayFlyerHorizontalRemovalFx(); // 0x00000001807E2000-0x00000001807E2230
	private void PlayerFlyerVerticalRemovalFx(); // 0x00000001807E2570-0x00000001807E27A0
	public void PlayBoosterFx(); // 0x00000001807E1330-0x00000001807E16C0
	public void PlayBoosterSpawnInFx(); // 0x00000001807E16C0-0x00000001807E1960
	public void PlayBoosterActivatedFx(); // 0x00000001807E1190-0x00000001807E1330
	private void RemoveEggShineFx(); // 0x00000001807E29A0-0x00000001807E2A40
	public void PlayEggShineFx(); // 0x00000001807E1E50-0x00000001807E2000
	public void PlayEggHatchFx(); // 0x00000001807E1CA0-0x00000001807E1E50
	[DeMethodButton] // 0x0000000180248320-0x0000000180248380
	private void EditorUpdateTileType(); // 0x00000001803774A0-0x00000001803774B0
	[DeMethodButton] // 0x0000000180248730-0x0000000180248790
	private void MakeTilePeacock(); // 0x00000001807E09E0-0x00000001807E0A80
	[DeMethodButton] // 0x0000000180248840-0x00000001802488A0
	private void MakeTileBomb(); // 0x00000001807E0940-0x00000001807E0960
	[DeMethodButton] // 0x0000000180248B20-0x0000000180248B80
	private void MakeTileFlyerHorizontal(); // 0x00000001807E0980-0x00000001807E09A0
	[DeMethodButton] // 0x0000000180248F60-0x0000000180248FC0
	private void MakeTileFlyerVertical(); // 0x00000001807E09A0-0x00000001807E09C0
	[DeMethodButton] // 0x00000001802492D0-0x0000000180249330
	private void MakeTileEgg(); // 0x00000001807E0960-0x00000001807E0980
	[DeMethodButton] // 0x000000018024A720-0x000000018024A780
	private void MakeTileNotEgg(); // 0x00000001807E09C0-0x00000001807E09E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTileMatched>b__43_0(); // 0x00000001807E2CC0-0x00000001807E2F20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ActivateBoosterTile>b__45_0(); // 0x00000001807E2CB0-0x00000001807E2CC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RemoveBoosterTile>b__46_0(); // 0x00000001807E2CB0-0x00000001807E2CC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <RemoveBoosterWhenReady>b__47_0(); // 0x00000001803CE080-0x00000001803CE090
}

