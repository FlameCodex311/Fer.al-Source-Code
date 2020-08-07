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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180277910-0x0000000180277970
	[Description] // 0x0000000180277910-0x0000000180277970
	public class SendEventToObjects : ActionTask // TypeDefIndex: 15444
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A2900-0x00000001807A2940 
	
		// Constructors
		public SendEventToObjects(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A26E0-0x00000001807A2900
	}
}
