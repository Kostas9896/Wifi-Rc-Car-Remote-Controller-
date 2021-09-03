EESchema Schematic File Version 4
EELAYER 30 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
Wire Wire Line
	8600 3850 8600 3800
$Comp
L Connector:Conn_01x04_Male J8
U 1 1 5F1B3C9B
P 8800 3900
F 0 "J8" H 8772 3782 50  0000 R CNN
F 1 "IA1,IB1 ,IA2,IB2" H 8772 3873 50  0000 R CNN
F 2 "Connector_PinHeader_2.00mm:PinHeader_1x04_P2.00mm_Vertical" H 8800 3900 50  0001 C CNN
F 3 "~" H 8800 3900 50  0001 C CNN
F 4 "J" H 8800 3900 50  0001 C CNN "Spice_Primitive"
F 5 "IA1,IB1 ,IA2,IB2" H 8800 3900 50  0001 C CNN "Spice_Model"
F 6 "Y" H 8800 3900 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Connector.lib" H 8800 3900 50  0001 C CNN "Spice_Lib_File"
	1    8800 3900
	-1   0    0    1   
$EndComp
Wire Wire Line
	8100 4300 8100 3900
Wire Wire Line
	8600 4350 8600 4000
Wire Wire Line
	8100 3900 8600 3900
Wire Wire Line
	5100 1900 6100 1900
$Comp
L power:VCC #PWR0103
U 1 1 5F0A6813
P 6400 2100
F 0 "#PWR0103" H 6400 1950 50  0001 C CNN
F 1 "VCC" H 6415 2273 50  0000 C CNN
F 2 "" H 6400 2100 50  0001 C CNN
F 3 "" H 6400 2100 50  0001 C CNN
	1    6400 2100
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0102
U 1 1 5F19199C
P 5850 5300
F 0 "#PWR0102" H 5850 5050 50  0001 C CNN
F 1 "GND" H 5855 5127 50  0000 C CNN
F 2 "" H 5850 5300 50  0001 C CNN
F 3 "" H 5850 5300 50  0001 C CNN
	1    5850 5300
	1    0    0    -1  
$EndComp
Wire Wire Line
	1700 4450 1750 4450
Wire Wire Line
	1700 4550 1700 4450
Wire Wire Line
	1700 4350 1750 4350
Wire Wire Line
	1700 4250 1700 4350
Wire Wire Line
	1700 3650 1700 3550
Wire Wire Line
	1700 3350 1700 3450
$Comp
L Connector:Screw_Terminal_01x02 J5
U 1 1 5F17480F
P 1900 3450
F 0 "J5" H 1980 3442 50  0000 L CNN
F 1 "MotorA" H 1980 3351 50  0000 L CNN
F 2 "TerminalBlock:TerminalBlock_bornier-2_P5.08mm" H 1900 3450 50  0001 C CNN
F 3 "~" H 1900 3450 50  0001 C CNN
F 4 "J" H 1900 3450 50  0001 C CNN "Spice_Primitive"
F 5 "MotorA" H 1900 3450 50  0001 C CNN "Spice_Model"
F 6 "Y" H 1900 3450 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Connector.lib" H 1900 3450 50  0001 C CNN "Spice_Lib_File"
	1    1900 3450
	1    0    0    -1  
$EndComp
Wire Wire Line
	5100 1550 5700 1550
Wire Wire Line
	5100 1550 5100 1650
Connection ~ 5100 1550
Connection ~ 3050 1900
Wire Wire Line
	1500 1900 1750 1900
Wire Wire Line
	1500 1900 1500 1400
Wire Wire Line
	1500 900  1500 1300
Connection ~ 5750 6750
Wire Wire Line
	6750 6750 6750 6400
Wire Wire Line
	5750 6750 6750 6750
Wire Wire Line
	6750 5950 6750 6300
$Comp
L Connector:Screw_Terminal_01x02 J2
U 1 1 5F13478C
P 6950 6300
F 0 "J2" H 7030 6292 50  0000 L CNN
F 1 "Output 5V" H 7030 6201 50  0000 L CNN
F 2 "TerminalBlock:TerminalBlock_bornier-2_P5.08mm" H 6950 6300 50  0001 C CNN
F 3 "~" H 6950 6300 50  0001 C CNN
F 4 "J" H 6950 6300 50  0001 C CNN "Spice_Primitive"
F 5 "Output 5V" H 6950 6300 50  0001 C CNN "Spice_Model"
F 6 "Y" H 6950 6300 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Connector.lib" H 6950 6300 50  0001 C CNN "Spice_Lib_File"
	1    6950 6300
	1    0    0    -1  
