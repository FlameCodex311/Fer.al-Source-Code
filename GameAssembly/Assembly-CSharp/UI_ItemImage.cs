/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ItemImage : MonoBehaviour // TypeDefIndex: 13714
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x20
	private Waiter _iconLoadWaiter; // 0x28
	private Item _item; // 0x30
	private BaseDef _def; // 0x38
	private Icon3DAnimationType _animationType; // 0x40
	private Icon3DTextureSize _textureSize; // 0x44

	// Constructors
	public UI_ItemImage(); // 0x000000018037DC30-0x000000018037DC40

	// Methods
	private void Awake(); // 0x000000018037D3A0-0x000000018037D430
	private void OnDestroy(); // 0x000000018037D510-0x000000018037D5A0
	public void Setup(Item inItem, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x007BA4B3 */, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None /* Metadata: 0x007BA4B7 */); // 0x000000018037D850-0x000000018037D990
	public void Setup(BaseDef inDef, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x007BA4BB */, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None /* Metadata: 0x007BA4BF */); // 0x000000018037D710-0x000000018037D850
	private void OnItemDyed(ItemDyeResponse inMessage); // 0x000000018037D660-0x000000018037D710
	private void OnDisable(); // 0x000000018037D5A0-0x000000018037D660
	[DeMethodButton] // 0x00000001801DF860-0x00000001801DF8C0
	public void DebugAssignIcon(); // 0x000000018037D430-0x000000018037D4B0
	[DeMethodButton] // 0x00000001801DFC40-0x00000001801DFCA0
	public void DebugReleaseIcon(); // 0x000000018037D4B0-0x000000018037D510
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__8_0(); // 0x000000018037DA80-0x000000018037DB40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(); // 0x000000018037DB40-0x000000018037DC30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnItemDyed>b__10_0(); // 0x000000018037D990-0x000000018037DA80
}

