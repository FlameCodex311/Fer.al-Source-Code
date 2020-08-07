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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018022E850-0x000000018022E880
	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 15377
		where T : Component
	{
		// Fields
		[Tooltip] // 0x0000000180258020-0x0000000180258050
		public bool immediately;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveComponent();
	
		// Methods
		protected override void OnExecute();
	}
}
