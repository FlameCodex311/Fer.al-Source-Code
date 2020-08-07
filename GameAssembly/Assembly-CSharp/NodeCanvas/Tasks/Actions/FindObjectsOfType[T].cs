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
	[Category] // 0x000000018025A0C0-0x000000018025A120
	[Description] // 0x000000018025A0C0-0x000000018025A120
	public class FindObjectsOfType<T> : ActionTask // TypeDefIndex: 15366
		where T : Component
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveGameObjects;
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<T>> saveComponents;
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15367
		{
			// Fields
			public static readonly <>c<T> <>9;
			public static Func<T, GameObject> <>9__2_0;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal GameObject <OnExecute>b__2_0(T o);
		}
	
		// Constructors
		public FindObjectsOfType();
	
		// Methods
		protected override void OnExecute();
	}
}
