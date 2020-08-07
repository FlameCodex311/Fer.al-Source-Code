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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerDialogPopup : MonoBehaviour // TypeDefIndex: 10524
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
	public CodeBreakerDialogPopup(); // 0x0000000180526830-0x0000000180526850

	// Methods
	private void Update(); // 0x0000000180526780-0x0000000180526830
	public void ShowDialogTextById(string inLocDefId, int inEmoteIndex, bool inAllowSkip = true /* Metadata: 0x0077BD75 */); // 0x0000000180526380-0x0000000180526420
	public void ShowDialogText(string inText, int inEmoteIndex, bool inAllowSkip = true /* Metadata: 0x0077BD76 */); // 0x0000000180526420-0x0000000180526610
	public void CloseDialogText(); // 0x00000001805262D0-0x00000001805262E0
	private void ShowEmote(int inIndex); // 0x0000000180526610-0x00000001805266E0
	private void ShowPopup(); // 0x00000001805266E0-0x0000000180526780
	private void HidePopup(); // 0x00000001805262E0-0x0000000180526380
}

