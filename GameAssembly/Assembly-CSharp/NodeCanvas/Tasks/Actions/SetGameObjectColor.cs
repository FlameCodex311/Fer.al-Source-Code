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
	[Category] // 0x00000001801289C0-0x0000000180128A20
	[Description] // 0x00000001801289C0-0x0000000180128A20
	public class SetGameObjectColor : ActionTask // TypeDefIndex: 14455
	{
		// Fields
		public BBParameter<GameObject> reference; // 0x68
		public BBParameter<string> colorProperty; // 0x70
		public BBParameter<Color> color; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181260800-0x00000001812609A0 
	
		// Constructors
		public SetGameObjectColor(); // 0x0000000181260780-0x0000000181260800
	
		// Methods
		protected override string OnInit(); // 0x00000001812604E0-0x0000000181260780
		protected override void OnExecute(); // 0x0000000180E98B70-0x0000000180E98B80
	}
}
