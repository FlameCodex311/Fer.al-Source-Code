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
	[Category] // 0x0000000180259460-0x00000001802594C0
	[Description] // 0x0000000180259460-0x00000001802594C0
	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 15363
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> childName; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAB620-0x0000000180BAB680 
	
		// Constructors
		public FindChildByName(); // 0x0000000180BAB5E0-0x0000000180BAB620
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAB500-0x0000000180BAB5E0
	}
}
