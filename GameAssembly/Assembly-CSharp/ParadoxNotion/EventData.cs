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
	public struct EventData : IEventData // TypeDefIndex: 15825
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject <receiver>k__BackingField; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <sender>k__BackingField; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <value>k__BackingField; // 0x10
	
		// Properties
		public GameObject receiver { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018001A8D0-0x000000018001A8E0 0x000000018001A8F0-0x000000018001A900
		public object sender { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001800034E0-0x00000001800034F0 0x000000018001A900-0x000000018001A910
		public object value { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018001A8E0-0x000000018001A8F0 0x000000018001A910-0x000000018001AA00
		public object valueBoxed { get; } // 0x000000018001A8E0-0x000000018001A8F0 
	
		// Constructors
		public EventData(object value, GameObject receiver, object sender); // 0x000000018001A8C0-0x000000018001A8D0
		public EventData(GameObject receiver, object sender); // 0x000000018001A8A0-0x000000018001A8C0
	}
}
