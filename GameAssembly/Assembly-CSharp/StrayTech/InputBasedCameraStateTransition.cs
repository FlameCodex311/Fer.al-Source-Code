/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class InputBasedCameraStateTransition : MonoBehaviour // TypeDefIndex: 13911
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CameraStateDefinition[] _cameraStateDefinitionArray; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private KeyCode _transitionKey; // 0x28
		private int _currentStateIndex; // 0x2C
		private bool _pressedLastFrame; // 0x30
	
		// Constructors
		public InputBasedCameraStateTransition(); // 0x0000000181200970-0x0000000181200980
	
		// Methods
		private void Update(); // 0x0000000181200840-0x0000000181200970
	}
}
