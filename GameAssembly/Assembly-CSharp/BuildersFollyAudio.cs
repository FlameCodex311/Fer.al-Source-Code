/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyAudio : MonoBehaviour // TypeDefIndex: 10441
{
	// Fields
	private static BuildersFollyAudio _instance; // 0x00
	[Tooltip] // 0x00000001801EF490-0x00000001801EF4C0
	public FeralAudioInfo splashMusic; // 0x20
	[Tooltip] // 0x00000001801EF5B0-0x00000001801EF5E0
	public FeralAudioInfo musicPlay; // 0x28
	[Tooltip] // 0x00000001801EF6F0-0x00000001801EF720
	public FeralAudioInfo musicSetup; // 0x30
	[Space] // 0x00000001801EF870-0x00000001801EF8C0
	[Tooltip] // 0x00000001801EF870-0x00000001801EF8C0
	public FeralAudioInfo deliverBoxGears; // 0x38
	[Tooltip] // 0x00000001801EFA60-0x00000001801EFA90
	public FeralAudioInfo stationDyeCooking; // 0x40
	[Tooltip] // 0x00000001801EFCC0-0x00000001801EFCF0
	public FeralAudioInfo stationBuildHammer; // 0x48
	[Tooltip] // 0x00000001801EFE50-0x00000001801EFE80
	public FeralAudioInfo stationKiln; // 0x50
	[Tooltip] // 0x00000001801F00D0-0x00000001801F0100
	public FeralAudioInfo stationCutSaw; // 0x58
	[Tooltip] // 0x00000001801F0320-0x00000001801F0350
	public FeralAudioInfo stationSew; // 0x60
	[Tooltip] // 0x00000001801F05F0-0x00000001801F0620
	public FeralAudioInfo stingerDelivered01; // 0x68
	[Tooltip] // 0x00000001801F0890-0x00000001801F08C0
	public FeralAudioInfo stingerDelivered02; // 0x70
	[Tooltip] // 0x00000001801F09F0-0x00000001801F0A20
	public FeralAudioInfo stingerStationPoints; // 0x78
	[Tooltip] // 0x00000001801F0CD0-0x00000001801F0D00
	public FeralAudioInfo stationRemovedDeselect; // 0x80
	[Tooltip] // 0x00000001801F0E30-0x00000001801F0E60
	public FeralAudioInfo buttonStationSelect; // 0x88
	[Tooltip] // 0x00000001801F10C0-0x00000001801F10F0
	public FeralAudioInfo stationPlaced; // 0x90
	[Tooltip] // 0x00000001801F12D0-0x00000001801F1300
	public FeralAudioInfo buttonClear; // 0x98
	[Tooltip] // 0x00000001801F1530-0x00000001801F1560
	public FeralAudioInfo tilePlaced; // 0xA0
	[Tooltip] // 0x00000001801F17A0-0x00000001801F17D0
	public FeralAudioInfo buttonTileSelect; // 0xA8
	[Tooltip] // 0x00000001801F2BE0-0x00000001801F2C10
	public FeralAudioInfo buttonBroom; // 0xB0
	[Tooltip] // 0x00000001801F2D70-0x00000001801F2DA0
	private ParamRef[] musicParam; // 0xB8
	public FeralAudioInfo buttonForward; // 0xC0
	[Tooltip] // 0x00000001801F2FD0-0x00000001801F3000
	public FeralAudioInfo buttonNormal; // 0xC8
	[Tooltip] // 0x00000001801F3200-0x00000001801F3230
	public FeralAudioInfo buttonReward; // 0xD0
	[Tooltip] // 0x00000001801F33F0-0x00000001801F3420
	public FeralAudioInfo stingerChooseReward; // 0xD8
	[Tooltip] // 0x00000001801F3560-0x00000001801F3590
	public FeralAudioInfo buttonReset; // 0xE0
	[Tooltip] // 0x00000001801F37E0-0x00000001801F3810
	public FeralAudioInfo buttonNext; // 0xE8
	[Tooltip] // 0x00000001801F3AA0-0x00000001801F3AD0
	public FeralAudioInfo buttonStartPlay; // 0xF0
	[Tooltip] // 0x00000001801F3F30-0x00000001801F3F60
	public FeralAudioInfo buttonOk; // 0xF8
	[Tooltip] // 0x00000001801F4100-0x00000001801F4130
	public FeralAudioInfo buttonExit; // 0x100
	[Tooltip] // 0x00000001801F4330-0x00000001801F4360
	public FeralAudioInfo buttonGoalsList; // 0x108
	[Tooltip] // 0x00000001801F4580-0x00000001801F45B0
	public FeralAudioInfo stationRotate; // 0x110
	[Tooltip] // 0x00000001801F48B0-0x00000001801F48E0
	public FeralAudioInfo stingerScoreBar; // 0x118
	[Tooltip] // 0x00000001801F4B10-0x00000001801F4B40
	public FeralAudioInfo tutorialButton; // 0x120
	[Tooltip] // 0x00000001801F4F80-0x00000001801F4FB0
	public FeralAudioInfo buttonChoose; // 0x128
	[Tooltip] // 0x00000001801F5190-0x00000001801F51C0
	public FeralAudioInfo clearBoard; // 0x130
	[Tooltip] // 0x00000001801F5480-0x00000001801F54B0
	public FeralAudioInfo restartStinger; // 0x138
	[Tooltip] // 0x00000001801F56C0-0x00000001801F56F0
	public FeralAudioInfo ButtonCancel; // 0x140
	[Tooltip] // 0x00000001801F59B0-0x00000001801F59E0
	public FeralAudioInfo levelSelect; // 0x148
	[Tooltip] // 0x00000001801F5B10-0x00000001801F5B40
	public FeralAudioInfo materialWiggle; // 0x150
	[Tooltip] // 0x00000001801F5D10-0x00000001801F5D40
	public FeralAudioInfo twiggleSparkle; // 0x158
	[Tooltip] // 0x00000001801F72E0-0x00000001801F7310
	public FeralAudioInfo twiggleSteps; // 0x160
	[Tooltip] // 0x00000001801F7520-0x00000001801F7550
	public FeralAudioInfo tapToContinue; // 0x168
	[Tooltip] // 0x00000001801F7790-0x00000001801F77C0
	public FeralAudioInfo twiggleSpawn; // 0x170

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000182133540-0x00000001821335D0 

	// Constructors
	public BuildersFollyAudio(); // 0x0000000182133460-0x0000000182133540

	// Methods
	public static void PlayMusic_Splash(bool inPlay); // 0x00000001821326B0-0x00000001821327A0
	public static void PlayMusic_Game(bool inPlay); // 0x00000001821323F0-0x00000001821325C0
	public static void PlayMusic_Setup(bool inPlay); // 0x00000001821325C0-0x00000001821326B0
	public static void PlayDeliverBoxGears(); // 0x00000001821322A0-0x0000000182132310
	public static void PlayStationDyeCooking(); // 0x00000001821329B0-0x0000000182132A60
	public static void PlayStationBuildHammer(); // 0x0000000182132850-0x0000000182132900
	public static void PlayStationKiln(); // 0x0000000182132A60-0x0000000182132B10
	public static void PlayStationCutSaw(); // 0x0000000182132900-0x00000001821329B0
	public static void PlayStationSew(); // 0x0000000182132D20-0x0000000182132DD0
	public static void PlayStingerDelivered01(); // 0x0000000182132E80-0x0000000182132F30
	public static void PlayStingerDelivered02(); // 0x0000000182132F30-0x0000000182132FE0
	public static void PlayStingerStationPoints(); // 0x0000000182133090-0x0000000182133140
	public static void PlayStationRemovedDeselect(); // 0x0000000182132BC0-0x0000000182132C70
	public static void PlayButtonStationSelect(); // 0x0000000182132090-0x0000000182132140
	public static void PlayStationPlaced(); // 0x0000000182132B10-0x0000000182132BC0
	public static void PlayButtonClear(); // 0x00000001821317F0-0x00000001821318A0
	public static void PlayTilePlaced(); // 0x00000001821331B0-0x0000000182133260
	public static void PlayButtonTileSelect(); // 0x0000000182132140-0x00000001821321F0
	public static void PlayButtonBroom(); // 0x00000001821315E0-0x0000000182131690
	public static void PlayButtonForward(); // 0x0000000182131950-0x0000000182131AE0
	public static void PlayButtonNormal(); // 0x0000000182131C40-0x0000000182131DD0
	public static void PlayButtonReward(); // 0x0000000182131F30-0x0000000182131FE0
	public static void PlayStingerChooseReward(); // 0x0000000182132DD0-0x0000000182132E80
	public static void PlayButtonReset(); // 0x0000000182131E80-0x0000000182131F30
	public static void PlayButtonNext(); // 0x0000000182131B90-0x0000000182131C40
	public static void PlayButtonStartPlay(); // 0x0000000182131FE0-0x0000000182132090
	public static void PlayButtonOk(); // 0x0000000182131DD0-0x0000000182131E80
	public static void PlayButtonExit(); // 0x00000001821318A0-0x0000000182131950
	public static void PlayButtonGoalsList(); // 0x0000000182131AE0-0x0000000182131B90
	public static void PlayStationRotate(); // 0x0000000182132C70-0x0000000182132D20
	public static void PlayStingerScoreBar(); // 0x0000000182132FE0-0x0000000182133090
	public static void PlayTutorialButton(); // 0x0000000182133260-0x0000000182133310
	public static void PlayButtonChoose(); // 0x0000000182131740-0x00000001821317F0
	public static void PlayClearBoard(); // 0x00000001821321F0-0x00000001821322A0
	public static void PlayRestartStinger(); // 0x00000001821327A0-0x0000000182132850
	public static void PlayButtonCancel(); // 0x0000000182131690-0x0000000182131740
	public static void PlayLevelSelect(); // 0x0000000182132310-0x0000000182132380
	public static void PlayMaterialWiggle(); // 0x0000000182132380-0x00000001821323F0
	public static void PlayTwiggleSparkle(); // 0x0000000182133310-0x0000000182133380
	public static void PlayTwiggleSteps(); // 0x00000001821333F0-0x0000000182133460
	public static void PlayTapToContinue(); // 0x0000000182133140-0x00000001821331B0
	public static void PlayTwiggleSpawn(); // 0x0000000182133380-0x00000001821333F0
	private void Awake(); // 0x00000001821315A0-0x00000001821315E0
}

