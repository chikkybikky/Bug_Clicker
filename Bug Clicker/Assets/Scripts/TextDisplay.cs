using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public UpgradeManager player;
    void Update()
    {
        GetComponent<Text>().text = "$" + player.money;
    }
}