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
	public class AnimatedCamera : ICameraState, IValidates // TypeDefIndex: 14539
	{
		// Fields
		private AnimatedCameraStateSettings _stateSettings; // 0x10
		private float _clipDuration; // 0x18
		private float _currentClipTime; // 0x1C
		private bool _animationComplete; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <Position>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <Rotation>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<OnFinishedEventArgs> OnFinished; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action OnStarted; // 0x48
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x0000000180372440-0x0000000180372450 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x00000001806C4390-0x00000001806C43A0 
		public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806757C0-0x00000001806757E0 0x0000000180CA4690-0x0000000180CA46A0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018043C660-0x000000018043C670 0x0000000180CA46A0-0x0000000180CA46B0
	
		// Events
		public event Action<OnFinishedEventArgs> OnFinished {
			add; // 0x0000000180CA4410-0x0000000180CA44B0
			remove; // 0x0000000180CA4550-0x0000000180CA45F0
		}
		public event Action OnStarted {
			add; // 0x0000000180CA44B0-0x0000000180CA4550
			remove; // 0x0000000180CA45F0-0x0000000180CA4690
		}
	
		// Nested types
		public class OnFinishedEventArgs // TypeDefIndex: 14540
		{
			// Fields
			private bool _animationFinished; // 0x10
	
			// Properties
			public bool AnimationFinished { get; } // 0x00000001803FD450-0x00000001803FD460 
	
			// Constructors
			public OnFinishedEventArgs(bool animationFinished); // 0x0000000180824FE0-0x0000000180825010
		}
	
		// Constructors
		public AnimatedCamera(ICameraStateSettings stateSettings); // 0x0000000180CA4290-0x0000000180CA4410
	
		// Methods
		public void StopCurrentAnimation(); // 0x0000000180CA3B60-0x0000000180CA3BF0
		public void UpdateCamera(float deltaTime); // 0x0000000180CA3BF0-0x0000000180CA4290
		public void Cleanup(); // 0x0000000180CA38E0-0x0000000180CA3A10
		public bool IsValid(); // 0x0000000180CA3A10-0x0000000180CA3B60
	}
}
