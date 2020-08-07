/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[Serializable]
	public class AnimatedCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14521
	{
		// Fields
		[SerializeField] // 0x000000018024B8D0-0x000000018024B910
		[Tooltip] // 0x000000018024B8D0-0x000000018024B910
		private AnimationClip _animationClip; // 0x10
		[SerializeField] // 0x000000018024BBF0-0x000000018024BC30
		[Tooltip] // 0x000000018024BBF0-0x000000018024BC30
		private Transform _parentOverride; // 0x18
		[SerializeField] // 0x000000018024BDD0-0x000000018024BE10
		[Tooltip] // 0x000000018024BDD0-0x000000018024BE10
		private float _yRotationFix; // 0x20
	
		// Properties
		public AnimationClip AnimationClip { get; } // 0x0000000180372440-0x0000000180372450 
		public Transform ParentOverride { get; } // 0x0000000180372430-0x0000000180372440 
		public float YRotationFix { get; } // 0x0000000180373AF0-0x0000000180373B00 
		public bool UseCameraCollision { get; } // 0x0000000180380950-0x0000000180380960 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x00000001806C4390-0x00000001806C43A0 
	
		// Constructors
		public AnimatedCameraStateSettings(AnimationClip animationClipToPlay, Transform parentOverride, float yRotationFix); // 0x0000000180CA3890-0x0000000180CA38E0
	}
}
