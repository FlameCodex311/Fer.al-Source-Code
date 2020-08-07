/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_AvailablePuzzlePieceCount : MonoBehaviour // TypeDefIndex: 10672
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _content; // 0x20
	[SerializeField] // 0x000000018024E7C0-0x000000018024E810
	[Tooltip] // 0x000000018024E7C0-0x000000018024E810
	private int _puzzleIndex; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _countText; // 0x30
	private int _count; // 0x38

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001807E3A90-0x00000001807E3AF0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10673
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__8_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001807F14B0-0x00000001807F1510
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnEnable>b__8_0(); // 0x00000001807F0C00-0x00000001807F0C70
	}

	// Constructors
	public Match3UI_AvailablePuzzlePieceCount(); // 0x000000018063CC90-0x000000018063CCA0

	// Methods
	public void OnAvailabilityStateChange(int inPuzzleIndex, int inPieceIndex); // 0x00000001807E36B0-0x00000001807E3750
	public void OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPieceIndex); // 0x00000001807E3860-0x00000001807E3880
	private void OnEnable(); // 0x00000001807E3750-0x00000001807E3860
	private void UpdateCount(); // 0x00000001807E38A0-0x00000001807E3920
	private void UpdateVisuals(); // 0x00000001807E3920-0x00000001807E3A90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnEnable>b__8_1(); // 0x00000001807E3880-0x00000001807E38A0
}

