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
	[Category] // 0x00000001800D84C0-0x00000001800D8590
	[Name] // 0x00000001800D84C0-0x00000001800D8590
	[EventReceiver] // 0x00000001800D84C0-0x00000001800D8590
	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 14161
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001812534A0-0x0000000181253530 
	
		// Constructors
		public CheckMouse2D(); // 0x0000000181253460-0x00000001812534A0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		public void OnMouseEnter(); // 0x0000000181253400-0x0000000181253420
		public void OnMouseExit(); // 0x0000000181253420-0x0000000181253440
		public void OnMouseOver(); // 0x0000000181253440-0x0000000181253460
	}
}
