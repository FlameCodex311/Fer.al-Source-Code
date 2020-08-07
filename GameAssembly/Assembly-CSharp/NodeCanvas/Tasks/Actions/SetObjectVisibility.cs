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
	[Category] // 0x000000018025DE60-0x000000018025DEE0
	[Description] // 0x000000018025DE60-0x000000018025DEE0
	[Name] // 0x000000018025DE60-0x000000018025DEE0
	public class SetObjectVisibility : ActionTask<Renderer> // TypeDefIndex: 15380
	{
		// Fields
		public SetVisibleMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A62C0-0x00000001807A6330 
	
		// Nested types
		public enum SetVisibleMode // TypeDefIndex: 15381
		{
			Hide = 0,
			Show = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectVisibility(); // 0x00000001807A6280-0x00000001807A62C0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A61E0-0x00000001807A6280
	}
}
