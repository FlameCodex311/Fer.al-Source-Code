/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public interface ICodeHashGenerator // TypeDefIndex: 7212
	{
		// Properties
		HashGeneratorResult LastResult { get; }
		bool IsBusy { get; }
	
		// Methods
		ICodeHashGenerator Generate();
	}
}
