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
	public class SendEventToObjects : ActionTask // TypeDefIndex: 14341
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125DDA0-0x000000018125DDE0 
	
		// Constructors
		public SendEventToObjects(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018125DB40-0x000000018125DDA0
	}
}
