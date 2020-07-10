/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DiffPlex.Model;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace DiffPlex
{
	public class Differ : IDiffer // TypeDefIndex: 15947
	{
		// Fields
		private static readonly string[] emptyStringArray; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15948
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<string, string[]> <>9__2_0; // 0x08
			public static Func<string, string[]> <>9__4_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018119DB50-0x000000018119DBB0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string[] <CreateLineDiffs>b__2_0(string str); // 0x000000018119CCF0-0x000000018119CE90
			internal string[] <CreateCharacterDiffs>b__4_0(string str); // 0x000000018119CBF0-0x000000018119CCF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 15949
		{
			// Fields
			public char[] separators; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string[] <CreateWordDiffs>b__0(string str); // 0x000000018119D940-0x000000018119D9B0
		}
	
		// Constructors
		public Differ(); // 0x000000018036B6C0-0x000000018036B6D0
		static Differ(); // 0x0000000181188180-0x00000001811881D0
	
		// Methods
		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace); // 0x0000000181187930-0x0000000181187AD0
		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase); // 0x0000000181187AD0-0x0000000181187C70
		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace); // 0x0000000181187260-0x0000000181187400
		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase); // 0x00000001811870C0-0x0000000181187260
		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators); // 0x0000000181187C70-0x0000000181187DC0
		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators); // 0x0000000181187DC0-0x0000000181187F20
		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker); // 0x0000000181187400-0x0000000181187430
		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker); // 0x0000000181187430-0x0000000181187930
		private static string[] SmartSplit(string str, char[] delims); // 0x0000000181187F20-0x0000000181188180
		protected static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB); // 0x0000000181186FD0-0x00000001811870C0
		private static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal); // 0x00000001811867F0-0x0000000181186FD0
		protected static void BuildModificationData(ModificationData A, ModificationData B); // 0x0000000181185F10-0x0000000181186040
		private static void BuildModificationData(ModificationData A, int startA, int endA, ModificationData B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal); // 0x0000000181186040-0x0000000181186550
		private static void BuildPieceHashes(IDictionary<string, int> pieceHash, ModificationData data, bool ignoreWhitespace, bool ignoreCase, Func<string, string[]> chunker); // 0x0000000181186550-0x00000001811867F0
	}
}
