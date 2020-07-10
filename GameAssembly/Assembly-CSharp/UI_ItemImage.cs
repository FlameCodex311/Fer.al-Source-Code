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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ItemImage : MonoBehaviour // TypeDefIndex: 12167
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x20
	private Waiter _iconLoadWaiter; // 0x28
	private Item _item; // 0x30
	private BaseDef _def; // 0x38
	private Icon3DAnimationType _animationType; // 0x40
	private Icon3DTextureSize _textureSize; // 0x44

	// Constructors
	public UI_ItemImage(); // 0x0000000180E46170-0x0000000180E46180

	// Methods
	private void Awake(); // 0x0000000180E458D0-0x0000000180E45960
	private void OnDestroy(); // 0x0000000180E45A40-0x0000000180E45AD0
	public void Setup(Item inItem, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x00782DA5 */, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None /* Metadata: 0x00782DA9 */); // 0x0000000180E45D90-0x0000000180E45ED0
	public void Setup(BaseDef inDef, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x00782DAD */, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None /* Metadata: 0x00782DB1 */); // 0x0000000180E45C50-0x0000000180E45D90
	private void OnItemDyed(ItemDyeResponse inMessage); // 0x0000000180E45B90-0x0000000180E45C50
	private void OnDisable(); // 0x0000000180E45AD0-0x0000000180E45B90
	[DeMethodButton] // 0x0000000180102810-0x0000000180102870
	public void DebugAssignIcon(); // 0x0000000180E45960-0x0000000180E459E0
	[DeMethodButton] // 0x0000000180102B20-0x0000000180102B80
	public void DebugReleaseIcon(); // 0x0000000180E459E0-0x0000000180E45A40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__8_0(); // 0x0000000180E45FC0-0x0000000180E46080
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(); // 0x0000000180E46080-0x0000000180E46170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnItemDyed>b__10_0(); // 0x0000000180E45ED0-0x0000000180E45FC0
}

