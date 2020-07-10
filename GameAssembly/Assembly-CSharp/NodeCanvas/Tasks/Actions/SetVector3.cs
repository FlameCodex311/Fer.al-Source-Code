/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800EF9E0-0x00000001800EFA40
	[Description] // 0x00000001800EF9E0-0x00000001800EFA40
	public class SetVector3 : ActionTask // TypeDefIndex: 14246
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> valueA; // 0x68
		public OperationMethod operation; // 0x70
		public BBParameter<Vector3> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181262B40-0x0000000181262D30 
	
		// Constructors
		public SetVector3(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181262A00-0x0000000181262B40
	}
}
