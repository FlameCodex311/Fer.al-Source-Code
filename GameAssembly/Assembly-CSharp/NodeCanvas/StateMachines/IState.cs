/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	public interface IState // TypeDefIndex: 14009
	{
		// Properties
		string name { get; }
		string tag { get; }
		float elapsedTime { get; }
		FSM FSM { get; }
	
		// Methods
		FSMConnection[] GetTransitions();
		bool CheckTransitions();
		void Finish(bool success);
	}
}
