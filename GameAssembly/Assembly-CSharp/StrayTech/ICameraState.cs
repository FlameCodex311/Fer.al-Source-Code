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
	public interface ICameraState // TypeDefIndex: 14542
	{
		// Properties
		ICameraStateSettings StateSettings { get; }
		Vector3 Position { get; set; }
		Quaternion Rotation { get; set; }
		CameraSystem.CameraStateEnum StateType { get; }
		bool AllowsModifiers { get; }
	
		// Methods
		void UpdateCamera(float deltaTime);
		void Cleanup();
	}
}
