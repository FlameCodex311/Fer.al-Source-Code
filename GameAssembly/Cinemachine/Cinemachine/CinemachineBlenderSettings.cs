/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 7342
	{
		// Fields
		[Tooltip] // 0x0000000180159D50-0x0000000180159D80
		public CustomBlend[] m_CustomBlends; // 0x18
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x007418DC
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct CustomBlend // TypeDefIndex: 7343
		{
			// Fields
			[Tooltip] // 0x000000018015A070-0x000000018015A0A0
			public string m_From; // 0x00
			[Tooltip] // 0x000000018015A280-0x000000018015A2B0
			public string m_To; // 0x08
			[CinemachineBlendDefinitionProperty] // 0x000000018015A540-0x000000018015A590
			[Tooltip] // 0x000000018015A540-0x000000018015A590
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlenderSettings(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend); // 0x00000001818A7710-0x00000001818A7950
	}
}
