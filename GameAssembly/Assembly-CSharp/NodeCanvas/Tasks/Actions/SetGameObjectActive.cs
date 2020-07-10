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
	[Category] // 0x00000001801285A0-0x0000000180128600
	[Description] // 0x00000001801285A0-0x0000000180128600
	public class SetGameObjectActive : ActionTask // TypeDefIndex: 14453
	{
		// Fields
		public BBParameter<GameObject> gameObject; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812603C0-0x00000001812604E0 
	
		// Constructors
		public SetGameObjectActive(); // 0x0000000181260370-0x00000001812603C0
	
		// Methods
		protected override string OnInit(); // 0x00000001812602E0-0x0000000181260370
		protected override void OnExecute(); // 0x0000000181260240-0x00000001812602E0
	}
}
