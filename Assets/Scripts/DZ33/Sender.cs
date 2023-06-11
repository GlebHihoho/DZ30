#nullable enable
using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Sender : MonoBehaviour
{
    [SerializeField] private int port = 25550;
    [SerializeField] private int targetPort = 24000;

    private string? previous = null;

    private UdpClient udpClient = null!;

    private void Start()
    {
        udpClient = new UdpClient(port);
    }

    private void Update()
    {
        var position = transform.position;
        var rotation = transform.rotation;

        // var positionMessage = $"{position.x}!{position.y}!{position.z}";
        var rotationMessage = $"{rotation.x}!{rotation.y}!{rotation.z}";

        if (previous == rotationMessage)
        {
            return;
        }

        var array = Encoding.ASCII.GetBytes(rotationMessage);

        udpClient.Send(array, array.Length, "localhost", targetPort);

        previous = rotationMessage;
    }
}
