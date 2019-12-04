# IAI-Robotics-.NET-Drivers
Drivers for controlling IAI SCON/PCON Axes and Slides. 

This repository contains the drivers and some test applications for a .NET driver set for any IAI robotic axes/slides 
which use MODBUS RTU as their underlying communication protocol over the SIO Port.

Drivers for IAI slides can be found in the IAIDrivers project. Currently only SCON and PCON are supported.

The drivers function with a dedicated serial queueing thread which is constantly updating a state onject with the contents 
of the status registers on the connected slide. Any serial commands are passed on to this thread in a the form of a concurent queue.
The serial queueing thread handles the transmission and reception of modbus messages in a timely and linear fashion.

Basic functionality includes:

- Access to all axes status and control registers via a dedicated 'State' Object

- The following control/access commands

  - SetPower
  - AlarmReset
  - Home
  - InchUp
  - InchDown
  - JogUpStart
  - JogDnStart
  - JogStop
  - AbsoluteMove
  - RelativeMove
  - SetSpeed
  - SetAccel
  - StopMotion
  - PauseMotion
  - BreakRelease
  - SafetySpeed
  
 Copyright (C) 2018 Dylan Morano | The GNU General Public License http://www.gnu.org/licenses/
  
 Included in this source code is the EasyModbus library provided by Stefan Roßmann.
 More information can be found at https://github.com/rossmann-engineering/EasyModbusTCP.NET
