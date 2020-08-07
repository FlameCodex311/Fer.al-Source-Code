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
	[Category] // 0x000000018023DB50-0x000000018023DBB0
	[Name] // 0x000000018023DB50-0x000000018023DBB0
	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 15263
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807F3820-0x00000001807F38B0 
	
		// Constructors
		public CheckMouseClick2D(); // 0x00000001807F37E0-0x00000001807F3820
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		protected override void OnEnable(); // 0x00000001807F3710-0x00000001807F37E0
		protected override void OnDisable(); // 0x00000001807F3640-0x00000001807F3710
		private void OnMouseDown(EventData msg); // 0x00000001807F3510-0x00000001807F3530
		private void OnMouseUp(EventData msg); // 0x00000001807F3530-0x00000001807F3550
	}
}
