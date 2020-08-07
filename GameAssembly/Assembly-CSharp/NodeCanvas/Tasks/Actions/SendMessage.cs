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
	[Category] // 0x000000018026AF90-0x000000018026AFF0
	[Description] // 0x000000018026AF90-0x000000018026AFF0
	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 15417
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A2DC0-0x00000001807A2E00 
	
		// Constructors
		public SendMessage(); // 0x00000001807A2D80-0x00000001807A2DC0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A2CF0-0x00000001807A2D80
	}
}
