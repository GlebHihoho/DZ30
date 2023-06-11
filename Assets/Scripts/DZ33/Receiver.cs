using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;

public class Receiver : MonoBehaviour
{
    async void Start()
    {
        var client = new UdpClient(24000);

        print("Started");
        while (true)
        {
            var data = await client.ReceiveAsync();
            var message = Encoding.ASCII.GetString(data.Buffer);

            print(message);

            var rotation = message.Split("!").Select(item => float.Parse(item));
            transform.rotation = Quaternion.Euler(rotation.ElementAt(0) * 2, rotation.ElementAt(1) * 2, rotation.ElementAt(2) * 2);
        }
    }
}
