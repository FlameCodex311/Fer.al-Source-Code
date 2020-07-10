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
	[Category] // 0x00000001800F8D80-0x00000001800F8DE0
	[Obsolete] // 0x00000001800F8D80-0x00000001800F8DE0
	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 14273
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001815482C0-0x00000001815484A0 
	
		// Constructors
		public GetGameObjectPosition(); // 0x0000000181548280-0x00000001815482C0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815481E0-0x0000000181548280
	}
}
