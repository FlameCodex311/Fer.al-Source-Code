/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal abstract class BaseWorker // TypeDefIndex: 7213
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private HashGeneratorResult <Result>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsBusy>k__BackingField; // 0x18
	
		// Properties
		public HashGeneratorResult Result { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public bool IsBusy { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
	
		// Constructors
		protected BaseWorker(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual void Execute(); // 0x000000018050A050-0x000000018050A060
		protected virtual void Complete(HashGeneratorResult result); // 0x0000000181115400-0x0000000181115410
	}
}
