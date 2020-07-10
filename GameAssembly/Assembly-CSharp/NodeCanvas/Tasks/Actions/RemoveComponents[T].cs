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
	[Category] // 0x00000001801226F0-0x0000000180122750
	[Description] // 0x00000001801226F0-0x0000000180122750
	public class RemoveComponents<T> : ActionTask // TypeDefIndex: 14441
		where T : Component
	{
		// Fields
		[Tooltip] // 0x00000001800F4E90-0x00000001800F4EC0
		public bool immediately;
		public bool includeChildern;
		public List<BBParameter<Transform>> transforms;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveComponents();
	
		// Methods
		private void DestroyComponent(T inComponent);
		protected override void OnExecute();
	}
}
