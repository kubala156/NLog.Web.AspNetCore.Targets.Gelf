using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace NLog.Web.AspNetCore.Targets.Gelf
{
    public class UdpTransportClient : ITransportClient
    {
        public void Send(byte[] datagram, int bytes, IPEndPoint ipEndPoint)
        {
            using (var udpClient = new UdpClient())
            {
                int result = udpClient.Send(datagram, bytes, ipEndPoint);
            }
        }
    }
}