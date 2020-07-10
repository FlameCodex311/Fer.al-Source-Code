/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ParlorGameBase : MonoBehaviour // TypeDefIndex: 13132
{
	// Fields
	public GameObject gameBoard; // 0x20
	public Animator gameBoardAnimator; // 0x28
	public Renderer gameBoardRenderer; // 0x30
	public Texture gameBoardMatOverride; // 0x38
	public Texture gameBoardBackOverride; // 0x40
	public Material gameBoardMatMaterialOverride; // 0x48
	public bool serverReady; // 0x50
	public float afterWagerDelay; // 0x54
	public float rollOutGameBoardDelay; // 0x58
	public float compareTime; // 0x5C
	public ParlorManager.EParlorGame parlorGame; // 0x60
	public EWinReplayType winReplayType; // 0x64
	[RootSelector] // 0x00000001800F5440-0x00000001800F54A0
	public string gameName; // 0x68
	private string _gameName; // 0x70
	[RootSelector] // 0x00000001800F5700-0x00000001800F5760
	public string gameDescription; // 0x78
	private string _gameDescription; // 0x80
	public Sprite gameSelectImage; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public GamePieceSpawner[] spawnedGamePieces; // 0x90
	internal ParlorManager parlorManager; // 0x98
	internal int scoreMultiplier; // 0xA0
	internal static int doubleUpsAllowed; // 0x00
	private static Material _cachedGameBoardMaterial; // 0x08

	// Properties
	internal string GameName { get; } // 0x000000018116C370-0x000000018116C460 
	internal string GameDescription { get; } // 0x000000018116C280-0x000000018116C370 

	// Nested types
	public enum EWinReplayType // TypeDefIndex: 13133
	{
		DoubleUp = 0,
		Multiplyer = 1
	}

	[Serializable]
	public class GamePieceSpawner // TypeDefIndex: 13134
	{
		// Fields
		public Transform gamePiece; // 0x10
		public float spawnDelay; // 0x18
		public float spawnTime; // 0x1C
		public UnityEvent OnLoaded; // 0x20
		private Vector3 _baseScale; // 0x28

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Spawn>d__5 : IEnumerator<object> // TypeDefIndex: 13135
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GamePieceSpawner <>4__this; // 0x20
			public float inRollOutGameBoardDelay; // 0x28
			private float <t>5__2; // 0x2C

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Spawn>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018117A2B0-0x000000018117A690
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018117A690-0x000000018117A6E0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DeSpawn>d__6 : IEnumerator<object> // TypeDefIndex: 13136
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GamePieceSpawner <>4__this; // 0x20
			private float <t>5__2; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DeSpawn>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181179320-0x0000000181179510
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181179510-0x0000000181179560
		}

		// Constructors
		public GamePieceSpawner(); // 0x00000001811674B0-0x0000000181167530

		// Methods
		[IteratorStateMachine] // 0x00000001800F6240-0x00000001800F6290
		internal IEnumerator Spawn(float inRollOutGameBoardDelay); // 0x0000000181167440-0x00000001811674B0
		[IteratorStateMachine] // 0x00000001800F66D0-0x00000001800F6720
		internal IEnumerator DeSpawn(); // 0x00000001811673E0-0x0000000181167440
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Load>d__28 : IEnumerator<object> // TypeDefIndex: 13137
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorGameBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Load>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181179770-0x0000000181179C40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181179C40-0x0000000181179C90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartGame>d__30 : IEnumerator<object> // TypeDefIndex: 13138
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorGameBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartGame>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018117A6E0-0x000000018117A780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018117A780-0x000000018117A7D0
	}

	// Constructors
	public ParlorGameBase(); // 0x000000018116C250-0x000000018116C280
	static ParlorGameBase(); // 0x000000018116C210-0x000000018116C250

	// Methods
	[IteratorStateMachine] // 0x00000001800F5A70-0x00000001800F5AC0
	internal virtual IEnumerator Load(int[] inAdditionalParameters = null); // 0x000000018116BE80-0x000000018116BEE0
	internal virtual void Unload(); // 0x000000018116C060-0x000000018116C210
	[IteratorStateMachine] // 0x00000001800F5DD0-0x00000001800F5E20
	internal virtual IEnumerator StartGame(); // 0x000000018116BEF0-0x000000018116BF50
	internal virtual void Replay(bool inDoubleUp = false /* Metadata: 0x00783684 */); // 0x00000001803581E0-0x00000001803581F0
	internal virtual void MultiplierResponse(int inMultiplerResults); // 0x00000001803581E0-0x00000001803581F0
	internal virtual void GameResponse(ParlorGameCommand parlorGameCommand); // 0x00000001803581E0-0x00000001803581F0
	internal virtual bool OverDoubleUpLimit(); // 0x000000018116BEE0-0x000000018116BEF0
	internal virtual ParlorManager.EWinState GetWinStateFromCommand(string inState); // 0x000000018116BDE0-0x000000018116BE80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Unload>b__29_0(); // 0x000000018116BF50-0x000000018116C060
}

