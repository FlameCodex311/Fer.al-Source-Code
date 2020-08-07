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
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 7538
	{
		// Fields
		[FormerlySerializedAs] // 0x00000001802025E0-0x0000000180202640
		[Tooltip] // 0x00000001802025E0-0x0000000180202640
		public TransformNoiseParams[] PositionNoise; // 0x18
		[FormerlySerializedAs] // 0x0000000180202800-0x0000000180202860
		[Tooltip] // 0x0000000180202800-0x0000000180202860
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get; } // 0x000000018058C7E0-0x000000018058C7F0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct NoiseParams // TypeDefIndex: 7539
		{
			// Fields
			[Tooltip] // 0x0000000180202E70-0x0000000180202EA0
			public float Frequency; // 0x00
			[Tooltip] // 0x0000000180203060-0x0000000180203090
			public float Amplitude; // 0x04
			[Tooltip] // 0x00000001802032C0-0x00000001802032F0
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset); // 0x000000018013D110-0x000000018013D120
		}
	
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct TransformNoiseParams // TypeDefIndex: 7540
		{
			// Fields
			[Tooltip] // 0x00000001802037E0-0x0000000180203810
			public NoiseParams X; // 0x00
			[Tooltip] // 0x0000000180203B50-0x0000000180203B80
			public NoiseParams Y; // 0x0C
			[Tooltip] // 0x0000000180203DA0-0x0000000180203DD0
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets); // 0x000000018013D120-0x000000018013D270
		}
	
		// Constructors
		public NoiseSettings(); // 0x0000000181FF7510-0x0000000181FF7570
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets); // 0x0000000181FF7170-0x0000000181FF73C0
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x0000000181FF73C0-0x0000000181FF7510
	}
}
