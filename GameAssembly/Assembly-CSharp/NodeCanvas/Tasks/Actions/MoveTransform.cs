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
	[Category] // 0x0000000180281FE0-0x0000000180282040
	[Description] // 0x0000000180281FE0-0x0000000180282040
	public class MoveTransform : ActionTask<Transform> // TypeDefIndex: 15481
	{
		// Fields
		public BBParameter<Vector3> position; // 0x68
		public BBParameter<bool> local; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB98C0-0x0000000180BB99A0 
	
		// Constructors
		public MoveTransform(); // 0x0000000180BB9880-0x0000000180BB98C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB9710-0x0000000180BB9880
	}
}
