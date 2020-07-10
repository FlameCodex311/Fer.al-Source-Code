/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010C300-0x000000018010C360
	[Description] // 0x000000018010C300-0x000000018010C360
	public class SendEventToObjects<T> : ActionTask // TypeDefIndex: 14342
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> targetObjects;
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendEventToObjects();
	
		// Methods
		protected override void OnExecute();
	}
}
