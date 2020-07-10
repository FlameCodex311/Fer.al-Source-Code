/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_AvailablePuzzlePieceCount : MonoBehaviour // TypeDefIndex: 13007
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _content; // 0x20
	[SerializeField] // 0x00000001800B5770-0x00000001800B57C0
	[Tooltip] // 0x00000001800B5770-0x00000001800B57C0
	private int _puzzleIndex; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _countText; // 0x30
	private int _count; // 0x38

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001810A71F0-0x00000001810A7250 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13008
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__8_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001810BD9B0-0x00000001810BDA10
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnEnable>b__8_0(); // 0x00000001810BD2B0-0x00000001810BD320
	}

	// Constructors
	public Match3UI_AvailablePuzzlePieceCount(); // 0x00000001810A71E0-0x00000001810A71F0

	// Methods
	public void OnAvailabilityStateChange(int inPuzzleIndex, int inPieceIndex); // 0x00000001810A6E00-0x00000001810A6EA0
	public void OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPieceIndex); // 0x00000001810A6FB0-0x00000001810A6FD0
	private void OnEnable(); // 0x00000001810A6EA0-0x00000001810A6FB0
	private void UpdateCount(); // 0x00000001810A6FF0-0x00000001810A7070
	private void UpdateVisuals(); // 0x00000001810A7070-0x00000001810A71E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnEnable>b__8_1(); // 0x00000001810A6FD0-0x00000001810A6FF0
}

