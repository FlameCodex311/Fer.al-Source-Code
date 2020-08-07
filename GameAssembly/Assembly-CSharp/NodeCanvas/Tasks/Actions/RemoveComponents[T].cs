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
	[Category] // 0x000000018028EA00-0x000000018028EA60
	[Description] // 0x000000018028EA00-0x000000018028EA60
	public class RemoveComponents<T> : ActionTask // TypeDefIndex: 15547
		where T : Component
	{
		// Fields
		[Tooltip] // 0x0000000180258020-0x0000000180258050
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
