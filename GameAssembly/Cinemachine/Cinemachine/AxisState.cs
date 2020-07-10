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
	[Serializable]
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public struct AxisState // TypeDefIndex: 7332
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018014B820-0x000000018014B870
		[Tooltip] // 0x000000018014B820-0x000000018014B870
		public float Value; // 0x00
		[Tooltip] // 0x000000018014BC30-0x000000018014BC60
		public float m_MaxSpeed; // 0x04
		[Tooltip] // 0x000000018014BEE0-0x000000018014BF10
		public float m_AccelTime; // 0x08
		[Tooltip] // 0x000000018014C120-0x000000018014C150
		public float m_DecelTime; // 0x0C
		[FormerlySerializedAs] // 0x000000018014C400-0x000000018014C460
		[Tooltip] // 0x000000018014C400-0x000000018014C460
		public string m_InputAxisName; // 0x10
		[NoSaveDuringPlay] // 0x000000018014C830-0x000000018014C870
		[Tooltip] // 0x000000018014C830-0x000000018014C870
		public float m_InputAxisValue; // 0x18
		[FormerlySerializedAs] // 0x000000018014CA60-0x000000018014CAC0
		[Tooltip] // 0x000000018014CA60-0x000000018014CAC0
		public bool m_InvertInput; // 0x1C
		[Tooltip] // 0x000000018014CE70-0x000000018014CEA0
		public float m_MinValue; // 0x20
		[Tooltip] // 0x000000018014CF30-0x000000018014CF60
		public float m_MaxValue; // 0x24
		[Tooltip] // 0x000000018014D060-0x000000018014D090
		public bool m_Wrap; // 0x28
		[Tooltip] // 0x000000018014D1C0-0x000000018014D1F0
		public Recentering m_Recentering; // 0x2C
		private float mCurrentSpeed; // 0x48
		private const float Epsilon = 0.0001f; // Metadata: 0x00741892
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <ValueRangeLocked>k__BackingField; // 0x4C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasRecentering>k__BackingField; // 0x4D
	
		// Properties
		public bool ValueRangeLocked { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A2E70-0x00000001802A3010
		public bool HasRecentering { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A2E60-0x00000001802A2E70
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct Recentering // TypeDefIndex: 7333
		{
			// Fields
			[Tooltip] // 0x000000018014DA00-0x000000018014DA30
			public bool m_enabled; // 0x00
			[Tooltip] // 0x000000018014EF20-0x000000018014EF50
			public float m_WaitTime; // 0x04
			[Tooltip] // 0x000000018014F020-0x000000018014F050
			public float m_RecenteringTime; // 0x08
			private float mLastAxisInputTime; // 0x0C
			private float mRecenteringVelocity; // 0x10
			[FormerlySerializedAs] // 0x0000000180150710-0x0000000180150770
			[HideInInspector] // 0x0000000180150710-0x0000000180150770
			[SerializeField] // 0x0000000180150710-0x0000000180150770
			private int m_LegacyHeadingDefinition; // 0x14
			[FormerlySerializedAs] // 0x0000000180150BD0-0x0000000180150C20
			[HideInInspector] // 0x0000000180150BD0-0x0000000180150C20
			[SerializeField] // 0x0000000180150BD0-0x0000000180150C20
			private int m_LegacyVelocityFilterStrength; // 0x18
	
			// Constructors
			public Recentering(bool enabled, float waitTime, float recenteringTime); // 0x00000001802A3600-0x00000001802A3680
	
			// Methods
			public void Validate(); // 0x00000001802A35F0-0x00000001802A3600
			public void CopyStateFrom(ref Recentering other); // 0x00000001802A3590-0x00000001802A35B0
			public void CancelRecentering(); // 0x00000001802A3560-0x00000001802A3590
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget); // 0x00000001802A35B0-0x00000001802A35C0
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter); // 0x00000001802A35C0-0x00000001802A35F0
		}
	
		// Constructors
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert); // 0x00000001802A2DB0-0x00000001802A2E60
	
		// Methods
		public void Validate(); // 0x00000001802A2DA0-0x00000001802A2DB0
		public void Reset(); // 0x00000001802A2D80-0x00000001802A2D90
		public bool Update(float deltaTime); // 0x00000001802A2D90-0x00000001802A2DA0
		private float GetMaxSpeed(); // 0x00000001802A2D70-0x00000001802A2D80
	}
}