$EndComp
Wire Wire Line
	1150 5750 1150 6200
Wire Wire Line
	1200 6750 1200 6300
Wire Wire Line
	5750 5950 6750 5950
Wire Wire Line
	3200 5750 5750 5750
Wire Wire Line
	5750 5750 5750 5950
Wire Wire Line
	4200 5950 5750 5950
Wire Wire Line
	3700 6750 5750 6750
Wire Wire Line
	2900 6350 2900 6750
Wire Wire Line
	2700 6350 2900 6350
Wire Wire Line
	2700 6150 2700 6350
Wire Wire Line
	2900 6750 3700 6750
Connection ~ 2900 6750
$Comp
L power:GND #PWR0104
U 1 1 5F0CD5EF
P 2900 6750
F 0 "#PWR0104" H 2900 6500 50  0001 C CNN
F 1 "GND" H 2905 6577 50  0000 C CNN
F 2 "" H 2900 6750 50  0001 C CNN
F 3 "" H 2900 6750 50  0001 C CNN
	1    2900 6750
	1    0    0    -1  
$EndComp
Connection ~ 5750 5950
Wire Wire Line
	5750 5950 5750 6200
$Comp
L Device:CP C8
U 1 1 5F1068C8
P 5750 6350
F 0 "C8" H 5868 6396 50  0000 L CNN
F 1 "220μF" H 5868 6305 50  0000 L CNN
F 2 "Capacitor_SMD:CP_Elec_10x10.5" H 5788 6200 50  0001 C CNN
F 3 "~" H 5750 6350 50  0001 C CNN
F 4 "C" H 5750 6350 50  0001 C CNN "Spice_Primitive"
F 5 "220u" H 5750 6350 50  0001 C CNN "Spice_Model"
F 6 "Y" H 5750 6350 50  0001 C CNN "Spice_Netlist_Enabled"
	1    5750 6350
	1    0    0    -1  
$EndComp
Wire Wire Line
	5750 6750 5750 6500
Connection ~ 3700 6750
$Comp
L Device:L L2
U 1 1 5F1068AD
P 4050 5950
F 0 "L2" V 4150 5950 50  0000 C CNN
F 1 "33μH" V 4150 6150 50  0000 C CNN
F 2 "Inductor_SMD:L_7.3x7.3_H4.5" H 4050 5950 50  0001 C CNN
F 3 "~" H 4050 5950 50  0001 C CNN
F 4 "L" H 4050 5950 50  0001 C CNN "Spice_Primitive"
F 5 "33u" H 4050 5950 50  0001 C CNN "Spice_Model"
F 6 "Y" H 4050 5950 50  0001 C CNN "Spice_Netlist_Enabled"
	1    4050 5950
	0    -1   -1   0   
$EndComp
Connection ~ 3700 5950
Wire Wire Line
	3700 5950 3900 5950
Wire Wire Line
	3700 5950 3700 6200
Wire Wire Line
	3200 5950 3700 5950
Wire Wire Line
	2200 6750 2900 6750
Connection ~ 2200 6750
Wire Wire Line
	2200 5950 2200 6750
Connection ~ 1400 6750
Wire Wire Line
	1400 6750 2200 6750
Wire Wire Line
	1400 6750 1200 6750
Wire Wire Line
	1400 6350 1400 6750
Wire Wire Line
	1400 5750 1150 5750
Connection ~ 1400 5750
Wire Wire Line
	1400 5750 1400 6050
$Comp
L Device:CP C6
U 1 1 5F106891
P 1400 6200
F 0 "C6" H 1518 6246 50  0000 L CNN
F 1 "680μF" H 1518 6155 50  0000 L CNN
F 2 "Capacitor_SMD:CP_Elec_16x17.5" H 1438 6050 50  0001 C CNN
F 3 "~" H 1400 6200 50  0001 C CNN
F 4 "C" H 1400 6200 50  0001 C CNN "Spice_Primitive"
F 5 "680u" H 1400 6200 50  0001 C CNN "Spice_Model"
F 6 "Y" H 1400 6200 50  0001 C CNN "Spice_Netlist_Enabled"
	1    1400 6200
	1    0    0    -1  
