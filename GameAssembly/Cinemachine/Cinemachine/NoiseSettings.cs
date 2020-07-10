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
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 7372
	{
		// Fields
		[FormerlySerializedAs] // 0x0000000180161320-0x0000000180161380
		[Tooltip] // 0x0000000180161320-0x0000000180161380
		public TransformNoiseParams[] PositionNoise; // 0x18
		[FormerlySerializedAs] // 0x0000000180161520-0x0000000180161580
		[Tooltip] // 0x0000000180161520-0x0000000180161580
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get; } // 0x0000000180DD1F20-0x0000000180DD1F30 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct NoiseParams // TypeDefIndex: 7373
		{
			// Fields
			[Tooltip] // 0x0000000180161940-0x0000000180161970
			public float Frequency; // 0x00
			[Tooltip] // 0x0000000180161B90-0x0000000180161BC0
			public float Amplitude; // 0x04
			[Tooltip] // 0x0000000180161D70-0x0000000180161DA0
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset); // 0x00000001802992A0-0x00000001802992D0
		}
	
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct TransformNoiseParams // TypeDefIndex: 7374
		{
			// Fields
			[Tooltip] // 0x0000000180161F80-0x0000000180161FB0
			public NoiseParams X; // 0x00
			[Tooltip] // 0x00000001801620C0-0x00000001801620F0
			public NoiseParams Y; // 0x0C
			[Tooltip] // 0x00000001801623D0-0x0000000180162400
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets); // 0x00000001802992D0-0x0000000180299420
		}
	
		// Constructors
		public NoiseSettings(); // 0x00000001817E8030-0x00000001817E80A0
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets); // 0x00000001817E7C90-0x00000001817E7EE0
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001817E7EE0-0x00000001817E8030
	}
}
