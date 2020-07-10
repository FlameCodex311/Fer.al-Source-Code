/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI3D_SanctuaryItem : UI_ScreenSpaceTransform // TypeDefIndex: 12636
{
	// Fields
	private SanctuaryObjectBase _sanctuaryObject; // 0xC0

	// Properties
	private SanctuaryObjectBase SanctuaryObject { get; } // 0x0000000180FB2F10-0x0000000180FB3000 

	// Constructors
	public UI3D_SanctuaryItem(); // 0x0000000180FB2F00-0x0000000180FB2F10

	// Methods
	public override void MStart(); // 0x0000000180FB2C30-0x0000000180FB2CD0
	public override void MOnDestroy(); // 0x0000000180FB2B90-0x0000000180FB2C30
	public void BtnClicked_Remove(); // 0x0000000180FB29B0-0x0000000180FB2B90
	private void OnSanctuaryObjectSelected(SanctuaryObjectSelectedMessage inMessage); // 0x0000000180FB2CD0-0x0000000180FB2DD0
	protected override void UpdateVisibilityAndAlpha(); // 0x0000000180FB2DD0-0x0000000180FB2F00
}

