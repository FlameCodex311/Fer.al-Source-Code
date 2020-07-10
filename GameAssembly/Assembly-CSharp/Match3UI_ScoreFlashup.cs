/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_ScoreFlashup : MonoBehaviour // TypeDefIndex: 13019
{
	// Fields
	public WWTextMeshProUGUI scoreText; // 0x20
	public DOTweenAnimator movementTween; // 0x28
	public int score; // 0x30
	public Color color; // 0x34
	public bool doMovement; // 0x44

	// Constructors
	public Match3UI_ScoreFlashup(); // 0x0000000180407560-0x0000000180407570

	// Methods
	public void Setup(int inScore, Color inColor, bool inDoMovement = true /* Metadata: 0x007834F1 */); // 0x00000001810AC6C0-0x00000001810AC6E0
	private void OnEnable(); // 0x00000001810AC5A0-0x00000001810AC5B0
	private void SetScoreText(); // 0x00000001810AC5B0-0x00000001810AC6C0
}

