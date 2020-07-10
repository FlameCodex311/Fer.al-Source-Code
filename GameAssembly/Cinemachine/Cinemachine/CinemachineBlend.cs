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
	public class CinemachineBlend // TypeDefIndex: 7337
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <CamA>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <CamB>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve <BlendCurve>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <TimeInBlend>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <Duration>k__BackingField; // 0x2C
	
		// Properties
		public ICinemachineCamera CamA { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public ICinemachineCamera CamB { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public AnimationCurve BlendCurve { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public float TimeInBlend { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
		public float BlendWeight { get; } // 0x00000001818A6F00-0x00000001818A6FC0 
		public bool IsValid { get; } // 0x00000001818A71B0-0x00000001818A7230 
		public float Duration { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0
		public bool IsComplete { get; } // 0x00000001818A7180-0x00000001818A71B0 
		public string Description { get; } // 0x00000001818A6FC0-0x00000001818A7180 
		public CameraState State { get; } // 0x00000001818A7230-0x00000001818A7710 
	
		// Constructors
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t); // 0x00000001818A6EA0-0x00000001818A6F00
	
		// Methods
		public bool Uses(ICinemachineCamera cam); // 0x00000001818A6D50-0x00000001818A6EA0
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818A6C50-0x00000001818A6D50
	}
}
