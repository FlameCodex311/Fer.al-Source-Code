/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	public interface ITaskSystem // TypeDefIndex: 14596
	{
		// Properties
		Component agent { get; }
		IBlackboard blackboard { get; }
		float elapsedTime { get; }
		UnityEngine.Object contextObject { get; }
	
		// Methods
		void SendTaskOwnerDefaults();
		void SendEvent(EventData eventData, object sender);
		void RecordUndo(string name);
	}
}
