/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class GaiaSettings : ScriptableObject // TypeDefIndex: 9038
	{
		// Fields
		[Header] // 0x00000001800CCA80-0x00000001800CCAB0
		public GaiaConstants.EnvironmentControllerType m_currentController; // 0x18
		[Tooltip] // 0x00000001800CCC40-0x00000001800CCC70
		public GaiaConstants.EnvironmentSize m_currentSize; // 0x1C
		[Tooltip] // 0x00000001800CCEF0-0x00000001800CCF20
		public GaiaConstants.EnvironmentTarget m_currentEnvironment; // 0x20
		[Tooltip] // 0x00000001800CD280-0x00000001800CD2B0
		public GaiaConstants.EnvironmentRenderer m_currentRenderer; // 0x24
		[Tooltip] // 0x00000001800CD4A0-0x00000001800CD4D0
		public GaiaDefaults m_currentDefaults; // 0x28
		[Tooltip] // 0x00000001800CD6F0-0x00000001800CD720
		public GaiaResource m_currentResources; // 0x30
		[Tooltip] // 0x00000001800CDB40-0x00000001800CDB70
		public GaiaResource m_currentGameObjectResources; // 0x38
		[Tooltip] // 0x00000001800CDDF0-0x00000001800CDE20
		public float m_currentSizeDivisor; // 0x40
		[Tooltip] // 0x00000001800CE130-0x00000001800CE160
		public string m_currentPlayerPrefabName; // 0x48
		[Tooltip] // 0x00000001800CE250-0x00000001800CE280
		public string m_currentWaterPrefabName; // 0x50
		[Tooltip] // 0x00000001800CE650-0x00000001800CE680
		public string m_currentTerrainLayerStoragePath; // 0x58
		[Tooltip] // 0x00000001800CE840-0x00000001800CE870
		public string m_publisherName; // 0x60
		[Tooltip] // 0x00000001800CEC00-0x00000001800CEC30
		public string m_fpsPlayerPrefabName; // 0x68
		[Tooltip] // 0x00000001800CF040-0x00000001800CF070
		public string m_3pPlayerPrefabName; // 0x70
		[Tooltip] // 0x00000001800CF440-0x00000001800CF470
		public string m_rbPlayerPrefabName; // 0x78
		[Tooltip] // 0x00000001800CF700-0x00000001800CF730
		public string m_waterMobilePrefabName; // 0x80
		[Tooltip] // 0x00000001800CF8C0-0x00000001800CF8F0
		public string m_waterPrefabName; // 0x88
		[Tooltip] // 0x00000001800CFB40-0x00000001800CFB70
		public bool m_showTooltips; // 0x90
		[Header] // 0x00000001800CFE40-0x00000001800CFEA0
		[Tooltip] // 0x00000001800CFE40-0x00000001800CFEA0
		public GaiaDefaults m_ultraLightDefaults; // 0x98
		[Tooltip] // 0x00000001800D04C0-0x00000001800D04F0
		public GaiaResource m_ultraLightResources; // 0xA0
		[Tooltip] // 0x00000001800D0820-0x00000001800D0850
		public GaiaResource m_ultraLightGameObjectResources; // 0xA8
		[Tooltip] // 0x00000001800D0980-0x00000001800D09B0
		public GaiaDefaults m_mobileDefaults; // 0xB0
		[Tooltip] // 0x00000001800D0BD0-0x00000001800D0C00
		public GaiaResource m_mobileResources; // 0xB8
		[Tooltip] // 0x00000001800D0F30-0x00000001800D0F60
		public GaiaResource m_mobileGameObjectResources; // 0xC0
		[Tooltip] // 0x00000001800D1120-0x00000001800D1150
		public GaiaDefaults m_desktopDefaults; // 0xC8
		[Tooltip] // 0x00000001800D1370-0x00000001800D13A0
		public GaiaResource m_desktopResources; // 0xD0
		[Tooltip] // 0x00000001800D1500-0x00000001800D1530
		public GaiaResource m_desktopGameObjectResources; // 0xD8
		[Tooltip] // 0x00000001800D1720-0x00000001800D1750
		public GaiaDefaults m_powerDesktopDefaults; // 0xE0
		[Tooltip] // 0x00000001800D19C0-0x00000001800D19F0
		public GaiaResource m_powerDesktopResources; // 0xE8
		[Tooltip] // 0x00000001800D1D60-0x00000001800D1D90
		public GaiaResource m_powerDesktopGameObjectResources; // 0xF0
		[Header] // 0x00000001800D2020-0x00000001800D2050
		public long m_lastWebUpdate; // 0xF8
		public bool m_hideHeroMessage; // 0x100
		public string m_latestNewsTitle; // 0x108
		public string m_latestNewsBody; // 0x110
		public string m_latestNewsUrl; // 0x118
		public Texture2D m_latestNewsImage; // 0x120
	
		// Constructors
		public GaiaSettings(); // 0x0000000181597420-0x00000001815975F0
	}
}
