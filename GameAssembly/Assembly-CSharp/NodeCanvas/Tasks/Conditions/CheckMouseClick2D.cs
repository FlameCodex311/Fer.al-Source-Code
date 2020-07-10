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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D9350-0x00000001800D9410
	[Name] // 0x00000001800D9350-0x00000001800D9410
	[EventReceiver] // 0x00000001800D9350-0x00000001800D9410
	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 14163
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181253570-0x0000000181253600 
	
		// Constructors
		public CheckMouseClick2D(); // 0x0000000181253530-0x0000000181253570
	
		// Methods
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		public void OnMouseDown(); // 0x0000000181253400-0x0000000181253420
		public void OnMouseUp(); // 0x0000000181253420-0x0000000181253440
	}
}
