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
	[Category] // 0x0000000180294630-0x0000000180294690
	[Description] // 0x0000000180294630-0x0000000180294690
	public class SetGameObjectColor : ActionTask // TypeDefIndex: 15561
	{
		// Fields
		public BBParameter<GameObject> reference; // 0x68
		public BBParameter<string> colorProperty; // 0x70
		public BBParameter<Color> color; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A5590-0x00000001807A5720 
	
		// Constructors
		public SetGameObjectColor(); // 0x00000001807A5510-0x00000001807A5590
	
		// Methods
		protected override string OnInit(); // 0x00000001807A5280-0x00000001807A5510
		protected override void OnExecute(); // 0x000000018079F110-0x000000018079F120
	}
}
