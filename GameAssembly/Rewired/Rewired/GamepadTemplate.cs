/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 9196
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x00744505
		public const int elementId_leftStickY = 1; // Metadata: 0x00744509
		public const int elementId_rightStickX = 2; // Metadata: 0x0074450D
		public const int elementId_rightStickY = 3; // Metadata: 0x00744511
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x00744515
		public const int elementId_a = 4; // Metadata: 0x00744519
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x0074451D
		public const int elementId_b = 5; // Metadata: 0x00744521
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x00744525
		public const int elementId_c = 6; // Metadata: 0x00744529
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x0074452D
		public const int elementId_x = 7; // Metadata: 0x00744531
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x00744535
		public const int elementId_y = 8; // Metadata: 0x00744539
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x0074453D
		public const int elementId_z = 9; // Metadata: 0x00744541
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x00744545
		public const int elementId_leftBumper = 10; // Metadata: 0x00744549
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x0074454D
		public const int elementId_leftTrigger = 11; // Metadata: 0x00744551
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x00744555
		public const int elementId_rightBumper = 12; // Metadata: 0x00744559
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x0074455D
		public const int elementId_rightTrigger = 13; // Metadata: 0x00744561
		public const int elementId_center1 = 14; // Metadata: 0x00744565
		public const int elementId_back = 14; // Metadata: 0x00744569
		public const int elementId_center2 = 15; // Metadata: 0x0074456D
		public const int elementId_start = 15; // Metadata: 0x00744571
		public const int elementId_center3 = 16; // Metadata: 0x00744575
		public const int elementId_guide = 16; // Metadata: 0x00744579
		public const int elementId_leftStickButton = 17; // Metadata: 0x0074457D
		public const int elementId_rightStickButton = 18; // Metadata: 0x00744581
		public const int elementId_dPadUp = 19; // Metadata: 0x00744585
		public const int elementId_dPadRight = 20; // Metadata: 0x00744589
		public const int elementId_dPadDown = 21; // Metadata: 0x0074458D
		public const int elementId_dPadLeft = 22; // Metadata: 0x00744591
		public const int elementId_leftStick = 23; // Metadata: 0x00744595
		public const int elementId_rightStick = 24; // Metadata: 0x00744599
		public const int elementId_dPad = 25; // Metadata: 0x0074459D
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get; } // 0x0000000181BBE470-0x0000000181BBE4B0 
		IControllerTemplateButton IGamepadTemplate.a { get; } // 0x0000000181BBE430-0x0000000181BBE470 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get; } // 0x0000000181BBE4B0-0x0000000181BBE4F0 
		IControllerTemplateButton IGamepadTemplate.b { get; } // 0x0000000181BBE5F0-0x0000000181BBE630 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get; } // 0x0000000181BBE4F0-0x0000000181BBE530 
		IControllerTemplateButton IGamepadTemplate.c { get; } // 0x0000000181BBE670-0x0000000181BBE6B0 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get; } // 0x0000000181BBE530-0x0000000181BBE570 
		IControllerTemplateButton IGamepadTemplate.x { get; } // 0x0000000181BBEAB0-0x0000000181BBEAF0 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get; } // 0x0000000181BBE570-0x0000000181BBE5B0 
		IControllerTemplateButton IGamepadTemplate.y { get; } // 0x0000000181BBEAF0-0x0000000181BBEB30 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get; } // 0x0000000181BBE5B0-0x0000000181BBE5F0 
		IControllerTemplateButton IGamepadTemplate.z { get; } // 0x0000000181BBEB30-0x0000000181BBEB70 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get; } // 0x0000000181BBE830-0x0000000181BBE870 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get; } // 0x0000000181BBE7F0-0x0000000181BBE830 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get; } // 0x0000000181BBE870-0x0000000181BBE8B0 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get; } // 0x0000000181BBE8F0-0x0000000181BBE930 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get; } // 0x0000000181BBE970-0x0000000181BBE9B0 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get; } // 0x0000000181BBE930-0x0000000181BBE970 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get; } // 0x0000000181BBE9B0-0x0000000181BBE9F0 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get; } // 0x0000000181BBEA30-0x0000000181BBEA70 
		IControllerTemplateButton IGamepadTemplate.center1 { get; } // 0x0000000181BBE6B0-0x0000000181BBE6F0 
		IControllerTemplateButton IGamepadTemplate.back { get; } // 0x0000000181BBE630-0x0000000181BBE670 
		IControllerTemplateButton IGamepadTemplate.center2 { get; } // 0x0000000181BBE6F0-0x0000000181BBE730 
		IControllerTemplateButton IGamepadTemplate.start { get; } // 0x0000000181BBEA70-0x0000000181BBEAB0 
		IControllerTemplateButton IGamepadTemplate.center3 { get; } // 0x0000000181BBE730-0x0000000181BBE770 
		IControllerTemplateButton IGamepadTemplate.guide { get; } // 0x0000000181BBE7B0-0x0000000181BBE7F0 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get; } // 0x0000000181BBE8B0-0x0000000181BBE8F0 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get; } // 0x0000000181BBE9F0-0x0000000181BBEA30 
		IControllerTemplateDPad IGamepadTemplate.dPad { get; } // 0x0000000181BBE770-0x0000000181BBE7B0 
	
		// Constructors
		public GamepadTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static GamepadTemplate(); // 0x0000000181BBEB70-0x0000000181BBEBD0
	}
}
