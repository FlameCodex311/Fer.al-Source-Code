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
	[Serializable]
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public struct AxisState // TypeDefIndex: 7498
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001801EB4E0-0x00000001801EB530
		[Tooltip] // 0x00000001801EB4E0-0x00000001801EB530
		public float Value; // 0x00
		[Tooltip] // 0x00000001801EB7E0-0x00000001801EB810
		public float m_MaxSpeed; // 0x04
		[Tooltip] // 0x00000001801EB8F0-0x00000001801EB920
		public float m_AccelTime; // 0x08
		[Tooltip] // 0x00000001801EBBD0-0x00000001801EBC00
		public float m_DecelTime; // 0x0C
		[FormerlySerializedAs] // 0x00000001801EBE30-0x00000001801EBE90
		[Tooltip] // 0x00000001801EBE30-0x00000001801EBE90
		public string m_InputAxisName; // 0x10
		[NoSaveDuringPlay] // 0x00000001801EC3B0-0x00000001801EC3F0
		[Tooltip] // 0x00000001801EC3B0-0x00000001801EC3F0
		public float m_InputAxisValue; // 0x18
		[FormerlySerializedAs] // 0x00000001801EC680-0x00000001801EC6E0
		[Tooltip] // 0x00000001801EC680-0x00000001801EC6E0
		public bool m_InvertInput; // 0x1C
		[Tooltip] // 0x00000001801ECB50-0x00000001801ECB80
		public float m_MinValue; // 0x20
		[Tooltip] // 0x00000001801ECBE0-0x00000001801ECC10
		public float m_MaxValue; // 0x24
		[Tooltip] // 0x00000001801ECD90-0x00000001801ECDC0
		public bool m_Wrap; // 0x28
		[Tooltip] // 0x00000001801ECE80-0x00000001801ECEB0
		public Recentering m_Recentering; // 0x2C
		private float mCurrentSpeed; // 0x48
		private const float Epsilon = 0.0001f; // Metadata: 0x00776580
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <ValueRangeLocked>k__BackingField; // 0x4C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasRecentering>k__BackingField; // 0x4D
	
		// Properties
		public bool ValueRangeLocked { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C07D0-0x00000001800C0970
		public bool HasRecentering { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C07C0-0x00000001800C07D0
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct Recentering // TypeDefIndex: 7499
		{
			// Fields
			[Tooltip] // 0x00000001801ED8E0-0x00000001801ED910
			public bool m_enabled; // 0x00
			[Tooltip] // 0x00000001801EDAC0-0x00000001801EDAF0
			public float m_WaitTime; // 0x04
			[Tooltip] // 0x00000001801EDBC0-0x00000001801EDBF0
			public float m_RecenteringTime; // 0x08
			private float mLastAxisInputTime; // 0x0C
			private float mRecenteringVelocity; // 0x10
			[FormerlySerializedAs] // 0x00000001801EDD00-0x00000001801EDD60
			[HideInInspector] // 0x00000001801EDD00-0x00000001801EDD60
			[SerializeField] // 0x00000001801EDD00-0x00000001801EDD60
			private int m_LegacyHeadingDefinition; // 0x14
			[FormerlySerializedAs] // 0x00000001801EDFD0-0x00000001801EE020
			[HideInInspector] // 0x00000001801EDFD0-0x00000001801EE020
			[SerializeField] // 0x00000001801EDFD0-0x00000001801EE020
			private int m_LegacyVelocityFilterStrength; // 0x18
	
			// Constructors
			public Recentering(bool enabled, float waitTime, float recenteringTime); // 0x00000001800C11D0-0x00000001800C12E0
	
			// Methods
			public void Validate(); // 0x00000001800C1150-0x00000001800C11D0
			public void CopyStateFrom(ref Recentering other); // 0x00000001800C0F20-0x00000001800C0F40
			public void CancelRecentering(); // 0x00000001800C0EF0-0x00000001800C0F20
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget); // 0x00000001800C0F40-0x00000001800C1120
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter); // 0x00000001800C1120-0x00000001800C1150
		}
	
		// Constructors
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert); // 0x00000001800C0710-0x00000001800C07C0
	
		// Methods
		public void Validate(); // 0x00000001800C0660-0x00000001800C0710
		public void Reset(); // 0x00000001800C0640-0x00000001800C0650
		public bool Update(float deltaTime); // 0x00000001800C0650-0x00000001800C0660
		private float GetMaxSpeed(); // 0x00000001800C0630-0x00000001800C0640
	}
}
