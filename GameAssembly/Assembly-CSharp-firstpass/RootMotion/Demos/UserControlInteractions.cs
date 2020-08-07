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
	public class UserControlInteractions : UserControlThirdPerson // TypeDefIndex: 9835
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CharacterThirdPerson character; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InteractionSystem interactionSystem; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool disableInputInInteraction; // 0x58
		public float enableInputAtProgress; // 0x5C
	
		// Constructors
		public UserControlInteractions(); // 0x00000001814409C0-0x00000001814409E0
	
		// Methods
		protected override void Update(); // 0x0000000181440890-0x00000001814409C0
		private void OnGUI(); // 0x0000000181440720-0x0000000181440890
	}
}
