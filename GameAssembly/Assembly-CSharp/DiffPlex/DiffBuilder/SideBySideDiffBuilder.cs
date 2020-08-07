/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DiffPlex;
using DiffPlex.DiffBuilder.Model;
using DiffPlex.Model;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace DiffPlex.DiffBuilder
{
	public class SideBySideDiffBuilder : ISideBySideDiffBuilder // TypeDefIndex: 14347
	{
		// Fields
		private readonly IDiffer differ; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly char[] <WordSeparaters>k__BackingField; // 0x18
	
		// Properties
		public char[] WordSeparaters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
		// Nested types
		private delegate void PieceBuilder(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces); // TypeDefIndex: 14348; 0x0000000180869FB0-0x000000018086A4F0
	
		// Constructors
		public SideBySideDiffBuilder(IDiffer differ); // 0x0000000180563340-0x00000001805633F0
		public SideBySideDiffBuilder(IDiffer differ, char[] wordSeparators); // 0x0000000180563220-0x0000000180563340
	
		// Methods
		public SideBySideDiffModel BuildDiffModel(string oldText, string newText); // 0x0000000180562500-0x0000000180562520
		public SideBySideDiffModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace); // 0x0000000180562270-0x0000000180562500
		private SideBySideDiffModel BuildLineDiff(string oldText, string newText, bool ignoreWhitespace); // 0x0000000180562F10-0x0000000180563100
		private void BuildWordDiffPieces(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces); // 0x0000000180563100-0x0000000180563220
		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> oldPieces, List<DiffPiece> newPieces, PieceBuilder subPieceBuilder); // 0x0000000180562520-0x0000000180562F10
	}
}
