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
	[Category] // 0x00000001800D8D70-0x00000001800D8E10
	[EventReceiver] // 0x00000001800D8D70-0x00000001800D8E10
	public class CheckMouseClick : ConditionTask<Collider> // TypeDefIndex: 14162
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181253640-0x00000001812536D0 
	
		// Constructors
		public CheckMouseClick(); // 0x0000000181253600-0x0000000181253640
	
		// Methods
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		public void OnMouseDown(); // 0x0000000181253400-0x0000000181253420
		public void OnMouseUp(); // 0x0000000181253420-0x0000000181253440
	}
}
