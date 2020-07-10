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
	public class AnimatedCamera : ICameraState, IValidates // TypeDefIndex: 13872
	{
		// Fields
		private AnimatedCameraStateSettings _stateSettings; // 0x10
		private float _clipDuration; // 0x18
		private float _currentClipTime; // 0x1C
		private bool _animationComplete; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <Position>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <Rotation>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<OnFinishedEventArgs> OnFinished; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action OnStarted; // 0x48
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001807A1520-0x00000001807A1540 0x0000000181203B60-0x0000000181203B70
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038E0C0-0x000000018038E0D0 0x0000000180DD2D40-0x0000000180DD2D50
	
		// Events
		public event Action<OnFinishedEventArgs> OnFinished {
			add; // 0x0000000181345C80-0x0000000181345D20
			remove; // 0x0000000181345DC0-0x0000000181345E60
		}
		public event Action OnStarted {
			add; // 0x0000000181345D20-0x0000000181345DC0
			remove; // 0x0000000181345E60-0x0000000181345F00
		}
	
		// Nested types
		public class OnFinishedEventArgs // TypeDefIndex: 13873
		{
			// Fields
			private bool _animationFinished; // 0x10
	
			// Properties
			public bool AnimationFinished { get; } // 0x0000000180375540-0x0000000180375550 
	
			// Constructors
			public OnFinishedEventArgs(bool animationFinished); // 0x0000000180419200-0x0000000180419230
		}
	
		// Constructors
		public AnimatedCamera(ICameraStateSettings stateSettings); // 0x0000000181345B00-0x0000000181345C80
	
		// Methods
		public void StopCurrentAnimation(); // 0x00000001813453B0-0x0000000181345440
		public void UpdateCamera(float deltaTime); // 0x0000000181345440-0x0000000181345B00
		public void Cleanup(); // 0x0000000181345130-0x0000000181345260
		public bool IsValid(); // 0x0000000181345260-0x00000001813453B0
	}
}
