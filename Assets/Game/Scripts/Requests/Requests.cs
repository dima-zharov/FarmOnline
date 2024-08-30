using System.Collections;
using UnityEngine.Networking;


public class Requests
{
    private UnityWebRequest Uwr;
    public string UwrMessage { get; private set; }

    public IEnumerator GetRequest(string uri)
    {

        Uwr = UnityWebRequest.Get(uri);
        yield return Uwr.SendWebRequest();

        if (Uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            UwrMessage = Uwr.error;
        }
        else
        {
            UwrMessage = Uwr.downloadHandler.text;
        }
    }

}
