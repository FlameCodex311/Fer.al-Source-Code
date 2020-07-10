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
	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 14272
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181547ED0-0x0000000181547F30 
	
		// Constructors
		public GetDistance(); // 0x0000000181547E90-0x0000000181547ED0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181547D20-0x0000000181547E90
	}
}
