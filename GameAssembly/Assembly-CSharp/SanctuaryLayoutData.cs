/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801DF260-0x00000001801DF2B0
public class SanctuaryLayoutData : ScriptableObject // TypeDefIndex: 13251
{
	// Fields
	private int _safeBeginningGridIndexMultiplier; // 0x18
	private int _worldSpacing; // 0x1C
	[RootSelector] // 0x00000001801DF4C0-0x00000001801DF520
	public string defaultFlooring; // 0x20
	[RootSelector] // 0x00000001801DF8C0-0x00000001801DF920
	public string defaultWallpaper; // 0x28
	[RootSelector] // 0x00000001801DF9F0-0x00000001801DFA50
	public string defaultTrim; // 0x30
	[RootSelector] // 0x00000001801DFCA0-0x00000001801DFD00
	public string defaultCeiling; // 0x38
	[NonSerialized]
	public Material defaultFlooringMat; // 0x40
	[NonSerialized]
	public Material defaultWallpaperMat; // 0x48
	[NonSerialized]
	public Material defaultTrimMat; // 0x50
	[NonSerialized]
	public Material defaultCeilingMat; // 0x58
	[Header] // 0x00000001801D2A20-0x00000001801D2A70
	[SerializeField] // 0x00000001801D2A20-0x00000001801D2A70
	private FeralAudioInfo[] _interiorAudio; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo[] _exteriorAudio; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioSelectObject; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioRotateItem; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioDoorOpen; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioDoorClose; // 0x88
	[Header] // 0x00000001801E0640-0x00000001801E0670
	public BaseMaterialInfo baseMaterialInfo; // 0x90
	public RoomScaleInfo roomScaleInfo; // 0x98
	[Header] // 0x00000001801E0850-0x00000001801E0880
	public InteriorInfo interiorInfo; // 0xA0
	[Header] // 0x00000001801E0A80-0x00000001801E0AB0
	public ExteriorInfo exteriorInfo; // 0xA8
	[Header] // 0x00000001801E0D40-0x00000001801E0D70
	public List<Floor> floors; // 0xB0
	[Header] // 0x00000001801E0F70-0x00000001801E0FC0
	[SerializeField] // 0x00000001801E0F70-0x00000001801E0FC0
	private GameObject _editHighlightPrefab; // 0xB8
	[Header] // 0x00000001801E25A0-0x00000001801E25F0
	[SerializeField] // 0x00000001801E25A0-0x00000001801E25F0
	private GameObject _indoorLightsPrefab; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _exteriorLightsPrefab; // 0xC8
	[Header] // 0x00000001801E2970-0x00000001801E29C0
	[SerializeField] // 0x00000001801E2970-0x00000001801E29C0
	private GameObject _portal; // 0xD0
	[Header] // 0x00000001801E2B10-0x00000001801E2B60
	[SerializeField] // 0x00000001801E2B10-0x00000001801E2B60
	private Color _colorDay; // 0xD8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorNight; // 0xE8
	[Header] // 0x00000001801E2FB0-0x00000001801E3000
	[SerializeField] // 0x00000001801E2FB0-0x00000001801E3000
	private float _rayDistance; // 0xF8
	[Header] // 0x00000001801E31F0-0x00000001801E3240
	[SerializeField] // 0x00000001801E31F0-0x00000001801E3240
	private int _maxExpansions; // 0xFC

	// Properties
	public int safeBeginningGridIndexMultiplier { get; } // 0x00000001803F46B0-0x00000001803F46C0 
	public int worldSpacing { get; } // 0x00000001803FB770-0x00000001803FB780 
	public FeralAudioInfo[] interiorAudio { get; } // 0x0000000180418970-0x0000000180418980 
	public FeralAudioInfo[] exteriorAudio { get; } // 0x00000001803765E0-0x00000001803765F0 
	public FeralAudioInfo audioSelectObject { get; } // 0x0000000180418980-0x0000000180418990 
	public FeralAudioInfo audioRotateItem { get; } // 0x0000000180418A40-0x0000000180418A50 
	public FeralAudioInfo audioDoorOpen { get; } // 0x000000018040ED60-0x000000018040ED70 
	public FeralAudioInfo audioDoorClose { get; } // 0x0000000180476CE0-0x0000000180476CF0 
	public GameObject editHighlightPrefab { get; } // 0x00000001803CFB60-0x00000001803CFB70 
	public GameObject indoorLightsPrefab { get; } // 0x0000000180529360-0x0000000180529370 
	public GameObject exteriorLightsPrefab { get; } // 0x00000001804AF400-0x00000001804AF410 
	public GameObject portal { get; } // 0x00000001805293A0-0x00000001805293B0 
	public Color colorDay { get; } // 0x0000000180BEAF10-0x0000000180BEAF20 
	public Color colorNight { get; } // 0x0000000180BEAF20-0x0000000180BEAF30 
	public float rayDistance { get; } // 0x0000000180BEAF40-0x0000000180BEAF50 
	public float maxExpansions { get; } // 0x0000000180BEAF30-0x0000000180BEAF40 

