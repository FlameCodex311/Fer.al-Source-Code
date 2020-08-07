/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 7506
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Name>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Priority>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <LookAt>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <Follow>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CameraState <State>k__BackingField; // 0x30
	
		// Properties
		public string Name { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public int Priority { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public Transform LookAt { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180374AF0-0x0000000180374B00 
		public Transform Follow { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803745B0-0x00000001803745C0 
		public CameraState State { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001813485F0-0x0000000181348680 0x0000000181348680-0x0000000181348700
		public GameObject VirtualCameraGameObject { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public bool IsValid { get; } // 0x0000000180380B60-0x0000000180380B70 
		public ICinemachineCamera ParentCamera { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public StaticPointVirtualCamera(CameraState state, string name); // 0x0000000181FF9890-0x0000000181FF9A20
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007765C8 */); // 0x0000000180380950-0x0000000180380960
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001803774A0-0x00000001803774B0
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001803774A0-0x00000001803774B0
	}
}
