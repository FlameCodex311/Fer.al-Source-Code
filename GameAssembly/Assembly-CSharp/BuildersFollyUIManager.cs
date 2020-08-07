/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyUIManager : MonoBehaviour // TypeDefIndex: 10505
{
	// Fields
	public Camera uICamera; // 0x20
	public Canvas hudCanvas; // 0x28
	public Color starColorFilled; // 0x30
	public Color starColorUnfilled; // 0x40
	public Color UIBlue; // 0x50
	public Color buttonColorHighlighted; // 0x60
	public Color buttonColorNormal; // 0x70
	public Color rewardsColorMystery; // 0x80
	public float infoPopUpTime; // 0x90
	public float starPulseTime; // 0x94
	public float starPulseScale; // 0x98
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public BuildersFollyUI_Tutorial tutorialScreen; // 0xA0
	public BuildersFollyUI_Tutorial tutorialExpertScreen; // 0xA8
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject splashScreen; // 0xB0
	public BuildersFollyUI_LevelSelect levelSelectScreen; // 0xB8
	public GameObject gameHUD; // 0xC0
	public GameObject rewardScreen; // 0xC8
	public GameObject exitGame; // 0xD0
	public GameObject exitGameGuidedButtonsBlocker; // 0xD8
	public GameObject exitGameResetButtonBlocker; // 0xE0
	public GameObject HideDuringGameplay; // 0xE8
	public GameObject devTools; // 0xF0
	public GameObject infoWindow; // 0xF8
	public GameObject infoWindowDeleteStation; // 0x100
	public GameObject playButton; // 0x108
	public GameObject fastForwardButton_normal; // 0x110
	public GameObject fastForwardButton_active; // 0x118
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject cutStationButtonMask; // 0x120
	public GameObject sewStationButtonMask; // 0x128
	public GameObject buildStationButtonMask; // 0x130
	public GameObject kilnStationButtonMask; // 0x138
	public GameObject dyeStationButtonMask; // 0x140
	public UI_ColorizedIcon cutStationIcon; // 0x148
	public UI_ColorizedIcon sewStationIcon; // 0x150
	public UI_ColorizedIcon buildStationIcon; // 0x158
	public UI_ColorizedIcon kilnStationIcon; // 0x160
	public UI_ColorizedIcon dyeStationIcon; // 0x168
	public Rectangle cutStationBKG; // 0x170
	public Rectangle sewStationBKG; // 0x178
	public Rectangle buildStationBKG; // 0x180
	public Rectangle kilnStationBKG; // 0x188
	public Rectangle dyeStationBKG; // 0x190
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public float goalsListSpaceing; // 0x198
	public GameObject goalsList; // 0x1A0
	public RectTransform goalsListBKG; // 0x1A8
	public BuildersFollyUI_GoalListItem goalsListItem; // 0x1B0
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public Sprite resourceImage_NONE; // 0x1B8
	public WWTextMeshProUGUI infoWindow_name; // 0x1C0
	public GameObject infoWindow_stationInfo; // 0x1C8
	public WWTextMeshProUGUI infoWindow_inputInfo; // 0x1D0
	public WWImage infoWindow_inputImage; // 0x1D8
	public WWTextMeshProUGUI infoWindow_outputInfo; // 0x1E0
	public WWImage infoWindow_outputImage; // 0x1E8
	public GameObject infoWindow_stationOptions; // 0x1F0
	public GameObject infoWindow_colorOptions; // 0x1F8
	public UI_ColorizedIcon infoWindow_colorIndicator; // 0x200
	public WWButton[] infoWindow_colors; // 0x208
	public GameObject infoWindow_buildStationInfo; // 0x210
	public WWTextMeshProUGUI infoWindow_buildStationInputInfo1; // 0x218
	public WWImage infoWindow_buildStationInputImage1; // 0x220
	public WWTextMeshProUGUI infoWindow_buildStationInputInfo2; // 0x228
	public WWImage infoWindow_buildStationInputImage2; // 0x230
	public WWTextMeshProUGUI infoWindow_buildStationOutputInfo; // 0x238
	public WWImage infoWindow_buildStationOutputImage; // 0x240
	public GameObject infoWindow_resourceInfo; // 0x248
	public WWImage infoWindow_resourceImage; // 0x250
	public WWTextMeshProUGUI infoWindow_resourceDescription; // 0x258
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject rewardScreenTitle_PickReward; // 0x260
	public GameObject rewardScreenTitle_NoStars; // 0x268
	public GameObject rewardScreenNextLevelButtonInactive; // 0x270
	public GameObject rewardScreenFinishedOptions; // 0x278
	public UI_ColorizedIcon rewardTierHalfStar; // 0x280
	public UI_ColorizedIcon rewardTier1Star; // 0x288
	public UI_ColorizedIcon rewardTier1HalfStar; // 0x290
	public UI_ColorizedIcon rewardTier2Star; // 0x298
	public UI_ColorizedIcon rewardTier2HalfStar; // 0x2A0
	public UI_ColorizedIcon rewardTier3Star; // 0x2A8
	public TextMeshProUGUI rewardsTier1Text; // 0x2B0
	public TextMeshProUGUI rewardsTier2Text; // 0x2B8
	public TextMeshProUGUI rewardsTier3Text; // 0x2C0
	public RawImage rewardsTier1Image; // 0x2C8
	public RawImage rewardsTier2Image; // 0x2D0
	public RawImage rewardsTier3Image; // 0x2D8
	public UI_ColorizedIcon reward1ImageFill; // 0x2E0
	public UI_ColorizedIcon reward2ImageFill; // 0x2E8
	public UI_ColorizedIcon reward3ImageFill; // 0x2F0
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject broomPopUp; // 0x2F8
	public RectTransform pathDelete; // 0x300
	public GameObject tut_intro; // 0x308
	public GameObject tut_showGoals; // 0x310
	public GameObject tut_showResources; // 0x318
	public GameObject tut_showResourceCounters; // 0x320
	public GameObject tut_showLogs; // 0x328
	public GameObject tut_clickDragLogPathOBJ; // 0x330
	public GameObject tut_clickDragLogPath; // 0x338
	public GameObject tut_clickPlay1; // 0x340
	public GameObject tut_tutorialComplete1; // 0x348
	public GameObject tut_showCutStation; // 0x350
	public GameObject tut_clickDragStation; // 0x358
	public GameObject tut_dragStationOBJ; // 0x360
	public GameObject tut_showRotate; // 0x368
	public GameObject tut_showFlip; // 0x370
	public GameObject tut_clickDragResource; // 0x378
	public GameObject tut_dragResourcePathOBJ; // 0x380
	public GameObject tut_showStationInfo; // 0x388
	public GameObject tut_showInput; // 0x390
	public GameObject tut_showOutput; // 0x398
	public GameObject tut_showOptionArrows; // 0x3A0
	public GameObject tut_drawNextPath; // 0x3A8
	public GameObject tut_dragStationPathOBJ; // 0x3B0
	public GameObject tut_clickPlay2; // 0x3B8
	public GameObject tut_tutorialComplete2; // 0x3C0
	public GameObject tileEditButtons; // 0x3C8
	public GameObject stationOptionButtons; // 0x3D0
	public WWTextMeshProUGUI levelName; // 0x3D8
	public RectTransform resourceBKG; // 0x3E0
	public BuildersFollyUI_ResoureDisplay resourceDisplay; // 0x3E8
	public float resourceXpadding; // 0x3F0
	public float resourceFrameXpadding; // 0x3F4
	public GameObject recipeWindow; // 0x3F8
	public GameObject recipeWindowBackButton; // 0x400
	public BuildersFollyUI_Recipe buildRecipe; // 0x408
	public BuildersFollyUI_Recipe stationRecipe; // 0x410
	public BuildersFollyUI_Recipe resourceRecipe; // 0x418
	public GameObject expertButton; // 0x420
	internal BuildersFollyTile infoTile; // 0x428
	internal List<BuildersFollyUI_ResoureDisplay> resoureDisplayList; // 0x430
	private Sprite _buildStationSprite; // 0x438
	private Sprite _cutStationSprite; // 0x440
	private Sprite _sewStationSprite; // 0x448
	private Sprite _kilnStationSprite; // 0x450
	private List<BuildersFollyUI_GoalListItem> _goalsLists; // 0x458
	private List<BuildersFollyResource> _recipeResources; // 0x460
	private RectTransform _canvasRect; // 0x468
	private Vector3 _infoPopUpEndScale; // 0x470
	private Vector3 _infoPopUpEndPosition; // 0x47C
	private Vector3 _rewardTierStarStartScale; // 0x488
	private bool _autoLevelSelect; // 0x494
	private bool _autoExit; // 0x495
	private int _tutorialPage; // 0x498
	private float _goalsListBKGHieght; // 0x49C
	private BuildersFollyGame.EgameState _cachedGameState; // 0x4A0
	private BuildersFollyInputManager.ETileMode _priorTileMode; // 0x4A4
	private BuildersFollyStationTile _selectedStation; // 0x4A8
	private Texture _cachedMysteryTexture; // 0x4B0
	private BuildersFollyGame _game; // 0x4B8
	private BuildersFollyInputManager _inputManager; // 0x4C0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PulseTransform>d__178 : IEnumerator<object> // TypeDefIndex: 10506
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyUIManager <>4__this; // 0x20
		public Vector3 inStartScale; // 0x28
		public Transform inTrans; // 0x38
		private float <halfTime>5__2; // 0x40
		private Vector3 <startScale>5__3; // 0x44
		private Vector3 <endScale>5__4; // 0x50
		private float <t>5__5; // 0x5C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PulseTransform>d__178(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804A8540-0x00000001804A88D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804A88D0-0x00000001804A8920
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InfoWindowPopUp>d__179 : IEnumerator<object> // TypeDefIndex: 10507
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyUIManager <>4__this; // 0x20
		public Vector3 inPos; // 0x28
		private float <t>5__2; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InfoWindowPopUp>d__179(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804A7B30-0x00000001804A7FC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804A7FC0-0x00000001804A8010
	}

	// Constructors
	public BuildersFollyUIManager(); // 0x0000000180AC99B0-0x0000000180AC9AA0

	// Methods
	internal void Init(); // 0x0000000180AC1E60-0x0000000180AC2720
	private void OnDestroy(); // 0x0000000180AC29A0-0x0000000180AC2A30
	private void OnBackButton(); // 0x0000000180AC2720-0x0000000180AC29A0
	private void InitGoalsList(); // 0x0000000180AC0650-0x0000000180AC0DF0
	internal void UpdateGoalListStars(); // 0x0000000180AC7330-0x0000000180AC84B0
	internal void InitResources(); // 0x0000000180AC1030-0x0000000180AC1E60
	internal void UpdateResourcesAmount(); // 0x0000000180AC84B0-0x0000000180AC8A30
	private void ShowSplashScreen(bool inShow); // 0x0000000180AC6880-0x0000000180AC6920
	internal void ShowInfoWindow(bool inShow, BuildersFollyTile inTile = null); // 0x0000000180AC41E0-0x0000000180AC5050
	private void DyeStationColorSet(BuildersFollyTile inDyeStationTile); // 0x0000000180ABFD80-0x0000000180AC0030
	internal string GetColorText(BuildersFollyLevel_Scriptable.BuildersFollyGoal inGoal); // 0x0000000180AC0030-0x0000000180AC0160
	private string GetColorText(BuildersFollyStationTile inTile, bool inOutput, int inIndex = 0 /* Metadata: 0x0077BD5A */); // 0x0000000180AC0160-0x0000000180AC0510
	internal void UpdateStationInfo(BuildersFollyStationTile inStationTile, bool inLeft = true /* Metadata: 0x0077BD5E */); // 0x0000000180AC8A30-0x0000000180AC99B0
	internal Sprite GetStationIconSprite(BuildersFollyData.EStationType inRequiredStation); // 0x0000000180AC0510-0x0000000180AC05D0
	internal void ShowPathDelete(bool inShow); // 0x0000000180AC50D0-0x0000000180AC5340
	internal void ShowWalkthroughPopup(); // 0x0000000180AC6C40-0x0000000180AC72D0
	internal void ShowHUD(bool inShow); // 0x0000000180AC40A0-0x0000000180AC4150
	private void ShowHideDuringGameplay(bool inPlay); // 0x0000000180AC4150-0x0000000180AC41E0
	internal void ShowLevelSelect(bool inShow); // 0x0000000180AC5050-0x0000000180AC50D0
	internal void ShowRewardScreen(bool inShow); // 0x0000000180AC5890-0x0000000180AC6880
	private void RewardScreenTierUpdate(int inTier); // 0x0000000180AC2D70-0x0000000180AC3D60
	internal void RewardCollected(); // 0x0000000180AC2C70-0x0000000180AC2D70
	private void ShowExitGame(bool inShow); // 0x0000000180AC3F50-0x0000000180AC4070
	private void ShowTutorialPage(); // 0x0000000180AC6920-0x0000000180AC6A10
	internal void ShowTutorial(bool inShow); // 0x0000000180AC6A10-0x0000000180AC6C40
	private void ShowGoalsList(bool inShow); // 0x0000000180AC4070-0x0000000180AC40A0
	private void ShowBroomPopUp(bool inShow); // 0x0000000180AC3EC0-0x0000000180AC3F50
	private void ResetResources(); // 0x0000000180AC2AC0-0x0000000180AC2C70
	private void SetGameRunning(); // 0x0000000180AC3D60-0x0000000180AC3EC0
	internal void CleanupLevel(); // 0x0000000180ABFBB0-0x0000000180ABFD80
	internal void TileModeChq(); // 0x0000000180AC72D0-0x0000000180AC7320
	[IteratorStateMachine] // 0x000000018020B850-0x000000018020B8A0
	internal IEnumerator PulseTransform(Transform inTrans, Vector3 inStartScale); // 0x0000000180AC2A30-0x0000000180AC2AC0
	[IteratorStateMachine] // 0x000000018020BB60-0x000000018020BBB0
	private IEnumerator InfoWindowPopUp(Vector3 inPos); // 0x0000000180AC05D0-0x0000000180AC0650
	private void InitRecipeIcon(BuildersFollyUI_RecipeIcon inRecipeIcon, BuildersFollyResource inResource); // 0x0000000180AC0DF0-0x0000000180AC1030
	internal void ShowRecipe(BuildersFollyResource inGoalResouorce, bool inReversing = false /* Metadata: 0x0077BD5F */); // 0x0000000180AC5450-0x0000000180AC5890
	internal void ShowRecipe(bool inShow, BuildersFollyLevel_Scriptable.BuildersFollyGoal inBuildersFollyGoal = null); // 0x0000000180AC5340-0x0000000180AC5450
	public void BtnClicked_ToggleExpertMode(); // 0x0000000180ABFAE0-0x0000000180ABFB50
	public void BtnClicked_RecipieBack(); // 0x0000000180ABF100-0x0000000180ABF1A0
	public void BtnClicked_RecipeClosed(); // 0x0000000180ABF060-0x0000000180ABF100
	public void BtnClicked_RewardScreenNextLevel(); // 0x0000000180ABF350-0x0000000180ABF530
	public void BtnClicked_RewardScreenLevelSelect(); // 0x0000000180ABF2A0-0x0000000180ABF350
	public void BtnClicked_RewardScreenReplay(); // 0x0000000180ABF530-0x0000000180ABF590
	public void BtnClicked_TileRotate(); // 0x0000000180ABFA40-0x0000000180ABFAE0
	public void BtnClicked_TileFlip(bool inHorizontal); // 0x0000000180ABF930-0x0000000180ABFA40
	public void BtnClicked_SplashScreenStart(); // 0x0000000180ABF610-0x0000000180ABF8F0
	public void BtnClicked_StartTutorial(); // 0x0000000180ABF8F0-0x0000000180ABF930
	public void BtnClicked_TutorialNextPage(); // 0x0000000180ABFB90-0x0000000180ABFBB0
	public void BtnClicked_TutorialClose(); // 0x0000000180ABFB50-0x0000000180ABFB90
	public void BtnClicked_LevelSelectStart(); // 0x0000000180ABE300-0x0000000180ABE960
	public void BtnClicked_CloseGoalsList(); // 0x0000000180ABD580-0x0000000180ABD5B0
	public void BtnClicked_GameX(); // 0x0000000180ABDF40-0x0000000180ABDFA0
	public void BtnClicked_ExitGame(); // 0x0000000180ABD9F0-0x0000000180ABDA20
	public void BtnClicked_ExitLevel(); // 0x0000000180ABDA20-0x0000000180ABDC50
	public void BtnClicked_ExitCancel(); // 0x0000000180ABD940-0x0000000180ABD9F0
	public void BtnClicked_ExitReset(); // 0x0000000180ABDC50-0x0000000180ABDF40
	public void BtnClicked_OpenLevelSelect(); // 0x0000000180ABEA00-0x0000000180ABEC30
	public void BtnClicked_Save(); // 0x0000000180ABF590-0x0000000180ABF610
	public void BtnClicked_ResetGrid(); // 0x0000000180ABF1A0-0x0000000180ABF2A0
	public void BtnClicked_LevelSuccessReward(); // 0x0000000180ABE960-0x0000000180ABEA00
	public void BtnClicked_BroomPopUpOK(); // 0x0000000180ABD330-0x0000000180ABD4B0
	public void BtnClicked_BroomPopUpCancel(); // 0x0000000180ABD300-0x0000000180ABD330
	public void BtnClicked_Broom(); // 0x0000000180ABD4B0-0x0000000180ABD580
	public void BtnClicked_PlayAndFastForward(); // 0x0000000180ABEC30-0x0000000180ABF060
	public void BtnClicked_InfoOption(bool inLeft); // 0x0000000180ABDFA0-0x0000000180ABE200
	public void BtnClicked_ColorSelect(int inIndex); // 0x0000000180ABD5B0-0x0000000180ABD940
	public void BtnClicked_DBG(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_InfoWindowDeleteStation(); // 0x0000000180ABE200-0x0000000180ABE300
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RewardCollected>b__168_0(); // 0x0000000180AC7320-0x0000000180AC7330
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RewardCollected>b__168_1(); // 0x0000000180ABD9F0-0x0000000180ABDA20
}

