/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class BuildHashes // TypeDefIndex: 7204
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly string <BuildPath>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly FileHash[] <FileHashes>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly string <SummaryHash>k__BackingField; // 0x20
	
		// Properties
		public string BuildPath { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
		public FileHash[] FileHashes { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		public string SummaryHash { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7205
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<FileHash> <>9__9_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181BB7EE0-0x0000000181BB7F40
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <.ctor>b__9_0(FileHash x, FileHash y); // 0x0000000181BB7EA0-0x0000000181BB7EE0
		}
	
		// Constructors
		internal BuildHashes(string buildPath, List<FileHash> fileHashes, SHA1Managed sha1); // 0x0000000181BAB470-0x0000000181BAB5C0
		internal BuildHashes(string buildPath, FileHash[] fileHashes, string summaryHash); // 0x0000000181BAB420-0x0000000181BAB470
	
		// Methods
		public bool HasFileHash(string hash); // 0x0000000181BAAEB0-0x0000000181BAAF50
		public void PrintToConsole(); // 0x0000000181BAAF50-0x0000000181BAB420
		private string CalculateSummaryCodeHash(List<FileHash> fileHashes, SHA1Managed sha1); // 0x0000000181BAACD0-0x0000000181BAAEB0
	}
}
