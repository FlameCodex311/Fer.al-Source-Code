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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeColorSpawner : MonoBehaviour // TypeDefIndex: 12915
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
	private Collider _collider; // 0x60
	private Rigidbody _wheelBody; // 0x68
	private CodeBreakerIngredient readyIngredient; // 0x70
	private FixedJoint readyIngredientPin; // 0x78
	private Vector3 _startingHatchRotation; // 0x80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <IngredientsLeft>k__BackingField; // 0x8C

	// Properties
	public int IngredientsLeft { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804D0670-0x00000001804D0680 0x00000001804D0BA0-0x00000001804D0BB0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12916
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__18_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181281FB0-0x0000000181282010
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnEnable>b__18_0(); // 0x0000000181281680-0x0000000181281720
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnIngredients>d__23 : IEnumerator<object> // TypeDefIndex: 12917
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeColorSpawner <>4__this; // 0x20
		private WaitForSeconds <yieldInterval>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnIngredients>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812813D0-0x0000000181281540
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181281540-0x0000000181281590
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 12918
	{
		// Fields
		public CodeBreakerIngredient droppedIngredient; // 0x10

		// Constructors
		public <>c__DisplayClass27_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DropIngredient>b__0(); // 0x0000000181281E00-0x0000000181281E30
	}

	// Constructors
	public CodeColorSpawner(); // 0x000000018127CA50-0x000000018127CA60

	// Methods
	private void Start(); // 0x000000018127C7C0-0x000000018127C840
	private void OnEnable(); // 0x000000018127BD50-0x000000018127BEA0
	private void Update(); // 0x000000018127C940-0x000000018127CA50
	private void OnSpawnerActivated(); // 0x000000018127BEA0-0x000000018127BF20
	public void Setup(IngredientWheel inWheel, int inSpawnCount); // 0x000000018127C4A0-0x000000018127C560
	private void OnDisable(); // 0x000000018127BAF0-0x000000018127BD50
	[IteratorStateMachine] // 0x000000018014A170-0x000000018014A1C0
	private IEnumerator SpawnIngredients(); // 0x000000018127C560-0x000000018127C5C0
	public void ReadyNextIngredient(); // 0x000000018127BF20-0x000000018127C440
	public CodeBreakerIngredient Spawn(); // 0x000000018127C5C0-0x000000018127C7C0
	public CodeBreakerIngredient GetNearestToPoint(Transform inPoint); // 0x000000018127B870-0x000000018127BAF0
	public CodeBreakerIngredient DropIngredient(Vector3 inDropToPos); // 0x000000018127B4A0-0x000000018127B870
	public bool RemoveIngredientFromSpawner(CodeBreakerIngredient inIngredient); // 0x000000018127C440-0x000000018127C4A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnEnable>b__18_1(); // 0x000000018127BEA0-0x000000018127BF20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSpawnerActivated>b__20_0(); // 0x000000018127C840-0x000000018127C8C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <ReadyNextIngredient>b__24_0(); // 0x000000018127C8C0-0x000000018127C900
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ReadyNextIngredient>b__24_1(Vector3 x); // 0x000000018127C900-0x000000018127C940
}

