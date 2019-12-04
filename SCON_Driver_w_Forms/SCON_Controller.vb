Imports EasyModbus.ModbusClient



Public Class SCON_Controller
#Region "Register Documentation"
#Region "Data of Status/Command Registers"

    ' ---------Status Coils-------- 
    'Reg  Symbol  Description
    '0100 EMGS    EMG status 
    '0101 SFTY    Safety speed enabled status
    '0102 PWR     Controller ready status 
    '0103 SV      Servo ON status 
    '0104 PSFL    Missed work in push-motion operation 
    '0105 ALMH    Major failure status 
    '0106 ALML    Minor failure status 
    '0107 ABER    Absolute error status ABER
    '0108 BKRL    Brake forced-release status 
    '010A STP     Pause status 
    '010B HEND    Home return status 
    '010C PEND    Position complete status 
    '0112 LOAD    Load output judgment status 
    '0113 TRQS    Torque level status 
    '0114 MODS    Teaching mode status 
    '0115 TEAC    Position-data load command status 
    '0116 JOG+    Jog+ status 
    '0117 JOG-    Jog- status  
    '0118 PE7     Position complete 7 
    '0119 PE6     Position complete 6 
    '011A PE5     Position complete 5 
    '011B PE4     Position complete 4 
    '011C PE3     Position complete 3 
    '011D PE2     Position complete 2 
    '011E PE1     Position complete 1 
    '011F PE0     Position complete 0

    '---------Status Registers-------- 
    'Reg  Symbol  Description
    '9000 PNOW    Current Position Monitor (high byte)
    '9001 PNOW    Current Position Monitor (low byte)
    '9002 ALMC    Present alarm code query
    '9003 DIPM    Input port query
    '9004 DOPM    Ouput port monitor query
    '9005 DSS1    Device status query 1
    '9006 DSS2    Device status query 2
    '9007 DSSE    Expansion device status query
    '9008 STAT    System status query (high byte)
    '9009 STAT    System status query (low byte)
    '900A VNOW    Current speed monitor (high byte)
    '900B VNOW    Current speed monitor (low byte)
    '900C CNOW    Current ampere monitor (high byte)
    '900D CNOW    Current ampere monitor (low byte)
    '900E DEVI    Deviation Monitor (high byte)
    '900F DEVI    Deviation Monitor (low byte)
    '9010 STIM    System timer query (high byte)
    '9011 STIM    System timer query (low byte)
    '9012 SIPM    Special input port query
    '9013 ZONS    Zone status query
    '9014 POSS    Position complete number status query

    '---------Commands Coils--------
    'Reg  Symbol  Description
    '0400 EMG     EMG operation specification 
    '0401 SFTY    Safety speed command 
    '0403 SON     Servo ON command 
    '0407 ALRS    Alarm reset command 
    '0408 BKRL    Brake forced-release command 
    '040A STP     Pause command 
    '040B HOME    Home return command 
    '040C CSTR    Positioning start command 
    '0411 JISL    Jog/inch switching 
    '0414 MOD     Teaching mode command 
    '0415 TEAC    Position data load command 
    '0416 JOG+    Jog+ command 
    '0417 JOG-    Jog command 
    '0418 ST7     Start position 7 
    '0419 ST6     Start position 6 
    '041A ST5     Start position 5 
    '041B ST4     Start position 4 
    '041C ST3     Start position 3 
    '041D ST2     Start position 2 
    '041E ST1     Start position 1 
    '041F ST0     Start position 0
    '042C STOP    Decelerate to a stop
    '*Most coils are high as FF00 and low as 0000

    '---------Command Registers--------
    '9900 PCMD    Target position specification register
    '9902 INP     Positioning band specification register
    '9904 VCMD    SPeed specification register
    '9906 ACMD    Accel/decel specification register
    '9907 PPOW    Push-current limiting value specification register
    '9908 CTLF    Control flag specification register

#End Region

