/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[DocumentationSorting] // 0x0000000180205D10-0x0000000180205D40
	[ExecuteAlways] // 0x0000000180205D10-0x0000000180205D40
	public class CinemachineDollyCart : UnityEngine.MonoBehaviour // TypeDefIndex: 7443
	{
		// Fields
		[Tooltip] // 0x0000000180289080-0x00000001802890B0
		public CinemachinePathBase m_Path; // 0x18
		[Tooltip] // 0x0000000180289340-0x0000000180289370
		public UpdateMethod m_UpdateMethod; // 0x20
		[Tooltip] // 0x00000001802894B0-0x00000001802894E0
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x24
		[FormerlySerializedAs] // 0x00000001802895D0-0x0000000180289630
		[Tooltip] // 0x00000001802895D0-0x0000000180289630
		public float m_Speed; // 0x28
		[FormerlySerializedAs] // 0x0000000180289830-0x0000000180289890
		[Tooltip] // 0x0000000180289830-0x0000000180289890
		public float m_Position; // 0x2C
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 7444
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart(); // 0x000000018135EEF0-0x000000018135EF00
	
		// Methods
		private void FixedUpdate(); // 0x000000018135EC50-0x000000018135ECA0
		private void Update(); // 0x000000018135EE90-0x000000018135EEF0
		private void LateUpdate(); // 0x000000018135ECA0-0x000000018135ED20
		private void SetCartPosition(float distanceAlongPath); // 0x000000018135ED20-0x000000018135EE90
	}
}
