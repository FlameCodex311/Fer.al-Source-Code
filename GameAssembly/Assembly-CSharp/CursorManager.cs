/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CursorManager : SingletonManagerBase<CursorManager> // TypeDefIndex: 12179
{
	// Fields
	[EnumList] // 0x00000001802489A0-0x0000000180248A10
	[SerializeField] // 0x00000001802489A0-0x0000000180248A10
	private List<MouseCursorTexture> _mouseCursorTextures; // 0x60
	private Dictionary<GameObject, MouseCursorType> _cursorIconLookup; // 0x68
	private List<GameObject> _hoveredObjectCandidates; // 0x70

	// Nested types
	public enum MouseCursorType // TypeDefIndex: 12180
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
	private class MouseCursorTexture // TypeDefIndex: 12181
	{
		// Fields
		public Texture2D texture; // 0x10
		public Vector2 hotspot; // 0x18

		// Constructors
		public MouseCursorTexture(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public CursorManager(); // 0x0000000180553040-0x00000001805530F0

	// Methods
	public void RegisterCursorIcon(GameObject inMouseOverTarget, MouseCursorType inCursorType); // 0x0000000180552E20-0x0000000180552EE0
	public void UnregisterCursorIcon(GameObject inMouseOverTarget); // 0x0000000180552F60-0x0000000180553040
	public void AddHoveredObject(GameObject inHoveredObject); // 0x0000000180552B50-0x0000000180552BD0
	public void RemoveHoveredObject(GameObject inHoveredObject); // 0x0000000180552EE0-0x0000000180552F60
	private void RefreshCursor(); // 0x0000000180552BD0-0x0000000180552E20
}

