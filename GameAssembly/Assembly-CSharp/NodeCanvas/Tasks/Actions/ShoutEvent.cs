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
	[Category] // 0x0000000180278440-0x00000001802784A0
	[Description] // 0x0000000180278440-0x00000001802784A0
	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 15446
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> shoutRange; // 0x70
		public BBParameter<float> completionTime; // 0x78
		private GraphOwner[] owners; // 0x80
		private List<GraphOwner> receivedOwners; // 0x88
		private float traveledDistance; // 0x90
	
		// Properties
		protected override string info { get; } // 0x00000001807A7D20-0x00000001807A7D80 
	
		// Constructors
		public ShoutEvent(); // 0x00000001807A7CB0-0x00000001807A7D20
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A78B0-0x00000001807A7940
		protected override void OnUpdate(); // 0x00000001807A7940-0x00000001807A7CB0
		public override void OnDrawGizmosSelected(); // 0x00000001807A7720-0x00000001807A78B0
	}
}
