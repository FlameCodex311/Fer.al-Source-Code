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
	[Serializable]
	public class AnimatedCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13854
	{
		// Fields
		[SerializeField] // 0x000000018011F3C0-0x000000018011F400
		[Tooltip] // 0x000000018011F3C0-0x000000018011F400
		private AnimationClip _animationClip; // 0x10
		[SerializeField] // 0x000000018011F800-0x000000018011F840
		[Tooltip] // 0x000000018011F800-0x000000018011F840
		private Transform _parentOverride; // 0x18
		[SerializeField] // 0x000000018011FA30-0x000000018011FA70
		[Tooltip] // 0x000000018011FA30-0x000000018011FA70
		private float _yRotationFix; // 0x20
	
		// Properties
		public AnimationClip AnimationClip { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Transform ParentOverride { get; } // 0x000000018038B150-0x000000018038B160 
		public float YRotationFix { get; } // 0x0000000180487DA0-0x0000000180487DB0 
		public bool UseCameraCollision { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018043D4B0-0x000000018043D4C0 
	
		// Constructors
		public AnimatedCameraStateSettings(AnimationClip animationClipToPlay, Transform parentOverride, float yRotationFix); // 0x00000001813450E0-0x0000000181345130
	}
}
