using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct PlayerData
{
    public int ranknumber;
    public int distance;
    public int coin;

    public PlayerData(int rankNumber, int distance, int coin)
    {
        this.ranknumber = rankNumber;
        this.distance = distance;
        this.coin = coin;
    }
}

public class RankData : MonoBehaviour
{
    public PlayerData playerData;
    [Space]
    [SerializeField] private TMP_Text rankText;
    [SerializeField] private TMP_Text distanceText;
    [SerializeField] private TMP_Text scoreText;

    public void UpdateData()
    {
        rankText.text = playerData.ranknumber.ToString();
        distanceText.text = playerData.distance.ToString() + " m.";
        scoreText.text = playerData.coin.ToString();
    }
}
