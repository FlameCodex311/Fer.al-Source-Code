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
	[Category] // 0x000000018027B2D0-0x000000018027B330
	[Description] // 0x000000018027B2D0-0x000000018027B330
	public class EnableDisableComponent<T> : ActionTask<Transform> // TypeDefIndex: 15458
		where T : Behaviour
	{
		// Fields
		public BBParameter<bool> includeChildTransforms;
		public BBParameter<bool> enable;
		public EActionObjects actionObjects;
		[ShowIf] // 0x000000018027B520-0x000000018027B550
		public List<BBParameter<Transform>> transforms;
	
		// Properties
		protected override string info { get; }
	
		// Nested types
		public enum EActionObjects // TypeDefIndex: 15459
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
