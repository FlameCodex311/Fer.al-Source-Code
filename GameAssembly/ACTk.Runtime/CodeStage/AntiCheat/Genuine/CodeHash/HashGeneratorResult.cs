/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public class HashGeneratorResult // TypeDefIndex: 7210
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <ErrorMessage>k__BackingField; // 0x10
		private string summaryCodeHash; // 0x18
		private BuildHashes buildHashes; // 0x20
	
		// Properties
		[Obsolete] // 0x00000001800EDF10-0x00000001800EDF40
		public string CodeHash { get; } // 0x00000001805B94B0-0x00000001805B94D0 
		public string SummaryHash { get; } // 0x00000001805B94B0-0x00000001805B94D0 
		public FileHash[] FileHashes { get; } // 0x00000001805B9470-0x00000001805B9490 
		public string ErrorMessage { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public bool Success { get; } // 0x0000000180BB2860-0x0000000180BB2870 
	
		// Constructors
		public HashGeneratorResult(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal static HashGeneratorResult FromError(string errorMessage); // 0x0000000181BAC820-0x0000000181BAC880
		internal static HashGeneratorResult FromBuildHashes(BuildHashes buildHashes); // 0x0000000181BAC7C0-0x0000000181BAC820
		public bool HasFileHash(string hash); // 0x0000000181BAC880-0x0000000181BAC930
	}
}
