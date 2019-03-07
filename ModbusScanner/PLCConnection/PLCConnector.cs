using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FieldTalk;
using System.Diagnostics;
using FieldTalk.Modbus.Master;

namespace MBMaster.PLCConnection {
  public class PLCConnector : IPLCConnector {
    private MbusIpClientBase protocol = null;
    public int slaveAddr = 0;
    long readCount = 0;
    string slaveIP = null;
    // time measurement
    Stopwatch sw = new Stopwatch();

    public bool Connect(ProtocolTypeEnum protocolType, BaseCommConfig commCfg, out string errorStr) {
      errorStr = "";
      TCPCommConfig ipCfg = commCfg as TCPCommConfig;
      if (protocol != null) {
        if (slaveIP == ipCfg.addressMajor)
          return true;
        else {
          errorStr = "Connected to a different device";
          return false;
        }
      }
      try {
        if (protocolType == ProtocolTypeEnum.TCP)
          protocol = new MbusTcpMasterProtocol();
        else
          protocol = new MbusUdpMasterProtocol();
      } catch (OutOfMemoryException ex) {
        return false;
      }
      slaveAddr = ipCfg.devId;
      protocol.timeout = ipCfg.timeout;
      protocol.retryCnt = ipCfg.retryCnt;
      protocol.pollDelay = ipCfg.pollDelay;
      protocol.setPort ((short)ipCfg.addressMinor);
      int res = protocol.openProtocol(ipCfg.addressMajor);
      if ((res == BusProtocolErrors.FTALK_SUCCESS)) {
        slaveIP = ipCfg.addressMajor;
        errorStr = string.Format("Modbus/TCP Device: {0} Port: {1} opened successfully", ipCfg.addressMajor, ipCfg.addressMinor);
        return true;
      } else {
        errorStr = ("Could not open protocol, error was: " + BusProtocolErrors.getBusProtocolErrorText(res));
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
