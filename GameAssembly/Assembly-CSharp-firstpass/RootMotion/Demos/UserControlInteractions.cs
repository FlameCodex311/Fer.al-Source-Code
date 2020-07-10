/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class UserControlInteractions : UserControlThirdPerson // TypeDefIndex: 9548
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CharacterThirdPerson character; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private InteractionSystem interactionSystem; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool disableInputInInteraction; // 0x58
		public float enableInputAtProgress; // 0x5C
	
		// Constructors
		public UserControlInteractions(); // 0x000000018183FC90-0x000000018183FCB0
	
		// Methods
		protected override void Update(); // 0x000000018183FB60-0x000000018183FC90
		private void OnGUI(); // 0x000000018183F9F0-0x000000018183FB60
	}
}
