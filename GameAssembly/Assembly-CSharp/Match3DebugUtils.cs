/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3DebugUtils : MonoBehaviour // TypeDefIndex: 12952
{
	// Fields
	private const string _match3GroupName = "Minigame/Match3"; // Metadata: 0x00783492
	public Match3GameBoard gameBoard; // 0x20
	private List<SavedBoardState> _states; // 0x28

	// Properties
	private Match3GameBoard GameBoard { get; } // 0x00000001816C22D0-0x00000001816C2330 

	// Nested types
	public class SavedBoardState // TypeDefIndex: 12953
	{
		// Fields
		public byte[,] grid; // 0x10
		public int moveCount; // 0x18
		public UnityEngine.Random.State randomState; // 0x1C

		// Constructors
		public SavedBoardState(Vector2Int gridSize); // 0x00000001816CFB70-0x00000001816D0E00
		public SavedBoardState(Match3GameBoard inBoard, UnityEngine.Random.State inRandomState); // 0x00000001816CF9E0-0x00000001816CFB70
	}

	// Constructors
	public Match3DebugUtils(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001816C2120-0x00000001816C2130
	private void OnDestroy(); // 0x00000001816C1DA0-0x00000001816C1DB0
	public void PushBoardState(UnityEngine.Random.State inRandomState); // 0x00000001816C2020-0x00000001816C2120
	public void PopBoardState(); // 0x00000001816C1DB0-0x00000001816C2020
	public static byte TileToByte(Match3GameBoard inGameBoard, Match3Tile inTile); // 0x00000001816C2130-0x00000001816C22D0
	public static Match3Tile ByteToTile(Match3GameBoard inGameBoard, byte inByte); // 0x00000001816C1A10-0x00000001816C1DA0
}