$EndComp
Wire Wire Line
	2200 5750 1400 5750
$Comp
L Regulator_Switching:LM2596S-ADJ U3
U 1 1 5F10688A
P 2700 5850
F 0 "U3" H 2700 6217 50  0000 C CNN
F 1 "LM2596S-ADJ-5V output" H 2700 6126 50  0000 C CNN
F 2 "Package_TO_SOT_SMD:TO-263-5_TabPin3" H 2750 5600 50  0001 L CIN
F 3 "http://www.ti.com/lit/ds/symlink/lm2596.pdf" H 2700 5850 50  0001 C CNN
F 4 "X" H 2700 5850 50  0001 C CNN "Spice_Primitive"
F 5 "LM2596S" H 2700 5850 50  0001 C CNN "Spice_Model"
F 6 "Y" H 2700 5850 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Converter_DCDC.lib" H 2700 5850 50  0001 C CNN "Spice_Lib_File"
	1    2700 5850
	1    0    0    -1  
$EndComp
$Comp
L power:GND #PWR0106
U 1 1 5F0DB824
P 4200 1900
F 0 "#PWR0106" H 4200 1650 50  0001 C CNN
F 1 "GND" H 4205 1727 50  0000 C CNN
F 2 "" H 4200 1900 50  0001 C CNN
F 3 "" H 4200 1900 50  0001 C CNN
	1    4200 1900
	1    0    0    -1  
$EndComp
Wire Wire Line
	5700 1100 6100 1100
Connection ~ 5700 1100
Wire Wire Line
	5700 1250 5700 1100
$Comp
L Device:C C3
U 1 1 5F0D557F
P 5700 1400
F 0 "C3" H 5815 1446 50  0000 L CNN
F 1 "1.5nF" H 5600 1200 50  0000 L CNN
F 2 "Capacitor_Tantalum_SMD:CP_EIA-1608-08_AVX-J" H 5738 1250 50  0001 C CNN
F 3 "~" H 5700 1400 50  0001 C CNN
F 4 "C" H 5700 1400 50  0001 C CNN "Spice_Primitive"
F 5 "1.5n" H 5700 1400 50  0001 C CNN "Spice_Model"
F 6 "Y" H 5700 1400 50  0001 C CNN "Spice_Netlist_Enabled"
	1    5700 1400
	1    0    0    -1  
$EndComp
Wire Wire Line
	4650 900  4650 1550
Wire Wire Line
	3550 900  4650 900 
Connection ~ 5100 1100
Wire Wire Line
	6100 1100 6100 1350
Wire Wire Line
	5100 1100 5700 1100
Connection ~ 5100 1900
Wire Wire Line
	6100 1900 6100 1650
Wire Wire Line
	5100 1900 5100 1850
Wire Wire Line
	5100 1100 5100 1250
Wire Wire Line
	4550 1100 5100 1100
$Comp
L Device:L L1
U 1 1 5F097594
P 4400 1100
F 0 "L1" V 4500 1100 50  0000 C CNN
F 1 "68μH" V 4500 1250 50  0000 C CNN
F 2 "Inductor_SMD:L_7.3x7.3_H4.5" H 4400 1100 50  0001 C CNN
F 3 "~" H 4400 1100 50  0001 C CNN
F 4 "L" H 4400 1100 50  0001 C CNN "Spice_Primitive"
F 5 "68u" H 4400 1100 50  0001 C CNN "Spice_Model"
F 6 "Y" H 4400 1100 50  0001 C CNN "Spice_Netlist_Enabled"
	1    4400 1100
	0    -1   -1   0   
$EndComp
Connection ~ 4050 1100
Wire Wire Line
	4050 1100 4250 1100
Wire Wire Line
	4050 1100 4050 1350
Wire Wire Line
	3550 1100 4050 1100
Wire Wire Line
	2550 1900 3050 1900
Wire Wire Line
	3050 1300 3050 1900
Connection ~ 2550 1900
Wire Wire Line
	2550 1100 2550 1900
Connection ~ 1750 1900
Wire Wire Line
	1750 1900 2550 1900
Wire Wire Line
	1750 1500 1750 1900
Wire Wire Line
	1750 900  1500 900 
Connection ~ 1750 900 
Wire Wire Line
	1750 900  1750 1200
