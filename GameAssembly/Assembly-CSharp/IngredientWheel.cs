/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class IngredientWheel : MonoBehaviour // TypeDefIndex: 12928
{
	// Fields
	public BeetleController beetleController; // 0x20
	public Transform dropPoint; // 0x28
	public TouchDrag dragWheel; // 0x30
	[EnumList] // 0x000000018014C870-0x000000018014C8D0
	public List<CodeBreakerIngredient> _ingredients; // 0x38
	public List<GameObject> ingredientCountOptions; // 0x40
	public List<GameObject> ingredientBins; // 0x48
	private List<CodeColorSpawner> _activeSpawners; // 0x50
	private int _ingredientsPerSpawner; // 0x58
	private int _pausedCount; // 0x5C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <IngredientTypeCount>k__BackingField; // 0x60

	// Properties
	private bool Paused { get; } // 0x0000000180F5CCC0-0x0000000180F5CCD0 
	public bool CanSpinWheel { get; } // 0x0000000180F5CCB0-0x0000000180F5CCC0 
	public int IngredientTypeCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A3730-0x00000001804A3740 0x000000018044E340-0x000000018044E350

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12929
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__17_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F704A0-0x0000000180F70500
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__17_0(); // 0x0000000180F6F4A0-0x0000000180F6F540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 12930
	{
		// Fields
		public CodeBreakerIngredient ingredient; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnIngredientDiscarded>b__0(); // 0x0000000180F70140-0x0000000180F701B0
	}

	// Constructors
	public IngredientWheel(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F5CA30-0x0000000180F5CB60
	private void OnDestroy(); // 0x0000000180F5C0B0-0x0000000180F5C200
	public void Setup(CodeColor colorFlags, int inIngredientsPerSpawner); // 0x0000000180F5C780-0x0000000180F5CA30
	public int GetTotalIngredients(); // 0x0000000180F5BC40-0x0000000180F5BD90
	public bool HasEnoughIngredients(Dictionary<CodeColor, int> inIngrdientCounts); // 0x0000000180F5BD90-0x0000000180F5BF90
	private void OnCodeColorSpawnerActive(CodeColorSpawnerActiveMessage inMessage); // 0x0000000180F5BF90-0x0000000180F5C040
	private void OnCodeColorSpawnerDeactive(CodeColorSpawnerDeactiveMessage inMessage); // 0x0000000180F5C040-0x0000000180F5C0B0
	private void OnIngredientDiscarded(IngredientDiscardedMessage inMessage); // 0x0000000180F5C290-0x0000000180F5C620
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000180F5C200-0x0000000180F5C290
	public void OnIngredientDrop(); // 0x0000000180F5C620-0x0000000180F5C780
	public CodeColorSpawner FindNearestSpawner(Vector3 inPosition); // 0x0000000180F5BA30-0x0000000180F5BC40
	private void EnableIngredientCountOption(List<CodeColor> inColors); // 0x0000000180F5B630-0x0000000180F5BA30
	public bool CheckForLastIngredient(Code inCode); // 0x0000000180F5B2E0-0x0000000180F5B570
	public void ClearIngredients(); // 0x0000000180F5B570-0x0000000180F5B630
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__17_1(); // 0x0000000180F5CB60-0x0000000180F5CCB0
}

