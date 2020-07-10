/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CodeBreakerLevel // TypeDefIndex: 12895
{
	// Fields
	[NameIndexer] // 0x0000000180142ED0-0x0000000180142F00
	public string name; // 0x10
	public int codeLength; // 0x18
	[EnumFlag] // 0x00000001800BDB50-0x00000001800BDB60
	public CodeColor colors; // 0x1C
	public bool allowRepeatColors; // 0x20
	public bool allowEmpty; // 0x21
	public int tryCount; // 0x24
	public int startingIngredientCount; // 0x28
	public int scorePerIngredient; // 0x2C
	public List<TimerScore> timerScoreThresholds; // 0x30
	public int oneStarScore; // 0x38
	public int twoStarScore; // 0x3C
	public int threeStarScore; // 0x40

	// Constructors
	public CodeBreakerLevel(); // 0x0000000181272F90-0x0000000181272FD0

	// Methods
	public int GetIngredientsLeftScore(int inIngredientsLeft); // 0x0000000181272E50-0x0000000181272E60
	public int GetTimeBonusScore(int inSecondsToComplete); // 0x0000000181272EA0-0x0000000181272F90
	public int GetStarCount(long inScore); // 0x0000000181272E60-0x0000000181272EA0
}