$Comp
L Device:CP C1
U 1 1 5F0DDC7F
P 1750 1350
F 0 "C1" H 1868 1396 50  0000 L CNN
F 1 "470μF" H 1868 1305 50  0000 L CNN
F 2 "Capacitor_SMD:CP_Elec_16x17.5" H 1788 1200 50  0001 C CNN
F 3 "~" H 1750 1350 50  0001 C CNN
F 4 "C" H 1750 1350 50  0001 C CNN "Spice_Primitive"
F 5 "470u" H 1750 1350 50  0001 C CNN "Spice_Model"
F 6 "Y" H 1750 1350 50  0001 C CNN "Spice_Netlist_Enabled"
	1    1750 1350
	1    0    0    -1  
$EndComp
Wire Wire Line
	2550 900  1750 900 
$Comp
L Regulator_Switching:LM2596S-ADJ U4
U 1 1 5F0D9AD6
P 3050 1000
F 0 "U4" H 3050 1367 50  0000 C CNN
F 1 "LM2596S-9V" H 3050 1276 50  0000 C CNN
F 2 "Package_TO_SOT_SMD:TO-263-5_TabPin3" H 3100 750 50  0001 L CIN
F 3 "http://www.ti.com/lit/ds/symlink/lm2596.pdf" H 3050 1000 50  0001 C CNN
F 4 "X" H 3050 1000 50  0001 C CNN "Spice_Primitive"
F 5 "LM2596" H 3050 1000 50  0001 C CNN "Spice_Model"
F 6 "Y" H 3050 1000 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Converter_DCDC.lib" H 3050 1000 50  0001 C CNN "Spice_Lib_File"
	1    3050 1000
	1    0    0    -1  
$EndComp
Wire Wire Line
	7550 4450 7550 4350
Wire Wire Line
	7550 3550 7550 3850
Wire Wire Line
	7700 3450 7700 3700
Wire Wire Line
	6350 3450 7700 3450
Connection ~ 6350 3450
Wire Wire Line
	6400 2300 6550 2300
Connection ~ 6400 2300
Wire Wire Line
	6550 2300 6550 2550
Connection ~ 6550 2300
Wire Wire Line
	6350 2300 6400 2300
Wire Wire Line
	6350 2550 6350 2300
$Comp
L Device:R_Small_US R1
U 1 1 5F0AA6D6
P 6350 2650
F 0 "R1" H 6418 2696 50  0000 L CNN
F 1 "10K" H 6418 2605 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" H 6350 2650 50  0001 C CNN
F 3 "~" H 6350 2650 50  0001 C CNN
F 4 "R" H 6350 2650 50  0001 C CNN "Spice_Primitive"
F 5 "10k" H 6350 2650 50  0001 C CNN "Spice_Model"
F 6 "Y" H 6350 2650 50  0001 C CNN "Spice_Netlist_Enabled"
	1    6350 2650
	1    0    0    -1  
$EndComp
$Comp
L Device:R_Small_US R4
U 1 1 5F0AA322
P 7050 2650
F 0 "R4" H 7118 2696 50  0000 L CNN
F 1 "10K" H 7118 2605 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" H 7050 2650 50  0001 C CNN
F 3 "~" H 7050 2650 50  0001 C CNN
F 4 "R" H 7050 2650 50  0001 C CNN "Spice_Primitive"
F 5 "10k" H 7050 2650 50  0001 C CNN "Spice_Model"
F 6 "Y" H 7050 2650 50  0001 C CNN "Spice_Netlist_Enabled"
	1    7050 2650
	1    0    0    -1  
$EndComp
Connection ~ 6800 2300
Wire Wire Line
	7050 2300 7050 2550
Wire Wire Line
	6800 2300 7050 2300
Wire Wire Line
	6800 2750 6800 4450
$Comp
L Device:R_Small_US R3
U 1 1 5F0A8399
P 6800 2650
F 0 "R3" H 6868 2696 50  0000 L CNN
F 1 "10K" H 6868 2605 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" H 6800 2650 50  0001 C CNN
F 3 "~" H 6800 2650 50  0001 C CNN
F 4 "R" H 6800 2650 50  0001 C CNN "Spice_Primitive"
F 5 "10k" H 6800 2650 50  0001 C CNN "Spice_Model"
F 6 "Y" H 6800 2650 50  0001 C CNN "Spice_Netlist_Enabled"
	1    6800 2650
	1    0    0    -1  
