/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001802115A0-0x00000001802115F0
	public class InteractionSystemTestGUI : UnityEngine.MonoBehaviour // TypeDefIndex: 9812
	{
		// Fields
		[SerializeField] // 0x0000000180211830-0x0000000180211880
		[Tooltip] // 0x0000000180211830-0x0000000180211880
		private InteractionObject interactionObject; // 0x18
		[SerializeField] // 0x00000001802119C0-0x0000000180211A10
		[Tooltip] // 0x00000001802119C0-0x0000000180211A10
		private FullBodyBipedEffector[] effectors; // 0x20
		private InteractionSystem interactionSystem; // 0x28
	
		// Constructors
		public InteractionSystemTestGUI(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000181379680-0x00000001813796C0
		private void OnGUI(); // 0x00000001813796C0-0x0000000181379910
	}
}
