/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800FE730-0x00000001800FE7B0
	[Description] // 0x00000001800FE730-0x00000001800FE7B0
	[Name] // 0x00000001800FE730-0x00000001800FE7B0
	public class FindClosestEdge : ActionTask // TypeDefIndex: 14295
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveFoundPosition; // 0x70
		private NavMeshHit hit; // 0x78
	
		// Constructors
		public FindClosestEdge(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181545850-0x0000000181545950
	}
}
