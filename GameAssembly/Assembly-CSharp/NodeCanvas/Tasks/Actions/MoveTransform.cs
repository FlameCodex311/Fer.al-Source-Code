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
	[Category] // 0x0000000180113890-0x00000001801138F0
	[Description] // 0x0000000180113890-0x00000001801138F0
	public class MoveTransform : ActionTask<Transform> // TypeDefIndex: 14378
	{
		// Fields
		public BBParameter<Vector3> position; // 0x68
		public BBParameter<bool> local; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181553820-0x0000000181553910 
	
		// Constructors
		public MoveTransform(); // 0x00000001815537E0-0x0000000181553820
	
		// Methods
		protected override void OnExecute(); // 0x0000000181553660-0x00000001815537E0
	}
}
