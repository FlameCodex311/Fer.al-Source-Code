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
	[Category] // 0x00000001800F6290-0x00000001800F62F0
	[Description] // 0x00000001800F6290-0x00000001800F62F0
	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 14263
	{
		// Fields
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		[TagField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<string> searchTag; // 0x68
		public BBParameter<bool> ignoreChildren; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveObjectAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x80
	
		// Constructors
		public FindClosestWithTag(); // 0x0000000181545D60-0x0000000181545DA0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181545950-0x0000000181545D60
	}
}
