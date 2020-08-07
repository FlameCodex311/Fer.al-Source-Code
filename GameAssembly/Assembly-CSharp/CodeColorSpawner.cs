/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeColorSpawner : MonoBehaviour // TypeDefIndex: 10580
{
	// Fields
	public int totalActiveIngredients; // 0x20
	public Transform spawnPoint; // 0x28
	public Transform dropPoint; // 0x30
	public GameObject hatch; // 0x38
	public CodeBreakerIngredient ingredientPrefab; // 0x40
	public float interval; // 0x48
	public TextMeshPro spawnCountText; // 0x50
	private List<CodeBreakerIngredient> _ingredients; // 0x58
	private Rigidbody _wheelBody; // 0x60
	private CodeBreakerIngredient readyIngredient; // 0x68
	private FixedJoint readyIngredientPin; // 0x70
	private Vector3 _startingHatchRotation; // 0x78
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <IngredientsLeft>k__BackingField; // 0x84

	// Properties
	public int IngredientsLeft { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180779F60-0x0000000180779F70 0x0000000180779F70-0x0000000180779F80

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10581
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__17_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180787000-0x0000000180787060
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnEnable>b__17_0(); // 0x0000000180786870-0x0000000180786910
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnIngredients>d__22 : IEnumerator<object> // TypeDefIndex: 10582
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeColorSpawner <>4__this; // 0x20
		private WaitForSeconds <yieldInterval>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnIngredients>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807865D0-0x0000000180786730
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180786730-0x0000000180786780
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 10583
	{
		// Fields
		public CodeBreakerIngredient droppedIngredient; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DropIngredient>b__0(); // 0x0000000180786EA0-0x0000000180786ED0
	}

	// Constructors
	public CodeColorSpawner(); // 0x0000000180779F50-0x0000000180779F60

	// Methods
	private void Start(); // 0x0000000180779CC0-0x0000000180779D40
	private void OnEnable(); // 0x0000000180779350-0x0000000180779480
	private void Update(); // 0x0000000180779E40-0x0000000180779F50
	private void OnSpawnerActivated(); // 0x0000000180779480-0x0000000180779500
	public void Setup(IngredientWheel inWheel, int inSpawnCount); // 0x00000001807799C0-0x0000000180779A80
	private void OnDisable(); // 0x0000000180779100-0x0000000180779350
	[IteratorStateMachine] // 0x000000018022A980-0x000000018022A9D0
	private IEnumerator SpawnIngredients(); // 0x0000000180779A80-0x0000000180779AE0
	public void ReadyNextIngredient(); // 0x0000000180779500-0x0000000180779960
	public CodeBreakerIngredient Spawn(); // 0x0000000180779AE0-0x0000000180779CC0
	public CodeBreakerIngredient GetNearestToPoint(Transform inPoint); // 0x0000000180778E90-0x0000000180779100
	public CodeBreakerIngredient DropIngredient(Vector3 inDropToPos); // 0x0000000180778AC0-0x0000000180778E90
	public bool RemoveIngredientFromSpawner(CodeBreakerIngredient inIngredient); // 0x0000000180779960-0x00000001807799C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnEnable>b__17_1(); // 0x0000000180779480-0x0000000180779500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSpawnerActivated>b__19_0(); // 0x0000000180779D40-0x0000000180779DC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <ReadyNextIngredient>b__23_0(); // 0x0000000180779DC0-0x0000000180779E00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ReadyNextIngredient>b__23_1(Vector3 x); // 0x0000000180779E00-0x0000000180779E40
}

