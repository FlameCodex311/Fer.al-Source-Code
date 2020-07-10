/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CursorManager : SingletonManagerBase<CursorManager> // TypeDefIndex: 10676
{
	// Fields
	[EnumList] // 0x000000018016BAA0-0x000000018016BB10
	[SerializeField] // 0x000000018016BAA0-0x000000018016BB10
	private List<MouseCursorTexture> _mouseCursorTextures; // 0x60
	private Dictionary<GameObject, MouseCursorType> _cursorIconLookup; // 0x68
	private List<GameObject> _hoveredObjectCandidates; // 0x70

	// Nested types
	public enum MouseCursorType // TypeDefIndex: 10677
	{
		Normal = 0,
		DraggableSize_Vertical = 10,
		DraggableSize_Horizontal = 11,
		DraggableSize_Diagonal = 12,
		DraggablePosition = 15,
		InputField = 20,
		SanctuaryCameraMove = 25,
		SanctuaryCameraRotate = 26,
		SanctuaryObjectMove = 27,
		SanctuaryObjectRotate = 28
	}

	[Serializable]
	private class MouseCursorTexture // TypeDefIndex: 10678
	{
		// Fields
		public Texture2D texture; // 0x10
		public Vector2 hotspot; // 0x18

		// Constructors
		public MouseCursorTexture(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public CursorManager(); // 0x0000000180F40920-0x0000000180F409D0

	// Methods
	public void RegisterCursorIcon(GameObject inMouseOverTarget, MouseCursorType inCursorType); // 0x0000000180F40700-0x0000000180F407C0
	public void UnregisterCursorIcon(GameObject inMouseOverTarget); // 0x0000000180F40840-0x0000000180F40920
	public void AddHoveredObject(GameObject inHoveredObject); // 0x0000000180F40420-0x0000000180F404A0
	public void RemoveHoveredObject(GameObject inHoveredObject); // 0x0000000180F407C0-0x0000000180F40840
	private void RefreshCursor(); // 0x0000000180F404A0-0x0000000180F40700
}

