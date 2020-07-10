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
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 14276
		where T : Component
	{
		// Fields
		[Tooltip] // 0x00000001800F4E90-0x00000001800F4EC0
		public bool immediately;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveComponent();
	
		// Methods
		protected override void OnExecute();
	}
}
