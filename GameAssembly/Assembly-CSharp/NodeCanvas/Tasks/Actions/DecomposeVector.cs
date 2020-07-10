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
	[Category] // 0x00000001800E66F0-0x00000001800E6750
	[Description] // 0x00000001800E66F0-0x00000001800E6750
	public class DecomposeVector : ActionTask // TypeDefIndex: 14214
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> x; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> y; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> z; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018174EBF0-0x000000018174EC30 
	
		// Constructors
		public DecomposeVector(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018174EAC0-0x000000018174EBF0
	}
}
