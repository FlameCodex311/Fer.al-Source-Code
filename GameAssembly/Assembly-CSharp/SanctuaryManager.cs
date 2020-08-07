/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryManager : SingletonManagerBase<SanctuaryManager> // TypeDefIndex: 12290
{
	// Fields
	[RootSelector] // 0x00000001802720A0-0x0000000180272100
	public string sanctuaryDataPath; // 0x60
	private static int _sanctuaryLayer; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LayerMask _portalRenderMask; // 0x68
	[Header] // 0x000000018021E0A0-0x000000018021E0F0
	[SerializeField] // 0x000000018021E0A0-0x000000018021E0F0
	private Color _colorValid; // 0x6C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorInvalid; // 0x7C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _gridColor; // 0x8C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _allowOverlappingItems; // 0x9C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _forceGroundItemsToGround; // 0x9D
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _forceWallItemsToWall; // 0x9E
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useGridPositioning; // 0x9F
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _enableStaticObjects; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _showGrid; // 0xA1
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _highlightNudge; // 0xA4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _roundTo; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _maxColliders; // 0xAC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _globalRoomFadeOut; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _globalRoomFadeWait; // 0xB4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _globalRoomFadeIn; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _stepHeight; // 0xBC

	// Properties
	public static int sanctuaryLayer { get; } // 0x0000000180BEC6F0-0x0000000180BEC7E0 
	public LayerMask portalRenderMask { get; } // 0x00000001806F4980-0x00000001806F4990 
	public bool inSanctuary { get; } // 0x0000000180BEC420-0x0000000180BEC4F0 
	public bool inSanctuaryInterior { get; } // 0x0000000180BEC350-0x0000000180BEC420 
	public bool inSanctuaryExterior { get; } // 0x0000000180BEC280-0x0000000180BEC350 
	public Color colorValid { get; } // 0x0000000180BEC200-0x0000000180BEC210 
	public Color colorInvalid { get; } // 0x0000000180BEC1F0-0x0000000180BEC200 
	public Color gridColor { get; } // 0x0000000180BEC260-0x0000000180BEC270 
	public bool allowOverlappingItems { get; } // 0x0000000180BEC1E0-0x0000000180BEC1F0 
	public bool forceGroundItemsToGround { get; } // 0x0000000180BEC210-0x0000000180BEC220 
	public bool forceWallItemsToWall { get; } // 0x0000000180BEC220-0x0000000180BEC230 
	public bool useGridPositioning { get; } // 0x0000000180BEC800-0x0000000180BEC810 
	public bool enableStaticObjects { get; } // 0x0000000180418A20-0x0000000180418A30 
	public bool showGrid { get; } // 0x0000000180BEC7E0-0x0000000180BEC7F0 
	public float highlightNudge { get; } // 0x0000000180BEC270-0x0000000180BEC280 
	public float roundTo { get; } // 0x0000000180BEC570-0x0000000180BEC580 
	public int maxColliders { get; } // 0x0000000180AD57F0-0x0000000180AD5800 
	public float globalRoomFadeOut { get; } // 0x0000000180BEC240-0x0000000180BEC250 
	public float globalRoomFadeWait { get; } // 0x0000000180BEC250-0x0000000180BEC260 
	public float globalRoomFadeIn { get; } // 0x0000000180BEC230-0x0000000180BEC240 
	public float stepHeight { get; } // 0x0000000180BEC7F0-0x0000000180BEC800 
	public bool sanctuaryHasLoaded { get; } // 0x0000000180BEC580-0x0000000180BEC6F0 
	public bool mySanctuary { get; } // 0x0000000180BEC4F0-0x0000000180BEC570 

	// Constructors
	public SanctuaryManager(); // 0x0000000180BEC080-0x0000000180BEC1E0
	static SanctuaryManager(); // 0x0000000180BEC040-0x0000000180BEC080

	// Methods
	public bool IsWall(Vector3 inNormal); // 0x0000000180BEBB30-0x0000000180BEBB50
	public bool ShouldTeleport(string inInventoryId, int inGridId, Vector3 inLocalPosition); // 0x0000000180BEBB50-0x0000000180BEC040
	public SanctuarySurface GetSanctuarySurface(int inSurfaceIdx); // 0x0000000180BEB930-0x0000000180BEBB30
}

