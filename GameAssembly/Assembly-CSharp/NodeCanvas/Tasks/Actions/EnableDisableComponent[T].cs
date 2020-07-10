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
	[Category] // 0x000000018010DCE0-0x000000018010DD40
	[Description] // 0x000000018010DCE0-0x000000018010DD40
	public class EnableDisableComponent<T> : ActionTask<Transform> // TypeDefIndex: 14355
		where T : Behaviour
	{
		// Fields
		public BBParameter<bool> includeChildTransforms;
		public BBParameter<bool> enable;
		public EActionObjects actionObjects;
		[ShowIf] // 0x000000018010DF70-0x000000018010DFA0
		public List<BBParameter<Transform>> transforms;
	
		// Properties
		protected override string info { get; }
	
		// Nested types
		public enum EActionObjects // TypeDefIndex: 14356
		{
			single = 0,
			multiple = 1
		}
	
		// Constructors
		public EnableDisableComponent();
	
		// Methods
		protected override void OnExecute();
		private void DoIt(Transform inT);
		private void EnableOrDisable(T[] inT);
	}
}
