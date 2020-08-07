/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180294870-0x00000001802948D0
	[Description] // 0x0000000180294870-0x00000001802948D0
	public class SetGameObjectsActive : ActionTask // TypeDefIndex: 15562
	{
		// Fields
		public BBParameter<GameObject[]> gameObjects; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A5930-0x00000001807A5C00 
	
		// Constructors
		public SetGameObjectsActive(); // 0x00000001807A58E0-0x00000001807A5930
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A5720-0x00000001807A58E0
	}
}
