/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public interface ITaskSystem // TypeDefIndex: 15730
	{
		// Properties
		Component agent { get; }
		IBlackboard blackboard { get; }
		UnityEngine.Object contextObject { get; }
		float elapsedTime { get; }
	
		// Methods
		void UpdateTasksOwner();
		void SendEvent(string name, object value, object sender);
		void SendEvent<T>(string name, T value, object sender);
	}
}