#Region "Detail of Data Registers"

    '------------------Monitor Registers---------------
    '
    '0D03 - Position number specification
    '     Bit     Name    Function
    '     15   NULL
    '     14   NULL
    '     13   NULL
    '     12   NULL
    '     11   NULL
    '     10   NULL
    '     9    NULL
    '     8       PC256   Position command bit 256
    '     7       PC128   Position command bit 128    These bits indicate position numbers To be moved Using binary codes.
    '     6       PC64    Position command bit 64     The actuator moves To the target position When CStr Of device control
    '     5       PC32    Position command bit 32     register 1 (5.5.1 Or 6.6.1) Is set to 1 after specifying a position number.
    '     4       PC16    Position command bit 16     Note that the maximum position number varies depending On the model
    '     3       PC8     Position command bit 8      And PIO pattern. 
    '     2       PC4     Position command bit 4
    '     1       PC2     Position command bit 2
    '     0       PC1     Position command bit 1

    '9000 - 9001 - Current position monitor
    'Pos = (Data(0)&Data(1)) * 0.01mm

    '9002 - Present alarm code query
    'Alarm code = data byte

    '9003 - Input Port query
    'Data = data byte

    '9004 - Ouput port monitor query
    'Data = data byte

    '9005 - Device status 1 query
    '     Bit     Name    Function
    '     15      EMGS    0: normal, 1: e-stopped
    '     14      SFTY    0: normal, 1: safety status enabled
    '     13      PWR     0: controller busy, 1: ready
    '     12      SV      0: servo off, 1: servo on
    '     11      PSFL    0: normal, 1: missed work in push-motion operation
    '     10      ALMH    0: normal, 1: major failure alarm present
    '     9       ALML    0: normal, 1: minor failure alarm present
    '     8       ABER    0: normal, 1: absolute error present
    '     7       BKRL    0: brake on, 1: brake off
    '     6    NULL
    '     5       STP     0: normal, 1: paused
    '     4       HEND    0: not homed, 1: homed
    '     3       PEND    0: positioning not complete, 1: positioning complete
    '     2    NULL
    '     1    NULL
    '     0    NULL

    '9006 - Device status 2 query
    '     Bit     Name    Function
    '     15   NULL
    '     14   NULL 
    '     13      LOAD    0: normal, 1: motor current reached threshold in check range during this/last pos command
    '     12      TRQS    0: normal, 1: motor torque reached threshold in check range during this/last pos command
    '     11      MODS    0: normal, 1: teaching mode
    '     10      TEAC    0: normal, 1: position data load complete 
    '     9       JOG+    0: normal, 1: jog+ command active
    '     8       JOG-    0: normal, 1: jog- command active
    '     7       PE7     Position complete 7
    '     6       PE6     Position complete 6   These bits output a position complete number As a binary value In PIO
    '     5       PE5     Position complete 5   pattern 4 Or 5 (solenoid valve mode).
    '     4       PE4     Position complete 4   These bits become 1 When the actuator reaches the target position And
    '     3       PE3     Position complete 3   enters the positioning band via the position movement command.
    '     2       PE2     Position complete 2   These bits become 0 If the servo Is turned OFF, but will become 1 If the
    '     1       PE1     Position complete 1   servo Is turned ON again as far as the actuator Is within the positioning band
    '     0       PE0     Position complete 0   of the command position data. Moreover, they will become 1 when pushmotion Is completed Or missed in push-motion operation. 

    '9007 - Expansion Device status query - TODO
    'TODO

    '9008 - 9009 - System status query
    '     Bit     Name    Function
    '     31   NULL
    '     30   NULL
    '     29   NULL
    '     28   NULL
    '     27   NULL
    '     26   NULL
    '     25   NULL
    '     24   NULL
    '     23   NULL
    '     22   NULL
    '     21   NULL
    '     20   NULL
    '     19   NULL
    '     18   NULL
    '     17      ASOF    0: normal, 1: servo auto powered off (servo powers off after set delay time parameter
    '     16      AEEP    0: normal, 1: EEPROM being accessed
    '     15   NULL     
    '     14   NULL
    '     13   NULL
    '     12   NULL
    '     11   NULL
    '     10   NULL
    '      9   NULL
    '      8   NULL
    '      7   NULL
    '      6   NULL
    '      5   NULL
    '      4      RMDS    0: AUTO, 1: MANU
    '      3      HEND    0: home return not yet completed, 1: home return completion
    '      2      SV      0: servo on, 1: servo off
    '      1      SON     0: servo commanded on, 1: servo commanded off
    '      0      MPOW    0: drive source cut, 1: normal

    '900A - 900B - Current Speed monitor
    'Vel = = (Data(0)&Data(1)) * 0.01mm/s

    '900C - 900D - Current ampere monitor
    '= (Data(0)&Data(1)) * 1mA

    '900E - 900F - Deviation monitor
    'Pulses = (Data(0)&Data(1)) pulse/ms

    '9010 - 9011 - System timer query TODO
    'Uptime == (Data(0)&Data(1)) * 1ms

    '9012 - Special input query (serial port) TODO
    '

    '9013 - Zone Status query TODO
    '

    '9014 - Position complete number status query
    '     Bit     Name    Function
    '     15    NULL
    '     14    NULL
    '     13    NULL
    '     12    NULL
    '     11    NULL
    '     10    NULL
    '      9    NULL  
    '      8      PM256   Position complete number status bit 256
    '      7      PM128   Position complete number status bit 128   These bits indicate position numbers For which positioning has been completed (valid in cases other than PIO patterns 4 And 5 (solenoid
    '      6      PM64    Position complete number status bit 64    valve mode)). The position complete Is read As binary code. It becomes possible To read position complete numbers When the current
    '      5      PM32    Position complete number status bit 32    position gets close To the target position (within the positioning band In either the positive Or negative directions). 0 Is read In other cases.
    '      4      PM16    Position complete number status bit 16    Although all the bits will change To 0 once the servo turns OFF, the position complete becomes valid again If the current position Is still
    '      3      PM8     Position complete number status bit 8     inside the positioning band When the servo Is turned On subsequently. In push-motion, the position complete numbers can be read at both the
    '      2      PM4     Position complete number status bit 4     completion And miss of push-motion. 
    '      1      PM2     Position complete number status bit 2
    '      0      PM1     Position complete number status bit 1

    '9800 - Position movement command
    '

    '------------------Command Registers---------------
    '0D00 - Device Control 1
    '     Bit     Name    Function
    '     15      EMG     0: e-stop off, 1: e-stop on, changing will e-stop the motor
    '     14      SFTY    0: disable safety speed, 1: enable safety speed
    '     13   NULL
    '     12      SON     0: Servo OFF, 1: Servo On (if emg,major failure bit,enable = 1
    '     11   NULL
    '     10   NULL
    '     9    NULL
    '     8       ALRS    0: normal, 0->1: reset (rising edge)
    '     7       BKRL    0: normal, 0->1: force release break
    '     6    NULL
    '     5       STP     0: normal, 0->1: pause all motion
    '     4       HOME    0: normal, 0->1: home return command, once completed, HEND = 1
    '     3       CSTR    0; normal, 0->1: move to target pos in POSR register, position complete will not be output unless set back to 0. if HEND = 0, will home before target
    '     2    NULL
    '     1    NULL
    '     0    NULL

    '0D01 - Device Control 2
    '     Bit     Name    Function
    '     15  NULL
    '     14      JISL    0: jog, 1: inch
    '     13  NULL
    '     12  NULL
    '     11      MODS   0: normal, 1: teaching mode
    '     10      TEAC   0: normal, 1: IF MOD=1, current pos data written to the position number specified by the position number specification register 
    '     9       JOG+   0: normal, 1: jog/inch up
    '     8       JOG-   0: normal, 1: jog/inch down
    '     7       ST7    ------
    '     6       ST6        (If any of these bits is enabled) The actuator moves to the position of the specified position number. 
    '     5       ST5        These bits are only valid when PIO patterns 4 or 5 (solenoid valve mode) is selected. 
    '     4       ST4        The move is started if either of the ST0 to ST7 bits is set to 1 (this bit: 0→ 1). 
    '     3       ST3        If a position other than the enabled start poison is selected, the alarm “085 Position No. error at moving” is generated. 
    '     2       ST2        It is possible to select the level operation or edge operation by user parameter No. 27 movement command type. 
    '     1       ST1        If multiple positions are entered at the same time, the smallest number takes the priority. 
    '     0       ST0    ------

    '9900 - 9901 - Target position coordinate specification
    '9900&9901 = targetPos(mm) * 100 (incriments of 0.01mm)

    '9902 - 9903 - Positioning band specification TODO
    'TODO

    '9904 - 9905 - Speed specification
    '9904&9905 = speed(mm/s) * 100 (incriments of 0.01mm/s)

    '9906 - Accel/Decel specification
    '9906 = acel(G) * 100 (incriments of 0.01G), max 300

    '9907 Push-current limiting value
    'current limit = 256 * (current%), current% should be between 0.2 - 0.7

    '9908 Control flag specification TODO
    '

