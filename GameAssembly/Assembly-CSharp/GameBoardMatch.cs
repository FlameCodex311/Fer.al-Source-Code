/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GameBoardMatch : HashSet<Match3Cell> // TypeDefIndex: 10604
{
	// Fields
	public Match3Cell primaryCell; // 0x48
	public Dictionary<Match3Cell, BoosterMatch> boosters; // 0x50
	private List<BoosterShapeFound> _foundBoosterShapes; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <MatchCount>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <CanCombine>k__BackingField; // 0x64
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <CanShapeMatch>k__BackingField; // 0x65

	// Properties
	public int MatchCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804ADA80-0x00000001804ADA90 0x00000001804ADAB0-0x00000001804ADAC0
	public bool CanCombine { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804CDB10-0x00000001804CDB20 0x000000018067C450-0x000000018067C460
	public bool CanShapeMatch { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018067C440-0x000000018067C450 0x000000018067C460-0x000000018067C470

	// Constructors
	public GameBoardMatch(List<Match3Cell> inMatchedCells, bool inCanCombine = true /* Metadata: 0x0077BE04 */, bool inCanShapeMatch = true /* Metadata: 0x0077BE05 */); // 0x000000018067C370-0x000000018067C440

	// Methods
	private void SetupMatchSet(List<Match3Cell> inMatchedCells); // 0x000000018067BE70-0x000000018067C230
	private void AddBooster(Match3Cell atCell, BoosterType boosterType, IEnumerable<Match3Cell> cells); // 0x000000018067AC70-0x000000018067AED0
	public void CombineMatches(GameBoardMatch inOtherMatch); // 0x000000018067B4C0-0x000000018067B550
	public void FindBoosterShapeMatch(Match3Grid inGrid, BoosterShapeData inBoosterShape); // 0x000000018067B550-0x000000018067BE70
	private bool AnyCellSameRowOrColumn(IEnumerable<Match3Cell> inCells); // 0x000000018067B1A0-0x000000018067B1F0
	private bool AnyCellSameRow(IEnumerable<Match3Cell> inCells); // 0x000000018067B1F0-0x000000018067B4C0
	private bool AnyCellSameColumn(IEnumerable<Match3Cell> inCells); // 0x000000018067AED0-0x000000018067B1A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <FindBoosterShapeMatch>b__19_0(Match3Cell cellA, Match3Cell cellB); // 0x000000018067C230-0x000000018067C370
}

