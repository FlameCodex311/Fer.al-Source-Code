﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180128DE0-0x0000000180128E40
	[Description] // 0x0000000180128DE0-0x0000000180128E40
	public class SetGameObjectsActive : ActionTask // TypeDefIndex: 14456
	{
		// Fields
		public BBParameter<GameObject[]> gameObjects; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181260BC0-0x0000000181260E90 
	
		// Constructors
		public SetGameObjectsActive(); // 0x0000000181260B70-0x0000000181260BC0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812609A0-0x0000000181260B70
	}
}
