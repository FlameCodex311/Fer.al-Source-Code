/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI3D_SanctuaryItem : UI_ScreenSpaceTransform // TypeDefIndex: 13825
{
	// Fields
	private SanctuaryObjectBase _sanctuaryObject; // 0xC0

	// Properties
	private SanctuaryObjectBase SanctuaryObject { get; } // 0x0000000180517ED0-0x0000000180517FC0 

	// Constructors
	public UI3D_SanctuaryItem(); // 0x0000000180517EC0-0x0000000180517ED0

	// Methods
	public override void MStart(); // 0x0000000180517BF0-0x0000000180517C90
	public override void MOnDestroy(); // 0x0000000180517B50-0x0000000180517BF0
	public void BtnClicked_Remove(); // 0x0000000180517970-0x0000000180517B50
	private void OnSanctuaryObjectSelected(SanctuaryObjectSelectedMessage inMessage); // 0x0000000180517C90-0x0000000180517D90
	protected override void UpdateVisibilityAndAlpha(); // 0x0000000180517D90-0x0000000180517EC0
}

