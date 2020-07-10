/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RunesGameBoard : MonoBehaviour // TypeDefIndex: 13161
{
	// Fields
	public RunesGame game; // 0x20
	public HexTile runeTilePrefab; // 0x28
	public RuneGroup runeGroupPrefab; // 0x30
	public HexGrid runeGrid; // 0x38
	public float pickUpTimer; // 0x40
	public float dragThreshold; // 0x44
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public GameObject tutorialContainer; // 0x48
	[EnumList] // 0x0000000180100910-0x0000000180100970
	public List<GameObject> tutorialObjects; // 0x50
	[EnumList] // 0x0000000180100B30-0x0000000180100B90
	public List<GameObject> tutorialUISteps; // 0x58
	[Header] // 0x0000000180100D40-0x0000000180100D70
	public List<RuneSpawnPoint> spawns; // 0x60
	public RuneSpawnPoint tutorialSpawn; // 0x68
	public Transform rightSideSpawnContainer; // 0x70
	public Transform rightSideSpawnLocation4x3; // 0x78
	[Header] // 0x0000000180100EF0-0x0000000180100F20
	public RuneSpawnPoint powerUpSpawn; // 0x80
	public int comboLevel1; // 0x88
	public int comboLevel2; // 0x8C
	[Range] // 0x0000000180101000-0x0000000180101020
	public int powerUpMeter; // 0x90
	public float powerUpMeterAnimSpeed; // 0x94
	public float powerUpMeterTutorialAnimSpeed; // 0x98
	public Animator powerUpMeterAnimator; // 0xA0
	[Header] // 0x00000001800FD010-0x00000001800FD040
	public GameObject fxPrefabScoreMultiplier2; // 0xA8
	public GameObject fxPrefabScoreMultiplier4; // 0xB0
	public GameObject fxPrefabTileExplosion; // 0xB8
	public GameObject fxPrefabTileExplosionFlame; // 0xC0
	public GameObject fxPrefabTileExplosionFlora; // 0xC8
	public GameObject fxPrefabTileExplosionMiasma; // 0xD0
	public GameObject fxPrefabCycloneFlame; // 0xD8
	public GameObject fxPrefabCycloneFlora; // 0xE0
	public GameObject fxPrefabCycloneMiasma; // 0xE8
	public ParticleSystem fxPowerupReady; // 0xF0
	public ParticleSystem fxPowerupPickedUp; // 0xF8
	private RuneGroup _holdingPiece; // 0x100
	private Vector3 _holdingOffset; // 0x108
	private float _holdTimer; // 0x114
	private bool _dragging; // 0x118
	private float _originalLocation; // 0x11C
	private List<HexCoord> _lastCanDropCoords; // 0x120
	private List<HexCoord> _lastDropCoords; // 0x128
	private List<HexCoord> _lastPowerupBombHighlightCoords; // 0x130
	private Plane _touchPlane; // 0x138
	public Dictionary<RuneType, ObscuredInt> _levelProgressPerRuneType; // 0x148
	public Dictionary<RuneType, ObscuredInt> _levelsReachedPerRuneType; // 0x150
	private List<int> _scoreThresholds; // 0x158
	private int _lastLevelThresholdDelta; // 0x160
	private int _waitForTilesCount; // 0x164
	private bool _updateHighScoreUservar; // 0x168
	private Queue<RuneType> queuedCycloneTiles; // 0x170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ObscuredInt <Score>k__BackingField; // 0x178
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ObscuredLong <HighScore>k__BackingField; // 0x190
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsPowerupMeterAnimating>k__BackingField; // 0x1B8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <TutorialOn>k__BackingField; // 0x1B9
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private TutorialSteps <TutorialStep>k__BackingField; // 0x1BC
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private TutorialSteps <NextTutorialStep>k__BackingField; // 0x1C0
	private List<HexTile> _tempCycloneTiles; // 0x1C8
	private List<RuneType> _standardRuneTypesList; // 0x1D0

	// Properties
	public ObscuredInt Score { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180FDD940-0x0000000180FDD960 0x0000000180FDD9B0-0x0000000180FDD9D0
	public ObscuredLong HighScore { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180FDD910-0x0000000180FDD940 0x0000000180FDD970-0x0000000180FDD9A0
	public bool IsPowerupMeterAnimating { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018081E120-0x000000018081E130 0x000000018081F760-0x000000018081F770
	public bool CanPickPieceUp { get; } // 0x0000000180FDD830-0x0000000180FDD910 
	public bool TutorialOn { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018081E1B0-0x000000018081E1C0 0x000000018081F9A0-0x000000018081F9B0
	public TutorialSteps TutorialStep { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180FDD960-0x0000000180FDD970 0x0000000180FDD9D0-0x0000000180FDD9E0
	public TutorialSteps NextTutorialStep { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180F0A720-0x0000000180F0A730 0x0000000180FDD9A0-0x0000000180FDD9B0

	// Nested types
	public enum TutorialSteps // TypeDefIndex: 13162
	{
		None = -1,
		RotatePiece = 0,
		DragPiece = 1,
		ScorePiece = 2,
		ScorePowerup = 3,
		ScoreMetersReward = 4,
		CycloneTile = 5,
		PowerupTile = 6,
		EndTutorial = 7
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13163
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__82_2; // 0x08
		public static TweenCallback <>9__82_0; // 0x10
		public static TweenCallback <>9__93_1; // 0x18
		public static TweenCallback <>9__93_2; // 0x20

		// Constructors
		static <>c(); // 0x0000000180E3CD80-0x0000000180E3CDE0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <CheckForLoseCondition>b__82_2(); // 0x0000000180E3B740-0x0000000180E3B750
		internal void <CheckForLoseCondition>b__82_0(); // 0x0000000180E3B730-0x0000000180E3B740
		internal void <OnCycloneRunePlaced>b__93_1(); // 0x0000000180E3B7E0-0x0000000180E3B7F0
		internal void <OnCycloneRunePlaced>b__93_2(); // 0x0000000180E3B7F0-0x0000000180E3B800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass89_0 // TypeDefIndex: 13164
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public RuneGroup inDroppedPiece; // 0x18
		public List<HexTile> scoreTiles; // 0x20

		// Constructors
		public <>c__DisplayClass89_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnRunePiecePlaced>b__0(); // 0x0000000180E3C240-0x0000000180E3C270
		internal void <OnRunePiecePlaced>b__1(); // 0x0000000180E3C270-0x0000000180E3C6A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass93_0 // TypeDefIndex: 13165
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public HexTile inCycloneTile; // 0x18
		public int newTileScore; // 0x20

		// Constructors
		public <>c__DisplayClass93_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnCycloneRunePlaced>b__0(); // 0x0000000180E3C6A0-0x0000000180E3C6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass111_0 // TypeDefIndex: 13166
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public TutorialSteps inStep; // 0x18

		// Constructors
		public <>c__DisplayClass111_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GoToTutorialStep>b__0(); // 0x0000000180E3BB70-0x0000000180E3BBA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass113_0 // TypeDefIndex: 13167
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public TutorialSteps inStep; // 0x18

		// Constructors
		public <>c__DisplayClass113_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <HandleSetupStep>b__0(); // 0x0000000180E3BBA0-0x0000000180E3BBD0
		internal void <HandleSetupStep>b__1(); // 0x0000000180E3BBD0-0x0000000180E3BC00
	}

	// Constructors
	public RunesGameBoard(); // 0x0000000180FDD690-0x0000000180FDD830

	// Methods
	private void Start(); // 0x0000000180FDBF00-0x0000000180FDC0F0
	public void SetGameData(RunesDataDefComponent inGameData); // 0x0000000180FDB750-0x0000000180FDBA30
	private int GetLevelThreshold(int inLevelIndex); // 0x0000000180FD7CD0-0x0000000180FD7DC0
	public void ResetBoard(); // 0x0000000180FDB270-0x0000000180FDB750
	public void SpawnAll(); // 0x0000000180FDBCC0-0x0000000180FDBE50
	private void Update(); // 0x0000000180FDD670-0x0000000180FDD690
	private void UpdateTutorial(); // 0x0000000180FDD3F0-0x0000000180FDD670
	private void UpdateBoard(); // 0x0000000180FDC100-0x0000000180FDD020
	private void CheckForLoseCondition(); // 0x0000000180FD5790-0x0000000180FD6520
	private void GameOver(); // 0x0000000180FD7AB0-0x0000000180FD7AD0
	private void ClearScores(); // 0x0000000180FD68E0-0x0000000180FD6AE0
	public void ClearBoard(); // 0x0000000180FD6520-0x0000000180FD68E0
	public void OnRuneGroupPressed(RuneGroup inGroup); // 0x0000000180FD93F0-0x0000000180FD96E0
	private void PlayPickedUpSfxForRuneGroup(RuneGroup inGroup); // 0x0000000180FDAE50-0x0000000180FDB0B0
	public void OnRuneGroupReleased(RuneGroup inGroup); // 0x0000000180FD96E0-0x0000000180FD9E30
	public void OnRunePiecePlaced(List<HexCoord> inDropCoords, RuneGroup inDroppedPiece); // 0x0000000180FD9E30-0x0000000180FDA9E0
	private void OnTileScored(HexTile inTile); // 0x0000000180FDA9E0-0x0000000180FDAE50
	private void AddTotalScore(int inScore); // 0x0000000180FD55A0-0x0000000180FD5770
	private void OnCycloneRunePlaced(HexTile inCycloneTile); // 0x0000000180FD86F0-0x0000000180FD8F30
	private void OnCycloneRuneCollected(HexTile inCycloneTile, int inNewTileScore); // 0x0000000180FD8460-0x0000000180FD86F0
	private void OnPowerUpBombPlaced(HexTile inBombTile); // 0x0000000180FD8F30-0x0000000180FD9310
	private List<HexTile> FindConnectedTiles(HexTile inTile, bool includeSelf = true /* Metadata: 0x00783738 */); // 0x0000000180FD7700-0x0000000180FD7AB0
	public void ReplaceDroppedPiece(RuneGroup inGroup); // 0x0000000180FDB0B0-0x0000000180FDB270
	private RuneGroup CreateRunePiece(); // 0x0000000180FD6EE0-0x0000000180FD71E0
	private RuneGroup CreatePowerUpRunePiece(RuneType inPowerUpType); // 0x0000000180FD6E00-0x0000000180FD6EE0
	private RuneGroup CreateTutorialPiece(TutorialSteps inTutorialStep); // 0x0000000180FD71E0-0x0000000180FD7460
	private void IncreasePowerUpMeterValue(int inIncrease); // 0x0000000180FD83C0-0x0000000180FD8460
	private void OnPowerUpMeterFull(); // 0x0000000180FD9310-0x0000000180FD93F0
	private void UpdatePowerUpMeter(bool forceUpdate = false /* Metadata: 0x00783739 */); // 0x0000000180FDD020-0x0000000180FDD3F0
	public static RuneType ConvertCycloneToStandardType(RuneType inCycloneType); // 0x0000000180FD6DA0-0x0000000180FD6DD0
	public static RuneType ConvertStandardToCycloneType(RuneType inStandardType); // 0x0000000180FD6DD0-0x0000000180FD6E00
	private void AddLevelReached(RuneType inRuneType); // 0x0000000180FD5320-0x0000000180FD55A0
	private void ExplodeTile(HexTile inTile); // 0x0000000180FD7550-0x0000000180FD7700
	private void ActivatePowerUpFx(); // 0x0000000180FD5240-0x0000000180FD5320
	private void DeactivatePowerUpFx(bool inPickedup); // 0x0000000180FD7460-0x0000000180FD7550
	private void GoToTutorialStep(TutorialSteps inStep, float inTransitionDelay = 0f /* Metadata: 0x0078373A */); // 0x0000000180FD7DC0-0x0000000180FD8130
	private void HandleCleanupStep(TutorialSteps inStep); // 0x0000000180FD8130-0x0000000180FD8220
	private void HandleSetupStep(TutorialSteps inStep); // 0x0000000180FD8220-0x0000000180FD83C0
	private void SpawnTutorialPieceForStep(TutorialSteps inStep); // 0x0000000180FDBE50-0x0000000180FDBF00
	private bool CanPlacePieceInTutorialStep(TutorialSteps inStep); // 0x0000000180FD5770-0x0000000180FD5790
	private List<HexCoord> GetDropCoordsForTutorialStep(TutorialSteps inStep); // 0x0000000180FD7AD0-0x0000000180FD7CD0
	private void SetTutorialStepActive(TutorialSteps inTutorialStep, bool inActive); // 0x0000000180FDBA30-0x0000000180FDBCC0
	private void ClearTutorialObjects(); // 0x0000000180FD6AE0-0x0000000180FD6DA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CheckForLoseCondition>b__82_1(); // 0x0000000180FD7AB0-0x0000000180FD7AD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnRuneGroupReleased>b__88_0(); // 0x0000000180FDC0F0-0x0000000180FDC100
}

