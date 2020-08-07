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
	[Category] // 0x00000001802408C0-0x0000000180240920
	[Description] // 0x00000001802408C0-0x0000000180240920
	public class CheckSignal : ConditionTask<Transform> // TypeDefIndex: 15273
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807F5AE0-0x00000001807F5B10 
	
		// Constructors
		public CheckSignal(); // 0x00000001807F5A70-0x00000001807F5AE0
	
		// Methods
		protected override string OnInit(); // 0x00000001807F5850-0x00000001807F58B0
		protected override void OnEnable(); // 0x00000001807F5750-0x00000001807F5850
		protected override void OnDisable(); // 0x00000001807F56B0-0x00000001807F5750
		private void OnSignalInvoke(Transform sender, Transform receiver, bool isGlobal, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x00000001807F58B0-0x00000001807F5A70
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
	}
}
