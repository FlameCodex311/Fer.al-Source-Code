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
	public class InlineDiffBuilder : IInlineDiffBuilder // TypeDefIndex: 14346
	{
		// Fields
		private readonly IDiffer differ; // 0x10
	
		// Constructors
		public InlineDiffBuilder(IDiffer differ); // 0x00000001805620B0-0x0000000180562140
	
		// Methods
		public DiffPaneModel BuildDiffModel(string oldText, string newText); // 0x0000000180561890-0x00000001805619B0
		public DiffPaneModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace); // 0x0000000180561750-0x0000000180561890
		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> pieces); // 0x00000001805619B0-0x00000001805620B0
	}
}