$EndComp
Wire Wire Line
	6550 2750 6550 3550
$Comp
L Device:R_Small_US R2
U 1 1 5F0A7B7A
P 6550 2650
F 0 "R2" H 6618 2696 50  0000 L CNN
F 1 "10K" H 6618 2605 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" H 6550 2650 50  0001 C CNN
F 3 "~" H 6550 2650 50  0001 C CNN
F 4 "R" H 6550 2650 50  0001 C CNN "Spice_Primitive"
F 5 "10k" H 6550 2650 50  0001 C CNN "Spice_Model"
F 6 "Y" H 6550 2650 50  0001 C CNN "Spice_Netlist_Enabled"
	1    6550 2650
	1    0    0    -1  
$EndComp
Wire Wire Line
	6800 4450 7550 4450
Connection ~ 6800 4450
Wire Wire Line
	6800 2300 6800 2550
Wire Wire Line
	6550 2300 6800 2300
Wire Wire Line
	6550 3550 7550 3550
Connection ~ 6550 3550
Wire Wire Line
	6350 3450 6350 2750
Wire Wire Line
	5150 4350 7050 4350
Wire Wire Line
	5150 4450 6800 4450
Wire Wire Line
	5100 3550 6550 3550
Wire Wire Line
	5100 3450 6350 3450
Connection ~ 5850 4550
Wire Wire Line
	5850 4250 5850 4550
Connection ~ 5850 4250
Connection ~ 5850 3650
Wire Wire Line
	5850 3650 5850 4250
Wire Wire Line
	5150 4250 5850 4250
Wire Wire Line
	5150 4550 5850 4550
Connection ~ 2300 4550
Wire Wire Line
	2300 4550 1700 4550
Connection ~ 2300 4250
Wire Wire Line
	2300 4250 1700 4250
Wire Wire Line
	2300 4250 2300 4300
Wire Wire Line
	2300 4550 2300 4500
$Comp
L Device:C_Small C5
U 1 1 5F098B5E
P 2300 4400
F 0 "C5" H 2392 4446 50  0000 L CNN
F 1 "0,1μF" H 2392 4355 50  0000 L CNN
F 2 "Capacitor_Tantalum_SMD:CP_EIA-3216-10_Kemet-I" H 2300 4400 50  0001 C CNN
F 3 "~" H 2300 4400 50  0001 C CNN
F 4 "C" H 2300 4400 50  0001 C CNN "Spice_Primitive"
F 5 "0.1u" H 2300 4400 50  0001 C CNN "Spice_Model"
F 6 "Y" H 2300 4400 50  0001 C CNN "Spice_Netlist_Enabled"
	1    2300 4400
	1    0    0    -1  
$EndComp
Wire Wire Line
	4050 4250 2300 4250
Wire Wire Line
	4050 4550 2300 4550
Connection ~ 2250 3650
Wire Wire Line
	2250 3650 1700 3650
Connection ~ 2250 3350
Wire Wire Line
	2250 3350 1700 3350
Wire Wire Line
	2250 3350 2250 3400
Wire Wire Line
	2250 3650 2250 3600
$Comp
L Device:C_Small C4
U 1 1 5F0923DD
P 2250 3500
F 0 "C4" H 2400 3550 50  0000 L CNN
F 1 "0,1μF" H 2342 3455 50  0000 L CNN
F 2 "Capacitor_Tantalum_SMD:CP_EIA-3216-10_Kemet-I" H 2250 3500 50  0001 C CNN
F 3 "~" H 2250 3500 50  0001 C CNN
F 4 "C" H 2250 3500 50  0001 C CNN "Spice_Primitive"
F 5 "0.1u" H 2250 3500 50  0001 C CNN "Spice_Model"
F 6 "Y" H 2250 3500 50  0001 C CNN "Spice_Netlist_Enabled"
	1    2250 3500
	1    0    0    -1  
$EndComp
Wire Wire Line
	2250 3650 4000 3650
Wire Wire Line
	4000 3350 2250 3350
Wire Wire Line
	5100 3350 5850 3350
Wire Wire Line
	5100 3650 5850 3650
Wire Wire Line
	5850 3350 5850 3650
Connection ~ 4200 1900
Wire Wire Line
	4200 1900 5100 1900
Wire Wire Line
	5850 4550 5850 5050
