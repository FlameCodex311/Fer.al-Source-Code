/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CD530-0x00000001800CD590
	[Description] // 0x00000001800CD530-0x00000001800CD590
	public class PathExists : ConditionTask<NavMeshAgent> // TypeDefIndex: 14144
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<Vector3>> savePathAs; // 0x70
	
		// Constructors
		public PathExists(); // 0x0000000181259A90-0x0000000181259AD0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181259970-0x0000000181259A90
	}
}
