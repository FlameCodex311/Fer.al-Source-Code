/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CodeBreakerLevel // TypeDefIndex: 10563
{
	// Fields
	[NameIndexer] // 0x0000000180221F70-0x0000000180221FA0
	public string name; // 0x10
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int codeLength; // 0x18
	[ChartEnumFlag] // 0x0000000180222380-0x00000001802223B0
	[EnumFlag] // 0x0000000180222380-0x00000001802223B0
	public CodeColor colors; // 0x1C
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool allowRepeatColors; // 0x20
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool allowEmpty; // 0x21
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int tryCount; // 0x24
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int startingIngredientCount; // 0x28
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int scorePerIngredient; // 0x2C
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<TimerScore> timerScoreThresholds; // 0x30
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int oneStarScore; // 0x38
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int twoStarScore; // 0x3C
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int threeStarScore; // 0x40

	// Constructors
	public CodeBreakerLevel(); // 0x000000018052B8C0-0x000000018052B900

	// Methods
	public int GetIngredientsLeftScore(int inIngredientsLeft); // 0x000000018052B790-0x000000018052B7A0
	public int GetTimeBonusScore(int inSecondsToComplete); // 0x000000018052B7E0-0x000000018052B8C0
	public int GetStarCount(long inScore); // 0x000000018052B7A0-0x000000018052B7E0
}

