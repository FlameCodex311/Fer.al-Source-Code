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
	[Category] // 0x0000000180293F50-0x0000000180293FB0
	[Description] // 0x0000000180293F50-0x0000000180293FB0
	public class SetGameObjectActive : ActionTask // TypeDefIndex: 15559
	{
		// Fields
		public BBParameter<GameObject> gameObject; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A5160-0x00000001807A5280 
	
		// Constructors
		public SetGameObjectActive(); // 0x00000001807A5110-0x00000001807A5160
	
		// Methods
		protected override string OnInit(); // 0x00000001807A5080-0x00000001807A5110
		protected override void OnExecute(); // 0x00000001807A4FE0-0x00000001807A5080
	}
}
