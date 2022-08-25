
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneratorB : MonoBehaviour
{
    public List<GameObject> pickables;
    public int terrainSizeX = 1000;
    public int terrainSizeZ = 1000;
    public int amountOfEach = 10;

    private LinkedList<GameObject> VecRecolectables = new LinkedList<GameObject>();
    void Start()
    {
        GenerarCajas();
    }
    protected void GenerarCajas()
    {
        for (int i = 0; i < pickables.Count; i++)
        {
            for (int j = 0; j < amountOfEach; j++)
            {
                VecRecolectables.AddLast(Instantiate(pickables[i], GetInstantiationPos(), Quaternion.identity));
            }
        }

    }

    private Vector3 GetInstantiationPos()
    {
        Vector3 pos;
        while (true)
        {
            pos.x = Random.Range(0, terrainSizeX);
            pos.z = Random.Range(0, terrainSizeZ);
            pos.y = 50;

            RaycastHit hit;
            if (Physics.Raycast(pos, Vector3.down, out hit, 1000))
            {
                if (hit.transform.CompareTag("Terrain") && hit.point.y <= 10)
                {
                    pos.y = hit.point.y + 0.5f;
                    return pos;
                }

            }

        }

    }


}