#End Region

#End Region

#Region "Register Constants"

    '-----------------------Status Coil Addresses----------------------------
    Private Const REG_STAT_EMGS = &H100      'EMG status 
    Private Const REG_STAT_SFTY = &H101      'Safety speed enabled status
    Private Const REG_STAT_PWR = &H102       'Controller ready status 
    Private Const REG_STAT_SV = &H103        'Servo ON status 
    Private Const REG_STAT_PSFL = &H104      'Missed work in push-motion operation 
    Private Const REG_STAT_ALMH = &H105      'Major failure status 
    Private Const REG_STAT_ALML = &H106      'Minor failure status 
    Private Const REG_STAT_ABER = &H107      'Absolute error status ABER
    Private Const REG_STAT_BKRL = &H108      'Brake forced-release status 
    Private Const REG_STAT_STP = &H10A       'Pause status 
    Private Const REG_STAT_HEND = &H10B      'Home return status 
    Private Const REG_STAT_PEND = &H10C      'Position complete status 
    Private Const REG_STAT_LOAD = &H112      'Load output judgment status 
    Private Const REG_STAT_TRQS = &H113      'Torque level status 
    Private Const REG_STAT_MODS = &H114      'Teaching mode status 
    Private Const REG_STAT_TEAC = &H115      'Position-data load command status 
    Private Const REG_STAT_JOGUP = &H116     'Jog+ status 
    Private Const REG_STAT_JOGDN = &H117     'Jog- status  
    Private Const REG_STAT_PE7 = &H118       'Position complete 7 
    Private Const REG_STAT_PE6 = &H119       'Position complete 6 
    Private Const REG_STAT_PE5 = &H11A       'Position complete 5 
    Private Const REG_STAT_PE4 = &H11B       'Position complete 4 
    Private Const REG_STAT_PE3 = &H11C       'Position complete 3 
    Private Const REG_STAT_PE2 = &H11D       'Position complete 2 
    Private Const REG_STAT_PE1 = &H11E       'Position complete 1 
    Private Const REG_STAT_PE0 = &H11F       'Position complete 0

    '-----------------------Status Register Addresses----------------------------
    Private Const REG_STAT_PNOW_HI = &H9000      'Current Position Monitor (high byte)
    Private Const REG_STAT_PNOW_LO = &H9001      'Current Position Monitor (low byte)
    Private Const REG_STAT_ALMC = &H9002         'Present alarm code query
    Private Const REG_STAT_DIPM = &H9003         'Input port query
    Private Const REG_STAT_DOPM = &H9004         'Ouput port monitor query
    Private Const REG_STAT_DSS1 = &H9005         'Device status query 1
    Private Const REG_STAT_DSS2 = &H9006         'Device status query 2
    Private Const REG_STAT_DSSE = &H9007         'Expansion device status query
    Private Const REG_STAT_STAT_HI = &H9008      'System status query (high byte)
    Private Const REG_STAT_STAT_LO = &H9009      'System status query (low byte)
    Private Const REG_STAT_VNOW_HI = &H900A      'Current speed monitor (high byte)
    Private Const REG_STAT_VNOW_LO = &H900B      'Current speed monitor (low byte)
    Private Const REG_STAT_CNOW_HI = &H900C      'Current ampere monitor (high byte)
    Private Const REG_STAT_CNOW_LO = &H900D      'Current ampere monitor (low byte)
    Private Const REG_STAT_DEVI_HI = &H900E      'Deviation Monitor (high byte)
    Private Const REG_STAT_DEVI_LO = &H900F      'Deviation Monitor (low byte)
    Private Const REG_STAT_STIM_HI = &H9010      'System timer query (high byte)
    Private Const REG_STAT_STIM_LO = &H9011      'System timer query (low byte)
    Private Const REG_STAT_SIPM = &H9012         'Special input port query
    Private Const REG_STAT_ZONS = &H9013         'Zone status query
    Private Const REG_STAT_POSS = &H9014         'Position complete number status query

    '-----------------------Command Coil Addresses----------------------------
    Private Const REG_CMD_EMG = &H400       'EMG operation specification 
    Private Const REG_CMD_SFTY = &H401      'Safety speed command 
    Private Const REG_CMD_SON = &H403       'Servo On command 
    Private Const REG_CMD_ALRS = &H407      'Alarm reset command 
    Private Const REG_CMD_BKRL = &H408      'Brake forced-release command 
    Private Const REG_CMD_STP = &H40A       'Pause command 
    Private Const REG_CMD_HOME = &H40B      'Home Return command 
    Private Const REG_CMD_CSTR = &H40C      'Positioning start command 
    Private Const REG_CMD_JISL = &H411      'Jog/inch switching 
    Private Const REG_CMD_MOD = &H414       'Teaching mode command 
    Private Const REG_CMD_TEAC = &H415      'Position data load command 
    Private Const REG_CMD_JOGUP = &H416     'Jog+ command 
    Private Const REG_CMD_JOGDN = &H417     'Jog command 
    Private Const REG_CMD_ST7 = &H418       'Start position 7 
    Private Const REG_CMD_ST6 = &H419       'Start position 6 
    Private Const REG_CMD_ST5 = &H41A       'Start position 5 
    Private Const REG_CMD_ST4 = &H41B       'Start position 4 
    Private Const REG_CMD_ST3 = &H41C       'Start position 3 
    Private Const REG_CMD_ST2 = &H41D       'Start position 2 
    Private Const REG_CMD_ST1 = &H41E       'Start position 1 
    Private Const REG_CMD_ST0 = &H41F       'Start position 0
    Private Const REG_CMD_STOP = &H42C      'Decelerate To a Stop

    '-----------------------Command Register Addresses----------------------------
    Private Const REG_CMD_PCMD = &H9900         'Target position specification register
    Private Const REG_CMD_INP = &H9902          'Positioning band specification register
    Private Const REG_CMD_VCMD = &H9904         'SPeed specification register
    Private Const REG_CMD_ACMD = &H9906         'Accel/decel specification register
    Private Const REG_CMD_PPOW = &H9907         'Push-current limiting value specification register
    Private Const REG_CMD_CTLF = &H9908         'Control flag specification register
