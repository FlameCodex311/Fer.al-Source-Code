/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChallengeManager : MonoBehaviour // TypeDefIndex: 13180
{
	// Fields
	public float gameTime; // 0x20
	public float timeRemaining; // 0x24
	public int playerScore; // 0x28
	public int kinoScore; // 0x2C
	public TextMeshProUGUI timerText; // 0x30
	public TextMeshProUGUI playerScoreText; // 0x38
	public TextMeshProUGUI kinoScoreText; // 0x40

	// Constructors
	public ChallengeManager(); // 0x000000018049D9F0-0x000000018049DA10

	// Methods
	private void Start(); // 0x000000018049D8C0-0x000000018049D900
	private void Update(); // 0x000000018049D900-0x000000018049D9F0
	public void StartGame(); // 0x000000018049D8B0-0x000000018049D8C0
	public void GameOver(); // 0x00000001803774A0-0x00000001803774B0
}

