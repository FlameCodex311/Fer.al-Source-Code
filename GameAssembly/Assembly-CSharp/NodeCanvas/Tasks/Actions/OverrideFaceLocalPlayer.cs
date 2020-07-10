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
	[Category] // 0x000000018011D430-0x000000018011D490
	[Description] // 0x000000018011D430-0x000000018011D490
	public class OverrideFaceLocalPlayer : ActionTask<Transform> // TypeDefIndex: 14415
	{
		// Fields
		public ELookAtType lookAtType; // 0x68
		[ShowIf] // 0x000000018011D680-0x000000018011D6B0
		public BBParameter<Transform> lookAt; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181556EF0-0x00000001815570D0 
	
		// Nested types
		public enum ELookAtType // TypeDefIndex: 14416
		{
			Target = 0,
			LocalPlayer = 1,
			Disabled = 2
		}
	
		// Constructors
		public OverrideFaceLocalPlayer(); // 0x0000000181556EB0-0x0000000181556EF0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181556CE0-0x0000000181556EB0
	}
}
