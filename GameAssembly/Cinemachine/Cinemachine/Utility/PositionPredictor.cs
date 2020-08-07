/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	public class PositionPredictor // TypeDefIndex: 7572
	{
		// Fields
		private Vector3 m_Position; // 0x10
		private GaussianWindow1D_Vector3 m_Velocity; // 0x20
		private GaussianWindow1D_Vector3 m_Accel; // 0x28
		private float mLastVelAddedTime; // 0x30
		private const float kSmoothingDefault = 10f; // Metadata: 0x0077669B
		private float mSmoothing; // 0x34
	
		// Properties
		public float Smoothing { set; } // 0x0000000181FF7E30-0x0000000181FF7F60
		public bool IsEmpty { get; } // 0x0000000181FF7DE0-0x0000000181FF7E30 
	
		// Constructors
		public PositionPredictor(); // 0x0000000181FF7D00-0x0000000181FF7DE0
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta); // 0x0000000181FF7960-0x0000000181FF7A20
		public void Reset(); // 0x0000000181FF7CA0-0x0000000181FF7D00
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime); // 0x0000000181FF7570-0x0000000181FF7960
		public Vector3 PredictPositionDelta(float lookaheadTime); // 0x0000000181FF7A20-0x0000000181FF7CA0
	}
}
