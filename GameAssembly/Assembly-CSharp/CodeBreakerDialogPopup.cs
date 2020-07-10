/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerDialogPopup : MonoBehaviour // TypeDefIndex: 12866
{
	// Fields
	public List<Sprite> characterEmotes; // 0x20
	public WWTextMeshProUGUI dialogueText; // 0x28
	public WWImage dialogEmoteImage; // 0x30
	public float minDisplayTime; // 0x38
	private float timer; // 0x3C
	private bool allowSkip; // 0x40
	private bool skipped; // 0x41
	private bool hiding; // 0x42

	// Constructors
	public CodeBreakerDialogPopup(); // 0x000000018126E160-0x000000018126E180

	// Methods
	private void Update(); // 0x000000018126E0B0-0x000000018126E160
	public void ShowDialogTextById(string inLocDefId, int inEmoteIndex, bool inAllowSkip = true /* Metadata: 0x007832CA */); // 0x000000018126DCB0-0x000000018126DD50
	public void ShowDialogText(string inText, int inEmoteIndex, bool inAllowSkip = true /* Metadata: 0x007832CB */); // 0x000000018126DD50-0x000000018126DF40
	public void CloseDialogText(); // 0x000000018126DC00-0x000000018126DC10
	private void ShowEmote(int inIndex); // 0x000000018126DF40-0x000000018126E010
	private void ShowPopup(); // 0x000000018126E010-0x000000018126E0B0
	private void HidePopup(); // 0x000000018126DC10-0x000000018126DCB0
}

