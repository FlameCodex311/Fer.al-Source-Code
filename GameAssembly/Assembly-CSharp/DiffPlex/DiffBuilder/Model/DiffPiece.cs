/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace DiffPlex.DiffBuilder.Model
{
	public class DiffPiece : IEquatable<DiffPlex.DiffBuilder.Model.DiffPiece> // TypeDefIndex: 15964
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ChangeType <Type>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int? <Position>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Text>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private List<DiffPiece> <SubPieces>k__BackingField; // 0x28
	
		// Properties
		public ChangeType Type { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public int? Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181185EF0-0x0000000181185F00 0x0000000181185F00-0x0000000181185F10
		public string Text { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public List<DiffPiece> SubPieces { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		public DiffPiece(string text, ChangeType type, int? position = default); // 0x0000000181185E30-0x0000000181185ED0
		public DiffPiece(); // 0x0000000181185ED0-0x0000000181185EF0
	
		// Methods
		public override bool Equals(object obj); // 0x0000000181185B00-0x0000000181185B80
		public bool Equals(DiffPiece other); // 0x0000000181185950-0x0000000181185B00
		public override int GetHashCode(); // 0x0000000181185B80-0x0000000181185CE0
		private bool SubPiecesEqual(DiffPiece other); // 0x0000000181185CE0-0x0000000181185E30
	}
}
