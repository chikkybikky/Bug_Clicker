using UnityEngine;

public class BackgroundUpdater : MonoBehaviour
{
    public UpgradeManager currentphase;
    public Sprite Garden1;
    public Sprite Garden2;
    public Sprite Garden3;
    void Start()
    {
        ChangeBackground(0);
    }
    public void ChangeBackground(int stageNum)
    {
        if(stageNum == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Garden1;
        }
        else if(stageNum == 1)
        {
            gameObject.GetComponent < SpriteRenderer >().sprite = Garden2;
        }
        else
        {
            gameObject.GetComponent < SpriteRenderer >().sprite = Garden3;
        }
    }
}