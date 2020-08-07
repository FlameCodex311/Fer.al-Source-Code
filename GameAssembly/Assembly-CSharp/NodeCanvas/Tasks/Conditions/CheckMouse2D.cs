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
	[Category] // 0x000000018023D840-0x000000018023D8A0
	[Name] // 0x000000018023D840-0x000000018023D8A0
	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 15261
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807F35B0-0x00000001807F3640 
	
		// Constructors
		public CheckMouse2D(); // 0x00000001807F3570-0x00000001807F35B0
	
		// Methods
		protected override void OnEnable(); // 0x00000001807F33F0-0x00000001807F3510
		protected override void OnDisable(); // 0x00000001807F32D0-0x00000001807F33F0
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void OnMouseEnter(EventData msg); // 0x00000001807F3510-0x00000001807F3530
		private void OnMouseExit(EventData msg); // 0x00000001807F3530-0x00000001807F3550
		private void OnMouseOver(EventData msg); // 0x00000001807F3550-0x00000001807F3570
	}
}