Wire Wire Line
	800  1300 1500 1300
Wire Wire Line
	1000 1400 1500 1400
Wire Wire Line
	850  6200 1150 6200
Wire Wire Line
	6100 1100 7000 1100
Wire Wire Line
	7000 1100 7000 2100
Connection ~ 6100 1100
Connection ~ 6400 2100
Wire Wire Line
	9900 1900 9900 5050
Wire Wire Line
	9900 5050 5850 5050
Wire Wire Line
	6100 1900 9900 1900
Connection ~ 6100 1900
Connection ~ 5850 5050
Wire Wire Line
	5850 5050 5850 5300
$Comp
L Connector:Screw_Terminal_01x02 J6
U 1 1 5F17FD85
P 1950 4350
F 0 "J6" H 2030 4342 50  0000 L CNN
F 1 "MotorB" H 2030 4251 50  0000 L CNN
F 2 "TerminalBlock:TerminalBlock_bornier-2_P5.08mm" H 1950 4350 50  0001 C CNN
F 3 "~" H 1950 4350 50  0001 C CNN
F 4 "J" H 1950 4350 50  0001 C CNN "Spice_Primitive"
F 5 "MotorB" H 1950 4350 50  0001 C CNN "Spice_Model"
F 6 "Y" H 1950 4350 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Connector.lib" H 1950 4350 50  0001 C CNN "Spice_Lib_File"
	1    1950 4350
	1    0    0    -1  
$EndComp
Text Notes 500  2500 0    50   ~ 0
+
Text Notes 500  2400 0    50   ~ 0
INPUT
Text Notes 500  2750 0    50   ~ 0
-
$Comp
L Connector:Screw_Terminal_01x02 J1
U 1 1 5F1591F5
P 600 2650
F 0 "J1" H 550 2750 50  0000 L CNN
F 1 "Vcc,GND" H 400 2800 50  0000 L CNN
F 2 "TerminalBlock:TerminalBlock_bornier-2_P5.08mm" H 600 2650 50  0001 C CNN
F 3 "~" H 600 2650 50  0001 C CNN
F 4 "J" H 600 2650 50  0001 C CNN "Spice_Primitive"
F 5 "Screw terminal" H 600 2650 50  0001 C CNN "Spice_Model"
F 6 "Y" H 600 2650 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Program Files\\KiCad\\share\\kicad\\library\\Connector.lib" H 600 2650 50  0001 C CNN "Spice_Lib_File"
	1    600  2650
	-1   0    0    1   
$EndComp
$Comp
L Circuit-Thesis-rescue:L9110-L9110-Circuit-Thesis-rescue U1
U 1 1 5F1730D1
P 4550 3500
F 0 "U1" H 4550 4043 60  0000 C CNN
F 1 "L9110-L9110" H 4550 3937 60  0000 C CNN
F 2 "Circuit Thesis:L9110" H 4550 3831 60  0000 C CNN
F 3 "" H 4550 3500 60  0000 C CNN
F 4 "M" H 4550 3500 50  0001 C CNN "Spice_Primitive"
F 5 "L9110" H 4550 3500 50  0001 C CNN "Spice_Model"
F 6 "Y" H 4550 3500 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Users\\Kostas\\Desktop\\KiCad-parts-master\\KiCad-parts-master\\library\\L9110.lib" H 4550 3500 50  0001 C CNN "Spice_Lib_File"
	1    4550 3500
	1    0    0    -1  
$EndComp
Connection ~ 7050 4300
Wire Wire Line
	7050 2750 7050 4300
Wire Wire Line
	7050 4300 7050 4350
Wire Wire Line
	7550 3850 8600 3850
Wire Wire Line
	7550 4350 8600 4350
Wire Wire Line
	7700 3700 8600 3700
Wire Wire Line
	7050 4300 8100 4300
$Comp
L Circuit-Thesis-rescue:L9110-L9110-Circuit-Thesis-rescue U2
U 1 1 5F17401C
P 4600 4400
F 0 "U2" H 4600 4943 60  0000 C CNN
F 1 "L9110-L9110" H 4600 4837 60  0000 C CNN
F 2 "Circuit Thesis:L9110" H 4600 4731 60  0000 C CNN
F 3 "" H 4600 4400 60  0000 C CNN
F 4 "M" H 4600 4400 50  0001 C CNN "Spice_Primitive"
F 5 "L9110" H 4600 4400 50  0001 C CNN "Spice_Model"
F 6 "Y" H 4600 4400 50  0001 C CNN "Spice_Netlist_Enabled"
F 7 "C:\\Users\\Kostas\\Desktop\\KiCad-parts-master\\KiCad-parts-master\\library\\L9110.lib" H 4600 4400 50  0001 C CNN "Spice_Lib_File"
	1    4600 4400
	1    0    0    -1  
