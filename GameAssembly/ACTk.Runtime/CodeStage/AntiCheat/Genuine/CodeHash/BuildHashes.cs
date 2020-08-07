/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class BuildHashes // TypeDefIndex: 7370
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly string <BuildPath>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly FileHash[] <FileHashes>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private readonly string <SummaryHash>k__BackingField; // 0x20
	
		// Properties
		public string BuildPath { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
		public FileHash[] FileHashes { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		public string SummaryHash { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7371
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<FileHash> <>9__9_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181887F90-0x0000000181887FF0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <.ctor>b__9_0(FileHash x, FileHash y); // 0x0000000181887F50-0x0000000181887F90
		}
	
		// Constructors
		internal BuildHashes(string buildPath, List<FileHash> fileHashes, SHA1Managed sha1); // 0x000000018187CD80-0x000000018187CED0
		internal BuildHashes(string buildPath, FileHash[] fileHashes, string summaryHash); // 0x000000018187CD30-0x000000018187CD80
	
		// Methods
		public bool HasFileHash(string hash); // 0x000000018187C810-0x000000018187C8B0
		public void PrintToConsole(); // 0x000000018187C8B0-0x000000018187CD30
		private string CalculateSummaryCodeHash(List<FileHash> fileHashes, SHA1Managed sha1); // 0x000000018187C640-0x000000018187C810
	}
}
