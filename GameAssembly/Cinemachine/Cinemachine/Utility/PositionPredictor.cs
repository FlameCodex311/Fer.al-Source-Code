/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.Utility
{
	public class PositionPredictor // TypeDefIndex: 7406
	{
		// Fields
		private Vector3 m_Position; // 0x10
		private GaussianWindow1D_Vector3 m_Velocity; // 0x20
		private GaussianWindow1D_Vector3 m_Accel; // 0x28
		private float mLastVelAddedTime; // 0x30
		private const float kSmoothingDefault = 10f; // Metadata: 0x007419AD
		private float mSmoothing; // 0x34
	
		// Properties
		public float Smoothing { set; } // 0x00000001817E8960-0x00000001817E8A90
		public bool IsEmpty { get; } // 0x00000001817E8910-0x00000001817E8960 
	
		// Constructors
		public PositionPredictor(); // 0x00000001817E8830-0x00000001817E8910
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta); // 0x00000001817E8490-0x00000001817E8550
		public void Reset(); // 0x00000001817E87D0-0x00000001817E8830
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime); // 0x00000001817E80A0-0x00000001817E8490
		public Vector3 PredictPositionDelta(float lookaheadTime); // 0x00000001817E8550-0x00000001817E87D0
	}
}
