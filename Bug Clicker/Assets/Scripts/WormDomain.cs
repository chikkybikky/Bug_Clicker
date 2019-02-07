using System.Collections;
using UnityEngine;

public class WormDomain : MonoBehaviour
{
    public GameObject WormPrefab;
    public Vector2 center;
    public Vector2 size;
    public UpgradeManager BirthControl;
    public Canvas canvas;
    void Update()
    {
        if (BirthControl.population < 4)
        {
            BirthControl.population += 1;
            StartCoroutine(GestationPeriod());
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
    public void WormPlacement()
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));
        GameObject babyWorm = Instantiate(WormPrefab, pos, Quaternion.identity) as GameObject;
        babyWorm.transform.SetParent(canvas.transform);
    }
    public IEnumerator GestationPeriod()
    {
        yield return new WaitForSeconds(Random.Range(.5f, 1.2f));
        WormPlacement();
    }
}