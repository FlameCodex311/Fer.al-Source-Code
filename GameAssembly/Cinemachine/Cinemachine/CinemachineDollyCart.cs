/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[DocumentationSorting] // 0x000000018011FBE0-0x000000018011FC10
	[ExecuteAlways] // 0x000000018011FBE0-0x000000018011FC10
	public class CinemachineDollyCart : UnityEngine.MonoBehaviour // TypeDefIndex: 7277
	{
		// Fields
		[Tooltip] // 0x000000018011FDA0-0x000000018011FDD0
		public CinemachinePathBase m_Path; // 0x18
		[Tooltip] // 0x000000018011FF40-0x000000018011FF70
		public UpdateMethod m_UpdateMethod; // 0x20
		[Tooltip] // 0x0000000180120150-0x0000000180120180
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x24
		[FormerlySerializedAs] // 0x0000000180120440-0x00000001801204A0
		[Tooltip] // 0x0000000180120440-0x00000001801204A0
		public float m_Speed; // 0x28
		[FormerlySerializedAs] // 0x0000000180120640-0x00000001801206A0
		[Tooltip] // 0x0000000180120640-0x00000001801206A0
		public float m_Position; // 0x2C
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 7278
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart(); // 0x00000001818B8C10-0x00000001818B8C20
	
		// Methods
		private void FixedUpdate(); // 0x00000001818B8960-0x00000001818B89B0
		private void Update(); // 0x00000001818B8BB0-0x00000001818B8C10
		private void LateUpdate(); // 0x00000001818B89B0-0x00000001818B8A30
		private void SetCartPosition(float distanceAlongPath); // 0x00000001818B8A30-0x00000001818B8BB0
	}
}
