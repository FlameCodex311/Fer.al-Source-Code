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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180267E20-0x0000000180267E80
	[Description] // 0x0000000180267E20-0x0000000180267E80
	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 15409
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15410
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Collider, GameObject> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180BC0F80-0x0000000180BC0FE0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GameObject <OnExecute>b__3_0(Collider c); // 0x0000000180BC0B30-0x0000000180BC0B50
		}
	
		// Constructors
		public GetOverlapSphereObjects(); // 0x0000000180BB0260-0x0000000180BB02C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAFFF0-0x0000000180BB0260
		public override void OnDrawGizmosSelected(); // 0x0000000180BAFEB0-0x0000000180BAFFF0
	}
}
