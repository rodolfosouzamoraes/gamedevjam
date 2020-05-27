using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BossShooting : MonoBehaviour
{
    private int index = 0;
    private List<GameObject> stones = new List<GameObject>();
    [SerializeField] private int stonesAmount = 10;
    [SerializeField] private GameObject stonePrefab;
    [SerializeField] private Transform aim;

    private void Awake()
    {
        InstantiateStones();
    }

    private void InstantiateStones()
    {
        for (int i = 0; i < stonesAmount; i++)
        {
            GameObject stone = Instantiate(stonePrefab, aim.position, Quaternion.identity, aim);
            stone.SetActive(false);
            stones.Add(stone);
        }
    }

    public void Shoot()
    {
        GameObject stone = stones[index];
        
        if (!stone.activeSelf)
        {
            stone.SetActive(true);
        }

        index++;
        index %= stones.Count;
    }

    public void ReturnStoneToAim(GameObject stone)
    {
        stone.transform.position = aim.position;
        stone.transform.rotation = Quaternion.identity;
    }
}
