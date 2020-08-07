/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3DebugUtils : MonoBehaviour // TypeDefIndex: 10617
{
	// Fields
	private const string _match3GroupName = "Minigame/Match3"; // Metadata: 0x0077BF4D
	public Match3GameBoard gameBoard; // 0x20
	private List<SavedBoardState> _states; // 0x28

	// Properties
	private Match3GameBoard GameBoard { get; } // 0x00000001804FBB90-0x00000001804FBBF0 

	// Nested types
	public class SavedBoardState // TypeDefIndex: 10618
	{
		// Fields
		public byte[,] grid; // 0x10
		public int moveCount; // 0x18
		public UnityEngine.Random.State randomState; // 0x1C

		// Constructors
		public SavedBoardState(Vector2Int gridSize); // 0x00000001805060D0-0x0000000180506170
		public SavedBoardState(Match3GameBoard inBoard, UnityEngine.Random.State inRandomState); // 0x0000000180505F50-0x00000001805060D0
	}

	// Constructors
	public Match3DebugUtils(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804FB9F0-0x00000001804FBA00
	private void OnDestroy(); // 0x00000001804FB540-0x00000001804FB550
	public void PushBoardState(UnityEngine.Random.State inRandomState); // 0x00000001804FB7B0-0x00000001804FB9F0
	public void PopBoardState(); // 0x00000001804FB550-0x00000001804FB7B0
	public static byte TileToByte(Match3GameBoard inGameBoard, Match3Tile inTile); // 0x00000001804FBA00-0x00000001804FBB90
	public static Match3Tile ByteToTile(Match3GameBoard inGameBoard, byte inByte); // 0x00000001804FB1D0-0x00000001804FB540
}

