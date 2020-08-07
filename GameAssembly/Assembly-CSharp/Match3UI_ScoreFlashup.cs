/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_ScoreFlashup : MonoBehaviour // TypeDefIndex: 10684
{
	// Fields
	public WWTextMeshProUGUI scoreText; // 0x20
	public DOTweenAnimator movementTween; // 0x28
	public int score; // 0x30
	public Color color; // 0x34
	public bool doMovement; // 0x44

	// Constructors
	public Match3UI_ScoreFlashup(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(int inScore, Color inColor, bool inDoMovement = true /* Metadata: 0x0077BFAC */); // 0x00000001807E8E30-0x00000001807E8E50
	private void OnEnable(); // 0x00000001807E8D10-0x00000001807E8D20
	private void SetScoreText(); // 0x00000001807E8D20-0x00000001807E8E30
}

