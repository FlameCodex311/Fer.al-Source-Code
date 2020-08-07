/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3AchievementTracker : MonoBehaviour // TypeDefIndex: 10607
{
	// Fields
	[EnumList] // 0x000000018022FFE0-0x0000000180230050
	[SerializeField] // 0x000000018022FFE0-0x0000000180230050
	private List<Match3AchievementTypeData> _typeDatas; // 0x20
	[Header] // 0x00000001802305F0-0x0000000180230640
	[SerializeField] // 0x00000001802305F0-0x0000000180230640
	private Match3PuzzleCollectionReference _puzzleCollectionReference; // 0x28
	[Header] // 0x0000000180230870-0x00000001802308C0
	[SerializeField] // 0x0000000180230870-0x00000001802308C0
	private IntIntEvent _achievementUnlockedEvent; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10608
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180509520-0x0000000180509580
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GeneratePuzzleCollectionFromCharts>b__4_0(); // 0x00000001805090C0-0x0000000180509130
	}

	// Constructors
	public Match3AchievementTracker(); // 0x00000001804F6930-0x00000001804F6990

	// Methods
	private void Awake(); // 0x00000001804F6590-0x00000001804F66A0
	private void GeneratePuzzleCollectionFromCharts(); // 0x00000001804F6590-0x00000001804F66A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <GeneratePuzzleCollectionFromCharts>b__4_1(); // 0x00000001804F66A0-0x00000001804F6930
}

