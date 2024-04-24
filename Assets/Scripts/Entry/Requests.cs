using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;


public class Requests : MonoBehaviour
{
    public UnityWebRequest uwr;

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


    public string CleanUrl(string url)
    {
        string decodedUrl = Uri.UnescapeDataString(url);
        string cleanUrl = string.Join("", decodedUrl.Where(c => (int)c < 127 && c != 0x200B));
        string encodedUrl = Uri.EscapeUriString(cleanUrl);

        return encodedUrl;
    }
}
