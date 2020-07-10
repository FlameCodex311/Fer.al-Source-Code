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
	[Category] // 0x000000018010C6A0-0x000000018010C700
	[Description] // 0x000000018010C6A0-0x000000018010C700
	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 14343
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> shoutRange; // 0x70
		public BBParameter<float> completionTime; // 0x78
		private GraphOwner[] owners; // 0x80
		private List<GraphOwner> receivedOwners; // 0x88
		private float traveledDistance; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000181263340-0x00000001812633A0 
	
		// Constructors
		public ShoutEvent(); // 0x00000001812632D0-0x0000000181263340
	
		// Methods
		protected override void OnExecute(); // 0x0000000181262ED0-0x0000000181262F60
		protected override void OnUpdate(); // 0x0000000181262F60-0x00000001812632D0
		public override void OnDrawGizmosSelected(); // 0x0000000181262D30-0x0000000181262ED0
	}
}
