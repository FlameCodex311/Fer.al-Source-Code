/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class IngredientWheel : MonoBehaviour // TypeDefIndex: 10593
{
	// Fields
	public BeetleController beetleController; // 0x20
	public Transform dropPoint; // 0x28
	public TouchDrag dragWheel; // 0x30
	[EnumList] // 0x000000018022CE20-0x000000018022CE80
	public List<CodeBreakerIngredient> _ingredients; // 0x38
	public List<GameObject> ingredientCountOptions; // 0x40
	public List<GameObject> ingredientBins; // 0x48
	private List<CodeColorSpawner> _activeSpawners; // 0x50
	private int _ingredientsPerSpawner; // 0x58
	private int _pausedCount; // 0x5C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <IngredientTypeCount>k__BackingField; // 0x60

	// Properties
	private bool Paused { get; } // 0x0000000180626110-0x0000000180626120 
	public bool CanSpinWheel { get; } // 0x0000000180626100-0x0000000180626110 
	public int IngredientTypeCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804ADA80-0x00000001804ADA90 0x00000001804ADAB0-0x00000001804ADAC0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10594
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__17_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001806317B0-0x0000000180631810
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__17_0(); // 0x0000000180630530-0x00000001806305D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 10595
	{
		// Fields
		public CodeBreakerIngredient ingredient; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnIngredientDiscarded>b__0(); // 0x0000000180631380-0x00000001806313F0
	}

	// Constructors
	public IngredientWheel(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180625E80-0x0000000180625FB0
	private void OnDestroy(); // 0x0000000180625510-0x0000000180625660
	public void Setup(CodeColor colorFlags, int inIngredientsPerSpawner); // 0x0000000180625BD0-0x0000000180625E80
	public int GetTotalIngredients(); // 0x00000001806250C0-0x0000000180625200
	public bool HasEnoughIngredients(Dictionary<CodeColor, int> inIngrdientCounts); // 0x0000000180625200-0x0000000180625400
	private void OnCodeColorSpawnerActive(CodeColorSpawnerActiveMessage inMessage); // 0x0000000180625400-0x00000001806254B0
	private void OnCodeColorSpawnerDeactive(CodeColorSpawnerDeactiveMessage inMessage); // 0x00000001806254B0-0x0000000180625510
	private void OnIngredientDiscarded(IngredientDiscardedMessage inMessage); // 0x00000001806256F0-0x0000000180625A70
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000180625660-0x00000001806256F0
	public void OnIngredientDrop(); // 0x0000000180625A70-0x0000000180625BD0
	public CodeColorSpawner FindNearestSpawner(Vector3 inPosition); // 0x0000000180624EC0-0x00000001806250C0
	private void EnableIngredientCountOption(List<CodeColor> inColors); // 0x0000000180624AD0-0x0000000180624EC0
	public bool CheckForLastIngredient(Code inCode); // 0x00000001806247A0-0x0000000180624A20
	public void ClearIngredients(); // 0x0000000180624A20-0x0000000180624AD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__17_1(); // 0x0000000180625FB0-0x0000000180626100
}

