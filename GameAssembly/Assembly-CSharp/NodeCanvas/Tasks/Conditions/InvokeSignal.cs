/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180222510-0x0000000180222570
	[Description] // 0x0000000180222510-0x0000000180222570
	public class InvokeSignal : ActionTask<Transform> // TypeDefIndex: 15196
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		public bool global; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x78
		private object[] args; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F5AE0-0x00000001807F5B10 
	
		// Constructors
		public InvokeSignal(); // 0x00000001807FF170-0x00000001807FF1E0
	
		// Methods
		protected override string OnInit(); // 0x00000001807FF0E0-0x00000001807FF170
		protected override void OnExecute(); // 0x00000001807FEEE0-0x00000001807FF0E0
	}
}
