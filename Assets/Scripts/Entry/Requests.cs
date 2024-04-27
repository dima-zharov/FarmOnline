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

    public void MakeRequestRegistrtion(out string url, ref string email, ref string password)
    {
        url = $"https://zetprime.pythonanywhere.com/game/api/registration?email={email}&password={password}";
        MakeRequest(url);
    }

    public void MakeRequestAuth(out string url, ref string email, ref string password)
    {

        url = $"https://zetprime.pythonanywhere.com/game/api/login?email={email}&password={password}";
        MakeRequest(url);
    }    
    
    public void MakeRequestConfirmingCode(out string url, string inputEmail, string code)
    {
        url = $"https://zetprime.pythonanywhere.com/game/api/validate?email={inputEmail}&code={code}";
        MakeRequest(url);
    }

    private void MakeRequest(string url)
    {
        url = CleanUrl(url);
    }
}
