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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BeetleController : MonoBehaviour // TypeDefIndex: 10519
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
	private bool Paused { get; } // 0x000000018212AB50-0x000000018212AB60 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MixIngredientsSequence>d__27 : IEnumerator<object> // TypeDefIndex: 10520
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BeetleController <>4__this; // 0x20
		public bool isTutorial; // 0x28
		public Code inCode; // 0x30
		private int <i>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MixIngredientsSequence>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018214A960-0x000000018214ADA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018214ADA0-0x000000018214ADF0
	}

	// Constructors
	public BeetleController(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018212A960-0x000000018212AAB0
	private void OnDestroy(); // 0x000000018212A0E0-0x000000018212A240
	private void Update(); // 0x000000018212AAB0-0x000000018212AB50
	public void ClearBeetles(); // 0x0000000182129B60-0x0000000182129C70
	public void Setup(int inCount, bool isTutorial = false /* Metadata: 0x0077BD73 */); // 0x000000018212A5A0-0x000000018212A960
	public bool CanHandleDrop(); // 0x00000001821299E0-0x0000000182129B60
	private Beetle GetFirstAvailableBeetle(); // 0x0000000182129E20-0x0000000182129F10
	private void OnBeetleSelected(BeetleSelectedMessage inMessage); // 0x0000000182129F90-0x000000018212A0E0
	private void OnIngredientDropped(IngredientDropMessage inMessage); // 0x000000018212A2D0-0x000000018212A4B0
	public void OnMixIngredients(); // 0x000000018212A530-0x000000018212A5A0
	public void OnMixIngredientsTutorial(); // 0x000000018212A4D0-0x000000018212A530
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x000000018212A240-0x000000018212A2D0
	private void OnLevelFinished(CodeBreakerLevelFinishedMessage inMessage); // 0x000000018212A4B0-0x000000018212A4D0
	public Code GetCode(); // 0x0000000182129C70-0x0000000182129E20
	[IteratorStateMachine] // 0x0000000180210E40-0x0000000180210E90
	private IEnumerator MixIngredientsSequence(Code inCode, bool isTutorial = false /* Metadata: 0x0077BD74 */); // 0x0000000182129F10-0x0000000182129F90
}

