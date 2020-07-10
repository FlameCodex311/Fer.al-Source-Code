/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GameBoardMatch : HashSet<Match3Cell> // TypeDefIndex: 12939
{
	// Fields
	public Match3Cell primaryCell; // 0x48
	public Dictionary<Match3Cell, BoosterMatch> boosters; // 0x50
	private List<BoosterShapeFound> _foundBoosterShapes; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <MatchCount>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <CanCombine>k__BackingField; // 0x64
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <CanShapeMatch>k__BackingField; // 0x65

	// Properties
	public int MatchCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A3730-0x00000001804A3740 0x000000018044E340-0x000000018044E350
	public bool CanCombine { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EF8A10-0x0000000180EF8A20 0x0000000181051B60-0x0000000181051B70
	public bool CanShapeMatch { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181051B50-0x0000000181051B60 0x0000000181051B70-0x0000000181051B80

	// Constructors
	public GameBoardMatch(List<Match3Cell> inMatchedCells, bool inCanCombine = true /* Metadata: 0x00783349 */, bool inCanShapeMatch = true /* Metadata: 0x0078334A */); // 0x0000000181051A80-0x0000000181051B50

	// Methods
	private void SetupMatchSet(List<Match3Cell> inMatchedCells); // 0x0000000181051550-0x0000000181051930
	private void AddBooster(Match3Cell atCell, BoosterType boosterType, IEnumerable<Match3Cell> cells); // 0x00000001810502F0-0x0000000181050560
	public void CombineMatches(GameBoardMatch inOtherMatch); // 0x0000000181050B70-0x0000000181050C00
	public void FindBoosterShapeMatch(Match3Grid inGrid, BoosterShapeData inBoosterShape); // 0x0000000181050C00-0x0000000181051550
	private bool AnyCellSameRowOrColumn(IEnumerable<Match3Cell> inCells); // 0x0000000181050840-0x0000000181050890
	private bool AnyCellSameRow(IEnumerable<Match3Cell> inCells); // 0x0000000181050890-0x0000000181050B70
	private bool AnyCellSameColumn(IEnumerable<Match3Cell> inCells); // 0x0000000181050560-0x0000000181050840
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <FindBoosterShapeMatch>b__19_0(Match3Cell cellA, Match3Cell cellB); // 0x0000000181051930-0x0000000181051A80
}

