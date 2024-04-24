using TMPro;
using UnityEngine;

public class ConfirmingCode : MonoBehaviour
{
    private Requests request = new Requests();

    private string code;

    [SerializeField] private TMP_InputField _inputCode;

    public void ConfirmingCodeMethod()
    {
        StartCoroutine(request.getRequest(""));
    }

}
