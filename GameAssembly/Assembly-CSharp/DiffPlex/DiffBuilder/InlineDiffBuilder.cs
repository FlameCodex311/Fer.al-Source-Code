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
	public class InlineDiffBuilder : IInlineDiffBuilder // TypeDefIndex: 15958
	{
		// Fields
		private readonly IDiffer differ; // 0x10
	
		// Constructors
		public InlineDiffBuilder(IDiffer differ); // 0x0000000181199610-0x00000001811996A0
	
		// Methods
		public DiffPaneModel BuildDiffModel(string oldText, string newText); // 0x0000000181198DA0-0x0000000181198ED0
		public DiffPaneModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace); // 0x0000000181198C60-0x0000000181198DA0
		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> pieces); // 0x0000000181198ED0-0x0000000181199610
	}
}
