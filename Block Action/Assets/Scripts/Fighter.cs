using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    public int health;
    public double buff;
    public List<BuffCounter> buffLeft;
    public int maxHealth;
    public Healthbar healthBar;
    GameObject healthPrefab;

    void Start()
    {
    }

    public void makeHealthBar()
    {
        healthPrefab = Resources.Load<GameObject>("Healthbar");
        Vector3 healthBarPosition = new Vector3(transform.position.x, transform.position.y - (GetComponent<SpriteRenderer>().bounds.size.y / 2) - 0.5f, 0);
        Debug.Log(healthBarPosition);
        Vector3 healthBarPos2 = WorldToScreenSpace(healthBarPosition, Camera.main, FindObjectOfType<Canvas>().GetComponent<RectTransform>());
        GameObject g = Instantiate(healthPrefab, Vector3.zero, Quaternion.identity);
        g.transform.SetParent(FindObjectOfType<Canvas>().transform);
        g.GetComponent<RectTransform>().anchoredPosition = healthBarPos2;
        g.transform.localScale = new Vector3(0.4f, 0.4f, 1);
        healthBar = g.GetComponent<Healthbar>();
    }

    public void updateHealthBar()
    {
        healthBar.setHealth(100 * health / maxHealth);
    }

    public static Vector3 WorldToScreenSpace(Vector3 worldPos, Camera cam, RectTransform area)
    {
        Vector3 screenPoint = cam.WorldToScreenPoint(worldPos);
        screenPoint.z = 0;

        Vector2 screenPos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(area, screenPoint, cam, out screenPos))
        {
            return screenPos;
        }

        return screenPoint;
    }

    void update() { 
    
    }
}