#End Region


    'Modbus related objects
    Private WithEvents modbusClient As EasyModbus.ModbusClient
    Public PortName As String = "COM1"
    Public BaudRate As Integer = 38400
    Public InchDist As Double = 10 'mm

    'Serial queue thread objects
    Private serialQueueThread As Threading.Thread
    Private singleCoilWriteQueue As New Concurrent.ConcurrentQueue(Of KeyValuePair(Of Integer, Boolean))
    Private multiCoilWriteQueue As New Concurrent.ConcurrentQueue(Of KeyValuePair(Of Integer, Boolean()))
    Private singleRegisterWriteQueue As New Concurrent.ConcurrentQueue(Of KeyValuePair(Of Integer, Integer))
    Private multiRegisterWriteQueue As New Concurrent.ConcurrentQueue(Of KeyValuePair(Of Integer, Integer()))
    'TODO - Impliment threadsafe on demand reading (probably event based) of slide registers
    'Private singleCoilReadQueue As New Concurrent.ConcurrentQueue(Of Integer)
    'Private multipleCoilReadQueue As New Concurrent.ConcurrentQueue(Of Integer)
    'Private singleRegisterReadQueue As New Concurrent.ConcurrentQueue(Of Integer)
    'Private multipleRegisterReadQueue As New Concurrent.ConcurrentQueue(Of Integer)
    Private getStateTimer As New Stopwatch

    ''' <summary>
    ''' Last requested axis state
    ''' </summary>
    Public State As New SCONState
    ''' <summary>
    ''' Continuously requests axis state in to 'State' object when true. 'UpdateRate' defines request frequency.
    ''' </summary>
    Public Active = False
    ''' <summary>
    ''' Rate (ms) at which to request axis state data. Default is 50ms
    ''' </summary>
    Public UpdateRate = 50


#Region "Constructors"
    Sub New()
        modbusClient = New EasyModbus.ModbusClient()
    End Sub

    Sub New(port As String, baud As Integer)
        modbusClient = New EasyModbus.ModbusClient(port)
        modbusClient.Baudrate = baud
    End Sub
#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Connect modbus client with defined port and baudrate
    ''' </summary>
    ''' <param name="port"></param>
    ''' <param name="baud"></param>
    Public Sub Connect(port As String, baud As Integer)
        If modbusClient.Connected Then
            modbusClient.Disconnect()
        End If
        modbusClient.SerialPort = port
        modbusClient.Baudrate = baud
        connectSlave()
    End Sub

    ''' <summary>
    ''' Connect modbus client according to information stored in PortName and BaudRate.
    ''' </summary>
    Public Sub Connect()
        If modbusClient.Connected Then
            modbusClient.Disconnect()
        End If
        connectSlave()
    End Sub

    ''' <summary>
    ''' Manually request an update of the State object
    ''' </summary>
    Public Sub GetState()
        Try
            Dim statusCoilData = readCoils(&H100, 23)
            Dim statusRegData = readHoldingRegisters(&H9000, 20)
            State = parseState(statusCoilData, statusRegData)
        Catch ex As Exception
            Threading.Thread.Sleep(20)
        End Try


    End Sub

    ''' <summary>
    ''' Set the servo power
    ''' </summary>
    ''' <param name="_on">True: On, False: Off</param>
    Public Sub SetPower(_on As Boolean)
        writeSingleCoil(REG_CMD_SON, _on)
        'GetState()
    End Sub

    ''' <summary>
    ''' Command servo to home
    ''' </summary>
    Public Sub Home()
        writeSingleCoil(REG_CMD_HOME, True)
        writeSingleCoil(REG_CMD_HOME, False)
        'GetState()
    End Sub

    ''' <summary>
    ''' Perform an inch upward. Distance and speed are dependant on their corresponding parameters
    ''' </summary>
    Public Sub InchUp()
        writeSingleCoil(REG_CMD_JISL, True)
        writeSingleCoil(REG_CMD_JOGUP, True)
        writeSingleCoil(REG_CMD_JOGUP, False)
        'GetState()

    End Sub

    ''' <summary>
    ''' Perform an inch downward. Distance and speed are dependant on their corresponding parameters
    ''' </summary>
    Public Sub InchDn()
        writeSingleCoil(REG_CMD_JISL, True)
        writeSingleCoil(REG_CMD_JOGDN, True)
        writeSingleCoil(REG_CMD_JOGDN, False)
        'GetState()
    End Sub

    ''' <summary>
    ''' Begin jogging upwards
    ''' </summary>
    Public Sub JogUpStart()
        writeSingleCoil(REG_CMD_JISL, False)
        writeSingleCoil(REG_CMD_JOGUP, True)
        'GetState()
    End Sub

    ''' <summary>
    ''' Begin jogging downwards
    ''' </summary>
    Public Sub JogDnStart()
        writeSingleCoil(REG_CMD_JISL, False)
        writeSingleCoil(REG_CMD_JOGDN, True)
        'GetState()
    End Sub

    ''' <summary>
    ''' Stop jogging
    ''' </summary>
    Public Sub JogStop()
        Try
            writeSingleCoil(REG_CMD_JOGDN, False)
            writeSingleCoil(REG_CMD_JOGUP, False)
            'GetState()
        Catch ex As Exception
            JogStop()
        End Try

    End Sub

    ''' <summary>
    ''' Perform an absolute move to a position in milimeters
    ''' </summary>
    ''' <param name="position">Position value (mm)</param>
    Public Sub AbsoluteMove(position As Double)
        Dim posInt = Math.Round(position, 2) * 100
        Dim regdata = deconstructLong(posInt)
        writeMultipleHoldingRegisters(REG_CMD_PCMD, regData)
    End Sub

