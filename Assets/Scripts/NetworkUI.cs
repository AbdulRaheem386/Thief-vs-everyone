using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class NetworkManagerUI : MonoBehaviour
{
    public GameObject hostbutton;
    public GameObject clientbutton;
    public GameObject panel;

    [Header("Host Connection")]
    public string hostIP = "192.168.1.4";
    public ushort port = 7777;

    public void StartHost()
    {
        panel.SetActive(false);

        NetworkManager.Singleton.StartHost();
    }

    public void StartClient()
    {
        Debug.Log("1. Client Button Clicked");

        panel.SetActive(false);

        Debug.Log("2. Panel Disabled: " + !panel.activeSelf);

        UnityTransport transport =
            NetworkManager.Singleton.GetComponent<UnityTransport>();

        transport.SetConnectionData(hostIP, port);

        Debug.Log("3. Starting Client");

        NetworkManager.Singleton.StartClient();
    }
}