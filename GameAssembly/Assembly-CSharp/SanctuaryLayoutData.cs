/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x0000000180104DE0-0x0000000180104E30
public class SanctuaryLayoutData : ScriptableObject // TypeDefIndex: 11724
{
	// Fields
	private int _safeBeginningGridIndexMultiplier; // 0x18
	private int _worldSpacing; // 0x1C
	[RootSelector] // 0x0000000180104EB0-0x0000000180104F10
	public string defaultFlooring; // 0x20
	[RootSelector] // 0x0000000180104F90-0x0000000180104FF0
	public string defaultWallpaper; // 0x28
	[RootSelector] // 0x00000001801050D0-0x0000000180105130
	public string defaultTrim; // 0x30
	[RootSelector] // 0x00000001801052E0-0x0000000180105340
	public string defaultCeiling; // 0x38
	[NonSerialized]
	public Material defaultFlooringMat; // 0x40
	[NonSerialized]
	public Material defaultWallpaperMat; // 0x48
	[NonSerialized]
	public Material defaultTrimMat; // 0x50
	[NonSerialized]
	public Material defaultCeilingMat; // 0x58
	[Header] // 0x00000001800DA180-0x00000001800DA1D0
	[SerializeField] // 0x00000001800DA180-0x00000001800DA1D0
	private FeralAudioInfo[] _interiorAudio; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo[] _exteriorAudio; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioSelectObject; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioRotateItem; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioDoorOpen; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioDoorClose; // 0x88
	[Header] // 0x0000000180105A00-0x0000000180105A30
	public BaseMaterialInfo baseMaterialInfo; // 0x90
	public RoomScaleInfo roomScaleInfo; // 0x98
	[Header] // 0x0000000180105AF0-0x0000000180105B20
	public InteriorInfo interiorInfo; // 0xA0
	[Header] // 0x0000000180105CE0-0x0000000180105D10
	public ExteriorInfo exteriorInfo; // 0xA8
	[Header] // 0x0000000180105F10-0x0000000180105F40
	public List<Floor> floors; // 0xB0
	[Header] // 0x00000001801060A0-0x00000001801060F0
	[SerializeField] // 0x00000001801060A0-0x00000001801060F0
	private GameObject _editHighlightPrefab; // 0xB8
	[Header] // 0x00000001801061F0-0x0000000180106240
	[SerializeField] // 0x00000001801061F0-0x0000000180106240
	private GameObject _indoorLightsPrefab; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _exteriorLightsPrefab; // 0xC8
	[Header] // 0x0000000180106480-0x00000001801064D0
	[SerializeField] // 0x0000000180106480-0x00000001801064D0
	private GameObject _portal; // 0xD0
	[Header] // 0x00000001800DF1C0-0x00000001800DF210
	[SerializeField] // 0x00000001800DF1C0-0x00000001800DF210
	private Color _colorDay; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorNight; // 0xE8
	[Header] // 0x00000001801068F0-0x0000000180106940
	[SerializeField] // 0x00000001801068F0-0x0000000180106940
	private float _rayDistance; // 0xF8
	[Header] // 0x0000000180106B10-0x0000000180106B60
	[SerializeField] // 0x0000000180106B10-0x0000000180106B60
	private int _maxExpansions; // 0xFC

