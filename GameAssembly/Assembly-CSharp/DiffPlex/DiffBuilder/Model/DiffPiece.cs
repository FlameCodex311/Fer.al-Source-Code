/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace DiffPlex.DiffBuilder.Model
{
	public class DiffPiece : IEquatable<DiffPlex.DiffBuilder.Model.DiffPiece> // TypeDefIndex: 14351
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ChangeType <Type>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int? <Position>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Text>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<DiffPiece> <SubPieces>k__BackingField; // 0x28
	
		// Properties
		public ChangeType Type { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public int? Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180561730-0x0000000180561740 0x0000000180561740-0x0000000180561750
		public string Text { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public List<DiffPiece> SubPieces { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public DiffPiece(string text, ChangeType type, int? position = default); // 0x0000000180561670-0x0000000180561710
		public DiffPiece(); // 0x0000000180561710-0x0000000180561730
	
		// Methods
		public override bool Equals(object obj); // 0x0000000180561360-0x00000001805613E0
		public bool Equals(DiffPiece other); // 0x00000001805611B0-0x0000000180561360
		public override int GetHashCode(); // 0x00000001805613E0-0x0000000180561530
		private bool SubPiecesEqual(DiffPiece other); // 0x0000000180561530-0x0000000180561670
	}
}