#End Region

#Region "Private Methods"
    Private Sub connectSlave()

        modbusClient.Parity = IO.Ports.Parity.None
        modbusClient.Connect()
        startSerialQueueThread()
    End Sub

    Private Function parseState(statusCoilData As Boolean(), statusRegData As Integer()) As SCONState
        Dim state As New SCONState With {
            .EMGS = statusCoilData(0),
            .SFTY = statusCoilData(1),
            .PWR = statusCoilData(2),
            .SV = statusCoilData(3),
            .PSFL = statusCoilData(4),
            .ALMH = statusCoilData(5),
            .ALML = statusCoilData(6),
            .ABER = statusCoilData(7),
            .BKRL = statusCoilData(8),
            .STP = statusCoilData(9),
            .HEND = statusCoilData(10),
            .PEND = statusCoilData(11),
            .LOAD = statusCoilData(12),
            .TRQS = statusCoilData(13),
            .MODS = statusCoilData(14),
            .TEAC = statusCoilData(15),
            .JOGUp = statusCoilData(16),
            .JOGDn = statusCoilData(17),
            .PNOW = combineShorts(statusRegData(0), statusRegData(1)) * 0.01,
            .ALMC = statusRegData(2),
            .DIPM = statusRegData(3),
            .DOPM = statusRegData(4),
            .DSS1 = statusRegData(5),
            .DSS2 = statusRegData(6),
            .DSSE = statusRegData(7),
            .STAT = combineShorts(statusRegData(8), statusRegData(9)),
            .VNOW = combineShorts(statusRegData(10), statusRegData(11)) * 0.01,
            .CNOW = combineShorts(statusRegData(12), statusRegData(13)),
            .STIM = combineShorts(statusRegData(14), statusRegData(15))
        }

        'Dim pHigh As Integer = statusRegData(0), pLow As Integer = statusRegData(1)
        ''Dim pnow = 0 Or (pHigh << 8) Or pLow
        ''Dim pnow As Integer = BitConverter.ToInt32({pHigh, pLow}, 0)
        'Dim pnow As Double = (pHigh * &H10000) + pLow * 0.01
        'Debug.WriteLine(pnow.ToString().PadLeft(32, "0"c))

        Return state
    End Function

    Private Function combineShorts(highInt As Integer, lowInt As Integer) As Integer
        Dim highRegByte As Byte() = BitConverter.GetBytes(highInt)
        Dim lowRegByte As Byte() = BitConverter.GetBytes(lowInt)
        Dim dataArray As Byte() = {lowRegByte(0), lowRegByte(1), highRegByte(0), highRegByte(1)}
        Return BitConverter.ToInt32(dataArray, 0)
    End Function

    Private Function deconstructLong(value As Integer) As Integer()
        Dim posB As Byte() = BitConverter.GetBytes(value)
        Dim lowInt As Integer = BitConverter.ToInt16(posB, 0)
        Dim highInt As Integer = BitConverter.ToInt16(posB, 2)
        Dim shorts = {highInt, lowInt}
        Return shorts
    End Function

    Private Function readCoils(start As Integer, count As Integer) As Boolean()
        Dim rslt() As Boolean = Nothing
        If modbusClient.Connected Then
            rslt = modbusClient.ReadCoils(start, count)
        End If
        Return rslt
    End Function

    Private Function readHoldingRegisters(start As Integer, count As Integer) As Integer()
        Dim rslt As Integer() = Nothing
        If modbusClient.Connected Then
            rslt = modbusClient.ReadHoldingRegisters(start, count)
        End If
        Return rslt
    End Function

    Private Function writeSingleHoldingRegister(register As Integer, value As Integer) As Boolean
        Dim success As Boolean = False
        If modbusClient.Connected Then
            Try
                'modbusClient.WriteSingleRegister(register, value)
                singleRegisterWriteQueue.Enqueue(New KeyValuePair(Of Integer, Integer)(register, value))
                success = True
            Catch ex As Exception
                'Console.WriteLine("Failure to write holding register: " & register & " " & ex.Message)
                Console.WriteLine("Failure to enqueue register write: " & register & " " & ex.Message)
                success = False
            End Try

        End If
        Return success

    End Function

    Private Function writeSingleCoil(coil As Integer, value As Integer) As Boolean
        Dim success As Boolean = False
        If modbusClient.Connected Then
            Try
                'modbusClient.WriteSingleCoil(coil, value)
                singleCoilWriteQueue.Enqueue(New KeyValuePair(Of Integer, Boolean)(coil, value))
                success = True
            Catch ex As Exception
                Console.WriteLine("Failure to enqueue coil write: " & coil & " " & ex.Message)
                success = False
            End Try

        End If
        Return success
    End Function

    Private Function writeMultipleHoldingRegisters(start As Integer, values As Integer()) As Boolean
        Dim success As Boolean = False
        If modbusClient.Connected Then
            Try
                'modbusClient.WriteMultipleRegisters(start, values)
                multiRegisterWriteQueue.Enqueue(New KeyValuePair(Of Integer, Integer())(start, values))
                success = True
            Catch ex As Exception
                Console.WriteLine("Failure to enqueue multiple holding register write: " & start & " " & ex.Message)
                success = False
            End Try

        End If
        Return success
    End Function

    Private Function writeMultipleCoils(start As Integer, values As Boolean()) As Boolean
        Dim success As Boolean = False
        If modbusClient.Connected Then
            Try
                'modbusClient.WriteMultipleCoils(start, values)
                multiCoilWriteQueue.Enqueue(New KeyValuePair(Of Integer, Boolean())(start, values))
                success = True
            Catch ex As Exception
                Console.WriteLine("Failure to enqueue multiple coil write: " & start & " " & ex.Message)
                success = False
            End Try

        End If
        Return success
    End Function