	// Properties
	public int safeBeginningGridIndexMultiplier { get; } // 0x0000000180367710-0x0000000180367720 
	public int worldSpacing { get; } // 0x000000018037E420-0x000000018037E430 
	public FeralAudioInfo[] interiorAudio { get; } // 0x0000000180369B40-0x0000000180369B50 
	public FeralAudioInfo[] exteriorAudio { get; } // 0x0000000180358970-0x0000000180358980 
	public FeralAudioInfo audioSelectObject { get; } // 0x0000000180369B50-0x0000000180369B60 
	public FeralAudioInfo audioRotateItem { get; } // 0x0000000180369C70-0x0000000180369C80 
	public FeralAudioInfo audioDoorOpen { get; } // 0x000000018035FCB0-0x000000018035FCC0 
	public FeralAudioInfo audioDoorClose { get; } // 0x0000000180424200-0x0000000180424210 
	public GameObject editHighlightPrefab { get; } // 0x00000001803ED9C0-0x00000001803ED9D0 
	public GameObject indoorLightsPrefab { get; } // 0x00000001804A1050-0x00000001804A1060 
	public GameObject exteriorLightsPrefab { get; } // 0x00000001804A2590-0x00000001804A25A0 
	public GameObject portal { get; } // 0x00000001804A24D0-0x00000001804A24E0 
	public Color colorDay { get; } // 0x00000001813626A0-0x00000001813626B0 
	public Color colorNight { get; } // 0x00000001813626B0-0x00000001813626C0 
	public float rayDistance { get; } // 0x00000001813626D0-0x00000001813626E0 
	public float maxExpansions { get; } // 0x00000001813626C0-0x00000001813626D0 

	// Nested types
	[Serializable]
	public class BaseMaterialInfo // TypeDefIndex: 11725
	{
		// Fields
		public Material blackMaterial; // 0x10
		public Material fadeMaterial; // 0x18
		public Material borderMaterial; // 0x20
		public Material editLineMaterial; // 0x28

		// Constructors
		public BaseMaterialInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class RoomScaleInfo // TypeDefIndex: 11726
	{
		// Properties
		public Vector3 decorateSize { get; } // 0x0000000181361C10-0x0000000181361C50 
		public Vector3 islandSize { get; } // 0x0000000181361C90-0x0000000181361CD0 
		public Vector3 houseSize { get; } // 0x0000000181361C50-0x0000000181361C90 

		// Constructors
		public RoomScaleInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class SkyboxInfo // TypeDefIndex: 11727
	{
		// Fields
		public GameObject skybox; // 0x10
		public Vector3 offset; // 0x18
		public float scale; // 0x24

		// Constructors
		public SkyboxInfo(); // 0x00000001813719E0-0x0000000181371A60
	}

	[Serializable]
	public class InteriorInfo // TypeDefIndex: 11728
	{
		// Fields
		public GameObject[] rooms; // 0x10
		public GameObject[] roomsUpgraded; // 0x18
		public SkyboxInfo skybox; // 0x20

		// Constructors
		public InteriorInfo(); // 0x0000000181361930-0x0000000181361990
	}

	[Serializable]
	public class ExteriorInfo // TypeDefIndex: 11729
	{
		// Fields
		public SkyboxInfo skybox; // 0x10

		// Constructors
		public ExteriorInfo(); // 0x0000000181361790-0x00000001813617F0
	}

	public enum ERoomType // TypeDefIndex: 11730
	{
		NOTUSED = 0,
		BASIC = 1,
		ENTRY = 2
	}

	[Serializable]
	public class Floor // TypeDefIndex: 11731
	{
		// Fields
		public List<RoomX> roomsX; // 0x10

		// Constructors
		public Floor(); // 0x00000001813617F0-0x0000000181361850
	}

	[Serializable]
	public class RoomX // TypeDefIndex: 11732
	{
		// Fields
		public List<RoomZ> roomsZ; // 0x10

		// Constructors
		public RoomX(); // 0x0000000181361CD0-0x0000000181361D30
	}

	[Serializable]
	public class RoomZ // TypeDefIndex: 11733
	{
		// Fields
		public RoomData roomData; // 0x10

		// Constructors
		public RoomZ(); // 0x0000000181361D30-0x0000000181361D90
	}

	[Serializable]
	public class RoomData // TypeDefIndex: 11734
	{
		// Fields
		public ERoomType roomType; // 0x10
		public int stageOpen; // 0x14
		public int roomPrefabIdx; // 0x18

		// Constructors
		public RoomData(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public SanctuaryLayoutData(); // 0x0000000181362470-0x00000001813626A0
}

