/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BeetleController : MonoBehaviour // TypeDefIndex: 12861
{
	// Fields
	public CodeBreakerGame game; // 0x20
	public Beetle beetlePrefab; // 0x28
	public Material evenBeetleMaterial; // 0x30
	public Material oddBeetleMaterial; // 0x38
	public Transform beetleSpawnOrigin; // 0x40
	public Transform beetleCatchPos; // 0x48
	public float beetleSpawnSpacing; // 0x50
	public FeralButton mixButton; // 0x58
	private List<Beetle> _beetles; // 0x60
	private Beetle _selectedBeetle; // 0x68
	private int _pausedCount; // 0x70

	// Properties
	private bool Paused { get; } // 0x0000000181043D70-0x0000000181043D80 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MixIngredientsSequence>d__27 : IEnumerator<object> // TypeDefIndex: 12862
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BeetleController <>4__this; // 0x20
		public bool isTutorial; // 0x28
		public Code inCode; // 0x30
		private int <i>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MixIngredientsSequence>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104B280-0x000000018104B6D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104B6D0-0x000000018104B9A0
	}

	// Constructors
	public BeetleController(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000181043B80-0x0000000181043CD0
	private void OnDestroy(); // 0x00000001810432E0-0x0000000181043440
	private void Update(); // 0x0000000181043CD0-0x0000000181043D70
	public void ClearBeetles(); // 0x0000000181042D60-0x0000000181042E70
	public void Setup(int inCount, bool isTutorial = false /* Metadata: 0x007832C8 */); // 0x00000001810437C0-0x0000000181043B80
	public bool CanHandleDrop(); // 0x0000000181042BE0-0x0000000181042D60
	private Beetle GetFirstAvailableBeetle(); // 0x0000000181043020-0x0000000181043110
	private void OnBeetleSelected(BeetleSelectedMessage inMessage); // 0x0000000181043190-0x00000001810432E0
	private void OnIngredientDropped(IngredientDropMessage inMessage); // 0x00000001810434D0-0x00000001810436C0
	public void OnMixIngredients(); // 0x0000000181043750-0x00000001810437C0
	public void OnMixIngredientsTutorial(); // 0x00000001810436E0-0x0000000181043750
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000181043440-0x00000001810434D0
	private void OnLevelFinished(CodeBreakerLevelFinishedMessage inMessage); // 0x00000001810436C0-0x00000001810436E0
	public Code GetCode(); // 0x0000000181042E70-0x0000000181043020
	[IteratorStateMachine] // 0x00000001801377A0-0x00000001801377F0
	private IEnumerator MixIngredientsSequence(Code inCode, bool isTutorial = false /* Metadata: 0x007832C9 */); // 0x0000000181043110-0x0000000181043190
}

