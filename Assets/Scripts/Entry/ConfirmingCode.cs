using UnityEngine;
using UnityEngine.UI;

public class ConfirmingCode : MonoBehaviour
{
    private Requests request = new Requests();

    private string code;

    [SerializeField] private InputField _inputCode;

    public void ConfirmingCodeMethod()
    {
        StartCoroutine(request.postRequest("string"));
    }


}
