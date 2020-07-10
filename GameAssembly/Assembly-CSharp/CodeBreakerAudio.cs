/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerAudio : MonoBehaviour // TypeDefIndex: 12864
{
	// Fields
	private static CodeBreakerAudio _instance; // 0x00
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	[Header] // 0x0000000180138580-0x00000001801385B0
	public FeralAudioInfo redCollision; // 0x30
	public FeralAudioInfo blueCollision; // 0x38
	public FeralAudioInfo yellowCollision; // 0x40
	public FeralAudioInfo greenCollision; // 0x48
	public FeralAudioInfo orangeCollision; // 0x50
	public FeralAudioInfo purpleCollision; // 0x58
	public FeralAudioInfo pinkCollision; // 0x60
	public FeralAudioInfo cyanCollision; // 0x68
	[Header] // 0x0000000180126FD0-0x0000000180127000
	public FeralAudioInfo scoreFillbarStarFilled; // 0x70
	public FeralAudioInfo dropButton; // 0x78
	public FeralAudioInfo mixButton; // 0x80
	public FeralAudioInfo levelButtonSelected; // 0x88
	public FeralAudioInfo uiForcedTutorialPopup; // 0x90
	public FeralAudioInfo uiForcedTutorialContinue; // 0x98
	[Header] // 0x00000001801399F0-0x0000000180139A20
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
	public static GameObject AudioGO { get; } // 0x000000018126DB10-0x000000018126DBA0 

	// Constructors
	public CodeBreakerAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018126C450-0x000000018126C490
	private void Start(); // 0x000000018126D610-0x000000018126D760
	public static void PlayGameMusic(); // 0x000000018126C8B0-0x000000018126C960
	public static void PlaySplashMusic(); // 0x000000018126D350-0x000000018126D400
	public static void StopSplashMusic(); // 0x000000018126DA60-0x000000018126DB10
	public static void PlayIngredientTypeCollide(CodeColor inIngredientType); // 0x000000018126CB70-0x000000018126CE40
	public static void PlayScoreFillbarStarFilled(); // 0x000000018126D1B0-0x000000018126D260
	public static void PlayTimerTick(); // 0x000000018126D400-0x000000018126D4B0
	public static void PlayDropButton(); // 0x000000018126C800-0x000000018126C8B0
	public static void PlayMixButton(); // 0x000000018126D050-0x000000018126D100
	public static void PlayBeetleMove(); // 0x000000018126C540-0x000000018126C5F0
	public static void PlayBeetleWingsLP(); // 0x000000018126C5F0-0x000000018126C6A0
	public static void StopBeetleWingsLP(); // 0x000000018126D760-0x000000018126D810
	public static void PlayBeetleDiscardIngredient(); // 0x000000018126C490-0x000000018126C540
	public static void PlayCauldronActive(); // 0x000000018126C6A0-0x000000018126C750
	public static void PlayCauldronLP(); // 0x000000018126C750-0x000000018126C800
	public static void StopCauldronLP(); // 0x000000018126D810-0x000000018126D8C0
	public static void PlayIngredientWheelTap(); // 0x000000018126CEF0-0x000000018126CFA0
	public static void PlayIngredientWheelDragLP(); // 0x000000018126CE40-0x000000018126CEF0
	public static void StopIngredientWheelDragLP(); // 0x000000018126D8C0-0x000000018126D970
	public static void PlayHintCorrect(); // 0x000000018126C960-0x000000018126CA10
	public static void PlayHintWrong(); // 0x000000018126CAC0-0x000000018126CB70
	public static void PlayHintSomeCorrect(); // 0x000000018126CA10-0x000000018126CAC0
	public static void PlayLevelButtonSelected(); // 0x000000018126CFA0-0x000000018126D050
	public static void PlayResultsStinger(); // 0x000000018126D100-0x000000018126D1B0
	public static void PlayScrollNotesLP(); // 0x000000018126D260-0x000000018126D350
	public static void StopScrollNotesLP(); // 0x000000018126D970-0x000000018126DA60
	public static void PlayUIForcedTutorialPopup(); // 0x000000018126D560-0x000000018126D610
	public static void PlayUIForcedTutorialContinue(); // 0x000000018126D4B0-0x000000018126D560
}

