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
	[Category] // 0x00000001802899C0-0x0000000180289A20
	[Description] // 0x00000001802899C0-0x0000000180289A20
	public class OverrideFaceLocalPlayer : ActionTask<Transform> // TypeDefIndex: 15520
	{
		// Fields
		public ELookAtType lookAtType; // 0x68
		[ShowIf] // 0x0000000180289CA0-0x0000000180289CD0
		public BBParameter<Transform> lookAt; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BBD390-0x0000000180BBD570 
	
		// Nested types
		public enum ELookAtType // TypeDefIndex: 15521
		{
			Target = 0,
			LocalPlayer = 1,
			Disabled = 2
		}
	
		// Constructors
		public OverrideFaceLocalPlayer(); // 0x0000000180BBD350-0x0000000180BBD390
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBD180-0x0000000180BBD350
	}
}
