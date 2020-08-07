/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeNoteUI : MonoBehaviour // TypeDefIndex: 10586
{
	// Fields
	public List<WWImage> code; // 0x20
	public List<WWImage> hintsMiddle; // 0x28
	public List<WWImage> hintsTopBottom; // 0x30
	[EnumList] // 0x000000018022BD50-0x000000018022BDB0
	public List<Sprite> ingredients; // 0x38
	public WWImage allWrongImage; // 0x40
	public WWImage allCorrectImage; // 0x48
	public GameObject someHintsContainer; // 0x50
	public GameObject someHintsOkBackground; // 0x58
	public GameObject someHintsGoodBackground; // 0x60
	public GameObject allHintsContainer; // 0x68
	public Sprite correctPlaceHintSprite; // 0x70
	public Sprite incorrectPlaceHintSprite; // 0x78
	public Sprite wrongHintSprite; // 0x80
	public GameObject hintFx_AllWrong; // 0x88
	public GameObject hintFx_AllRight; // 0x90
	public GameObject hintFx_SomeCorrectPosition; // 0x98
	public GameObject hintFx_SomeIncorrectPosition; // 0xA0
	public WWImage separator; // 0xA8
	private GameObject _revealFx; // 0xB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CodeAttempt <NoteAttempt>k__BackingField; // 0xB8
	private int _revealSfxCounter; // 0xC0

	// Properties
	private CodeAttempt NoteAttempt { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018049F9C0-0x000000018049F9D0

	// Constructors
	public CodeNoteUI(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void SetCodeLength(int inLength); // 0x000000018077A7B0-0x000000018077A890
	public void SetNote(CodeAttempt inAttempt); // 0x000000018077A890-0x000000018077AEF0
	public void RevealNotes(); // 0x000000018077A3C0-0x000000018077A7B0
	private void DisableAllHints(); // 0x000000018077A150-0x000000018077A3C0
	public void SetSeparatorVisible(bool inVisible); // 0x000000018077AEF0-0x000000018077AFA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RevealNotes>b__26_1(); // 0x000000018077AFC0-0x000000018077B060
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RevealNotes>b__26_0(); // 0x000000018077AFA0-0x000000018077AFC0
}

