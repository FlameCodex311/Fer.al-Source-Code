/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 7341
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private CinemachineBlend <Blend>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Priority>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <LookAt>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <Follow>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private CameraState <State>k__BackingField; // 0x30
	
		// Properties
		public CinemachineBlend Blend { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public string Name { get; } // 0x00000001818A2180-0x00000001818A21B0 
		public int Priority { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180367710-0x0000000180367720 
		public Transform LookAt { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC70-0x000000018036AC80 
		public Transform Follow { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369B60-0x0000000180369B70 
		public CameraState State { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001817E8FE0-0x00000001817E9070 0x00000001817E9070-0x00000001817E91C0
		public GameObject VirtualCameraGameObject { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public bool IsValid { get; } // 0x00000001818A2160-0x00000001818A2180 
		public ICinemachineCamera ParentCamera { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public BlendSourceVirtualCamera(CinemachineBlend blend); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007418DB */); // 0x00000001818A2060-0x00000001818A2080
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818A2080-0x00000001818A2160
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001803581E0-0x00000001803581F0
	}
}
