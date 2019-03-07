using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldTalk.Modbus.Master;

namespace ModbusScanner {
  public class PLCSerialConnector {
    private MbusRtuMasterProtocol protocol = null;
    private string commPort = null;
    public int slaveAddr = 0;
    Stopwatch sw = new Stopwatch();
    long readCount = 0;

    public bool Connect(BaseCommConfig commCfg, out string errorStr) {
      errorStr = "";
      SerialCommConfig serCfg = commCfg as SerialCommConfig;
      if (protocol != null) {
        if (commPort == serCfg.addressMajor)
          return true;
        else {
          errorStr = "Connected to a different device";
          return false;
        }
      }
      try {
        protocol = new MbusRtuMasterProtocol();
      } catch (OutOfMemoryException ex) {
        return false;
      }
      slaveAddr = serCfg.devId;
      protocol.timeout = serCfg.timeout;
      protocol.retryCnt = serCfg.retryCnt;
      protocol.pollDelay = serCfg.pollDelay;
      int res = protocol.openProtocol(
        serCfg.addressMajor, serCfg.addressMinor, (int)serCfg.dataBits,
        (int)serCfg.stopBits, (int)serCfg.parity);
      if ((res == BusProtocolErrors.FTALK_SUCCESS)) {
        commPort = serCfg.addressMajor;
        errorStr = $"Modbus/TCP Device: {serCfg.addressMajor} Baud: {serCfg.addressMinor} opened successfully";
        return true;
      } else {
        errorStr = $"Could not open protocol, error was: {BusProtocolErrors.getBusProtocolErrorText(res)}";
        protocol = null;
        return false;
      }
    }

    public void Disconnect() {
      if (protocol == null) {
        System.Diagnostics.Debug.WriteLine("Disconnect - protocol = null");
        return;
      }
      protocol.closeProtocol();
      protocol = null;
    }

    public bool ReadRegisters(int start, int count, short[] values) {
      if (protocol == null || !protocol.isOpen())
        return false;
      sw.Start();
      int res = protocol.readMultipleRegisters(slaveAddr, start, values, count);
      sw.Stop();
      readCount++;
      if (res != BusProtocolErrors.FTALK_SUCCESS) {
        string str = BusProtocolErrors.getBusProtocolErrorText(res);
        System.Diagnostics.Debug.WriteLine($"ReadRegisters => {res}/{str}");
      }
      return (res == BusProtocolErrors.FTALK_SUCCESS);
    }

    public bool ReadInputRegisters(int start, int count, short[] values) {
      if (protocol == null || !protocol.isOpen())
        return false;
      sw.Start();
      int res = protocol.readInputRegisters(slaveAddr, start, values, count);
      sw.Stop();
      readCount++;
      if (res != BusProtocolErrors.FTALK_SUCCESS) {
        string str = BusProtocolErrors.getBusProtocolErrorText(res);
        System.Diagnostics.Debug.WriteLine($"ReadRegisters => {res}/{str}");
      }
      return (res == BusProtocolErrors.FTALK_SUCCESS);
    }

    public bool ReadRegisters(int start, int count, int[] values) {
      if (protocol == null || !protocol.isOpen())
        return false;
      sw.Start();
      int res = protocol.readInputRegisters(slaveAddr, start, values, count);
      sw.Stop();
      readCount++;
      if (res != BusProtocolErrors.FTALK_SUCCESS) {
        string str = BusProtocolErrors.getBusProtocolErrorText(res);
        System.Diagnostics.Debug.WriteLine($"ReadInputRegisters => {res}/{str}");
      }
      return (res == BusProtocolErrors.FTALK_SUCCESS);
    }

    public bool WriteRegister(int regNum, short value) {
      if (protocol == null || !protocol.isOpen())
        return false;
      int res = protocol.writeSingleRegister(slaveAddr, regNum, value);
      if (res != BusProtocolErrors.FTALK_SUCCESS) {
        string str = BusProtocolErrors.getBusProtocolErrorText(res);
        System.Diagnostics.Debug.WriteLine($"WriteRegister => {res}/{str}");
      }
      return (res == BusProtocolErrors.FTALK_SUCCESS);
    }

    public bool WriteRegisters(int start, int count, short[] values) {
      if (protocol == null || !protocol.isOpen())
        return false;
      int res = protocol.writeMultipleRegisters(slaveAddr, start, values, count);
      if (res != BusProtocolErrors.FTALK_SUCCESS) {
        string str = BusProtocolErrors.getBusProtocolErrorText(res);
        System.Diagnostics.Debug.WriteLine($"WriteRegisters => {res}/{str}");
      }
      return (res == BusProtocolErrors.FTALK_SUCCESS);
    }
  }
}
