/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerAudio : MonoBehaviour // TypeDefIndex: 10522
{
	// Fields
	private static CodeBreakerAudio _instance; // 0x00
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	[Header] // 0x00000001802134F0-0x0000000180213520
	public FeralAudioInfo redCollision; // 0x30
	public FeralAudioInfo blueCollision; // 0x38
	public FeralAudioInfo yellowCollision; // 0x40
	public FeralAudioInfo greenCollision; // 0x48
	public FeralAudioInfo orangeCollision; // 0x50
	public FeralAudioInfo purpleCollision; // 0x58
	public FeralAudioInfo pinkCollision; // 0x60
	public FeralAudioInfo cyanCollision; // 0x68
	[Header] // 0x00000001802136B0-0x00000001802136E0
	public FeralAudioInfo scoreFillbarStarFilled; // 0x70
	public FeralAudioInfo dropButton; // 0x78
	public FeralAudioInfo mixButton; // 0x80
	public FeralAudioInfo levelButtonSelected; // 0x88
	public FeralAudioInfo uiForcedTutorialPopup; // 0x90
	public FeralAudioInfo uiForcedTutorialContinue; // 0x98
	[Header] // 0x00000001802138E0-0x0000000180213910
	public FeralAudioInfo timerTick; // 0xA0
	public FeralAudioInfo beetleMove; // 0xA8
	public FeralAudioInfo beetleWingsLP; // 0xB0
	public FeralAudioInfo beetleDiscardIngredient; // 0xB8
	public FeralAudioInfo cauldronActive; // 0xC0
	public FeralAudioInfo cauldronLP; // 0xC8
	public FeralAudioInfo ingredientWheelTap; // 0xD0
	public FeralAudioInfo ingredientWheelDragLP; // 0xD8
	public FeralAudioInfo resultsStinger; // 0xE0
	public FeralAudioInfo scrollNotesLP; // 0xE8
	public FeralAudioInfo hintCorrect; // 0xF0
	public FeralAudioInfo hintWrong; // 0xF8
	public FeralAudioInfo hintSomeCorrect; // 0x100
	private Dictionary<CodeColor, float> _lastPlayedTimers; // 0x108
	private bool _playingScrollNotesLP; // 0x110

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001805261D0-0x0000000180526260 

	// Constructors
	public CodeBreakerAudio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x0000000180524B50-0x0000000180524B90
	private void Start(); // 0x0000000180525CE0-0x0000000180525E30
	public static void PlayGameMusic(); // 0x0000000180524FB0-0x0000000180525060
	public static void PlaySplashMusic(); // 0x0000000180525A20-0x0000000180525AD0
	public static void StopSplashMusic(); // 0x0000000180526120-0x00000001805261D0
	public static void PlayIngredientTypeCollide(CodeColor inIngredientType); // 0x0000000180525270-0x0000000180525520
	public static void PlayScoreFillbarStarFilled(); // 0x0000000180525890-0x0000000180525940
	public static void PlayTimerTick(); // 0x0000000180525AD0-0x0000000180525B80
	public static void PlayDropButton(); // 0x0000000180524F00-0x0000000180524FB0
	public static void PlayMixButton(); // 0x0000000180525730-0x00000001805257E0
	public static void PlayBeetleMove(); // 0x0000000180524C40-0x0000000180524CF0
	public static void PlayBeetleWingsLP(); // 0x0000000180524CF0-0x0000000180524DA0
	public static void StopBeetleWingsLP(); // 0x0000000180525E30-0x0000000180525EE0
	public static void PlayBeetleDiscardIngredient(); // 0x0000000180524B90-0x0000000180524C40
	public static void PlayCauldronActive(); // 0x0000000180524DA0-0x0000000180524E50
	public static void PlayCauldronLP(); // 0x0000000180524E50-0x0000000180524F00
	public static void StopCauldronLP(); // 0x0000000180525EE0-0x0000000180525F90
	public static void PlayIngredientWheelTap(); // 0x00000001805255D0-0x0000000180525680
	public static void PlayIngredientWheelDragLP(); // 0x0000000180525520-0x00000001805255D0
	public static void StopIngredientWheelDragLP(); // 0x0000000180525F90-0x0000000180526040
	public static void PlayHintCorrect(); // 0x0000000180525060-0x0000000180525110
	public static void PlayHintWrong(); // 0x00000001805251C0-0x0000000180525270
	public static void PlayHintSomeCorrect(); // 0x0000000180525110-0x00000001805251C0
	public static void PlayLevelButtonSelected(); // 0x0000000180525680-0x0000000180525730
	public static void PlayResultsStinger(); // 0x00000001805257E0-0x0000000180525890
	public static void PlayScrollNotesLP(); // 0x0000000180525940-0x0000000180525A20
	public static void StopScrollNotesLP(); // 0x0000000180526040-0x0000000180526120
	public static void PlayUIForcedTutorialPopup(); // 0x0000000180525C30-0x0000000180525CE0
	public static void PlayUIForcedTutorialContinue(); // 0x0000000180525B80-0x0000000180525C30
}

