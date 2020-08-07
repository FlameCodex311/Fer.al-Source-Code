/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public interface ITriggerGate // TypeDefIndex: 14589
	{
		// Properties
		bool IsActive { get; }
	
		// Methods
		void TriggerWasEntered(Collider other);
		bool IsTriggerBlocked();
	}
}
