/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralCursor : MonoBehaviour // TypeDefIndex: 11861
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static FeralCursor <instance>k__BackingField; // 0x00
	[Header] // 0x000000018028E150-0x000000018028E1A0
	[SerializeField] // 0x000000018028E150-0x000000018028E1A0
	private Texture2D _cursor; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cursorHotSpot; // 0x28
	[Header] // 0x000000018028E550-0x000000018028E5A0
	[SerializeField] // 0x000000018028E550-0x000000018028E5A0
	private Texture2D _cursorClick; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cursorClickHotSpot; // 0x38
	private bool _override; // 0x40
	private Texture2D _overrideCursor; // 0x48
	private Vector2 _overrideCursorHotSpot; // 0x50

	// Properties
	public static FeralCursor instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018069B7A0-0x000000018069B7E0 0x000000018069B7E0-0x000000018069B820

	// Constructors
	public FeralCursor(); // 0x000000018069B6F0-0x000000018069B7A0

	// Methods
	private void Awake(); // 0x000000018069B390-0x000000018069B4C0
	public void SetOverrideCursor(Texture2D inTexture, Vector2 inHotSpot); // 0x000000018069B6E0-0x000000018069B6F0
	public void ResetOverrideCursor(); // 0x000000018069B500-0x000000018069B580
	private void Update(); // 0x000000018069B580-0x000000018069B6E0
	private void OnDestroy(); // 0x000000018069B4C0-0x000000018069B500
	private void SetCursor(); // 0x000000018069B580-0x000000018069B6E0
}