$EndComp
Wire Wire Line
	4050 4450 3500 4450
Wire Wire Line
	4050 4350 3500 4350
Connection ~ 3500 4350
Wire Wire Line
	3500 4350 3500 4450
Wire Wire Line
	4000 3550 3500 3550
Connection ~ 3500 3550
Wire Wire Line
	3500 3550 3500 4350
Wire Wire Line
	3500 3450 4000 3450
Connection ~ 3500 3450
Wire Wire Line
	3500 3450 3500 3550
Wire Wire Line
	6400 2100 6400 2300
Wire Wire Line
	1000 1400 1000 2650
Wire Wire Line
	7000 2100 6400 2100
Wire Wire Line
	3500 2300 6350 2300
Wire Wire Line
	3500 2300 3500 3450
Connection ~ 6350 2300
$Comp
L Device:R_Small_US R5
U 1 1 5F09DB5E
P 5100 1750
F 0 "R5" H 5168 1796 50  0000 L CNN
F 1 "1kΩ" H 5168 1705 50  0000 L CNN
F 2 "Resistor_SMD:R_0805_2012Metric" H 5100 1750 50  0001 C CNN
F 3 "~" H 5100 1750 50  0001 C CNN
F 4 "R" H 5100 1750 50  0001 C CNN "Spice_Primitive"
F 5 "1k" H 5100 1750 50  0001 C CNN "Spice_Model"
F 6 "Y" H 5100 1750 50  0001 C CNN "Spice_Netlist_Enabled"
	1    5100 1750
	1    0    0    -1  
$EndComp
$Comp
L Circuit-Thesis-rescue:SS34-E3_57T-SS34-E3_57T D2
U 1 1 5F2B1DDB
P 3700 6400
F 0 "D2" V 3746 6320 50  0000 R CNN
F 1 "SS34-E3_57T" V 3655 6320 50  0000 R CNN
F 2 "DIOM7959X262N" H 3700 6400 50  0001 L BNN
F 3 "2.62mm" H 3700 6400 50  0001 L BNN
F 4 "VISHAY" H 3700 6400 50  0001 L BNN "Field4"
F 5 "IPC 7351B" H 3700 6400 50  0001 L BNN "Field5"
F 6 "N/A" H 3700 6400 50  0001 L BNN "Field6"
F 7 "D" H 3700 6400 50  0001 C CNN "Spice_Primitive"
F 8 "SS34-E3_57T" H 3700 6400 50  0001 C CNN "Spice_Model"
F 9 "Y" H 3700 6400 50  0001 C CNN "Spice_Netlist_Enabled"
F 10 "C:\\Users\\Kostas\\Desktop\\SS34-E3_57T\\SS34-E3_57T.lib" H 3700 6400 50  0001 C CNN "Spice_Lib_File"
	1    3700 6400
	0    -1   -1   0   
$EndComp
Wire Wire Line
	3700 6600 3700 6750
$Comp
L Circuit-Thesis-rescue:SS34-E3_57T-SS34-E3_57T D1
U 1 1 5F2C8AC1
P 4050 1550
F 0 "D1" V 4096 1470 50  0000 R CNN
F 1 "SS34-E3_57T" V 4005 1470 50  0000 R CNN
F 2 "DIOM7959X262N" H 4050 1550 50  0001 L BNN
F 3 "2.62mm" H 4050 1550 50  0001 L BNN
F 4 "VISHAY" H 4050 1550 50  0001 L BNN "Field4"
F 5 "IPC 7351B" H 4050 1550 50  0001 L BNN "Field5"
F 6 "N/A" H 4050 1550 50  0001 L BNN "Field6"
F 7 "D" H 4050 1550 50  0001 C CNN "Spice_Primitive"
F 8 "SS34-E3_57T" H 4050 1550 50  0001 C CNN "Spice_Model"
F 9 "Y" H 4050 1550 50  0001 C CNN "Spice_Netlist_Enabled"
F 10 "C:\\Users\\Kostas\\Desktop\\SS34-E3_57T\\SS34-E3_57T.lib" H 4050 1550 50  0001 C CNN "Spice_Lib_File"
	1    4050 1550
	0    -1   -1   0   
