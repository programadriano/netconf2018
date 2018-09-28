using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabLogin : MonoBehaviour
{

    public void Start()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId))
        {
            PlayFabSettings.TitleId = "dotnetconf2018";
        }
        var request = new LoginWithCustomIDRequest { CustomId = "l;ksdf;lsdkfl;dsk;", CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }



    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Autenticado com sucesso!");
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogError("Error: " + error.GenerateErrorReport());
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
