/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class HashGeneratorResult // TypeDefIndex: 7376
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <ErrorMessage>k__BackingField; // 0x10
		private string summaryCodeHash; // 0x18
		private BuildHashes buildHashes; // 0x20
	
		// Properties
		[Obsolete] // 0x000000018024E9E0-0x000000018024EA10
		public string CodeHash { get; } // 0x00000001803FBF40-0x00000001803FBF60 
		public string SummaryHash { get; } // 0x00000001803FBF40-0x00000001803FBF60 
		public FileHash[] FileHashes { get; } // 0x0000000180CA3590-0x0000000180CA35B0 
		public string ErrorMessage { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public bool Success { get; } // 0x00000001811AE400-0x00000001811AE410 
	
		// Constructors
		public HashGeneratorResult(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal static HashGeneratorResult FromError(string errorMessage); // 0x000000018187E0D0-0x000000018187E130
		internal static HashGeneratorResult FromBuildHashes(BuildHashes buildHashes); // 0x000000018187E070-0x000000018187E0D0
		public bool HasFileHash(string hash); // 0x000000018187E130-0x000000018187E1D0
	}
}
