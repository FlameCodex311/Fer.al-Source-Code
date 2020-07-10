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
	[Category] // 0x00000001800D7D10-0x00000001800D7DC0
	[EventReceiver] // 0x00000001800D7D10-0x00000001800D7DC0
	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 14160
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181253EA0-0x0000000181253F30 
	
		// Constructors
		public CheckMouse(); // 0x0000000181253E60-0x0000000181253EA0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		public void OnMouseEnter(); // 0x0000000181253400-0x0000000181253420
		public void OnMouseExit(); // 0x0000000181253420-0x0000000181253440
		public void OnMouseOver(); // 0x0000000181253440-0x0000000181253460
	}
}
