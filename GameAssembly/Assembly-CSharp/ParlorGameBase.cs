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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ParlorGameBase : MonoBehaviour // TypeDefIndex: 10797
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
	[RootSelector] // 0x000000018028FD70-0x000000018028FDD0
	public string gameName; // 0x68
	private string _gameName; // 0x70
	[RootSelector] // 0x000000018028FFA0-0x0000000180290000
	public string gameDescription; // 0x78
	private string _gameDescription; // 0x80
	public Sprite gameSelectImage; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	public GamePieceSpawner[] spawnedGamePieces; // 0x90
	internal ParlorManager parlorManager; // 0x98
	internal int scoreMultiplier; // 0xA0
	internal static int doubleUpsAllowed; // 0x00
	private static Material _cachedGameBoardMaterial; // 0x08

	// Properties
	internal string GameName { get; } // 0x00000001804D9220-0x00000001804D9310 
	internal string GameDescription { get; } // 0x00000001804D9130-0x00000001804D9220 

	// Nested types
	public enum EWinReplayType // TypeDefIndex: 10798
	{
		DoubleUp = 0,
		Multiplyer = 1
	}

	[Serializable]
	public class GamePieceSpawner // TypeDefIndex: 10799
	{
		// Fields
		public Transform gamePiece; // 0x10
		public float spawnDelay; // 0x18
		public float spawnTime; // 0x1C
		public UnityEvent OnLoaded; // 0x20
		private Vector3 _baseScale; // 0x28

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Spawn>d__5 : IEnumerator<object> // TypeDefIndex: 10800
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GamePieceSpawner <>4__this; // 0x20
			public float inRollOutGameBoardDelay; // 0x28
			private float <t>5__2; // 0x2C

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Spawn>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001804EBB40-0x00000001804EBF10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001804EBF10-0x00000001804EBF60
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DeSpawn>d__6 : IEnumerator<object> // TypeDefIndex: 10801
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GamePieceSpawner <>4__this; // 0x20
			private float <t>5__2; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DeSpawn>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001804EA750-0x00000001804EA930
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001804EA930-0x00000001804EA980
		}

		// Constructors
		public GamePieceSpawner(); // 0x00000001804D67D0-0x00000001804D6850

		// Methods
		[IteratorStateMachine] // 0x0000000180290640-0x0000000180290690
		internal IEnumerator Spawn(float inRollOutGameBoardDelay); // 0x00000001804D6760-0x00000001804D67D0
		[IteratorStateMachine] // 0x00000001802909A0-0x00000001802909F0
		internal IEnumerator DeSpawn(); // 0x00000001804D6700-0x00000001804D6760
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Load>d__28 : IEnumerator<object> // TypeDefIndex: 10802
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorGameBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Load>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EAB90-0x00000001804EB040
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EB040-0x00000001804EB090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartGame>d__30 : IEnumerator<object> // TypeDefIndex: 10803
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorGameBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartGame>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EBF60-0x00000001804EC000
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EC000-0x00000001804EC050
	}

	// Constructors
	public ParlorGameBase(); // 0x00000001804D9100-0x00000001804D9130
	static ParlorGameBase(); // 0x00000001804D90C0-0x00000001804D9100

	// Methods
	[IteratorStateMachine] // 0x0000000180290200-0x0000000180290250
	internal virtual IEnumerator Load(int[] inAdditionalParameters = null); // 0x00000001804D8D40-0x00000001804D8DA0
	internal virtual void Unload(); // 0x00000001804D8F20-0x00000001804D90C0
	[IteratorStateMachine] // 0x0000000180290390-0x00000001802903E0
	internal virtual IEnumerator StartGame(); // 0x00000001804D8DB0-0x00000001804D8E10
	internal virtual void Replay(bool inDoubleUp = false /* Metadata: 0x0077C13F */); // 0x00000001803774A0-0x00000001803774B0
	internal virtual void MultiplierResponse(int inMultiplerResults); // 0x00000001803774A0-0x00000001803774B0
	internal virtual void GameResponse(ParlorGameCommand parlorGameCommand); // 0x00000001803774A0-0x00000001803774B0
	internal virtual bool OverDoubleUpLimit(); // 0x00000001804D8DA0-0x00000001804D8DB0
	internal virtual ParlorManager.EWinState GetWinStateFromCommand(string inState); // 0x00000001804D8CA0-0x00000001804D8D40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Unload>b__29_0(); // 0x00000001804D8E10-0x00000001804D8F20
}

