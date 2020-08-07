/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate // TypeDefIndex: 9362
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftStickX = 0; // Metadata: 0x007791F3
		public const int elementId_leftStickY = 1; // Metadata: 0x007791F7
		public const int elementId_rightStickX = 2; // Metadata: 0x007791FB
		public const int elementId_rightStickY = 3; // Metadata: 0x007791FF
		public const int elementId_actionBottomRow1 = 4; // Metadata: 0x00779203
		public const int elementId_a = 4; // Metadata: 0x00779207
		public const int elementId_actionBottomRow2 = 5; // Metadata: 0x0077920B
		public const int elementId_b = 5; // Metadata: 0x0077920F
		public const int elementId_actionBottomRow3 = 6; // Metadata: 0x00779213
		public const int elementId_c = 6; // Metadata: 0x00779217
		public const int elementId_actionTopRow1 = 7; // Metadata: 0x0077921B
		public const int elementId_x = 7; // Metadata: 0x0077921F
		public const int elementId_actionTopRow2 = 8; // Metadata: 0x00779223
		public const int elementId_y = 8; // Metadata: 0x00779227
		public const int elementId_actionTopRow3 = 9; // Metadata: 0x0077922B
		public const int elementId_z = 9; // Metadata: 0x0077922F
		public const int elementId_leftShoulder1 = 10; // Metadata: 0x00779233
		public const int elementId_leftBumper = 10; // Metadata: 0x00779237
		public const int elementId_leftShoulder2 = 11; // Metadata: 0x0077923B
		public const int elementId_leftTrigger = 11; // Metadata: 0x0077923F
		public const int elementId_rightShoulder1 = 12; // Metadata: 0x00779243
		public const int elementId_rightBumper = 12; // Metadata: 0x00779247
		public const int elementId_rightShoulder2 = 13; // Metadata: 0x0077924B
		public const int elementId_rightTrigger = 13; // Metadata: 0x0077924F
		public const int elementId_center1 = 14; // Metadata: 0x00779253
		public const int elementId_back = 14; // Metadata: 0x00779257
		public const int elementId_center2 = 15; // Metadata: 0x0077925B
		public const int elementId_start = 15; // Metadata: 0x0077925F
		public const int elementId_center3 = 16; // Metadata: 0x00779263
		public const int elementId_guide = 16; // Metadata: 0x00779267
		public const int elementId_leftStickButton = 17; // Metadata: 0x0077926B
		public const int elementId_rightStickButton = 18; // Metadata: 0x0077926F
		public const int elementId_dPadUp = 19; // Metadata: 0x00779273
		public const int elementId_dPadRight = 20; // Metadata: 0x00779277
		public const int elementId_dPadDown = 21; // Metadata: 0x0077927B
		public const int elementId_dPadLeft = 22; // Metadata: 0x0077927F
		public const int elementId_leftStick = 23; // Metadata: 0x00779283
		public const int elementId_rightStick = 24; // Metadata: 0x00779287
		public const int elementId_dPad = 25; // Metadata: 0x0077928B
	
		// Properties
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get; } // 0x000000018105DAB0-0x000000018105DAF0 
		IControllerTemplateButton IGamepadTemplate.a { get; } // 0x000000018105DA70-0x000000018105DAB0 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get; } // 0x000000018105DAF0-0x000000018105DB30 
		IControllerTemplateButton IGamepadTemplate.b { get; } // 0x000000018105DC30-0x000000018105DC70 
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get; } // 0x000000018105DB30-0x000000018105DB70 
		IControllerTemplateButton IGamepadTemplate.c { get; } // 0x000000018105DCB0-0x000000018105DCF0 
		IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get; } // 0x000000018105DB70-0x000000018105DBB0 
		IControllerTemplateButton IGamepadTemplate.x { get; } // 0x000000018105E0F0-0x000000018105E130 
		IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get; } // 0x000000018105DBB0-0x000000018105DBF0 
		IControllerTemplateButton IGamepadTemplate.y { get; } // 0x000000018105E130-0x000000018105E170 
		IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get; } // 0x000000018105DBF0-0x000000018105DC30 
		IControllerTemplateButton IGamepadTemplate.z { get; } // 0x000000018105E170-0x000000018105E1B0 
		IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get; } // 0x000000018105DE70-0x000000018105DEB0 
		IControllerTemplateButton IGamepadTemplate.leftBumper { get; } // 0x000000018105DE30-0x000000018105DE70 
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get; } // 0x000000018105DEB0-0x000000018105DEF0 
		IControllerTemplateAxis IGamepadTemplate.leftTrigger { get; } // 0x000000018105DF30-0x000000018105DF70 
		IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get; } // 0x000000018105DFB0-0x000000018105DFF0 
		IControllerTemplateButton IGamepadTemplate.rightBumper { get; } // 0x000000018105DF70-0x000000018105DFB0 
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get; } // 0x000000018105DFF0-0x000000018105E030 
		IControllerTemplateAxis IGamepadTemplate.rightTrigger { get; } // 0x000000018105E070-0x000000018105E0B0 
		IControllerTemplateButton IGamepadTemplate.center1 { get; } // 0x000000018105DCF0-0x000000018105DD30 
		IControllerTemplateButton IGamepadTemplate.back { get; } // 0x000000018105DC70-0x000000018105DCB0 
		IControllerTemplateButton IGamepadTemplate.center2 { get; } // 0x000000018105DD30-0x000000018105DD70 
		IControllerTemplateButton IGamepadTemplate.start { get; } // 0x000000018105E0B0-0x000000018105E0F0 
		IControllerTemplateButton IGamepadTemplate.center3 { get; } // 0x000000018105DD70-0x000000018105DDB0 
		IControllerTemplateButton IGamepadTemplate.guide { get; } // 0x000000018105DDF0-0x000000018105DE30 
		IControllerTemplateThumbStick IGamepadTemplate.leftStick { get; } // 0x000000018105DEF0-0x000000018105DF30 
		IControllerTemplateThumbStick IGamepadTemplate.rightStick { get; } // 0x000000018105E030-0x000000018105E070 
		IControllerTemplateDPad IGamepadTemplate.dPad { get; } // 0x000000018105DDB0-0x000000018105DDF0 
	
		// Constructors
		public GamepadTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static GamepadTemplate(); // 0x000000018105E1B0-0x000000018105E210
	}
}
