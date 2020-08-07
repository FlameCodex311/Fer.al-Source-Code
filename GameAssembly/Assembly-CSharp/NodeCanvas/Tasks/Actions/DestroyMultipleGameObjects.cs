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
	[Category] // 0x0000000180279AC0-0x0000000180279B20
	[Description] // 0x0000000180279AC0-0x0000000180279B20
	public class DestroyMultipleGameObjects : ActionTask // TypeDefIndex: 15455
	{
		// Fields
		[Tooltip] // 0x0000000180258020-0x0000000180258050
		public bool immediately; // 0x68
		public BBParameter<GameObject[]> gameObjects; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180CC2CD0-0x0000000180CC2F70 
	
		// Constructors
		public DestroyMultipleGameObjects(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC2AD0-0x0000000180CC2CD0
	}
}
