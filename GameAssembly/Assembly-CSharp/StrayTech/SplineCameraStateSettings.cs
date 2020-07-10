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
	public class SplineCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13859
	{
		// Fields
		[SerializeField] // 0x00000001801248E0-0x0000000180124920
		[Tooltip] // 0x00000001801248E0-0x0000000180124920
		private BezierSpline _spline; // 0x10
		[SerializeField] // 0x0000000180124A90-0x0000000180124AD0
		[Tooltip] // 0x0000000180124A90-0x0000000180124AD0
		private float _splinePositionOffset; // 0x18
		[SerializeField] // 0x0000000180124C90-0x0000000180124CD0
		[Tooltip] // 0x0000000180124C90-0x0000000180124CD0
		private float _cameraLineOfSightOffset; // 0x1C
		[SerializeField] // 0x0000000180125090-0x00000001801250D0
		[Tooltip] // 0x0000000180125090-0x00000001801250D0
		private float _cameraMaxDistance; // 0x20
		[SerializeField] // 0x00000001801252D0-0x0000000180125310
		[Tooltip] // 0x00000001801252D0-0x0000000180125310
		private float _splineTravelMaxSpeed; // 0x24
		[SerializeField] // 0x0000000180122380-0x00000001801223C0
		[Tooltip] // 0x0000000180122380-0x00000001801223C0
		private bool _useCameraCollision; // 0x28
	
		// Properties
		public BezierSpline Spline { get; } // 0x000000018036AC80-0x000000018036AC90 
		public float SplinePositionOffset { get; } // 0x00000001805D9080-0x00000001805D9090 
		public float CameraLineOfSightOffset { get; } // 0x00000001805D9070-0x00000001805D9080 
		public float CameraMaxDistance { get; } // 0x0000000180487DA0-0x0000000180487DB0 
		public float SplineTravelMaxSpeed { get; } // 0x00000001804935B0-0x00000001804935C0 
		public bool UseCameraCollision { get; } // 0x00000001803A2790-0x00000001803A27A0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018042E670-0x000000018042E680 
	
		// Constructors
		public SplineCameraStateSettings(BezierSpline spline, float splinePositionOffset, float cameraLineOfSightOffset, float cameraMaxDistance, float splineTravelMaxSpeed); // 0x00000001812030E0-0x0000000181203150
	}
}
