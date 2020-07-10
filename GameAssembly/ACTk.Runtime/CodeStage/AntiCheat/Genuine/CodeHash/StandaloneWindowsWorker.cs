/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class StandaloneWindowsWorker : BaseWorker // TypeDefIndex: 7214
	{
		// Constructors
		public StandaloneWindowsWorker(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static BuildHashes GetBuildHashes(string buildPath, FileFilter[] fileFilters, SHA1Managed sha1); // 0x0000000181BB6C50-0x0000000181BB7150
		public override void Execute(); // 0x0000000181BB6840-0x0000000181BB69C0
		private void GenerateHashThread(object folder); // 0x0000000181BB69C0-0x0000000181BB6C50
	}
}
