/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180103810-0x0000000180103870
	[Description] // 0x0000000180103810-0x0000000180103870
	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 14311
		where T : Component
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> message;
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<object> argument;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendMessageToType();
	
		// Methods
		protected override void OnExecute();
	}
}
