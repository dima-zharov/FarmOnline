using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


public class Requests : MonoBehaviour
{
    public UnityWebRequest uwr { get; private set; }

    public IEnumerator getRequest(string uri)
    {

        uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
}
