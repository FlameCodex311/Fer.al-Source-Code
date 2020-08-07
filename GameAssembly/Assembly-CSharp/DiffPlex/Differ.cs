/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DiffPlex.Model;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace DiffPlex
{
	public class Differ : IDiffer // TypeDefIndex: 14334
	{
		// Fields
		private static readonly string[] emptyStringArray; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14335
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<string, string[]> <>9__2_0; // 0x08
			public static Func<string, string[]> <>9__4_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018086C200-0x000000018086C260
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string[] <CreateLineDiffs>b__2_0(string str); // 0x000000018086B9E0-0x000000018086BB60
			internal string[] <CreateCharacterDiffs>b__4_0(string str); // 0x000000018086B8F0-0x000000018086B9E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 14336
		{
			// Fields
			public char[] separators; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string[] <CreateWordDiffs>b__0(string str); // 0x000000018086C130-0x000000018086C1A0
		}
	
		// Constructors
		public Differ(); // 0x0000000180373240-0x0000000180373250
		static Differ(); // 0x0000000180854DC0-0x0000000180854E10
	
		// Methods
		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace); // 0x0000000180854580-0x0000000180854720
		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase); // 0x0000000180854720-0x00000001808548C0
		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace); // 0x0000000180853ED0-0x0000000180854070
		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase); // 0x0000000180853D30-0x0000000180853ED0
		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators); // 0x00000001808548C0-0x0000000180854A10
		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators); // 0x0000000180854A10-0x0000000180854B70
		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker); // 0x0000000180854070-0x00000001808540A0
		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker); // 0x00000001808540A0-0x0000000180854580
		private static string[] SmartSplit(string str, char[] delims); // 0x0000000180854B70-0x0000000180854DC0
		protected static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB); // 0x0000000180853C40-0x0000000180853D30
		private static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal); // 0x00000001808534A0-0x0000000180853C40
		protected static void BuildModificationData(ModificationData A, ModificationData B); // 0x0000000180852C20-0x0000000180852D40
		private static void BuildModificationData(ModificationData A, int startA, int endA, ModificationData B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal); // 0x0000000180852D40-0x0000000180853210
		private static void BuildPieceHashes(IDictionary<string, int> pieceHash, ModificationData data, bool ignoreWhitespace, bool ignoreCase, Func<string, string[]> chunker); // 0x0000000180853210-0x00000001808534A0
	}
}
