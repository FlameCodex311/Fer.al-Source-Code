/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public struct EventData<T> : IEventData // TypeDefIndex: 15826
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject <receiver>k__BackingField;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <sender>k__BackingField;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T <value>k__BackingField;
	
		// Properties
		public GameObject receiver { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
		public object sender { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
		public T value { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
		public object valueBoxed { get; }
	
		// Constructors
		public EventData(T value, GameObject receiver, object sender);
	}
}
