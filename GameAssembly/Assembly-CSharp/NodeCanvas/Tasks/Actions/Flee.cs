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
	[Category] // 0x00000001800FEB90-0x00000001800FEBF0
	[Description] // 0x00000001800FEB90-0x00000001800FEBF0
	public class Flee : ActionTask<NavMeshAgent> // TypeDefIndex: 14296
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> fledDistance; // 0x78
		public BBParameter<float> lookAhead; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181547000-0x0000000181547040 
	
		// Constructors
		public Flee(); // 0x0000000181546F70-0x0000000181547000
	
		// Methods
		protected override void OnExecute(); // 0x0000000181546910-0x0000000181546B20
		protected override void OnUpdate(); // 0x0000000181546BC0-0x0000000181546F70
		protected override void OnPause(); // 0x000000018090E380-0x000000018090E3A0
		protected override void OnStop(); // 0x0000000181546B20-0x0000000181546BC0
	}
}
