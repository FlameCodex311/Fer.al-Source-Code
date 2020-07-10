/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800B6E20-0x00000001800B6E50
public class MinimapMap : ManagedBehaviour // TypeDefIndex: 10856
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LayerMask _cullingMask; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _hideTerrainObjects; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _hideTerrain; // 0x55
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject[] _hideObjects; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _mapCenter; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _mapSize; // 0x6C
	private int _mapTextureSize; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _flip180; // 0x74
	private int _mapTextureCount; // 0x78
	public MapImageInfo[] mapImageInfos; // 0x80
	private float _mapUnitScale; // 0x88

	// Properties
	public LayerMask cullingMask { get; } // 0x0000000180369BA0-0x0000000180369BB0 
	public bool hideTerrainObjects { get; } // 0x0000000180F6A9C0-0x0000000180F6A9D0 
	public bool hideTerrain { get; } // 0x00000001810B8B80-0x00000001810B8B90 
	public GameObject[] hideObjects { get; } // 0x0000000180357120-0x0000000180357130 
	public Vector3 mapCenter { get; } // 0x00000001810B8B90-0x00000001810B8BB0 
	public float mapSize { get; } // 0x0000000180EF1650-0x0000000180EF1660 
	public int mapTextureSize { get; } // 0x00000001803DAD00-0x00000001803DAD10 
	public bool flip180 { get; } // 0x0000000180545D50-0x0000000180545D60 
	public int mapTextureCount { get; } // 0x00000001803DAE10-0x00000001803DAE20 
	public float mapUnitScale { get; } // 0x00000001810B8BB0-0x00000001810B8BE0 

	// Nested types
	[Serializable]
	public class MapImageInfo // TypeDefIndex: 10857
	{
		// Fields
		public Sprite mapImage; // 0x10
		public float farClip; // 0x18
		public float mapHeight; // 0x1C
		public bool showBounds; // 0x20

		// Constructors
		public MapImageInfo(); // 0x00000001810A2480-0x00000001810A24A0
	}

	// Constructors
	public MinimapMap(); // 0x00000001810B8AD0-0x00000001810B8B80

	// Methods
	private void OnDrawGizmosSelected(); // 0x00000001810B86A0-0x00000001810B8AD0
}

