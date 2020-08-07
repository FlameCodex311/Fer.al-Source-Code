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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018022D660-0x000000018022D6E0
	[Description] // 0x000000018022D660-0x000000018022D6E0
	[Name] // 0x000000018022D660-0x000000018022D6E0
	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 15223
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public Vector3 offset; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> saveDistanceAs; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get; } // 0x00000001807F3270-0x00000001807F32D0 
	
		// Constructors
		public CheckLOS(); // 0x00000001807F3210-0x00000001807F3270
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F2D00-0x00000001807F2FC0
		public override void OnDrawGizmosSelected(); // 0x00000001807F2FC0-0x00000001807F3210
	}
}
