/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3AchievementTracker : MonoBehaviour // TypeDefIndex: 12942
{
	// Fields
	[EnumList] // 0x0000000180151D40-0x0000000180151DB0
	[SerializeField] // 0x0000000180151D40-0x0000000180151DB0
	private List<Match3AchievementTypeData> _typeDatas; // 0x20
	[Header] // 0x0000000180152070-0x00000001801520C0
	[SerializeField] // 0x0000000180152070-0x00000001801520C0
	private Match3PuzzleCollectionReference _puzzleCollectionReference; // 0x28
	[Header] // 0x00000001801523E0-0x0000000180152430
	[SerializeField] // 0x00000001801523E0-0x0000000180152430
	private IntIntEvent _achievementUnlockedEvent; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12943
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001816D5B90-0x00000001816D5BF0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GeneratePuzzleCollectionFromCharts>b__4_0(); // 0x00000001816D56F0-0x00000001816D5760
	}

	// Constructors
	public Match3AchievementTracker(); // 0x00000001811EFE90-0x00000001811EFEF0

	// Methods
	private void Awake(); // 0x00000001811EFAE0-0x00000001811EFBF0
	private void GeneratePuzzleCollectionFromCharts(); // 0x00000001811EFAE0-0x00000001811EFBF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <GeneratePuzzleCollectionFromCharts>b__4_1(); // 0x00000001811EFBF0-0x00000001811EFE90
}

