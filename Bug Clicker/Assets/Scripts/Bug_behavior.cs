using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bug_behavior : MonoBehaviour
{
    public int wormCost;
    public UpgradeManager player;
    private IEnumerator Time2Die()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        player.population -= 1;
    }
    private void Start()
    {
        StartCoroutine(Time2Die());
        player = GameObject.Find("Upgrader").GetComponent<UpgradeManager>();

    }
    public void WhenClicked()
    {
        player.money += wormCost;
        GetComponent<Button>().interactable = false;
        Destroy(gameObject);
        player.population -= 1;
    }
}