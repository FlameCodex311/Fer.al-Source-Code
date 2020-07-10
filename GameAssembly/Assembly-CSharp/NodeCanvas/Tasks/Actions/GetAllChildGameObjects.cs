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
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 14269
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181547780-0x0000000181547810 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14270
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Transform, GameObject> <>9__4_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C5D0-0x000000018155C630
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GameObject <OnExecute>b__4_0(Transform t); // 0x000000018155C190-0x000000018155C1C0
		}
	
		// Constructors
		public GetAllChildGameObjects(); // 0x0000000181547740-0x0000000181547780
	
		// Methods
		protected override void OnExecute(); // 0x00000001815473B0-0x0000000181547740
		private List<Transform> Get(Transform parent); // 0x0000000181547150-0x00000001815473B0
	}
}
