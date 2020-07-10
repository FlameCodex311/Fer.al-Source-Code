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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180101360-0x00000001801013C0
	[Description] // 0x0000000180101360-0x00000001801013C0
	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 14306
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14307
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Collider, GameObject> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C630-0x000000018155C690
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GameObject <OnExecute>b__3_0(Collider c); // 0x000000018155C190-0x000000018155C1C0
		}
	
		// Constructors
		public GetOverlapSphereObjects(); // 0x000000018154A1A0-0x000000018154A200
	
		// Methods
		protected override void OnExecute(); // 0x0000000181549F30-0x000000018154A1A0
		public override void OnDrawGizmosSelected(); // 0x0000000181549DF0-0x0000000181549F30
	}
}
