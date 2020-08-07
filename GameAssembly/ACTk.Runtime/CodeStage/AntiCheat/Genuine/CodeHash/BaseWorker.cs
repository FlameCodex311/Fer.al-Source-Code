/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal abstract class BaseWorker // TypeDefIndex: 7379
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HashGeneratorResult <Result>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsBusy>k__BackingField; // 0x18
	
		// Properties
		public HashGeneratorResult Result { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public bool IsBusy { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
	
		// Constructors
		protected BaseWorker(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual void Execute(); // 0x0000000180B32300-0x0000000180B32310
		protected virtual void Complete(HashGeneratorResult result); // 0x00000001806A9A60-0x00000001806A9A70
	}
}
