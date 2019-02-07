using UnityEngine;
using UnityEngine.UI;
public class UpgradeManager : MonoBehaviour
{
    public BackgroundUpdater changeBG;
    public Text stageDisplay;
    public int cost = 1000;
    public int money = 0;
    public int population = 0;
    public int stagePhase = 0;
    Button upgrader;
    private string[] Itemnames = { "Grass", "Pond"};
    private void Start()
    {
        upgrader = GetComponent<Button>();
        upgrader.interactable = true;
    }
    public void Update()
    {
        stageDisplay.text = Itemnames[stagePhase] + "\n $" + cost;
    }
    public void WhenBought(int stagephase)
    {
        if (money >= cost)
        {
            money -= cost;
            stagePhase += 1;
            cost += 1000;
            changeBG.ChangeBackground(stagePhase);
            if (stagePhase == 2)
            {
                GetComponent<Button>().interactable = false;
            }
        }
    }
}