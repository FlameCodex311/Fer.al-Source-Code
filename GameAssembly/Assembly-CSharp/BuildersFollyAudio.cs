/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyAudio : MonoBehaviour // TypeDefIndex: 12783
{
	// Fields
	private static BuildersFollyAudio _instance; // 0x00
	[Tooltip] // 0x000000018011D950-0x000000018011D980
	public FeralAudioInfo splashMusic; // 0x20
	[Tooltip] // 0x000000018011DAD0-0x000000018011DB00
	public FeralAudioInfo musicPlay; // 0x28
	[Tooltip] // 0x000000018011DCE0-0x000000018011DD10
	public FeralAudioInfo musicSetup; // 0x30
	[Space] // 0x000000018011DE50-0x000000018011DEA0
	[Tooltip] // 0x000000018011DE50-0x000000018011DEA0
	public FeralAudioInfo deliverBoxGears; // 0x38
	[Tooltip] // 0x000000018011E0A0-0x000000018011E0D0
	public FeralAudioInfo stationDyeCooking; // 0x40
	[Tooltip] // 0x000000018011E310-0x000000018011E340
	public FeralAudioInfo stationBuildHammer; // 0x48
	[Tooltip] // 0x000000018011E490-0x000000018011E4C0
	public FeralAudioInfo stationKiln; // 0x50
	[Tooltip] // 0x000000018011E690-0x000000018011E6C0
	public FeralAudioInfo stationCutSaw; // 0x58
	[Tooltip] // 0x000000018011E840-0x000000018011E870
	public FeralAudioInfo stationSew; // 0x60
	[Tooltip] // 0x000000018011EA70-0x000000018011EAA0
	public FeralAudioInfo stingerDelivered01; // 0x68
	[Tooltip] // 0x000000018011EC20-0x000000018011EC50
	public FeralAudioInfo stingerDelivered02; // 0x70
	[Tooltip] // 0x000000018011EDE0-0x000000018011EE10
	public FeralAudioInfo stingerStationPoints; // 0x78
	[Tooltip] // 0x000000018011F030-0x000000018011F060
	public FeralAudioInfo stationRemovedDeselect; // 0x80
	[Tooltip] // 0x000000018011F1C0-0x000000018011F1F0
	public FeralAudioInfo buttonStationSelect; // 0x88
	[Tooltip] // 0x000000018011F360-0x000000018011F390
	public FeralAudioInfo stationPlaced; // 0x90
	[Tooltip] // 0x000000018011F710-0x000000018011F740
	public FeralAudioInfo buttonClear; // 0x98
	[Tooltip] // 0x000000018011F870-0x000000018011F8A0
	public FeralAudioInfo tilePlaced; // 0xA0
	[Tooltip] // 0x000000018011FA70-0x000000018011FAA0
	public FeralAudioInfo buttonTileSelect; // 0xA8
	[Tooltip] // 0x000000018011FC40-0x000000018011FC70
	public FeralAudioInfo buttonBroom; // 0xB0
	[Tooltip] // 0x000000018011FD70-0x000000018011FDA0
	private ParamRef[] musicParam; // 0xB8
	public FeralAudioInfo buttonForward; // 0xC0
	[Tooltip] // 0x000000018011FEC0-0x000000018011FEF0
	public FeralAudioInfo buttonNormal; // 0xC8
	[Tooltip] // 0x0000000180120120-0x0000000180120150
	public FeralAudioInfo buttonReward; // 0xD0
	[Tooltip] // 0x00000001801203D0-0x0000000180120400
	public FeralAudioInfo stingerChooseReward; // 0xD8
	[Tooltip] // 0x0000000180120560-0x0000000180120590
	public FeralAudioInfo buttonReset; // 0xE0
	[Tooltip] // 0x0000000180120710-0x0000000180120740
	public FeralAudioInfo buttonNext; // 0xE8
	[Tooltip] // 0x0000000180121BE0-0x0000000180121C10
	public FeralAudioInfo buttonStartPlay; // 0xF0
	[Tooltip] // 0x0000000180121E80-0x0000000180121EB0
	public FeralAudioInfo buttonOk; // 0xF8
	[Tooltip] // 0x0000000180122030-0x0000000180122060
	public FeralAudioInfo buttonExit; // 0x100
	[Tooltip] // 0x0000000180122290-0x00000001801222C0
	public FeralAudioInfo buttonGoalsList; // 0x108
	[Tooltip] // 0x00000001801223C0-0x00000001801223F0
	public FeralAudioInfo stationRotate; // 0x110
	[Tooltip] // 0x0000000180122520-0x0000000180122550
	public FeralAudioInfo stingerScoreBar; // 0x118
	[Tooltip] // 0x0000000180122750-0x0000000180122780
	public FeralAudioInfo tutorialButton; // 0x120
	[Tooltip] // 0x00000001801228F0-0x0000000180122920
	public FeralAudioInfo buttonChoose; // 0x128
	[Tooltip] // 0x0000000180122AC0-0x0000000180122AF0
	public FeralAudioInfo clearBoard; // 0x130
	[Tooltip] // 0x0000000180122D50-0x0000000180122D80
	public FeralAudioInfo restartStinger; // 0x138
	[Tooltip] // 0x0000000180122E40-0x0000000180122E70
	public FeralAudioInfo ButtonCancel; // 0x140
	[Tooltip] // 0x0000000180124380-0x00000001801243B0
	public FeralAudioInfo levelSelect; // 0x148
	[Tooltip] // 0x0000000180124640-0x0000000180124670
	public FeralAudioInfo materialWiggle; // 0x150
	[Tooltip] // 0x0000000180124780-0x00000001801247B0
	public FeralAudioInfo twiggleSparkle; // 0x158
	[Tooltip] // 0x0000000180124860-0x0000000180124890
	public FeralAudioInfo twiggleSteps; // 0x160
	[Tooltip] // 0x0000000180124970-0x00000001801249A0
	public FeralAudioInfo tapToContinue; // 0x168
	[Tooltip] // 0x0000000180124B00-0x0000000180124B30
	public FeralAudioInfo twiggleSpawn; // 0x170

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001814D2A60-0x00000001814D2AF0 

	// Constructors
	public BuildersFollyAudio(); // 0x00000001814D2970-0x00000001814D2A60

	// Methods
	public static void PlayMusic_Splash(bool inPlay); // 0x00000001814D1B80-0x00000001814D1C70
	public static void PlayMusic_Game(bool inPlay); // 0x00000001814D18B0-0x00000001814D1A90
	public static void PlayMusic_Setup(bool inPlay); // 0x00000001814D1A90-0x00000001814D1B80
	public static void PlayDeliverBoxGears(); // 0x00000001814D1740-0x00000001814D17B0
	public static void PlayStationDyeCooking(); // 0x00000001814D1E80-0x00000001814D1F30
	public static void PlayStationBuildHammer(); // 0x00000001814D1D20-0x00000001814D1DD0
	public static void PlayStationKiln(); // 0x00000001814D1F30-0x00000001814D1FE0
	public static void PlayStationCutSaw(); // 0x00000001814D1DD0-0x00000001814D1E80
	public static void PlayStationSew(); // 0x00000001814D21F0-0x00000001814D22A0
	public static void PlayStingerDelivered01(); // 0x00000001814D2350-0x00000001814D2400
	public static void PlayStingerDelivered02(); // 0x00000001814D2400-0x00000001814D24B0
	public static void PlayStingerStationPoints(); // 0x00000001814D2560-0x00000001814D2610
	public static void PlayStationRemovedDeselect(); // 0x00000001814D2090-0x00000001814D2140
	public static void PlayButtonStationSelect(); // 0x00000001814D1530-0x00000001814D15E0
	public static void PlayStationPlaced(); // 0x00000001814D1FE0-0x00000001814D2090
	public static void PlayButtonClear(); // 0x00000001814D0C90-0x00000001814D0D40
	public static void PlayTilePlaced(); // 0x00000001814D2690-0x00000001814D2740
	public static void PlayButtonTileSelect(); // 0x00000001814D15E0-0x00000001814D1690
	public static void PlayButtonBroom(); // 0x00000001814D0A80-0x00000001814D0B30
	public static void PlayButtonForward(); // 0x00000001814D0DF0-0x00000001814D0F80
	public static void PlayButtonNormal(); // 0x00000001814D10E0-0x00000001814D1270
	public static void PlayButtonReward(); // 0x00000001814D13D0-0x00000001814D1480
	public static void PlayStingerChooseReward(); // 0x00000001814D22A0-0x00000001814D2350
	public static void PlayButtonReset(); // 0x00000001814D1320-0x00000001814D13D0
	public static void PlayButtonNext(); // 0x00000001814D1030-0x00000001814D10E0
	public static void PlayButtonStartPlay(); // 0x00000001814D1480-0x00000001814D1530
	public static void PlayButtonOk(); // 0x00000001814D1270-0x00000001814D1320
	public static void PlayButtonExit(); // 0x00000001814D0D40-0x00000001814D0DF0
	public static void PlayButtonGoalsList(); // 0x00000001814D0F80-0x00000001814D1030
	public static void PlayStationRotate(); // 0x00000001814D2140-0x00000001814D21F0
	public static void PlayStingerScoreBar(); // 0x00000001814D24B0-0x00000001814D2560
	public static void PlayTutorialButton(); // 0x00000001814D2740-0x00000001814D27F0
	public static void PlayButtonChoose(); // 0x00000001814D0BE0-0x00000001814D0C90
	public static void PlayClearBoard(); // 0x00000001814D1690-0x00000001814D1740
	public static void PlayRestartStinger(); // 0x00000001814D1C70-0x00000001814D1D20
	public static void PlayButtonCancel(); // 0x00000001814D0B30-0x00000001814D0BE0
	public static void PlayLevelSelect(); // 0x00000001814D17B0-0x00000001814D1830
	public static void PlayMaterialWiggle(); // 0x00000001814D1830-0x00000001814D18B0
	public static void PlayTwiggleSparkle(); // 0x00000001814D27F0-0x00000001814D2870
	public static void PlayTwiggleSteps(); // 0x00000001814D28F0-0x00000001814D2970
	public static void PlayTapToContinue(); // 0x00000001814D2610-0x00000001814D2690
	public static void PlayTwiggleSpawn(); // 0x00000001814D2870-0x00000001814D28F0
	private void Awake(); // 0x00000001814D0A40-0x00000001814D0A80
}

