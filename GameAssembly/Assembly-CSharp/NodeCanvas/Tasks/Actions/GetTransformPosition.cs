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
	[Category] // 0x000000018010EC10-0x000000018010EC70
	[Description] // 0x000000018010EC10-0x000000018010EC70
	public class GetTransformPosition : ActionTask<Transform> // TypeDefIndex: 14361
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> savePosition; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018154AFA0-0x000000018154B080 
	
		// Constructors
		public GetTransformPosition(); // 0x000000018154AF60-0x000000018154AFA0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154AEA0-0x000000018154AF60
	}
}
