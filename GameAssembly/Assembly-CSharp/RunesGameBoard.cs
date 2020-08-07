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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RunesGameBoard : MonoBehaviour // TypeDefIndex: 10826
{
	// Fields
	public RunesGame game; // 0x20
	public HexTile runeTilePrefab; // 0x28
	public RuneGroup runeGroupPrefab; // 0x30
	public HexGrid runeGrid; // 0x38
	public float pickUpTimer; // 0x40
	public float dragThreshold; // 0x44
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject tutorialContainer; // 0x48
	[EnumList] // 0x00000001801D3EE0-0x00000001801D3F40
	public List<GameObject> tutorialObjects; // 0x50
	[EnumList] // 0x00000001801D42C0-0x00000001801D4320
	public List<GameObject> tutorialUISteps; // 0x58
	[Header] // 0x00000001801D46E0-0x00000001801D4710
	public List<RuneSpawnPoint> spawns; // 0x60
	public RuneSpawnPoint tutorialSpawn; // 0x68
	public Transform rightSideSpawnContainer; // 0x70
	public Transform rightSideSpawnLocation4x3; // 0x78
	[Header] // 0x00000001801D4990-0x00000001801D49C0
	public RuneSpawnPoint powerUpSpawn; // 0x80
	public int comboLevel1; // 0x88
	public int comboLevel2; // 0x8C
	[Range] // 0x00000001801D4BD0-0x00000001801D4BF0
	public int powerUpMeter; // 0x90
	public float powerUpMeterAnimSpeed; // 0x94
	public float powerUpMeterTutorialAnimSpeed; // 0x98
	public Animator powerUpMeterAnimator; // 0xA0
	[Header] // 0x00000001801CF440-0x00000001801CF470
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ObscuredInt <Score>k__BackingField; // 0x178
	private ObscuredInt _prevScoreSent; // 0x18C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ObscuredLong <HighScore>k__BackingField; // 0x1A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsPowerupMeterAnimating>k__BackingField; // 0x1C8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <TutorialOn>k__BackingField; // 0x1C9
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TutorialSteps <TutorialStep>k__BackingField; // 0x1CC
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TutorialSteps <NextTutorialStep>k__BackingField; // 0x1D0
	private List<HexTile> _tempCycloneTiles; // 0x1D8
	private List<RuneType> _standardRuneTypesList; // 0x1E0

	// Properties
	public ObscuredInt Score { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180739250-0x0000000180739270 0x00000001807392E0-0x0000000180739300
	public ObscuredLong HighScore { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180739200-0x0000000180739230 0x0000000180739290-0x00000001807392C0
	public bool IsPowerupMeterAnimating { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180739230-0x0000000180739240 0x00000001807392C0-0x00000001807392D0
	public bool CanPickPieceUp { get; } // 0x00000001807390C0-0x0000000180739200 
	public bool TutorialOn { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180739270-0x0000000180739280 0x0000000180739300-0x0000000180739310
	public TutorialSteps TutorialStep { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180739280-0x0000000180739290 0x0000000180739310-0x0000000180739320
	public TutorialSteps NextTutorialStep { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180739240-0x0000000180739250 0x00000001807392D0-0x00000001807392E0

	// Nested types
	public enum TutorialSteps // TypeDefIndex: 10827
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10828
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__83_2; // 0x08
		public static TweenCallback <>9__83_0; // 0x10
		public static TweenCallback <>9__94_1; // 0x18
		public static TweenCallback <>9__94_2; // 0x20

		// Constructors
		static <>c(); // 0x000000018074A760-0x000000018074A7C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <CheckForLoseCondition>b__83_2(); // 0x00000001807300F0-0x00000001807301A0
		internal void <CheckForLoseCondition>b__83_0(); // 0x000000018072FB70-0x000000018072FC20
		internal void <OnCycloneRunePlaced>b__94_1(); // 0x000000018072F3E0-0x000000018072F490
		internal void <OnCycloneRunePlaced>b__94_2(); // 0x000000018072F280-0x000000018072F330
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass90_0 // TypeDefIndex: 10829
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public RuneGroup inDroppedPiece; // 0x18
		public List<HexTile> scoreTiles; // 0x20

		// Constructors
		public <>c__DisplayClass90_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnRunePiecePlaced>b__0(); // 0x000000018074A120-0x000000018074A150
		internal void <OnRunePiecePlaced>b__1(); // 0x000000018074A150-0x000000018074A6D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass94_0 // TypeDefIndex: 10830
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public HexTile inCycloneTile; // 0x18
		public int newTileScore; // 0x20

		// Constructors
		public <>c__DisplayClass94_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnCycloneRunePlaced>b__0(); // 0x000000018074A6D0-0x000000018074A700
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass112_0 // TypeDefIndex: 10831
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public TutorialSteps inStep; // 0x18

		// Constructors
		public <>c__DisplayClass112_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GoToTutorialStep>b__0(); // 0x0000000180749960-0x0000000180749990
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass114_0 // TypeDefIndex: 10832
	{
		// Fields
		public RunesGameBoard <>4__this; // 0x10
		public TutorialSteps inStep; // 0x18

		// Constructors
		public <>c__DisplayClass114_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <HandleSetupStep>b__0(); // 0x0000000180749990-0x00000001807499C0
		internal void <HandleSetupStep>b__1(); // 0x00000001807499C0-0x00000001807499F0
	}

	// Constructors
	public RunesGameBoard(); // 0x0000000180738F20-0x00000001807390C0

	// Methods
	private void Start(); // 0x0000000180737860-0x0000000180737A50
	public void SetGameData(RunesDataDefComponent inGameData); // 0x00000001807370D0-0x0000000180737390
	private int GetLevelThreshold(int inLevelIndex); // 0x0000000180733800-0x00000001807338E0
	public void ResetBoard(); // 0x0000000180736BC0-0x00000001807370D0
	public void SpawnAll(); // 0x0000000180737620-0x00000001807377B0
	private void Update(); // 0x0000000180738F00-0x0000000180738F20
	private void UpdateTutorial(); // 0x0000000180738D40-0x0000000180738F00
	private void UpdateBoard(); // 0x0000000180737A70-0x0000000180738980
	private void CheckForLoseCondition(); // 0x0000000180731160-0x0000000180731ED0
	private void GameOver(); // 0x0000000180733430-0x0000000180733600
	private void ClearScores(); // 0x0000000180732280-0x00000001807324A0
	public void ClearBoard(); // 0x0000000180731ED0-0x0000000180732280
	public void OnRuneGroupPressed(RuneGroup inGroup); // 0x0000000180734D60-0x00000001807350D0
	private void PlayPickedUpSfxForRuneGroup(RuneGroup inGroup); // 0x00000001807367B0-0x0000000180736A10
	public void OnRuneGroupReleased(RuneGroup inGroup); // 0x00000001807350D0-0x0000000180735810
	public void OnRunePiecePlaced(List<HexCoord> inDropCoords, RuneGroup inDroppedPiece); // 0x0000000180735810-0x0000000180736380
	private void OnTileScored(HexTile inTile); // 0x0000000180736380-0x00000001807367B0
	private void AddTotalScore(int inScore); // 0x0000000180730F90-0x0000000180731140
	private void OnCycloneRunePlaced(HexTile inCycloneTile); // 0x0000000180734090-0x00000001807348B0
	private void OnCycloneRuneCollected(HexTile inCycloneTile, int inNewTileScore); // 0x0000000180733E00-0x0000000180734090
	private void OnPowerUpBombPlaced(HexTile inBombTile); // 0x00000001807348B0-0x0000000180734C80
	private List<HexTile> FindConnectedTiles(HexTile inTile, bool includeSelf = true /* Metadata: 0x0077C1F3 */); // 0x0000000180733090-0x0000000180733430
	public void ReplaceDroppedPiece(RuneGroup inGroup); // 0x0000000180736A10-0x0000000180736BC0
	private RuneGroup CreateRunePiece(); // 0x0000000180732890-0x0000000180732B80
	private RuneGroup CreatePowerUpRunePiece(RuneType inPowerUpType); // 0x00000001807327B0-0x0000000180732890
	private RuneGroup CreateTutorialPiece(TutorialSteps inTutorialStep); // 0x0000000180732B80-0x0000000180732DF0
	private void IncreasePowerUpMeterValue(int inIncrease); // 0x0000000180733D60-0x0000000180733E00
	private void OnPowerUpMeterFull(); // 0x0000000180734C80-0x0000000180734D60
	private void UpdatePowerUpMeter(bool forceUpdate = false /* Metadata: 0x0077C1F4 */); // 0x0000000180738980-0x0000000180738D40
	public static RuneType ConvertCycloneToStandardType(RuneType inCycloneType); // 0x0000000180732750-0x0000000180732780
	public static RuneType ConvertStandardToCycloneType(RuneType inStandardType); // 0x0000000180732780-0x00000001807327B0
	private void AddLevelReached(RuneType inRuneType); // 0x0000000180730D20-0x0000000180730F90
	private void ExplodeTile(HexTile inTile); // 0x0000000180732EE0-0x0000000180733090
	private void ActivatePowerUpFx(); // 0x0000000180730C40-0x0000000180730D20
	private void DeactivatePowerUpFx(bool inPickedup); // 0x0000000180732DF0-0x0000000180732EE0
	private void GoToTutorialStep(TutorialSteps inStep, float inTransitionDelay = 0f /* Metadata: 0x0077C1F5 */); // 0x00000001807338E0-0x0000000180733AD0
	private void HandleCleanupStep(TutorialSteps inStep); // 0x0000000180733AD0-0x0000000180733BD0
	private void HandleSetupStep(TutorialSteps inStep); // 0x0000000180733BD0-0x0000000180733D60
	private void SpawnTutorialPieceForStep(TutorialSteps inStep); // 0x00000001807377B0-0x0000000180737860
	private bool CanPlacePieceInTutorialStep(TutorialSteps inStep); // 0x0000000180731140-0x0000000180731160
	private List<HexCoord> GetDropCoordsForTutorialStep(TutorialSteps inStep); // 0x0000000180733600-0x0000000180733800
	private void SetTutorialStepActive(TutorialSteps inTutorialStep, bool inActive); // 0x0000000180737390-0x0000000180737620
	private void ClearTutorialObjects(); // 0x00000001807324A0-0x0000000180732750
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CheckForLoseCondition>b__83_1(); // 0x0000000180737A50-0x0000000180737A60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnRuneGroupReleased>b__89_0(); // 0x0000000180737A60-0x0000000180737A70
}

