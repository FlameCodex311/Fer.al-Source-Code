/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x0000000180221580-0x00000001802215B0
public class CodeBreakerLevels : ScriptableObject // TypeDefIndex: 10561
{
	// Fields
	public int FirstGuessBonus; // 0x18
	public int LastIngredientBonus; // 0x1C
	[Header] // 0x0000000180221860-0x0000000180221890
	public CodeBreakerLevel tutorialLevel; // 0x20
	public List<CodeBreakerLevel> levels; // 0x28

	// Constructors
	public CodeBreakerLevels(); // 0x000000018052B900-0x000000018052B920

	// Methods
	[DeMethodButton] // 0x00000001802219E0-0x0000000180221A40
	public void TransferDataToPropertyEditor(); // 0x00000001803774A0-0x00000001803774B0
}

