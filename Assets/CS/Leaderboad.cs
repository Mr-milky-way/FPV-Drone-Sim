using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.SceneManagement;

public class Leaderboad : MonoBehaviour
{
    public TMP_Text Username;
    public TMP_Text[] names;
    public TMP_Text[] times;
    public string LeaderboardId = "leaderboard_config";
    string VersionId { get; set; }
    int Offset { get; set; }
    int Limit { get; set; }
    int RangeLimit { get; set; }
    public int SceneNum;

    async void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            times[i].text = "";
            names[i].text = "";
        }
        await UnityServices.InitializeAsync();
        await SignInAnonymously();
        Username.text = "You are " + AuthenticationService.Instance.PlayerName;
    }

    async Task SignInAnonymously()
    {
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("Signed in as: " + AuthenticationService.Instance.PlayerId);
        };
        AuthenticationService.Instance.SignInFailed += s =>
        {
            // Take some action here...
            Debug.Log(s);
        };

        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    [System.Serializable]
    public class results
    {
        public string playerName;
        public string score;
    }

    [System.Serializable]
    public class itemList
    {
        public results[] results;
    }

    public itemList leaderboard = new itemList();
    public async void GetScores()
    {
        var scoresResponse = await LeaderboardsService.Instance
            .GetScoresAsync(LeaderboardId);
        string data = JsonConvert.SerializeObject(scoresResponse);
        leaderboard = JsonUtility.FromJson<itemList>(data);
        for (int i = 0; i < leaderboard.results.Length; i++)
        {
            times[i].text = leaderboard.results[i].score;
            names[i].text = leaderboard.results[i].playerName;
        }
    }

    public async void AddScore(float time)
    {
        var playerEntry = await LeaderboardsService.Instance
            .AddPlayerScoreAsync(LeaderboardId, time);
        Debug.Log(JsonConvert.SerializeObject(playerEntry));
    }



    public void Restart()
    {
        SceneManager.LoadScene(SceneNum);
    }
}