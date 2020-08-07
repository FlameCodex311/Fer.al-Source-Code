/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 9363
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x0077928F
		public const int elementId_accelerator = 1; // Metadata: 0x00779293
		public const int elementId_brake = 2; // Metadata: 0x00779297
		public const int elementId_clutch = 3; // Metadata: 0x0077929B
		public const int elementId_shiftDown = 4; // Metadata: 0x0077929F
		public const int elementId_shiftUp = 5; // Metadata: 0x007792A3
		public const int elementId_wheelButton1 = 6; // Metadata: 0x007792A7
		public const int elementId_wheelButton2 = 7; // Metadata: 0x007792AB
		public const int elementId_wheelButton3 = 8; // Metadata: 0x007792AF
		public const int elementId_wheelButton4 = 9; // Metadata: 0x007792B3
		public const int elementId_wheelButton5 = 10; // Metadata: 0x007792B7
		public const int elementId_wheelButton6 = 11; // Metadata: 0x007792BB
		public const int elementId_wheelButton7 = 12; // Metadata: 0x007792BF
		public const int elementId_wheelButton8 = 13; // Metadata: 0x007792C3
		public const int elementId_wheelButton9 = 14; // Metadata: 0x007792C7
		public const int elementId_wheelButton10 = 15; // Metadata: 0x007792CB
		public const int elementId_consoleButton1 = 16; // Metadata: 0x007792CF
		public const int elementId_consoleButton2 = 17; // Metadata: 0x007792D3
		public const int elementId_consoleButton3 = 18; // Metadata: 0x007792D7
		public const int elementId_consoleButton4 = 19; // Metadata: 0x007792DB
		public const int elementId_consoleButton5 = 20; // Metadata: 0x007792DF
		public const int elementId_consoleButton6 = 21; // Metadata: 0x007792E3
		public const int elementId_consoleButton7 = 22; // Metadata: 0x007792E7
		public const int elementId_consoleButton8 = 23; // Metadata: 0x007792EB
		public const int elementId_consoleButton9 = 24; // Metadata: 0x007792EF
		public const int elementId_consoleButton10 = 25; // Metadata: 0x007792F3
		public const int elementId_shifter1 = 26; // Metadata: 0x007792F7
		public const int elementId_shifter2 = 27; // Metadata: 0x007792FB
		public const int elementId_shifter3 = 28; // Metadata: 0x007792FF
		public const int elementId_shifter4 = 29; // Metadata: 0x00779303
		public const int elementId_shifter5 = 30; // Metadata: 0x00779307
		public const int elementId_shifter6 = 31; // Metadata: 0x0077930B
		public const int elementId_shifter7 = 32; // Metadata: 0x0077930F
		public const int elementId_shifter8 = 33; // Metadata: 0x00779313
		public const int elementId_shifter9 = 34; // Metadata: 0x00779317
		public const int elementId_shifter10 = 35; // Metadata: 0x0077931B
		public const int elementId_reverseGear = 44; // Metadata: 0x0077931F
		public const int elementId_select = 36; // Metadata: 0x00779323
		public const int elementId_start = 37; // Metadata: 0x00779327
		public const int elementId_systemButton = 38; // Metadata: 0x0077932B
		public const int elementId_horn = 43; // Metadata: 0x0077932F
		public const int elementId_dPadUp = 39; // Metadata: 0x00779333
		public const int elementId_dPadRight = 40; // Metadata: 0x00779337
		public const int elementId_dPadDown = 41; // Metadata: 0x0077933B
		public const int elementId_dPadLeft = 42; // Metadata: 0x0077933F
		public const int elementId_dPad = 45; // Metadata: 0x00779343
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get; } // 0x00000001820C6610-0x00000001820C6650 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get; } // 0x00000001820C5BD0-0x00000001820C5C10 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get; } // 0x00000001820C5C10-0x00000001820C5C50 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get; } // 0x00000001820C5C50-0x00000001820C5C90 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get; } // 0x00000001820C6010-0x00000001820C6050 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get; } // 0x00000001820C6050-0x00000001820C6090 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get; } // 0x00000001820C63D0-0x00000001820C6410 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get; } // 0x00000001820C6410-0x00000001820C6450 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get; } // 0x00000001820C6450-0x00000001820C6490 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get; } // 0x00000001820C6490-0x00000001820C64D0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get; } // 0x00000001820C64D0-0x00000001820C6510 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get; } // 0x00000001820C6510-0x00000001820C6550 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get; } // 0x00000001820C6550-0x00000001820C6590 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get; } // 0x00000001820C6590-0x00000001820C65D0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get; } // 0x00000001820C65D0-0x00000001820C6610 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get; } // 0x00000001820C6390-0x00000001820C63D0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get; } // 0x00000001820C5CD0-0x00000001820C5D10 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get; } // 0x00000001820C5D10-0x00000001820C5D50 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get; } // 0x00000001820C5D50-0x00000001820C5D90 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get; } // 0x00000001820C5D90-0x00000001820C5DD0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get; } // 0x00000001820C5DD0-0x00000001820C5E10 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get; } // 0x00000001820C5E10-0x00000001820C5E50 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get; } // 0x00000001820C5E50-0x00000001820C5E90 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get; } // 0x00000001820C5E90-0x00000001820C5ED0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get; } // 0x00000001820C5ED0-0x00000001820C5F10 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get; } // 0x00000001820C5C90-0x00000001820C5CD0 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get; } // 0x00000001820C60D0-0x00000001820C6110 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get; } // 0x00000001820C6110-0x00000001820C6150 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get; } // 0x00000001820C6150-0x00000001820C6190 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get; } // 0x00000001820C6190-0x00000001820C61D0 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get; } // 0x00000001820C61D0-0x00000001820C6210 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get; } // 0x00000001820C6210-0x00000001820C6250 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get; } // 0x00000001820C6250-0x00000001820C6290 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get; } // 0x00000001820C6290-0x00000001820C62D0 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get; } // 0x00000001820C62D0-0x00000001820C6310 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get; } // 0x00000001820C6090-0x00000001820C60D0 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get; } // 0x00000001820C5F90-0x00000001820C5FD0 
		IControllerTemplateButton IRacingWheelTemplate.select { get; } // 0x00000001820C5FD0-0x00000001820C6010 
		IControllerTemplateButton IRacingWheelTemplate.start { get; } // 0x00000001820C6310-0x00000001820C6350 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get; } // 0x00000001820C6350-0x00000001820C6390 
		IControllerTemplateButton IRacingWheelTemplate.horn { get; } // 0x00000001820C5F50-0x00000001820C5F90 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get; } // 0x00000001820C5F10-0x00000001820C5F50 
	
		// Constructors
		public RacingWheelTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static RacingWheelTemplate(); // 0x00000001820C6650-0x00000001820C66B0
	}
}
