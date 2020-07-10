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
	[Category] // 0x00000001800FCFB0-0x00000001800FD010
	[Description] // 0x00000001800FCFB0-0x00000001800FD010
	public class InputMove : ActionTask<Transform> // TypeDefIndex: 14290
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> strafe; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> turn; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> forward; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> up; // 0x80
		public BBParameter<float> moveSpeed; // 0x88
		public BBParameter<float> rotationSpeed; // 0x90
		public bool repeat; // 0x98
	
		// Constructors
		public InputMove(); // 0x000000018154D320-0x000000018154D390
	
		// Methods
		protected override void OnUpdate(); // 0x000000018154CCD0-0x000000018154D320
	}
}
