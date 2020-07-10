/*
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
	[Category] // 0x000000018010D130-0x000000018010D190
	[Description] // 0x000000018010D130-0x000000018010D190
	public class DestroyMultipleGameObjects : ActionTask // TypeDefIndex: 14350
	{
		// Fields
		[Tooltip] // 0x00000001800F4E90-0x00000001800F4EC0
		public bool immediately; // 0x68
		public BBParameter<GameObject[]> gameObjects; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181540C30-0x0000000181540EB0 
	
		// Constructors
		public DestroyMultipleGameObjects(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181540A20-0x0000000181540C30
	}
}
