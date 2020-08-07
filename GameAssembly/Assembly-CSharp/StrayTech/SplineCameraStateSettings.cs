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
	public class SplineCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14526
	{
		// Fields
		[SerializeField] // 0x000000018024E730-0x000000018024E770
		[Tooltip] // 0x000000018024E730-0x000000018024E770
		private BezierSpline _spline; // 0x10
		[SerializeField] // 0x000000018024E8F0-0x000000018024E930
		[Tooltip] // 0x000000018024E8F0-0x000000018024E930
		private float _splinePositionOffset; // 0x18
		[SerializeField] // 0x000000018024EBD0-0x000000018024EC10
		[Tooltip] // 0x000000018024EBD0-0x000000018024EC10
		private float _cameraLineOfSightOffset; // 0x1C
		[SerializeField] // 0x000000018024EE30-0x000000018024EE70
		[Tooltip] // 0x000000018024EE30-0x000000018024EE70
		private float _cameraMaxDistance; // 0x20
		[SerializeField] // 0x000000018024F130-0x000000018024F170
		[Tooltip] // 0x000000018024F130-0x000000018024F170
		private float _splineTravelMaxSpeed; // 0x24
		[SerializeField] // 0x000000018024D170-0x000000018024D1B0
		[Tooltip] // 0x000000018024D170-0x000000018024D1B0
		private bool _useCameraCollision; // 0x28
	
		// Properties
		public BezierSpline Spline { get; } // 0x0000000180372440-0x0000000180372450 
		public float SplinePositionOffset { get; } // 0x000000018049DFC0-0x000000018049DFD0 
		public float CameraLineOfSightOffset { get; } // 0x0000000180918C20-0x0000000180918C30 
		public float CameraMaxDistance { get; } // 0x0000000180373AF0-0x0000000180373B00 
		public float SplineTravelMaxSpeed { get; } // 0x000000018090BD10-0x000000018090BD20 
		public bool UseCameraCollision { get; } // 0x00000001804C6790-0x00000001804C67A0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		public SplineCameraStateSettings(BezierSpline spline, float splinePositionOffset, float cameraLineOfSightOffset, float cameraMaxDistance, float splineTravelMaxSpeed); // 0x0000000180CB7730-0x0000000180CB77A0
	}
}
