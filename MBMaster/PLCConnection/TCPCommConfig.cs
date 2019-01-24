using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBMaster.PLCConnection {
  public class BaseCommConfig {
    public string addressMajor = "";  // IP address in TCP/UDP, Com port in serial
    public int addressMinor = 0;      // port in TCP/UDP, baudrate in serial
    public int devId;
    public string name;
  }

  public class TCPCommConfig : BaseCommConfig {
    public int timeout = 100;
    public int retryCnt = 3;
    public int pollDelay = 20;
  }

}
