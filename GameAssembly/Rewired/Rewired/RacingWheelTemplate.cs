/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate // TypeDefIndex: 9197
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_wheel = 0; // Metadata: 0x007445A1
		public const int elementId_accelerator = 1; // Metadata: 0x007445A5
		public const int elementId_brake = 2; // Metadata: 0x007445A9
		public const int elementId_clutch = 3; // Metadata: 0x007445AD
		public const int elementId_shiftDown = 4; // Metadata: 0x007445B1
		public const int elementId_shiftUp = 5; // Metadata: 0x007445B5
		public const int elementId_wheelButton1 = 6; // Metadata: 0x007445B9
		public const int elementId_wheelButton2 = 7; // Metadata: 0x007445BD
		public const int elementId_wheelButton3 = 8; // Metadata: 0x007445C1
		public const int elementId_wheelButton4 = 9; // Metadata: 0x007445C5
		public const int elementId_wheelButton5 = 10; // Metadata: 0x007445C9
		public const int elementId_wheelButton6 = 11; // Metadata: 0x007445CD
		public const int elementId_wheelButton7 = 12; // Metadata: 0x007445D1
		public const int elementId_wheelButton8 = 13; // Metadata: 0x007445D5
		public const int elementId_wheelButton9 = 14; // Metadata: 0x007445D9
		public const int elementId_wheelButton10 = 15; // Metadata: 0x007445DD
		public const int elementId_consoleButton1 = 16; // Metadata: 0x007445E1
		public const int elementId_consoleButton2 = 17; // Metadata: 0x007445E5
		public const int elementId_consoleButton3 = 18; // Metadata: 0x007445E9
		public const int elementId_consoleButton4 = 19; // Metadata: 0x007445ED
		public const int elementId_consoleButton5 = 20; // Metadata: 0x007445F1
		public const int elementId_consoleButton6 = 21; // Metadata: 0x007445F5
		public const int elementId_consoleButton7 = 22; // Metadata: 0x007445F9
		public const int elementId_consoleButton8 = 23; // Metadata: 0x007445FD
		public const int elementId_consoleButton9 = 24; // Metadata: 0x00744601
		public const int elementId_consoleButton10 = 25; // Metadata: 0x00744605
		public const int elementId_shifter1 = 26; // Metadata: 0x00744609
		public const int elementId_shifter2 = 27; // Metadata: 0x0074460D
		public const int elementId_shifter3 = 28; // Metadata: 0x00744611
		public const int elementId_shifter4 = 29; // Metadata: 0x00744615
		public const int elementId_shifter5 = 30; // Metadata: 0x00744619
		public const int elementId_shifter6 = 31; // Metadata: 0x0074461D
		public const int elementId_shifter7 = 32; // Metadata: 0x00744621
		public const int elementId_shifter8 = 33; // Metadata: 0x00744625
		public const int elementId_shifter9 = 34; // Metadata: 0x00744629
		public const int elementId_shifter10 = 35; // Metadata: 0x0074462D
		public const int elementId_reverseGear = 44; // Metadata: 0x00744631
		public const int elementId_select = 36; // Metadata: 0x00744635
		public const int elementId_start = 37; // Metadata: 0x00744639
		public const int elementId_systemButton = 38; // Metadata: 0x0074463D
		public const int elementId_horn = 43; // Metadata: 0x00744641
		public const int elementId_dPadUp = 39; // Metadata: 0x00744645
		public const int elementId_dPadRight = 40; // Metadata: 0x00744649
		public const int elementId_dPadDown = 41; // Metadata: 0x0074464D
		public const int elementId_dPadLeft = 42; // Metadata: 0x00744651
		public const int elementId_dPad = 45; // Metadata: 0x00744655
	
		// Properties
		IControllerTemplateAxis IRacingWheelTemplate.wheel { get; } // 0x0000000181BC17F0-0x0000000181BC1830 
		IControllerTemplateAxis IRacingWheelTemplate.accelerator { get; } // 0x0000000181BC0DB0-0x0000000181BC0DF0 
		IControllerTemplateAxis IRacingWheelTemplate.brake { get; } // 0x0000000181BC0DF0-0x0000000181BC0E30 
		IControllerTemplateAxis IRacingWheelTemplate.clutch { get; } // 0x0000000181BC0E30-0x0000000181BC0E70 
		IControllerTemplateButton IRacingWheelTemplate.shiftDown { get; } // 0x0000000181BC11F0-0x0000000181BC1230 
		IControllerTemplateButton IRacingWheelTemplate.shiftUp { get; } // 0x0000000181BC1230-0x0000000181BC1270 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1 { get; } // 0x0000000181BC15B0-0x0000000181BC15F0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2 { get; } // 0x0000000181BC15F0-0x0000000181BC1630 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3 { get; } // 0x0000000181BC1630-0x0000000181BC1670 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4 { get; } // 0x0000000181BC1670-0x0000000181BC16B0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5 { get; } // 0x0000000181BC16B0-0x0000000181BC16F0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6 { get; } // 0x0000000181BC16F0-0x0000000181BC1730 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7 { get; } // 0x0000000181BC1730-0x0000000181BC1770 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8 { get; } // 0x0000000181BC1770-0x0000000181BC17B0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9 { get; } // 0x0000000181BC17B0-0x0000000181BC17F0 
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10 { get; } // 0x0000000181BC1570-0x0000000181BC15B0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1 { get; } // 0x0000000181BC0EB0-0x0000000181BC0EF0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2 { get; } // 0x0000000181BC0EF0-0x0000000181BC0F30 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3 { get; } // 0x0000000181BC0F30-0x0000000181BC0F70 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4 { get; } // 0x0000000181BC0F70-0x0000000181BC0FB0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5 { get; } // 0x0000000181BC0FB0-0x0000000181BC0FF0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6 { get; } // 0x0000000181BC0FF0-0x0000000181BC1030 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7 { get; } // 0x0000000181BC1030-0x0000000181BC1070 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8 { get; } // 0x0000000181BC1070-0x0000000181BC10B0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9 { get; } // 0x0000000181BC10B0-0x0000000181BC10F0 
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10 { get; } // 0x0000000181BC0E70-0x0000000181BC0EB0 
		IControllerTemplateButton IRacingWheelTemplate.shifter1 { get; } // 0x0000000181BC12B0-0x0000000181BC12F0 
		IControllerTemplateButton IRacingWheelTemplate.shifter2 { get; } // 0x0000000181BC12F0-0x0000000181BC1330 
		IControllerTemplateButton IRacingWheelTemplate.shifter3 { get; } // 0x0000000181BC1330-0x0000000181BC1370 
		IControllerTemplateButton IRacingWheelTemplate.shifter4 { get; } // 0x0000000181BC1370-0x0000000181BC13B0 
		IControllerTemplateButton IRacingWheelTemplate.shifter5 { get; } // 0x0000000181BC13B0-0x0000000181BC13F0 
		IControllerTemplateButton IRacingWheelTemplate.shifter6 { get; } // 0x0000000181BC13F0-0x0000000181BC1430 
		IControllerTemplateButton IRacingWheelTemplate.shifter7 { get; } // 0x0000000181BC1430-0x0000000181BC1470 
		IControllerTemplateButton IRacingWheelTemplate.shifter8 { get; } // 0x0000000181BC1470-0x0000000181BC14B0 
		IControllerTemplateButton IRacingWheelTemplate.shifter9 { get; } // 0x0000000181BC14B0-0x0000000181BC14F0 
		IControllerTemplateButton IRacingWheelTemplate.shifter10 { get; } // 0x0000000181BC1270-0x0000000181BC12B0 
		IControllerTemplateButton IRacingWheelTemplate.reverseGear { get; } // 0x0000000181BC1170-0x0000000181BC11B0 
		IControllerTemplateButton IRacingWheelTemplate.select { get; } // 0x0000000181BC11B0-0x0000000181BC11F0 
		IControllerTemplateButton IRacingWheelTemplate.start { get; } // 0x0000000181BC14F0-0x0000000181BC1530 
		IControllerTemplateButton IRacingWheelTemplate.systemButton { get; } // 0x0000000181BC1530-0x0000000181BC1570 
		IControllerTemplateButton IRacingWheelTemplate.horn { get; } // 0x0000000181BC1130-0x0000000181BC1170 
		IControllerTemplateDPad IRacingWheelTemplate.dPad { get; } // 0x0000000181BC10F0-0x0000000181BC1130 
	
		// Constructors
		public RacingWheelTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static RacingWheelTemplate(); // 0x0000000181BC1830-0x0000000181BC1890
	}
}
