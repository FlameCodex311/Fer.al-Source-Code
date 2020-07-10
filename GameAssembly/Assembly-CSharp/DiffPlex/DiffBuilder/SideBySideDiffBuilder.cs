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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace DiffPlex.DiffBuilder
{
	public class SideBySideDiffBuilder : ISideBySideDiffBuilder // TypeDefIndex: 15960
	{
		// Fields
		private readonly IDiffer differ; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly char[] <WordSeparaters>k__BackingField; // 0x18
	
		// Properties
		public char[] WordSeparaters { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
		// Nested types
		private delegate void PieceBuilder(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces); // TypeDefIndex: 15961; 0x00000001811998E0-0x0000000181199DC0
	
		// Constructors
		public SideBySideDiffBuilder(IDiffer differ); // 0x000000018119AF10-0x000000018119AFC0
		public SideBySideDiffBuilder(IDiffer differ, char[] wordSeparators); // 0x000000018119ADE0-0x000000018119AF10
	
		// Methods
		public SideBySideDiffModel BuildDiffModel(string oldText, string newText); // 0x000000018119A060-0x000000018119A080
		public SideBySideDiffModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace); // 0x0000000181199DC0-0x000000018119A060
		private SideBySideDiffModel BuildLineDiff(string oldText, string newText, bool ignoreWhitespace); // 0x000000018119AAD0-0x000000018119ACC0
		private void BuildWordDiffPieces(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces); // 0x000000018119ACC0-0x000000018119ADE0
		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> oldPieces, List<DiffPiece> newPieces, PieceBuilder subPieceBuilder); // 0x000000018119A080-0x000000018119AAD0
	}
}
