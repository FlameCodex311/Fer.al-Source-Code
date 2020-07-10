/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace DiffPlex.Model
{
	public class DiffResult // TypeDefIndex: 15953
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly string[] <PiecesOld>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly string[] <PiecesNew>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly IList<DiffBlock> <DiffBlocks>k__BackingField; // 0x20
	
		// Properties
		public string[] PiecesOld { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
		public string[] PiecesNew { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		public IList<DiffBlock> DiffBlocks { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 
	
		// Constructors
		public DiffResult(string[] peicesOld, string[] piecesNew, IList<DiffBlock> blocks); // 0x00000001806D0A80-0x00000001806D0AD0
	}
}
