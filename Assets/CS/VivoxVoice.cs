using System;
using UnityEngine;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Vivox;

public class VivoxVoice : MonoBehaviour
{
    public string UserDisplayName = "test";

    private async void Start()
    {
        try
        {
            await InitializeAsync();
            await LoginToVivoxAsync();
            await JoinEchoChannelAsync();
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error during Vivox setup: {ex.Message}");
        }
    }
    private async System.Threading.Tasks.Task InitializeAsync()
    {
        await UnityServices.InitializeAsync();

        await AuthenticationService.Instance.SignInAnonymouslyAsync();

        await VivoxService.Instance.InitializeAsync();
    }

    private async System.Threading.Tasks.Task LoginToVivoxAsync()
    {
        LoginOptions options = new LoginOptions
        {
            DisplayName = UserDisplayName,
            EnableTTS = true
        };

        await VivoxService.Instance.LoginAsync(options);
    }


    private async System.Threading.Tasks.Task JoinEchoChannelAsync()
    {
        string channelToJoin = "Lobby";

        await VivoxService.Instance.JoinGroupChannelAsync(channelToJoin, ChatCapability.TextAndAudio);
    }
}
