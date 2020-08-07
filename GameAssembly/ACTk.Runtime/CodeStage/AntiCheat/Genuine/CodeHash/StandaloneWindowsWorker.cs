/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class StandaloneWindowsWorker : BaseWorker // TypeDefIndex: 7380
	{
		// Constructors
		public StandaloneWindowsWorker(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static BuildHashes GetBuildHashes(string buildPath, FileFilter[] fileFilters, SHA1Managed sha1); // 0x0000000181886D20-0x0000000181887210
		public override void Execute(); // 0x0000000181886920-0x0000000181886AA0
		private void GenerateHashThread(object folder); // 0x0000000181886AA0-0x0000000181886D20
	}
}
