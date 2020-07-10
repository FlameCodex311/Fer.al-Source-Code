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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C8C00-0x00000001800C8C60
	[Description] // 0x00000001800C8C00-0x00000001800C8C60
	public class CanSeeTarget : ConditionTask<Transform> // TypeDefIndex: 14132
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<float> awarnessDistance; // 0x78
		[SliderField] // 0x00000001800C9340-0x00000001800C9360
		public BBParameter<float> viewAngle; // 0x80
		public Vector3 offset; // 0x88
		private RaycastHit hit; // 0x94
	
		// Properties
		protected override string info { get; } // 0x000000018124E5F0-0x000000018124E630 
	
		// Constructors
		public CanSeeTarget(); // 0x000000018124E570-0x000000018124E5F0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124D9B0-0x000000018124DE70
		public override void OnDrawGizmosSelected(); // 0x000000018124DE70-0x000000018124E570
	}
}