$EndComp
Wire Wire Line
	3050 1900 4050 1900
Wire Wire Line
	4050 1750 4050 1900
Connection ~ 4050 1900
Wire Wire Line
	4050 1900 4200 1900
$Comp
L Device:CP C2
U 1 1 5F0CC595
P 6100 1500
F 0 "C2" H 6218 1546 50  0000 L CNN
F 1 "220μF" H 6218 1455 50  0000 L CNN
F 2 "Capacitor_SMD:CP_Elec_10x10.5" H 6138 1350 50  0001 C CNN
F 3 "~" H 6100 1500 50  0001 C CNN
F 4 "C" H 6100 1500 50  0001 C CNN "Spice_Primitive"
F 5 "220uF" H 6100 1500 50  0001 C CNN "Spice_Model"
F 6 "Y" H 6100 1500 50  0001 C CNN "Spice_Netlist_Enabled"
	1    6100 1500
	1    0    0    -1  
$EndComp
Wire Wire Line
	800  1300 800  2550
Wire Wire Line
	4650 1550 5100 1550
$Comp
L Device:RTRIM R6
U 1 1 5F28F943
P 5100 1400
F 0 "R6" H 5168 1446 50  0000 L CNN
F 1 "6,4kΩ" H 5168 1355 50  0000 L CNN
F 2 "Potentiometer_SMD:Potentiometer_Bourns_3269W_Vertical" H 5100 1400 50  0001 C CNN
F 3 "~" H 5100 1400 50  0001 C CNN
F 4 "R" H 5100 1400 50  0001 C CNN "Spice_Primitive"
F 5 "6.4k" H 5100 1400 50  0001 C CNN "Spice_Model"
F 6 "Y" H 5100 1400 50  0001 C CNN "Spice_Netlist_Enabled"
	1    5100 1400
	1    0    0    -1  
$EndComp
$Comp
L Mechanical:MountingHole H3
U 1 1 5F32C30A
P 9300 5950
F 0 "H3" H 9400 5996 50  0000 L CNN
F 1 "MountingHole" H 9400 5905 50  0000 L CNN
F 2 "MountingHole:MountingHole_2.1mm" H 9300 5950 50  0001 C CNN
F 3 "~" H 9300 5950 50  0001 C CNN
	1    9300 5950
	1    0    0    -1  
$EndComp
$Comp
L Mechanical:MountingHole H2
U 1 1 5F32A6A7
P 750 7000
F 0 "H2" H 850 7046 50  0000 L CNN
F 1 "MountingHole" H 850 6955 50  0000 L CNN
F 2 "MountingHole:MountingHole_2.1mm" H 750 7000 50  0001 C CNN
F 3 "~" H 750 7000 50  0001 C CNN
	1    750  7000
	1    0    0    -1  
$EndComp
$Comp
L Mechanical:MountingHole H1
U 1 1 5F32B1E9
P 750 800
F 0 "H1" H 850 846 50  0000 L CNN
F 1 "MountingHole" H 850 755 50  0000 L CNN
F 2 "MountingHole:MountingHole_2.1mm" H 750 800 50  0001 C CNN
F 3 "~" H 750 800 50  0001 C CNN
	1    750  800 
	1    0    0    -1  
$EndComp
$Comp
L Mechanical:MountingHole H4
U 1 1 5F32B8C5
P 10000 1100
F 0 "H4" H 10100 1146 50  0000 L CNN
F 1 "MountingHole" H 10100 1055 50  0000 L CNN
F 2 "MountingHole:MountingHole_2.1mm" H 10000 1100 50  0001 C CNN
F 3 "~" H 10000 1100 50  0001 C CNN
	1    10000 1100
	1    0    0    -1  
$EndComp
Wire Wire Line
	800  2650 1000 2650
Wire Wire Line
	800  2650 800  6300
Connection ~ 800  2650
Wire Wire Line
	800  6300 1200 6300
Wire Wire Line
	800  2550 850  2550
Wire Wire Line
	850  2550 850  6200
Connection ~ 800  2550
$EndSCHEMATC
