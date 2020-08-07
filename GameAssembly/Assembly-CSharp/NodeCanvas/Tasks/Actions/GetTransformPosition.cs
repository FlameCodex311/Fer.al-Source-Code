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
	[Category] // 0x000000018027BD30-0x000000018027BD90
	[Description] // 0x000000018027BD30-0x000000018027BD90
	public class GetTransformPosition : ActionTask<Transform> // TypeDefIndex: 15464
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> savePosition; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180BB0F00-0x0000000180BB0FE0 
	
		// Constructors
		public GetTransformPosition(); // 0x0000000180BB0EC0-0x0000000180BB0F00
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB0E00-0x0000000180BB0EC0
	}
}