#End Region

#Region "Serial queue thread"

    Private Sub startSerialQueueThread()
        serialQueueThread = New Threading.Thread(AddressOf serialQueueThreadLoop)
        serialQueueThread.Start()
    End Sub

    Private Sub serialQueueThreadLoop()
        getStateTimer.Start()

        While True
            If modbusClient.Connected Then

                Dim coilWriteItem As KeyValuePair(Of Integer, Boolean) = Nothing
                Dim regWriteItem As KeyValuePair(Of Integer, Integer) = Nothing
                Dim multiCoilWriteItem As KeyValuePair(Of Integer, Boolean()) = Nothing
                Dim multiRegWriteItem As KeyValuePair(Of Integer, Integer()) = Nothing

                If Active And getStateTimer.ElapsedMilliseconds > UpdateRate Then
                    GetState()
                    getStateTimer.Restart()
                End If

                Dim scpop = singleCoilWriteQueue.TryDequeue(coilWriteItem)
                Dim srpop = singleRegisterWriteQueue.TryDequeue(regWriteItem)
                Dim mcpop = multiCoilWriteQueue.TryDequeue(multiCoilWriteItem)
                Dim mrpop = multiRegisterWriteQueue.TryDequeue(multiRegWriteItem)

                If scpop Then
                    modbusClient.WriteSingleCoil(coilWriteItem.Key, coilWriteItem.Value)
                End If
                If srpop Then
                    modbusClient.WriteSingleRegister(regWriteItem.Key, regWriteItem.Value)
                End If
                If mcpop Then
                    modbusClient.WriteMultipleCoils(multiCoilWriteItem.Key, multiCoilWriteItem.Value)
                End If
                If mrpop Then
                    modbusClient.WriteMultipleRegisters(multiRegWriteItem.Key, multiRegWriteItem.Value)
                End If

            End If

        End While
    End Sub

