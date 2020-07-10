/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SanctuaryManager : SingletonManagerBase<SanctuaryManager> // TypeDefIndex: 10780
{
	// Fields
	[RootSelector] // 0x00000001800D6190-0x00000001800D61F0
	public string sanctuaryDataPath; // 0x60
	private static int _sanctuaryLayer; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LayerMask _portalRenderMask; // 0x68
	[Header] // 0x00000001800D6560-0x00000001800D65B0
	[SerializeField] // 0x00000001800D6560-0x00000001800D65B0
	private Color _colorValid; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorInvalid; // 0x7C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _gridColor; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowOverlappingItems; // 0x9C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _forceGroundItemsToGround; // 0x9D
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _forceWallItemsToWall; // 0x9E
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useGridPositioning; // 0x9F
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _enableStaticObjects; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _showGrid; // 0xA1
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _highlightNudge; // 0xA4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _roundTo; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _maxColliders; // 0xAC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _globalRoomFadeOut; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _globalRoomFadeWait; // 0xB4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _globalRoomFadeIn; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _stepHeight; // 0xBC

	// Properties
	public static int sanctuaryLayer { get; } // 0x0000000181363EF0-0x0000000181363FE0 
	public LayerMask portalRenderMask { get; } // 0x00000001803DAC60-0x00000001803DAC70 
	public bool inSanctuary { get; } // 0x0000000181363C20-0x0000000181363CF0 
	public bool inSanctuaryInterior { get; } // 0x0000000181363B50-0x0000000181363C20 
	public bool inSanctuaryExterior { get; } // 0x0000000181363A80-0x0000000181363B50 
	public Color colorValid { get; } // 0x0000000181363A00-0x0000000181363A10 
	public Color colorInvalid { get; } // 0x00000001813639F0-0x0000000181363A00 
	public Color gridColor { get; } // 0x0000000181363A60-0x0000000181363A70 
	public bool allowOverlappingItems { get; } // 0x0000000180CB7780-0x0000000180CB7790 
	public bool forceGroundItemsToGround { get; } // 0x0000000181363A10-0x0000000181363A20 
	public bool forceWallItemsToWall { get; } // 0x0000000181363A20-0x0000000181363A30 
	public bool useGridPositioning { get; } // 0x0000000181364000-0x0000000181364010 
	public bool enableStaticObjects { get; } // 0x0000000180369C30-0x0000000180369C40 
	public bool showGrid { get; } // 0x0000000181363FE0-0x0000000181363FF0 
	public float highlightNudge { get; } // 0x0000000181363A70-0x0000000181363A80 
	public float roundTo { get; } // 0x0000000181363D70-0x0000000181363D80 
	public int maxColliders { get; } // 0x00000001806891F0-0x0000000180689200 
	public float globalRoomFadeOut { get; } // 0x0000000181363A40-0x0000000181363A50 
	public float globalRoomFadeWait { get; } // 0x0000000181363A50-0x0000000181363A60 
	public float globalRoomFadeIn { get; } // 0x0000000181363A30-0x0000000181363A40 
	public float stepHeight { get; } // 0x0000000181363FF0-0x0000000181364000 
	public bool sanctuaryHasLoaded { get; } // 0x0000000181363D80-0x0000000181363EF0 
	public bool mySanctuary { get; } // 0x0000000181363CF0-0x0000000181363D70 

	// Constructors
	public SanctuaryManager(); // 0x0000000181363890-0x00000001813639F0
	static SanctuaryManager(); // 0x0000000181363850-0x0000000181363890

	// Methods
	public bool IsWall(Vector3 inNormal); // 0x0000000181363330-0x0000000181363350
	public bool ShouldTeleport(string inInventoryId, int inGridId, Vector3 inLocalPosition); // 0x0000000181363350-0x0000000181363850
	public SanctuarySurface GetSanctuarySurface(int inSurfaceIdx); // 0x0000000181363120-0x0000000181363330
}

