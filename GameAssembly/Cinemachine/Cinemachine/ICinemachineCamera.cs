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
	public interface ICinemachineCamera // TypeDefIndex: 7370
	{
		// Properties
		string Name { get; }
		int Priority { get; }
		Transform LookAt { get; }
		Transform Follow { get; }
		CameraState State { get; }
		GameObject VirtualCameraGameObject { get; }
		bool IsValid { get; }
		ICinemachineCamera ParentCamera { get; }
	
		// Methods
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x00741950 */);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}
}
