/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018026B680-0x000000018026B6E0
	[Description] // 0x000000018026B680-0x000000018026B6E0
	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 15419
		where T : Component
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> message;
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<object> argument;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendMessageToType();
	
		// Methods
		protected override void OnExecute();
	}
}
