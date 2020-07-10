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
	[RequireComponent] // 0x00000001800D8B30-0x00000001800D8B80
	public class InteractionSystemTestGUI : UnityEngine.MonoBehaviour // TypeDefIndex: 9525
	{
		// Fields
		[SerializeField] // 0x00000001800D8E10-0x00000001800D8E60
		[Tooltip] // 0x00000001800D8E10-0x00000001800D8E60
		private InteractionObject interactionObject; // 0x18
		[SerializeField] // 0x00000001800D9110-0x00000001800D9160
		[Tooltip] // 0x00000001800D9110-0x00000001800D9160
		private FullBodyBipedEffector[] effectors; // 0x20
		private InteractionSystem interactionSystem; // 0x28
	
		// Constructors
		public InteractionSystemTestGUI(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x0000000181832C60-0x0000000181832CA0
		private void OnGUI(); // 0x0000000181832CA0-0x0000000181832F00
	}
}
