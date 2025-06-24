using System.Collections.Generic;
using System;
using System.Net;
public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
        var startIP = ToInt(start);
        var endIP = ToInt(end);

        return endIP - startIP;
    }

    public static long ToInt(string addr)
    {
        return (uint)IPAddress.NetworkToHostOrder(
             (int)IPAddress.Parse(addr).Address);
    }
}
