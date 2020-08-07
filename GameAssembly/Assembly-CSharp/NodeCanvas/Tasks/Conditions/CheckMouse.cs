/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023D710-0x000000018023D740
	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 15260
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807F4520-0x00000001807F45B0 
	
		// Constructors
		public CheckMouse(); // 0x00000001807F44E0-0x00000001807F4520
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		protected override void OnEnable(); // 0x00000001807F43C0-0x00000001807F44E0
		protected override void OnDisable(); // 0x00000001807F42A0-0x00000001807F43C0
		private void OnMouseEnter(EventData msg); // 0x00000001807F3510-0x00000001807F3530
		private void OnMouseExit(EventData msg); // 0x00000001807F3530-0x00000001807F3550
		private void OnMouseOver(EventData msg); // 0x00000001807F3550-0x00000001807F3570
	}
}
