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
	[Category] // 0x00000001800C9BC0-0x00000001800C9C40
	[Description] // 0x00000001800C9BC0-0x00000001800C9C40
	[Name] // 0x00000001800C9BC0-0x00000001800C9C40
	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 14134
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public Vector3 offset; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get; } // 0x00000001812533A0-0x0000000181253400 
	
		// Constructors
		public CheckLOS(); // 0x0000000181253340-0x00000001812533A0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181252E20-0x00000001812530F0
		public override void OnDrawGizmosSelected(); // 0x00000001812530F0-0x0000000181253340
	}
}
