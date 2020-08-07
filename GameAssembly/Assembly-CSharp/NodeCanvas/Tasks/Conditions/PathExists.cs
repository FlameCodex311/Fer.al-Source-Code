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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180231770-0x00000001802317D0
	[Description] // 0x0000000180231770-0x00000001802317D0
	public class PathExists : ConditionTask<NavMeshAgent> // TypeDefIndex: 15235
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<Vector3>> savePathAs; // 0x70
	
		// Constructors
		public PathExists(); // 0x0000000180804F40-0x0000000180804F80
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180804E20-0x0000000180804F40
	}
}
