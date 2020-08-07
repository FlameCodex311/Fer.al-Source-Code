/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace DiffPlex.Model
{
	public class DiffResult // TypeDefIndex: 14340
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly string[] <PiecesOld>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly string[] <PiecesNew>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly IList<DiffBlock> <DiffBlocks>k__BackingField; // 0x20
	
		// Properties
		public string[] PiecesOld { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
		public string[] PiecesNew { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		public IList<DiffBlock> DiffBlocks { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 
	
		// Constructors
		public DiffResult(string[] peicesOld, string[] piecesNew, IList<DiffBlock> blocks); // 0x0000000180852BD0-0x0000000180852C20
	}
}
