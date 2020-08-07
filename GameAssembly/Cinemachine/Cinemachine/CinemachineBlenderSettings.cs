/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 7508
	{
		// Fields
		[Tooltip] // 0x00000001801FA410-0x00000001801FA440
		public CustomBlend[] m_CustomBlends; // 0x18
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x007765CA
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct CustomBlend // TypeDefIndex: 7509
		{
			// Fields
			[Tooltip] // 0x00000001801FA820-0x00000001801FA850
			public string m_From; // 0x00
			[Tooltip] // 0x00000001801FA9E0-0x00000001801FAA10
			public string m_To; // 0x08
			[CinemachineBlendDefinitionProperty] // 0x00000001801FAB60-0x00000001801FABB0
			[Tooltip] // 0x00000001801FAB60-0x00000001801FABB0
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlenderSettings(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend); // 0x000000018134DBC0-0x000000018134DE00
	}
}
