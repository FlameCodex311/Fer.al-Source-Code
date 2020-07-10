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
	[Category] // 0x00000001800FFBA0-0x00000001800FFBD0
	public class GetLinecastInfo : ActionTask<Transform> // TypeDefIndex: 14302
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveHitGameObjectAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> savePointAs; // 0x88
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveNormalAs; // 0x90
		private RaycastHit hit; // 0x98
	
		// Constructors
		public GetLinecastInfo(); // 0x0000000181549970-0x00000001815499D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815496D0-0x0000000181549970
		public override void OnDrawGizmosSelected(); // 0x0000000181549540-0x00000001815496D0
	}
}
