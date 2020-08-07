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
	public class CinemachineBlend // TypeDefIndex: 7503
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <CamA>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <CamB>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve <BlendCurve>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <TimeInBlend>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <Duration>k__BackingField; // 0x2C
	
		// Properties
		public ICinemachineCamera CamA { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public ICinemachineCamera CamB { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public AnimationCurve BlendCurve { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public float TimeInBlend { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
		public float BlendWeight { get; } // 0x000000018134D3C0-0x000000018134D480 
		public bool IsValid { get; } // 0x000000018134D670-0x000000018134D6F0 
		public float Duration { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50
		public bool IsComplete { get; } // 0x000000018134D640-0x000000018134D670 
		public string Description { get; } // 0x000000018134D480-0x000000018134D640 
		public CameraState State { get; } // 0x000000018134D6F0-0x000000018134DBC0 
	
		// Constructors
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t); // 0x000000018134D360-0x000000018134D3C0
	
		// Methods
		public bool Uses(ICinemachineCamera cam); // 0x000000018134D210-0x000000018134D360
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018134D110-0x000000018134D210
	}
}
