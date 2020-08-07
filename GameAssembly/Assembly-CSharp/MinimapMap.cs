/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018026FA70-0x000000018026FAA0
public class MinimapMap : ManagedBehaviour // TypeDefIndex: 12366
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LayerMask _cullingMask; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _hideTerrainObjects; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _hideTerrain; // 0x55
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject[] _hideObjects; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _mapCenter; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _mapSize; // 0x6C
	private int _mapTextureSize; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _flip180; // 0x74
	private int _mapTextureCount; // 0x78
	public MapImageInfo[] mapImageInfos; // 0x80
	private float _mapUnitScale; // 0x88

	// Properties
	public LayerMask cullingMask { get; } // 0x00000001803F8270-0x00000001803F8280 
	public bool hideTerrainObjects { get; } // 0x00000001804D5820-0x00000001804D5830 
	public bool hideTerrain { get; } // 0x0000000180C07EA0-0x0000000180C07EB0 
	public GameObject[] hideObjects { get; } // 0x00000001803A1580-0x00000001803A1590 
	public Vector3 mapCenter { get; } // 0x0000000180A542D0-0x0000000180A542F0 
	public float mapSize { get; } // 0x00000001804C5F30-0x00000001804C5F40 
	public int mapTextureSize { get; } // 0x00000001804B4700-0x00000001804B4710 
	public bool flip180 { get; } // 0x00000001808AE770-0x00000001808AE780 
	public int mapTextureCount { get; } // 0x00000001803959E0-0x00000001803959F0 
	public float mapUnitScale { get; } // 0x0000000180C07EB0-0x0000000180C07EE0 

	// Nested types
	[Serializable]
	public class MapImageInfo // TypeDefIndex: 12367
	{
		// Fields
		public Sprite mapImage; // 0x10
		public float farClip; // 0x18
		public float mapHeight; // 0x1C
		public bool showBounds; // 0x20

		// Constructors
		public MapImageInfo(); // 0x0000000180BFDE10-0x0000000180BFDE30
	}

	// Constructors
	public MinimapMap(); // 0x0000000180C07DF0-0x0000000180C07EA0

	// Methods
	private void OnDrawGizmosSelected(); // 0x0000000180C079D0-0x0000000180C07DF0
}

