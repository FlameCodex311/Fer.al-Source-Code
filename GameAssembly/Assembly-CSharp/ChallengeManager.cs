/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChallengeManager : MonoBehaviour // TypeDefIndex: 11655
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
	public ChallengeManager(); // 0x0000000181025080-0x00000001810250A0

	// Methods
	private void Start(); // 0x0000000181024F50-0x0000000181024F90
	private void Update(); // 0x0000000181024F90-0x0000000181025080
	public void StartGame(); // 0x0000000181024F40-0x0000000181024F50
	public void GameOver(); // 0x00000001803581E0-0x00000001803581F0
}

