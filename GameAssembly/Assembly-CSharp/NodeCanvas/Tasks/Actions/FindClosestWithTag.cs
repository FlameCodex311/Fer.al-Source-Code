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
	[Category] // 0x00000001802599D0-0x0000000180259A30
	[Description] // 0x00000001802599D0-0x0000000180259A30
	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 15364
	{
		// Fields
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		[TagField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<string> searchTag; // 0x68
		public BBParameter<bool> ignoreChildren; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveObjectAs; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> saveDistanceAs; // 0x80
	
		// Constructors
		public FindClosestWithTag(); // 0x0000000180BABB70-0x0000000180BABBB0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAB770-0x0000000180BABB70
	}
}
