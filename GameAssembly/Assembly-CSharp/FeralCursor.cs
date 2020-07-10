/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralCursor : MonoBehaviour // TypeDefIndex: 10371
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static FeralCursor <instance>k__BackingField; // 0x00
	[Header] // 0x00000001800F7350-0x00000001800F73A0
	[SerializeField] // 0x00000001800F7350-0x00000001800F73A0
	private Texture2D _cursor; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cursorHotSpot; // 0x28
	[Header] // 0x00000001800F7770-0x00000001800F77C0
	[SerializeField] // 0x00000001800F7770-0x00000001800F77C0
	private Texture2D _cursorClick; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cursorClickHotSpot; // 0x38
	private bool _override; // 0x40
	private Texture2D _overrideCursor; // 0x48
	private Vector2 _overrideCursorHotSpot; // 0x50

	// Properties
	public static FeralCursor instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181105EE0-0x0000000181105F20 0x0000000181105F20-0x0000000181105F60

	// Constructors
	public FeralCursor(); // 0x0000000181105E30-0x0000000181105EE0

	// Methods
	private void Awake(); // 0x0000000181105AD0-0x0000000181105C00
	public void SetOverrideCursor(Texture2D inTexture, Vector2 inHotSpot); // 0x0000000181105E20-0x0000000181105E30
	public void ResetOverrideCursor(); // 0x0000000181105C40-0x0000000181105CC0
	private void Update(); // 0x0000000181105CC0-0x0000000181105E20
	private void OnDestroy(); // 0x0000000181105C00-0x0000000181105C40
	private void SetCursor(); // 0x0000000181105CC0-0x0000000181105E20
}

