/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace MiniGames
{
	public class QualitySettingsOverride : MonoBehaviour // TypeDefIndex: 15517
	{
		// Fields
		public OverrideValues overrides; // 0x20
		private OverrideValues _savedValues; // 0x28
	
		// Nested types
		[Serializable]
		public class OverrideValues // TypeDefIndex: 15518
		{
			// Fields
			public float shadowDistance; // 0x10
			public ShadowProjection shadowProjectionOverride; // 0x14
	
			// Constructors
			public OverrideValues(); // 0x00000001810BB890-0x00000001810BB8B0
		}
	
		// Constructors
		public QualitySettingsOverride(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x00000001810BB900-0x00000001810BBA00
		private void OnDestroy(); // 0x00000001810BB8B0-0x00000001810BB900
	}
}
