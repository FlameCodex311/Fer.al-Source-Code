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
	[Category] // 0x000000018022E850-0x000000018022E880
	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 15370
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAD5C0-0x0000000180BAD650 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15371
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Transform, GameObject> <>9__4_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180BC0F20-0x0000000180BC0F80
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GameObject <OnExecute>b__4_0(Transform t); // 0x0000000180BC0B30-0x0000000180BC0B50
		}
	
		// Constructors
		public GetAllChildGameObjects(); // 0x0000000180BAD580-0x0000000180BAD5C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAD200-0x0000000180BAD580
		private List<Transform> Get(Transform parent); // 0x0000000180BACFA0-0x0000000180BAD200
	}
}