#End Region

    Public Class SCONState
        Public EMGS As Boolean = False    'EMG status 
        Public SFTY As Boolean = False    'Safety speed enabled status
        Public PWR As Boolean = False    'Controller ready status 
        Public SV As Boolean = False    'Servo On status 
        Public PSFL As Boolean = False    'Missed work In push-motion operation 
        Public ALMH As Boolean = False    'Major failure status 
        Public ALML As Boolean = False    'Minor failure status 
        Public ABER As Boolean = False    'Absolute Error status ABER
        Public BKRL As Boolean = False    'Brake forced-release status 
        Public STP As Boolean = False    'Pause status 
        Public HEND As Boolean = False    'Home Return status 
        Public PEND As Boolean = False    'Position complete status 
        Public LOAD As Boolean = False    'Load output judgment status 
        Public TRQS As Boolean = False    'Torque level status 
        Public MODS As Boolean = False    'Teaching mode status 
        Public TEAC As Boolean = False    'Position-data load command status 
        Public JOGUp As Boolean = False    'Jog+ status 
        Public JOGDn As Boolean = False    'Jog- status  

        Public PNOW As Double = 0           'Current Position Monitor (high Byte)
        'Public PNOW              'Current Position Monitor (low byte)
        Public ALMC As Double = 0           'Present alarm code query
        Public DIPM As Double = 0           'Input port query
        Public DOPM As Double = 0           'Ouput port monitor query
        Public DSS1 As Double = 0           'Device status query 1
        Public DSS2 As Double = 0           'Device status query 2
        Public DSSE As Double = 0           'Expansion device status query
        Public STAT As Double = 0           'System status query (high Byte)
        'Public STAT              'System status query (low byte)
        Public VNOW As Double = 0           'Current speed monitor (high Byte)
        'Public VNOW              'Current speed monitor (low byte)
        Public CNOW As Double = 0           'Current ampere monitor (high Byte)
        'Public CNOW              'Current ampere monitor (low byte)
        Public DEVI As Double = 0           'Deviation Monitor (high Byte)
        'Public DEVI              'Deviation Monitor (low byte)
        Public STIM As Double = 0           'System timer query (high Byte)
        'Public STIM              'System timer query (low byte)


    End Class
End Class




