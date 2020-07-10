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
	[Category] // 0x00000001801030D0-0x0000000180103130
	[Description] // 0x00000001801030D0-0x0000000180103130
	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 14309
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018125E2A0-0x000000018125E2E0 
	
		// Constructors
		public SendMessage(); // 0x000000018125E260-0x000000018125E2A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018125E1D0-0x000000018125E260
	}
}