	// Nested types
	[Serializable]
	public class BaseMaterialInfo // TypeDefIndex: 13252
	{
		// Fields
		public Material blackMaterial; // 0x10
		public Material fadeMaterial; // 0x18
		public Material borderMaterial; // 0x20
		public Material editLineMaterial; // 0x28

		// Constructors
		public BaseMaterialInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class RoomScaleInfo // TypeDefIndex: 13253
	{
		// Properties
		public Vector3 decorateSize { get; } // 0x0000000180BE52B0-0x0000000180BE52F0 
		public Vector3 islandSize { get; } // 0x0000000180BE53F0-0x0000000180BE5430 
		public Vector3 houseSize { get; } // 0x0000000180BE53B0-0x0000000180BE53F0 
		public Vector3 greenhouseDecorateSize { get; } // 0x0000000180BE52F0-0x0000000180BE5330 
		public Vector3 greenhouseIslandSize { get; } // 0x0000000180BE5330-0x0000000180BE5370 
		public Vector3 greenhouseSize { get; } // 0x0000000180BE5370-0x0000000180BE53B0 

		// Constructors
		public RoomScaleInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class SkyboxInfo // TypeDefIndex: 13254
	{
		// Fields
		public GameObject skybox; // 0x10
		public Vector3 offset; // 0x18
		public float scale; // 0x24

		// Constructors
		public SkyboxInfo(); // 0x0000000180BF6ED0-0x0000000180BF6F50
	}

	[Serializable]
	public class InteriorInfo // TypeDefIndex: 13255
	{
		// Fields
		public GameObject[] rooms; // 0x10
		public GameObject[] roomsUpgraded; // 0x18
		public SkyboxInfo skybox; // 0x20

		// Constructors
		public InteriorInfo(); // 0x0000000180BE4FD0-0x0000000180BE5030
	}

	[Serializable]
	public class ExteriorInfo // TypeDefIndex: 13256
	{
		// Fields
		public SkyboxInfo skybox; // 0x10

		// Constructors
		public ExteriorInfo(); // 0x0000000180BE4F10-0x0000000180BE4F70
	}

	public enum ERoomType // TypeDefIndex: 13257
	{
		NOTUSED = 0,
		BASIC = 1,
		ENTRY = 2
	}

	[Serializable]
	public class Floor // TypeDefIndex: 13258
	{
		// Fields
		public List<RoomX> roomsX; // 0x10

		// Constructors
		public Floor(); // 0x0000000180BE4F70-0x0000000180BE4FD0
	}

	[Serializable]
	public class RoomX // TypeDefIndex: 13259
	{
		// Fields
		public List<RoomZ> roomsZ; // 0x10

		// Constructors
		public RoomX(); // 0x0000000180BE5430-0x0000000180BE5490
	}

	[Serializable]
	public class RoomZ // TypeDefIndex: 13260
	{
		// Fields
		public RoomData roomData; // 0x10

		// Constructors
		public RoomZ(); // 0x0000000180BE5490-0x0000000180BE54F0
	}

	[Serializable]
	public class RoomData // TypeDefIndex: 13261
	{
		// Fields
		public ERoomType roomType; // 0x10
		public int stageOpen; // 0x14
		public int roomPrefabIdx; // 0x18

		// Constructors
		public RoomData(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public SanctuaryLayoutData(); // 0x0000000180BEACE0-0x0000000180BEAF10
}

